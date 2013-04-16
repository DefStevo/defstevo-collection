Attribute VB_Name = "mdlPBH"
Public FehlerText As String
Public strID As String

Sub Main()
On Error GoTo ErrDb
If Left(Command$, 1) = "$" Then
  'Datenbank �ffnen mit Parameter
  Set DB = DBEngine.OpenDatabase(App.Path & "\PBH." & Right(Command$, Len(Command$) - 1) & ".mdb", False, False, ";pwd=DBpbh")
  'Login anzeigen
  frmMenu.Show
  Exit Sub
End If
'Datenbank �ffnen
Set DB = DBEngine.OpenDatabase(App.Path & "\PBH.mdb", False, False, ";pwd=DBpbh")
'Menu anzeigen
frmMenu.Show

Exit Sub
ErrDb:
'Fehler Nummer 3024: DB nicht gefunden.
If Err.Number = 3024 Then
  If mdlDB.DBAnla = True Then 'Function DBAnla wird ausgef�hrt, wenn Erfolgreich wird WAHR zur�ckgegeben
    frmMenu.Show
    Exit Sub
  Else
  On Error Resume Next
    Kill App.Path & "\PBH.mdb" 'Datenbank wird bei Fehler gel�scht
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
'Tabelle �ffnen
Set RS = DB.OpenRecordset(strSql)
'Pr�fung ob Datens�tz vorhanden sind
If Not RS.EOF And Not RS.BOF Then
  '1. Datensatz ausw�hlen
  RS.MoveFirst
  'Anzahl der Spalten bestimmen
  For i = 1 To RS.Fields.Count
    'Spalten hinzuf�gen
    frmListe.lst.ColumnAdd , RS.Fields(i - 1).Name
  Next i
  'Pr�fung ob lezter Datensatz
  Do While Not RS.EOF
    'Datensatz bilden
    strDatensatz = ""
    For i = 1 To RS.Fields.Count
      strDatensatz = strDatensatz & RS.Fields(i - 1).Value & vbTab
    Next i
    'Datensatz in Liste einf�gen
    frmListe.lst.AddItem RS(strID), strDatensatz
    RS.MoveNext
  Loop
  frmListe.lst.ColWidth(1) = 705
  frmListe.lst.ColWidth(2) = 3045
  frmListe.lst.Refresh
  'Bef�llen erfolgreich
  Liste = True
  strTabelle = strFrom
Else
  'Bef�llen fehlgeschlagen
  Liste = False
  FehlerText = "Kein Datensatz vorhanden" & vbCrLf & vbCrLf & _
               "SQL-Select: " & vbCrLf & _
               strSql
End If
'Variablen an Liste �bergeben
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
'Tabelle �ffnen
Set RS = DB.OpenRecordset(strSql)
'Pr�fung ob Datens�tz vorhanden sind
If Not RS.EOF And Not RS.BOF Then
  '1. Datensatz ausw�hlen
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
