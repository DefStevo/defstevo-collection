Public Class frmEinst
  Private Tabelle As New ADODB.Recordset
  Private TabelleEinst As New ADODB.Recordset

  Private Sub frmEinst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    TabelleEinst = Datenbank.Tabelle÷ffnen("EINST")
    TabelleEinst.MoveFirst()
    txtBestand.Text = TabelleEinst("StdKtoBestand").Value
    txtKto.Text = TabelleEinst("StdKto").Value
    txtAdr.Text = TabelleEinst("StdAdr").Value
    txtGegBestand.Text = TabelleEinst("StdKtoGegBestand").Value
  End Sub

  Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
    TabelleEinst.Fields("StdKtoBestand").Value = txtBestand.Text
    TabelleEinst.Fields("StdKto").Value = txtKto.Text
    TabelleEinst.Fields("StdAdr").Value = txtAdr.Text
    TabelleEinst.Fields("StdKtoGegBestand").Value = txtGegBestand.Text
    TabelleEinst.Update()
  End Sub

  Private Sub btnEnde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnde.Click
    Me.Close()
  End Sub

  Private Sub txtBestand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBestand.KeyDown
    If e.KeyCode = Keys.F4 Then
      Dim frmListe As New frmListe
      txtBestand.Text = frmListe.Liste("KtoNr, KtoName, KtoSaldo", "Kto", "KtoBestand=1", "KtoNr")
    End If
  End Sub

  Private Sub txtBestand_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBestand.LostFocus
    If Not txtBestand.Text = "" And Not txtBestand.Text = "0" And IsNumeric(txtBestand.Text) Then
      Tabelle = Datenbank.Tabelle÷ffnen("Select * from Kto where KtoNr='" & txtBestand.Text & "' and KtoBestand=1")
      If Tabelle.BOF And Tabelle.EOF Then
        MsgBox("Konto nicht vorhanden oder kein Bestandskonto")
      End If
    Else
      txtBestand.Focus()
    End If
  End Sub

  Private Sub txtKto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKto.KeyDown
    If e.KeyCode = Keys.F4 Then
      Dim frmListe As New frmListe
      txtKto.Text = frmListe.Liste("KtoNr, KtoName, KtoSaldo", "Kto", "KtoBestand=0", "KtoNr")
    End If
  End Sub

  Private Sub txtKto_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKto.LostFocus
    If Not txtKto.Text = "" And Not txtKto.Text = "0" And IsNumeric(txtKto.Text) Then
      Tabelle = Datenbank.Tabelle÷ffnen("Select * from Kto where KtoNr='" & txtKto.Text & "' and KtoBestand=0")
      If Tabelle.BOF And Tabelle.EOF Then
        MsgBox("Konto nicht vorhanden oder ein Bestandskonto")
      End If
    Else
      txtKto.Focus()
    End If
  End Sub

  Private Sub txtAdr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAdr.KeyDown
    If e.KeyCode = Keys.F4 Then
      Dim frmListe As New frmListe
      txtAdr.Text = frmListe.Liste("AdrNr, AdrName, AdrSaldo", "Adr", "", "AdrNr")
    End If
  End Sub

  Private Sub txtAdr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdr.LostFocus
    If Not txtAdr.Text = "" And Not txtAdr.Text = "0" And IsNumeric(txtAdr.Text) Then
      Tabelle = Datenbank.Tabelle÷ffnen("Select * from Adr where AdrNr='" & txtAdr.Text & "'")
      If Tabelle.BOF And Tabelle.EOF Then
        MsgBox("Adresse nicht vorhanden")
      End If
    Else
      txtAdr.Focus()
    End If
  End Sub

  Private Sub txtGegBestand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGegBestand.KeyDown
    If e.KeyCode = Keys.F4 Then
      Dim frmListe As New frmListe
      txtGegBestand.Text = frmListe.Liste("KtoNr, KtoName, KtoSaldo", "Kto", "KtoBestand=1", "KtoNr")
    End If
  End Sub

  Private Sub txtGegBestand_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGegBestand.LostFocus
    If Not txtGegBestand.Text = "" And Not txtGegBestand.Text = "0" And IsNumeric(txtGegBestand.Text) Then
      Tabelle = Datenbank.Tabelle÷ffnen("Select * from Kto where KtoNr='" & txtGegBestand.Text & "' and KtoBestand=1")
      If Tabelle.BOF And Tabelle.EOF Then
        MsgBox("Konto nicht vorhanden oder kein Bestandskonto")
      End If
    Else
      txtGegBestand.Focus()
    End If
  End Sub

End Class