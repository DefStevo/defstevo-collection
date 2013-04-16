Public Class Form1

    Private Const pipeName As String = "\\.\pipe\MyPipe"
    Private Const BUFFSIZE As Short = 10000
    Private Buffer(BUFFSIZE) As Byte
    Private hPipe As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim openMode, pipeMode As Integer
        'Create the named pipe
        openMode = PIPE_ACCESS_DUPLEX Or FILE_FLAG_WRITE_THROUGH
        pipeMode = PIPE_WAIT Or PIPE_TYPE_MESSAGE Or PIPE_READMODE_MESSAGE
        hPipe = CreateNamedPipe(pipeName, openMode, pipeMode, 10, 10000, 2000, 10000, IntPtr.Zero)

        Label1.Text = "Created the named pipe and waiting for the clients."
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim byteCount, i, res, cbnCount As Integer
        For i = 0 To BUFFSIZE - 1 'Fill an array of numbers
            Buffer(i) = i Mod 256
        Next i
        'Wait for a connection, block until a client connects
        Label1.Text = "Waiting for client connections"
        Me.Refresh()
        Do
            res = ConnectNamedPipe(hPipe, 0)
            'Read the data sent by the client over the pipe
            cbnCount = 4
            res = ReadFile(hPipe, byteCount, Len(byteCount), cbnCount, 0)
            If byteCount > BUFFSIZE Then 'Client requested for byteCount bytes
                byteCount = BUFFSIZE 'but only send up to 20000 bytes
            End If
            'Write the number of bytes requested by the client 
            res = WriteFile(hPipe, Buffer, byteCount, cbnCount, 0)
            res = FlushFileBuffers(hPipe)
            'Disconnect the named pipe.
            res = DisconnectNamedPipe(hPipe)
            'Loop until the client makes no more requests for data. 
        Loop Until byteCount = 0
        Label1.Text = "Read or Write completed"
        Button2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Close the pipe handle when the client makes no requests
        CloseHandle(hPipe)
        Label1.Text = "Disconnected the named pipe"
    End Sub
End Class
