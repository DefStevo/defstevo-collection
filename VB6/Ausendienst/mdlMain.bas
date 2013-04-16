Attribute VB_Name = "mdlMain"
Sub Main()
'Datenbank öffnen
If DBOpen = True Then
'  frmMain.Show
  frmDiat.Show
Else
  MsgBox mdlDBA.ErrDes, vbOKOnly, "Fehler " & mdlDBA.ErrNr
End If
End Sub
