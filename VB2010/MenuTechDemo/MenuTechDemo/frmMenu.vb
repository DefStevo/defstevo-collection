#Region "Imports"
Imports WeifenLuo.WinFormsUI.Docking

#End Region

Public Class frmMenu

    Private Sub btnNewForm_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnNewForm1_Click(sender As System.Object, e As System.EventArgs) Handles btnNewForm.Click
        Dim _frmForm As New frmForm
        Dim _i As Integer = -1

        _i = DockPanel.Contents.Count + 1

        _frmForm.Text = "Form " & _i.ToString
        _frmForm.Show(DockPanel, DockState.Document)
    End Sub
End Class
