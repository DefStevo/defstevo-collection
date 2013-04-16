Attribute VB_Name = "mdlPBH"
Public FehlerText As String
Public strID As String

Sub Main()
On Error GoTo ErrDb
If Left(Command$, 1) = "$" Then
  'Datenbank öffnen mit Parameter
  Set DB = DBEngine.OpenDatabase(App.Path & "\PBH." & Right(Command$, Len(Command$) - 1) & ".mdb", False, False, ";pwd=DBpbh")
  'Login anzeigen
  frmMenu.Show
  Exit Sub
End If
'Datenbank öffnen
Set DB = DBEngine.OpenDatabase(App.Path & "\PBH.mdb", False, False, ";pwd=DBpbh")
'Menu anzeigen
frmMenu.Show

Exit Sub
ErrDb:
'Fehler Nummer 3024: DB nicht gefunden.
If Err.Number = 3024 Then
  If mdlDB.DBAnla = True Then 'Function DBAnla wird ausgeführt, wenn Erfolgreich wird WAHR zurückgegeben
    frmMenu.Show
    Exit Sub
  Else
  On Error Resume Next
    Kill App.Path & "\PBH.mdb" 'Datenbank wird bei Fehler gelöscht
  End If
End If
MsgBox FehlerText 'Fehlermeldung
End Sub

Public Function Liste(strID As String, strSelect As String, strFrom As String, strWhere As String, strOrder As String) As Boolean
'True=Erfolgreich
'False=Kein Datensatz gefunden
Dim i As Integer
Dim strSql As String
Dim strDatensatz As String
On Error GoTo Err
'SQL Abfrage erstellen
strSql = "Select " & strSelect & " from " & strFrom
'Falls Where-Bedingung mit angegeben wird
If Not strWhere = "" Then
  strSql = strSql & " where " & strWhere
End If
If Not strOrder = "" Then
  strSql = strSql & " Order By " & strOrder
End If
'Tabelle öffnen
Set RS = DB.OpenRecordset(strSql)
'Prüfung ob Datensätz vorhanden sind
If Not RS.EOF And Not RS.BOF Then
  '1. Datensatz auswählen
  RS.MoveFirst
  'Anzahl der Spalten bestimmen
  For i = 1 To RS.Fields.Count
    'Spalten hinzufügen
    frmListe.lst.ColumnAdd , RS.Fields(i - 1).Name
  Next i
  'Prüfung ob lezter Datensatz
  Do While Not RS.EOF
    'Datensatz bilden
    strDatensatz = ""
    For i = 1 To RS.Fields.Count
      strDatensatz = strDatensatz & RS.Fields(i - 1).Value & vbTab
    Next i
    'Datensatz in Liste einfügen
    frmListe.lst.AddItem RS(strID), strDatensatz
    RS.MoveNext
  Loop
  frmListe.lst.ColWidth(1) = 705
  frmListe.lst.ColWidth(2) = 3045
  frmListe.lst.Refresh
  'Befüllen erfolgreich
  Liste = True
  strTabelle = strFrom
Else
  'Befüllen fehlgeschlagen
  Liste = False
  FehlerText = "Kein Datensatz vorhanden" & vbCrLf & vbCrLf & _
               "SQL-Select: " & vbCrLf & _
               strSql
End If
'Variablen an Liste übergeben
Exit Function
Err:
'Fehler aufgetreten
Liste = False
FehlerText = "Fehler: " & Err.Number & vbCrLf & _
             Err.Description & vbCrLf & vbCrLf & _
             "SQL-Select: " & vbCrLf & _
             strSql
End Function

Public Function LadeDaten(strFrom As String, strWhere As String) As Boolean
strID = ""
'True=Erfolgreich
'False=Kein Datensatz gefunden
On Error GoTo Err
'SQl Abfrage erstellen
strSql = "Select * from " & strFrom & " where " & strWhere
'Tabelle öffnen
Set RS = DB.OpenRecordset(strSql)
'Prüfung ob Datensätz vorhanden sind
If Not RS.EOF And Not RS.BOF Then
  '1. Datensatz auswählen
  RS.MoveFirst
  LadeDaten = True
Else
  'Kein Datensatz vorhanden
  LadeDaten = False
  FehlerText = "Kein Datensatz vorhanden" & vbCrLf & vbCrLf & _
               "SQL-Select: " & vbCrLf & _
               strSql
End If
Exit Function
Err:
'Fehler aufgetreten
LadeDaten = False
FehlerText = "Fehler: " & Err.Number & vbCrLf & _
             Err.Description & vbCrLf & vbCrLf & _
             "SQL-Select: " & vbCrLf & _
             strSql
End Function
