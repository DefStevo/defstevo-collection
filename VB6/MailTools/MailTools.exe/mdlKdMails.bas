Attribute VB_Name = "mdlKdMails"
'Einstellungsvariablen
Public intDate As Integer
Public strDb As String
Public intLOG As Integer
'Protokollvariablen
Public RSLog As Recordset
'Sonstige Variablen
Public strKd As String
Public strEntId As String
Public strFoldName As String
Public int1 As Integer
Public int2 As Integer
Public MailCount As Integer

Public Function FoldIdDB() As Boolean
Dim iCount As Integer
DB.Execute ("Delete * from OutFold")
Set RS = DB.OpenRecordset("OutFold")
Set OUTNS = Application.GetNamespace("MAPI")

'Rewe durchsuchen
Set OUTFOLDERS = OUTNS.GetFolderFromID("000000001A447390AA6611CD9BC800AA002FC45A0300833A7E3A19495E408237FAAE11A0029F0000000000240000").Folders
Set OUTFOLD = OUTFOLDERS.GetFirst
iCount = 1
Do While Not OUTFOLD Is Nothing
frmOptionen.cmdFoldDb.Caption = "Rewe: Ordner " & iCount & " von " & OUTFOLDERS.Count
frmOptionen.cmdFoldDb.Refresh
  For i = 1 To Len(OUTFOLD.Name)
    If Right(Left(OUTFOLD.Name, i), 1) = " " Then
      RS.AddNew
      RS("SupKD").Value = Left(OUTFOLD.Name, i - 1)
      RS("FoldName").Value = OUTFOLD.Name
      RS("EntryId").Value = OUTFOLD.EntryId
      RS.Update
      Exit For
    End If
  Next i
  Set OUTFOLD = OUTFOLDERS.GetNext
iCount = iCount + 1
Loop

'Wawi durchsuchen
Set OUTFOLDERS = OUTNS.GetFolderFromID("000000001A447390AA6611CD9BC800AA002FC45A0300833A7E3A19495E408237FAAE11A0029F00000000006F0000").Folders
Set OUTFOLD = OUTFOLDERS.GetFirst
iCount = 1
Do While Not OUTFOLD Is Nothing
frmOptionen.cmdFoldDb.Caption = "Wawi: Ordner " & iCount & " von " & OUTFOLDERS.Count
frmOptionen.cmdFoldDb.Refresh
  For i = 1 To Len(OUTFOLD.Name)
    If Right(Left(OUTFOLD.Name, i), 1) = " " Then
      RS.AddNew
      RS("SupKD").Value = Left(OUTFOLD.Name, i - 1)
      RS("FoldName").Value = OUTFOLD.Name
      RS("EntryId").Value = OUTFOLD.EntryId
      RS.Update
      Exit For
    End If
  Next i
  Set OUTFOLD = OUTFOLDERS.GetNext
iCount = iCount + 1
Loop

DB.Execute "Update Settings set SetValue ='0' where SetName='KdMailsDB'"
FoldIdDB = True
End Function

Public Function BatchKdMails()
If GetParameter = True Then
  If SucheMails = True Then
    For i = 1 To frmKdMails.lstMail.ListIndex
      MoveMail 1
    Next i
  End If
End If
DB.Execute ("Delete * from Sniffer")
Unload frmHilfe
Unload frmInfo
Unload frmKdMails
Unload frmKdMailsLOG
Unload frmOptionen
Unload frmOptionenFoldDB
Unload frmSupSniffer
Unload frmSupSnifferTab
Unload frmMain
End Function

Public Function GetParameter() As Boolean
Set RS = DB.OpenRecordset("Select SetValue from Settings where SetName='KdMailsDays'")
RS.MoveFirst
intDate = RS("SetValue").Value
Set RS = DB.OpenRecordset("Select SetValue from Settings where SetName='KdMailsDB'")
RS.MoveFirst
strDb = RS("SetValue").Value
Set RS = DB.OpenRecordset("Select SetValue from Settings where SetName='KdMailsLOG'")
RS.MoveFirst
intLOG = RS("SetValue").Value
Set RSLog = DB.OpenRecordset("KdMailsLog")
GetParameter = True
End Function

Public Function SucheMails() As Boolean
frmKdMails.Caption = "E-Mails werden analysiert..."
Set OUTNS = Application.GetNamespace("MAPI")
Set OUTOUTBOX = OUTNS.GetDefaultFolder(olFolderSentMail)
MailCount = OUTOUTBOX.Items.Restrict("[SentOn] > '" & Format(Date - intDate, "DD:MM:YYYY HH:MM") & "'").Count
For i = 1 To MailCount
  frmKdMails.txtMail.Text = "E-Mail: " & i & " von " & MailCount & " wird analysiert."
  frmKdMails.Refresh
  Set OUTITEM = OUTOUTBOX.Items.Restrict("[SentOn] > '" & Format(Date - intDate, "DD:MM:YYYY HH:MM") & "'").Item(i)
  SucheKD (OUTITEM.Subject)
  If Not strKd = "=> Kein Supportmail" Then
    If strDb = 1 Then
      SucheEntId (strKd)
    Else
      SucheEntIdDB (strKd)
    End If
  Else
    strEntId = ""
  End If
  If Not strEntId = "" Then
    frmKdMails.lstMail.AddItem OUTITEM.EntryId, OUTITEM.Subject & vbTab & strKd & vbTab & OUTITEM.SentOn & vbTab & OUTITEM.EntryId & vbTab & strEntId & vbTab & strFoldName
  End If
