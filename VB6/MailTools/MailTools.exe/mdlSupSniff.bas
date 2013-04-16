Attribute VB_Name = "mdlSupSniff"
'Einstellungsvariablen
Public strDate As String
Public strTime As String
Public strFoldId As String
Public iTyp As Integer
'Sonstige Variablen
Public MailCount As Integer
Public bolNew As Boolean

Public Function GetSettings() As Boolean
Set RS = DB.OpenRecordset("Select * from Settings where SetName='SniffDate'")
strDate = RS("SetValue").Value
Set RS = DB.OpenRecordset("Select * from Settings where SetName='SniffTime'")
strTime = RS("SetValue").Value
Set RS = DB.OpenRecordset("Select * from Settings where SetName='SupSnifffoldEntryId'")
strFoldId = RS("SetValue").Value
Set RS = DB.OpenRecordset("Select * from Settings where SetName='SupSniffNotific'")
iTyp = RS("SetValue").Value
GetSettings = True
End Function

Public Function OpenRs() As Boolean
Set RS = DB.OpenRecordset("Sniffer")
OpenRs = True
End Function

Public Function Sniff() As Boolean
Set OUTNS = Application.GetNamespace("MAPI")
Set OUTFOLD = OUTNS.GetFolderFromID(strFoldId)
Set OUTITEMS = OUTFOLD.Items.Restrict("[ReceivedTime] > '" & Format(strDate & " " & strTime, "DD.MM.YYYY HH:MM") & "'")

If OUTITEMS.Count > 0 Then
  For Each SNIFFOUTITEM In OUTITEMS
    If CheckinDB(SNIFFOUTITEM.EntryId) = False Then
      AddToDB SNIFFOUTITEM.SenderName, SNIFFOUTITEM.SentOn, SNIFFOUTITEM.Subject, SNIFFOUTITEM.EntryId
      frmSupSnifferTab.lstMails.AddItem , SNIFFOUTITEM.SenderName & vbTab & _
                                          SNIFFOUTITEM.Subject & vbTab & _
                                          SNIFFOUTITEM.SentOn & vbTab & _
                                          SNIFFOUTITEM.EntryId
      frmSupSnifferTab.lstMails.Refresh
      i = i + 1
      bolNew = True
    End If
  Next
End If

If i > 0 And bolNew = True Then
'Neue E-Mails
frmSupSniffer.sevTray.IconStyle = sevFlashingIcon
  If iTyp = 0 Then
    'Tooltip anzeigen
    frmSupSniffer.sevTray.ShowBalloon "Neue Nachrichten", "Im Supportordner befinden sich " & i & " neue Nachrichten", sevTTInfoIcon
  Else
    'Tabelle anzeigen
  End If
bolNew = False
End If
End Function

Public Function AddToDB(Sender As String, SentTime As String, Subject As String, EntryId As String)
If Subject = "" Then Subject = "Kein Betreff"
RS.AddNew
RS("Sender").Value = Sender
RS("SentTime").Value = SentTime
RS("Subject").Value = Subject
RS("ENtryID").Value = EntryId
RS.Update
End Function

Public Function CheckinDB(EntryId As String) As Boolean
If Not RS.RecordCount = 0 Then
  RS.MoveLast
  RS.MoveFirst
  Do Until RS.EOF = True
    If RS("EntryID").Value = EntryId Then
      CheckinDB = True
      Exit Function
    End If
    RS.MoveNext
  Loop
End If
CheckinDB = False
End Function

Public Function DelFromDB(EntryId As String)
DB.Execute ("Delete from Sniffer where EntryID='" & EntryId & "'")
End Function

Public Function OpenFolder()
Set Application.ActiveExplorer.CurrentFolder = OUTNS.GetFolderFromID(strFoldId)
Application.ActiveExplorer.Display
End Function

Public Function Gelesen()
DB.Execute ("Delete * from Sniffer")
DB.Execute ("Update Settings set SetValue='" & Date & "' where SetName='SniffDate'")
DB.Execute ("Update Settings set SetValue='" & Time & "' where setname='Snifftime'")
End Function
