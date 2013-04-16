Public Class frmRouter
  Public ID As Integer
  Private Sub frmRouter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = "Router " & ID
    Select Case ID
      Case 1
        txtName.Text = My.Settings.Name1
        txtIP.Text = My.Settings.IP1
        txtGateway.Text = My.Settings.Gate1
      Case 2
        txtName.Text = My.Settings.Name2
        txtIP.Text = My.Settings.IP2
        txtGateway.Text = My.Settings.Gate2
      Case 3
        txtName.Text = My.Settings.Name3
        txtIP.Text = My.Settings.IP3
        txtGateway.Text = My.Settings.Gate3
      Case 4
        txtName.Text = My.Settings.Name4
        txtIP.Text = My.Settings.IP4
        txtGateway.Text = My.Settings.Gate4
      Case 5
        txtName.Text = My.Settings.Name5
        txtIP.Text = My.Settings.IP5
        txtGateway.Text = My.Settings.Gate5
    End Select
  End Sub

  Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
    Select Case ID
      Case 1
        My.Settings.Name1 = txtName.Text
        My.Settings.IP1 = txtIP.Text
        My.Settings.Gate1 = txtGateway.Text
      Case 2
        My.Settings.Name2 = txtName.Text
        My.Settings.IP2 = txtIP.Text
        My.Settings.Gate2 = txtGateway.Text
      Case 3
        My.Settings.Name3 = txtName.Text
        My.Settings.IP3 = txtIP.Text
        My.Settings.Gate3 = txtGateway.Text
      Case 4
        My.Settings.Name4 = txtName.Text
        My.Settings.IP4 = txtIP.Text
        My.Settings.Gate4 = txtGateway.Text
      Case 5
        My.Settings.Name5 = txtName.Text
        My.Settings.IP5 = txtIP.Text
        My.Settings.Gate5 = txtGateway.Text
    End Select
    frmEinstellungen.LadeRouter()
    Me.Close()
  End Sub
End Class