Attribute VB_Name = "mdlBatch"
Public Sub KdMails()
Dim i As Integer
GetParameter
Set RS = DB.OpenRecordset("Select SetValue from Settings where SetName='KdMailsDB'")
If RS("SetValue").Value = "FALSE" Then
  MsgBox "Keine DB vorhanden"
  frmMain.Show
  Exit Sub
End If
If SucheMails = True Then
  'Mails vorhanden
  MoveMails True
Else
  'keine Mails vorhanden
  Exit Sub
End If
Unload frmKdMails
frmMain.Show
End Sub

Public Sub SupSniff()
frmSupSniffer.Show
End Sub
