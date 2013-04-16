Public Class frmPage

    Private Sub frmPage_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        lblPage.Text &= vbNewLine & "Closed"

        MsgBox(e.CloseReason)
    End Sub

    Private Sub frmPage_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lblPage.Text &= vbNewLine & "Closing"

        MsgBox(e.CloseReason)
        e.Cancel = True
    End Sub

    Private Sub frmPage_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        lblPage.Text &= vbNewLine & "GotFocus"
    End Sub

    Private Sub frmPage_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblPage.Text &= vbNewLine & "Load"
    End Sub

    Private Sub frmPage_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        lblPage.Text &= vbNewLine & "Lost Focus"
    End Sub
End Class