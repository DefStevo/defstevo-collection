Public Class frmKto
  Private Sub frmAdr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    AlleFelderLeeren(Me) 'Standardwert alle Felder(TextBox, MaskedTextBox) entfernen
  End Sub

  Private Sub btnEnde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnde.Click
    Me.Close()
  End Sub
End Class