
Public Class frmMenuStripe

    Private Sub btnNewChild_Click(sender As System.Object, e As System.EventArgs) Handles btnNewChild.Click
        Dim newForm As Form = New frmChildForm
        frmMenu.NewChild(newForm)
    End Sub

    Private Sub frmMenuStripe_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnExtForm_Click(sender As System.Object, e As System.EventArgs) Handles btnExtForm.Click
        Dim newExtForm As Form = New NewForm.frmNewForm
        frmMenu.NewChild(newExtForm)

    End Sub

    Private Sub btnNewChildThread_Click(sender As System.Object, e As System.EventArgs) Handles btnNewChildThread.Click
        Dim t As New Threading.Thread(AddressOf RunForm)
        t.Start(New frmChildForm)

    End Sub

    Private Shared Sub RunForm(oForm As Form)
        MsgBox("RunForm")
        'oForm.ShowDialog()
        frmMenu.NewChild(oForm)
        MsgBox("FormRunning")
    End Sub


    Private Sub btnNewChild_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub
End Class