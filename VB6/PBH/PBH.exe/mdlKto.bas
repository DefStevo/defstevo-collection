Attribute VB_Name = "mdlKto"
Public Function Kürzel(strKürzel As String) As String
Select Case strKürzel
Case "0"
Kürzel = "Inaktiv"
Case "1"
Kürzel = "Aktiv"
Case "A"
Kürzel = "Ausgaben"
Case "B"
Kürzel = "Bestand"
Case "E"
Kürzel = "Einnahmen"
Case "U"
Kürzel = "Umbuchung"
End Select
End Function

Public Function Buchungen(KtoNr As String, KtoArt As String) As Boolean
Dim RsKto As Recordset
Dim RsBestand As Recordset
Dim RsAdr As Recordset
Dim strStatus As String
Buchungen = True
'On Error GoTo Err
strSql = "Select BuchId, BuchDat, BuchStatus, BuchKtoBestand, BuchKto, BuchAdr, BuchKtoBetrag, BuchText from Buch"
If KtoArt = "B" Then
  strSql = strSql & " where BuchKtoBestand='" & KtoNr & "' or BuchKto='" & KtoNr & "'"
ElseIf KtoArt = "P" Then
  strSql = strSql & " where BuchAdr='" & KtoNr & "'"
Else
  strSql = strSql & " where BuchKto='" & KtoNr & "'"
End If
strSql = strSql & " Order by BuchID"
Set RS = DB.OpenRecordset(strSql)
If Not RS.BOF And Not RS.EOF Then
  RS.MoveLast
  RS.MoveFirst
  For i = 1 To RS.RecordCount
    If RS("BuchStatus").Value = "N" Then
      strStatus = "Neu"
    ElseIf RS("BuchStatus").Value = "V" Then
      strStatus = "Verbucht"
    ElseIf RS("BuchStatus").Value = "S" Then
      strStatus = "Storniert"
    ElseIf RS("BuchStatus").Value = "I" Then
      strStatus = "Importiert"
    End If
    Set RsKto = DB.OpenRecordset("Select KtoName from Kto where KtoNr='" & RS("BuchKto").Value & "'")
    Set RsBestand = DB.OpenRecordset("Select KtoName from Kto where KtoNr='" & RS("BuchKtoBestand").Value & "'")
    If Not RS("BuchAdr").Value = "" Then
      Set RsAdr = DB.OpenRecordset("Select AdrName from Adr where AdrNr='" & RS("BuchAdr").Value & "'")
      frmBuchungen.lst.AddItem , RS("BuchID").Value & vbTab & _
                                 RS("BuchDat").Value & vbTab & _
                                 strStatus & vbTab & _
                                 RS("BuchKtoBestand").Value & vbTab & _
                                 RsBestand("KtoName").Value & vbTab & _
                                 RS("BuchKto").Value & vbTab & _
                                 RsKto("KtoName").Value & vbTab & _
                                 RS("BuchAdr").Value & vbTab & _
                                 RsAdr("AdrName").Value & vbTab & _
                                 Format(RS("BuchKtoBetrag").Value, "#,##0.00 €") & vbTab & _
                                 RS("BuchText").Value
    Else
      frmBuchungen.lst.AddItem , RS("BuchID").Value & vbTab & _
                                 RS("BuchDat").Value & vbTab & _
                                 strStatus & vbTab & _
                                 RS("BuchKtoBestand").Value & vbTab & _
                                 RsBestand("KtoName").Value & vbTab & _
                                 RS("BuchKto").Value & vbTab & _
                                 RsKto("KtoName").Value & vbTab & vbTab & vbTab & _
                                 Format(RS("BuchKtoBetrag").Value, "#,##0.00 €") & vbTab & _
                                 RS("BuchText").Value
    End If
    RS.MoveNext
  Next i
Else
  'Kein Datensatz vorhanden
  Buchunge = False
  FehlerText = "Kein Datensatz vorhanden" & vbCrLf & vbCrLf & _
               "SQL-Select: " & vbCrLf & _
               strSql
End If
Exit Function
Err:
'Fehler aufgetreten
Buchungen = False
FehlerText = "Fehler: " & Err.Number & vbCrLf & _
             Err.Description & vbCrLf & vbCrLf & _
             "SQL-Select: " & vbCrLf & _
             strSql
End Function


