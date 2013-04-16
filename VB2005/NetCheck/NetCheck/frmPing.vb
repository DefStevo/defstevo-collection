Public Class frmPing
  Dim bPing As Boolean
  Dim tBegin As Date
  Dim i As Integer
  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim tDif(txtAnzahl.Text - 1) As TimeSpan
    txtResultat.Text = ""
    bPing = My.Computer.Network.Ping(txtHost.Text)
    For i = 0 To txtAnzahl.Text - 1
      tBegin = Now
      bPing = My.Computer.Network.Ping(txtHost.Text)
      tDif(i) = Now - tBegin
      If bPing = False Then
        txtResultat.Text = txtResultat.Text & _
        i + 1 & ": Zielhost nicht erreicht nach: " & tDif(i).Milliseconds & " ms" & vbCrLf
      Else
        txtResultat.Text = txtResultat.Text & _
        i + 1 & ": " & txtHost.Text & " erreich nach: " & tDif(i).Milliseconds & " ms" & vbCrLf
      End If
      txtResultat.Refresh()
    Next
  End Sub

  Private Sub btnEinstellungen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEinstellungen.Click
    frmEinstellungen.Show()
  End Sub
End Class
