Public Class Form1
    Private Const pipeName As String = "\\.\pipe\MyPipe"
    Private Const BUFFSIZE As Integer = 10000
    Private hpipe As Integer

    Public Const INVALID_HANDLE_VALUE As Short = -1
    Public Declare Function CallNamedPipe Lib "kernel32" Alias "CallNamedPipeA" _
    (ByVal lpNamedPipeName As String, _
    ByRef lpInBuffer As Integer, _
    ByVal nInBufferSize As Integer, _
    ByRef lpOutBuffer As Byte, _
    ByVal nOutBufferSize As Integer, _
    ByRef lpBytesRead As Integer, ByVal nTimeOut As Integer) As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i, res, cbRead, numBytes As Integer
        Dim bArray() As Byte
        Dim temp As String

        numBytes = CInt(TextBox1.Text)
        If numBytes < 0 Then
            MsgBox("Value must be at least 0.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If numBytes = 0 Then
            Label1.Visible = True
            Label1.Text = "The connection to the server is disconnected."
            'Button1.Visible = False
            'TextBox1.Visible = False
            'TextBox2.Visible = False
        End If
        If numBytes > BUFFSIZE Then
            numBytes = BUFFSIZE
        End If

        ReDim bArray(numBytes) 'Create the return buffer
        'Call the CallNamedPipe function to do the transactions
        res = CallNamedPipe(pipeName, numBytes, Len(numBytes), bArray(0), numBytes, cbRead, 30000)
        'Wait up to 30 seconds for a response
        'Format the data received, and then display the data in the text box
        If res > 0 Then
            temp = Format(bArray(0), " 000")
            For i = 1 To cbRead - 1
                If (i Mod 16) = 0 Then temp = temp & vbCrLf
                temp = temp & " " & Format(bArray(i), "000")
            Next i
            TextBox2.Text = temp
        Else
            MsgBox("Error number " & Err.LastDllError & _
            "while trying to call the CallNamedPipe function.", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class
