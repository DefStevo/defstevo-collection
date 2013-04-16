Public Class frmBuch
  Private Tabelle As New ADODB.Recordset
  Private FehlerText As String

  Private Sub frmBuch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    FensterZurücksetzten()
  End Sub

  Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    If PrüfeEinst() = True Then
      txtBuchNr.Text = ErmittleBuchNr()
      grpEinstellungen.Enabled = False
      grpBestand.Enabled = True
      txtBestand.Focus()
    Else
      MsgBox(FehlerText)
    End If
  End Sub

#Region "Sonstige Funktionen"
  Private Function FensterZurücksetzten() As Boolean
    FensterStandardwerte(Me, Me.Tag)
    txtDatum.Text = Date.Today.ToString
    grpEinstellungen.Enabled = True
    grpBestand.Enabled = False
    grpKonto.Enabled = False
    grpSonstiges.Enabled = False
    btnFertig.Enabled = False
    txtArt.Focus()
    Return True
  End Function

  Private Function ErmittleBuchNr() As Integer
    Tabelle = Datenbank.TabelleÖffnen("select max(BuchNr) as MaxBuchNr from Buch")
    If Not IsDBNull(Tabelle("maxBuchNr").Value) Then
      Return Tabelle("maxBuchId").Value + 1
    Else
      Return 1
    End If
  End Function
#End Region

#Region "Prüfungen"
  Private Function PrüfeEinst() As Boolean
    PrüfeEinst = True
    FehlerText = "Folgende Fehler wurden festgestellt:"
    If Not IsDate(txtDatum.Text) Then
      PrüfeEinst = False
      FehlerText = FehlerText & vbCrLf & "- Kein gültiges Datum hinterlegt"
    End If
    If txtArt.Text = "" Then
      PrüfeEinst = False
      FehlerText = FehlerText & vbCrLf & "- Keine Buchungsart hinterlegt"
    End If
    FehlerText = FehlerText & vbCrLf & vbCrLf & "Bitte korrigieren Sie die eingaben"
  End Function
#End Region
End Class