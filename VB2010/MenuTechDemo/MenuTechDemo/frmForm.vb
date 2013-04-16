Public Class frmForm

    Private Sub btnNewPage1_Click(sender As System.Object, e As System.EventArgs) Handles btnNewPage.Click
        Dim _frmPage As New frmPage
        Dim _i As Integer = TabControl.TabPages.Count + 1

        _frmPage.Text = "Page " & _i.ToString
        _frmPage.lblPage.Text = "Page " & _i.ToString

        TabPage = New Crownwood.Magic.Controls.TabPage(_frmPage.Text, _frmPage)

        TabControl.TabPages.Add(TabPage)
        TabControl.SelectedTab = TabPage
    End Sub

    Private Sub TabControl_ClosePressed(sender As Object, e As System.EventArgs) Handles TabControl.ClosePressed
        TabControl.TabPages.Remove(TabControl.SelectedTab)
    End Sub

    Private Sub TabControl_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles TabControl.SelectionChanged

    End Sub
End Class