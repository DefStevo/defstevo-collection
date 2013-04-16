Public Class frmAdrKto
  Private Tabelle As New ADODB.Recordset
  Private FehlerText As String

  Private Sub frmAdrKto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    FensterZurücksetzen()
  End Sub

  Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
    FensterZurücksetzen()
  End Sub

  Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
    If PrüfenDaten() = True Then
      If SpeichernDaten() = True Then
        FensterZurücksetzen()
      End If
    Else
      MsgBox(FehlerText)
    End If
  End Sub

  Private Sub btnSuchen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuchen.Click
    FensterZurücksetzen()
    Dim frmListe As New frmListe
    txtNr.Text = frmListe.Liste(Me.Tag & "Nr, " & Me.Tag & "Name, " & Me.Tag & "Saldo", _
                              Me.Tag, "", _
                              Me.Tag & "Nr")
    txtName.Focus()
  End Sub

  Private Sub btnEnde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnde.Click
    Me.Close()
  End Sub

  Private Sub txtNr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNr.LostFocus
    If Not txtNr.Text = "" And Not txtNr.Text = "0" And IsNumeric(txtNr.Text) Then
      txtNr.Enabled = False
      Tabelle = Datenbank.TabelleÖffnen("Select * from " & Me.Tag & " where " & Me.Tag & "Nr='" & txtNr.Text & "'")
      If Not IsNothing(Tabelle) Then
        If Not Tabelle.BOF And Not Tabelle.EOF Then
          txtSaldo.Text = FormatCurrency(Tabelle.Fields(Me.Tag & "Saldo").Value, 2, TriState.True, TriState.True, TriState.True)
          txtName.Text = Tabelle.Fields(Me.Tag & "Name").Value
          txtMemo.Text = Tabelle.Fields(Me.Tag & "Memo").Value
          If Me.Tag = "Kto" Then
            If Tabelle.Fields(Me.Tag & "Bestand").Value = 1 Then
              cbBestand.Checked = True
            Else
              cbBestand.Checked = False
            End If
          End If
          Select Case Tabelle.Fields(Me.Tag & "Status").Value
            Case "A"
              txtStatus.Text = "Aktiv"
            Case "I"
              txtStatus.Text = "Inaktiv"
          End Select
          If txtSaldo.Text = "€ 0,00" Then
            btnBuchungen.Enabled = False
          Else
            btnBuchungen.Enabled = True
          End If
        Else
          txtSaldo.Text = FormatCurrency(0, 2, TriState.True, TriState.True, TriState.True)
        End If
      End If
    Else
      txtNr.Focus()
    End If
  End Sub

  Private Function FensterZurücksetzen() As Boolean
    FensterStandardwerte(Me, Me.Tag) 'Alle Felder (TextBox, MaskedTextBox) werden geleert
    If Me.Tag = "Kto" Then
      cbBestand.Visible = True
      cbBestand.Checked = False
    End If
    txtSaldo.Text = FormatCurrency("0", 2, TriState.True, TriState.True, TriState.True)
    txtNr.Enabled = True
    txtNr.Focus()
    Return True
  End Function

  Private Function PrüfenDaten() As Boolean
    PrüfenDaten = True
    FehlerText = "Folgende Fehler wurden festgestellt:"
    If txtNr.Text = "" Then
      PrüfenDaten = False
      FehlerText = FehlerText & vbCrLf & "- Keine Nummer angegeben"
    ElseIf Not IsNumeric(txtNr.Text) Then
      PrüfenDaten = False
      FehlerText = FehlerText & vbCrLf & "- Nummer ist nicht Nummerisch"
    End If
    If txtName.Text = "" Then
      PrüfenDaten = False
      FehlerText = FehlerText & vbCrLf & "- Kein Name angegeben"
    End If
    If txtStatus.Text = "" Then
      PrüfenDaten = False
      FehlerText = FehlerText & vbCrLf & "- Kein Status angegeben"
    End If
  End Function

  Private Function SpeichernDaten() As Boolean
    Tabelle.Fields(Me.Tag & "Nr").Value = txtNr.Text
    If Me.Tag = "Kto" Then
      If Me.cbBestand.Checked = True Then
        Tabelle.Fields(Me.Tag & "Bestand").Value = 1
      Else
        Tabelle.Fields(Me.Tag & "Bestand").Value = 0
      End If
    End If
    Tabelle.Fields(Me.Tag & "Status").Value = txtStatus.Text.Substring(0, 1)
    Tabelle.Fields(Me.Tag & "Name").Value = txtName.Text
    Tabelle.Fields(Me.Tag & "Saldo").Value = txtSaldo.Text
    Tabelle.Fields(Me.Tag & "Memo").Value = txtMemo.Text
    Tabelle.Update()
    Return True
  End Function

End Class