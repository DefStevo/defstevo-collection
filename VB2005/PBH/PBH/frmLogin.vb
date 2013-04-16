Public Class frmLogin

  Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
    If objDB.Connect() = True Then
      Me.Hide()
      frmMenu.ShowDialog()
    End If
  End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

  Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    txtDB.Text = My.Settings.Server & " (" & My.Settings.Datenbank & ")"
  End Sub
End Class
