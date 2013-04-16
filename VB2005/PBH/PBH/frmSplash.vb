Public NotInheritable Class frmSplash
  Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ApplicationTitle.Text = My.Application.Info.Title
    Version.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
    Copyright.Text = My.Application.Info.Copyright
  End Sub
End Class