Next i
frmKdMails.lstMail.SortAuto = True
frmKdMails.lstMail.Refresh
frmKdMails.lstMail.SortAuto = False
frmKdMails.Caption = "E-Mail Tools - KdMails"
If frmKdMails.lstMail.ListCount = 0 Then
frmKdMails.txtMail.Text = "Keine E-Mails zum verschieben vorhanden."
SucheMails = False
Else
frmKdMails.txtMail.Text = "Folgende E-Mails können verschoben werden," & vbCrLf & _
                          "Doppelklick um den jeweiligen E-Mail zu verschieben."
frmKdMails.lstMail.Enabled = True
frmKdMails.lstMail.BackColor = &H80000005
frmKdMails.lstMail.DeSelectAll
frmKdMails.cmdMove.Enabled = True
frmKdMails.cmdMoveAll.Enabled = True
SucheMails = True
End If
frmKdMails.cmdEnde.Enabled = True
End Function

Public Function SucheKD(Subject As String)
strKd = "=> Kein Supportmail"
For int1 = 1 To Len(Subject)
  If Right(Left(Subject, int1), 1) = "/" Then
    strKd = Left(Subject, int1 - 1)
    For int2 = 1 To Len(strKd)
      If Left(Right(strKd, int2), 1) = " " Then
        If Left(Right(strKd, int2 + 10), 10) = "RS Support" Then
          strKd = Right(strKd, int2 - 1)
          Exit Function
        Else
          strKd = "=> Kein Supportmail"
        End If
      ElseIf int2 = Len(strKd) Then
        strKd = "=> Kein Supportmail"
      End If
    Next int2
  End If
Next int1
End Function

Public Function SucheEntId(Kunde As String) As Boolean
'WAWI Ordner durchsuchen
Set OUTFOLDERS = OUTNS.GetFolderFromID("000000001A447390AA6611CD9BC800AA002FC45A0300833A7E3A19495E408237FAAE11A0029F00000000006F0000").Folders
Set OUTFOLD = OUTFOLDERS.GetFirst
Do While Not OUTFOLD Is Nothing
  For i = 1 To Len(OUTFOLD.Name)
    If Right(Left(OUTFOLD.Name, i), 1) = " " Then
        strFoldName = Left(OUTFOLD.Name, i - 1)
    Exit For
    End If
  Next i
  If strFoldName = Kunde Then
    strEntId = OUTFOLD.EntryId
    Exit Function
  Else
    strEntId = ""
  End If
Set OUTFOLD = OUTFOLDERS.GetNext
Loop

'REWE Ordner durchsuchen
Set OUTFOLDERS = OUTNS.GetFolderFromID("000000001A447390AA6611CD9BC800AA002FC45A0300833A7E3A19495E408237FAAE11A0029F0000000000240000").Folders
Set OUTFOLD = OUTFOLDERS.GetFirst
Do While Not OUTFOLD Is Nothing
  For i = 1 To Len(OUTFOLD.Name)
    If Right(Left(OUTFOLD.Name, i), 1) = " " Then
        strFoldName = Left(OUTFOLD.Name, i - 1)
    Exit For
    End If
  Next i
  If strFoldName = Kunde Then
    strEntId = OUTFOLD.EntryId
    Exit Function
  Else
    strEntId = ""
  End If
Set OUTFOLD = OUTFOLDERS.GetNext
Loop
End Function

Public Function SucheEntIdDB(Kunde As String) As Boolean
Set RS = DB.OpenRecordset("OutFold")
RS.MoveLast
RS.MoveFirst
Do Until RS.EOF = True
  If Kunde = RS("SupKD").Value Then
    strEntId = RS("EntryID").Value
    strFoldName = RS("FoldName").Value
    Exit Function
  Else
    strEntId = ""
    strFoldName = ""
  End If
RS.MoveNext
Loop
End Function

Public Function MoveMail(idxMail As Integer) As Boolean
If Not frmKdMails.lstMail.SubItems(idxMail, 4) = "" Then
  frmKdMails.txtMail.Text = "Verschiebe " & frmKdMails.lstMail.SubItems(idxMail, 1) & " nach " & frmKdMails.lstMail.SubItems(idxMail, 2)
  frmKdMails.txtMail.Refresh
  If intLOG = 1 Then
      RSLog.AddNew
      RSLog("Date").Value = Date
      RSLog("Time").Value = Time
      RSLog("Subject").Value = frmKdMails.lstMail.SubItems(idxMail, 1)
      RSLog("SupKD").Value = frmKdMails.lstMail.SubItems(idxMail, 2)
      RSLog("FoldName").Value = frmKdMails.lstMail.SubItems(idxMail, 6)
      RSLog.Update
  End If
  Set OUTITEM = OUTNS.GetItemFromID(frmKdMails.lstMail.SubItems(idxMail, 4))
  OUTITEM.Move OUTNS.GetFolderFromID(frmKdMails.lstMail.SubItems(idxMail, 5))
  frmKdMails.lstMail.RemoveItem (idxMail)
  If Not frmKdMails.lstMail.ListCount = 0 Then
    frmKdMails.txtMail.Text = "Folgende E-Mails können verschoben werden," & vbCrLf & _
                              "Doppelklick um den jeweiligen E-Mail zu verschieben."
    frmKdMails.txtMail.Refresh
  Else
    frmKdMails.txtMail.Text = "Keine weiteren Mails vorhanden."
    frmKdMails.cmdMove.Enabled = False
    frmKdMails.cmdMoveAll.Enabled = False
  End If
End If
End Function
