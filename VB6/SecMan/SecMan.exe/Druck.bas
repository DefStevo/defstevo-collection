Attribute VB_Name = "Druck"
Public dReport As DREngine.Report

Public Sub DokDruck(Programm As String, Dokument As String)
Dim QrDok As QueryDef

'Query öffnen
Set QrDok = DBSecMan.QueryDefs("qr" & Programm & "Druck")

'SQL Select erzeugen
strSQL = "SELECT " & Programm & "." & Programm & "Nr, " & Programm & ".Dat, " & Programm & ".Wert, " & Programm & ".UstWert, Z.ArtId, Z.Bez, ART.Einh, Z.EPreis, Z.Anzahl, Z.GPreis, Z.UstBetrag, VER.VName, VER.SP, KD.Anr, KD.VName, KD.NName, KD.Adr, KD.PLZ, KD.Ort, ZAHL.Text " & _
         "FROM (ART INNER JOIN (((" & Programm & " INNER JOIN VER ON " & Programm & ".VerId = VER.VerId) INNER JOIN KD ON VER.KdId = KD.KdId) INNER JOIN Z ON " & Programm & "." & Programm & "Nr = Z.DokId) ON ART.ArtId = Z.ArtId) INNER JOIN ZAHL ON " & Programm & ".ZahlId = ZAHL.ZahlId " & _
         "WHERE (((" & Programm & "." & Programm & "Nr)='" & Dokument & "')) " & _
         "ORDER BY Z.ArtId;"

'SELECT AN.AnNr, AN.Dat, AN.Wert, Z.ArtId, Z.Bez, ART.Einh, Z.EPreis, Z.Anzahl, Z.GPreis, VER.VName, VER.SP, KD.VName, KD.NName, KD.Adr, KD.PLZ, KD.Ort, ZAHL.Text
'FROM (ART INNER JOIN (((AN INNER JOIN VER ON AN.VerId = VER.VerId) INNER JOIN KD ON VER.KdId = KD.KdId) INNER JOIN Z ON AN.AnNr = Z.DokId) ON ART.ArtId = Z.ArtId) INNER JOIN ZAHL ON AN.ZahlId = ZAHL.ZahlId
'WHERE (((AN.AnNr)='AN003/2007'))
'ORDER BY Z.ArtId;

'Query aktualisieren
QrDok.SQL = strSQL

'Abfrage welcher Druck gewählt werden soll
Select Case Programm
Case "AN"
  Set dReport = DREngine.OpenReport(App.Path & "\DRZ\Anbot.drz")

Case "AU"
  Set dReport = DREngine.OpenReport(App.Path & "\DRZ\Auftrag.drz")

Case "RE"
  Set dReport = DREngine.OpenReport(App.Path & "\DRZ\Rechnung.drz")
End Select

If QrDok.ReturnsRecords = True Then
  dReport.Preview
Else
  MsgBox "Keine Daten vorhanden", vbOKOnly + vbInformation, "Fehler beim Druck"
End If

Unload frmDruck
End Sub

Public Sub MADruck()
Set dReport = DREngine.OpenReport(App.Path & "\DRZ\MA.drz")
dReport.Preview
Unload frmDruck
End Sub

Public Sub KDDruck()
Set dReport = DREngine.OpenReport(App.Path & "\DRZ\KD.drz")
dReport.Preview
Unload frmDruck
End Sub

Public Sub VERDruck()
Set dReport = DREngine.OpenReport(App.Path & "\DRZ\VER.drz")
dReport.Preview
Unload frmDruck
End Sub

Public Sub ARTDruck()
Set dReport = DREngine.OpenReport(App.Path & "\DRZ\ART.drz")
dReport.Preview
Unload frmDruck
End Sub
