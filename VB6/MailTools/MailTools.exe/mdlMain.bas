Attribute VB_Name = "mdlMain"
'Standard Variablen
Public Idx As Index
Public i As Integer
'DB Variablen
Public WSP As Workspace
Public DB As Database
Public RS As Recordset
Public TDF As TableDef
Public FLD As Field
'Outlook Variablen
Public OUTNS As Outlook.NameSpace
Public OUTFOLDERS As Outlook.Folders
Public OUTFOLD As Outlook.MAPIFolder
Public OUTOUTBOX As Outlook.MAPIFolder
Public OUTITEMS As Outlook.Items
Public OUTITEM As Outlook.MailItem
Public SNIFFOUTITEM As Object

Sub Main()
If FileExists(App.Path & "\Mail.mdb") = True Then
  Set DB = DBEngine.OpenDatabase(App.Path & "\Mail.mdb", False, False)
  If Command$ = "" Then
    frmMain.Show
  Else
    Set RS = DB.OpenRecordset("select * from Settings where SetName='KdMailsBatch'")
    RS.MoveFirst
    If Command$ = RS("SetValue").Value Then
      BatchKdMails
      Exit Sub
    Else
      MsgBox "Wrong Batch-Call: " & Command$, vbInformation + vbOKOnly, "Fehler beim Batchlauf"
      frmMain.Show
    End If
  End If
Else
  If DBAnla = True Then
    frmMain.Show
  End If
End If
End Sub

Private Function DBAnla() As Boolean
DBAnla = True
Set WSP = DBEngine.Workspaces(0)
'Datenbank wird angelegt
Set DB = WSP.CreateDatabase(App.Path & "\Mail.mdb", dbLangGeneral)

'Tabelle OutFold anlegen
Set TDF = DB.CreateTableDef("OutFold")
TDF.Fields.Append TDF.CreateField("SupKD", dbText, 50)
TDF.Fields.Append TDF.CreateField("FoldName", dbText, 255)
TDF.Fields.Append TDF.CreateField("EntryId", dbMemo)
DB.TableDefs.Append TDF

'Index für OutFold anlegen
Set Idx = TDF.CreateIndex("idxOutFold")
Idx.Primary = True
Idx.Required = True
Idx.Fields.Append TDF.CreateField("EntryId")
TDF.Indexes.Append Idx

'Tabelle für Log(KdMails Batch) anlegen
Set TDF = DB.CreateTableDef("KdMailsLOG")
TDF.Fields.Append TDF.CreateField("Typ", dbText, 1) '0=Batch, 1=Programm
TDF.Fields.Append TDF.CreateField("Date", dbDate)
TDF.Fields.Append TDF.CreateField("Time", dbDate)
TDF.Fields.Append TDF.CreateField("Subject", dbText)
TDF.Fields.Append TDF.CreateField("SupKd", dbText)
TDF.Fields.Append TDF.CreateField("FoldName", dbText)
DB.TableDefs.Append TDF

'Tabelle Sniffer anlegen
Set TDF = DB.CreateTableDef("Sniffer")
TDF.Fields.Append TDF.CreateField("Sender", dbText, 50)
TDF.Fields.Append TDF.CreateField("SentTime", dbDate)
TDF.Fields.Append TDF.CreateField("Subject", dbText, 255)
TDF.Fields.Append TDF.CreateField("EntryId", dbMemo)
DB.TableDefs.Append TDF

'Index für Sniffer anlegen
Set Idx = TDF.CreateIndex("idxSniffer")
Idx.Primary = True
Idx.Required = True
Idx.Fields.Append TDF.CreateField("EntryId")
TDF.Indexes.Append Idx

'Tabelle Settings anlegen
Set TDF = DB.CreateTableDef("Settings")
TDF.Fields.Append TDF.CreateField("SetName", dbText, 50)
TDF.Fields.Append TDF.CreateField("SetValue", dbText, 255)
DB.TableDefs.Append TDF

'Standardwerte
Set RS = DB.OpenRecordset("Settings")

RS.AddNew
RS("SetName").Value = "SupSnifffold"
RS("SetValue").Value = "0"
RS.Update

RS.AddNew
RS("SetName").Value = "SupSnifffoldEntryId"
RS("SetValue").Value = "0"
RS.Update

RS.AddNew
RS("SetName").Value = "SupSniffNotific"
RS("SetValue").Value = "0"
RS.Update

RS.AddNew
RS("SetName").Value = "KdMailsDays"
RS("SetValue").Value = "7"
RS.Update

RS.AddNew
RS("SetName").Value = "KdMailsDB"
RS("SetValue").Value = "1"
RS.Update

RS.AddNew
RS("SetName").Value = "KdMailsBatch"
RS("SetValue").Value = "Batch"
RS.Update

RS.AddNew
RS("SetName").Value = "SniffDate"
RS("SetValue").Value = Date
RS.Update

RS.AddNew
RS("SetName").Value = "SniffTime"
RS("SetValue").Value = Time
RS.Update

RS.AddNew
RS("SetName").Value = "KdMailsLOG"
RS("SetValue").Value = "0"
RS.Update
End Function

Public Function FileExists(Path As String) As Boolean
Const NotFile = vbDirectory Or vbVolume
On Error Resume Next
FileExists = (GetAttr(Path) And NotFile) = 0
On Error GoTo 0
End Function
