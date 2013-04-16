Public Class frmChildForm
    Public iChildIndex As Integer = 0


    Private Sub btnMessage_Click(sender As System.Object, e As System.EventArgs) Handles btnMessage.Click
        MsgBox("Hallo Welt" + vbNewLine + _
                "Ich bin Fenster #" + iChildIndex.ToString, vbOKOnly, "ChildFenster")
    End Sub

    Private Sub frmChildForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Me.Tag = "" Then
            MsgBox("Leer")
        Else
            MsgBox(Me.Tag)
            iChildIndex = Me.Tag
        End If
    End Sub
End Class