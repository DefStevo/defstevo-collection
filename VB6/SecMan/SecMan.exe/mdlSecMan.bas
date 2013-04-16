Attribute VB_Name = "mdlSecMan"
Public DBSecMan As Database
Public RS As Recordset

'Wird zum zwischenspeichern von SQL Befehlen bzw. Select's verwendet
Public strSQL As String

'Wird zum unterscheiden des Aufrufs für die einzelnen Programme verwendet
'0=Standard
'1=Neuanlage, 2=bestehender Datensatz
'11=Angebot Neu, 12=Angebot bestehender Datensatz
'21=Auftrag Neu, 22=Auftrag bestehender Datensatz, 23=Überleitung aus Angebot
'31=Rechnung Neu, 32=Rechnung bestehender Datensatz, 33=Überleitung aus Auftrag
Public Aufruf As Integer

Sub Main()
On Error GoTo ErrDb
Dim Version As String
'On Error GoTo ErrDb 'Error Handler

'Verbindung zur Datenbank herstellen (Muss im selben Verzeichnis wie die Exe liegen sonst Fehler.Nr. 3024
Set DBSecMan = DBEngine.OpenDatabase(App.Path & "\SecMan.mdb", False, False, ";pwd=DBSecMan")

'Tabelle SYS öffnen und Version kontrollieren x.x.x
Set RS = DBSecMan.OpenRecordset("SYS")
Version = App.Major & "." & App.Minor & "." & App.Revision

If Not RS("Version").Value = Version Then
    'wenn Version nicht übereinstimmt wirde der DB Update durchgeführt,
    'hierfür wird als Parameter die Version übergeben auf die Upgedatet werden soll.
    Shell App.Path & "\DBAnla.exe " & RS("Version").Value
  Else
    'wenn die Version übereinstimmt wird das Menu geöffnet
    frmMenu.Show
End If

Exit Sub

ErrDb:
'Fehler.Nr. 3024 (DB nicht gefunden)
If Err.Number = 3024 Then
    'Anlage einer neuen Leeren DB über DBAnla.exe und Parameter Neu
    Shell App.Path & "\DbAnla.exe Neu", vbNormalFocus
End If

End Sub
