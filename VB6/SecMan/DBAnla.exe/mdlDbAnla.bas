Attribute VB_Name = "mdlDbAnla"
Public DBSecMan As Database
Public Wsp As Workspace
Public Tdf As TableDef
Public Fld As Field
Public Idx As Index
Public Rel As Relation
Public qr As QueryDef

Public Sub Main()
If Command$ = "Neu" Then
frmDbAnla.Show
Set Wsp = DBEngine.Workspaces(0)

'Datenbank anlegen in den selben Pfad wie die Exe mit Kennwort DBSecMan
frmDbAnla.lblInfo.Caption = "Datenbank wird angelegt"
Set DBSecMan = Wsp.CreateDatabase(App.Path & "\SecMan.mdb", dbLangGeneral & ";pwd=DBSecMan")

'Tabellen anlagen
frmDbAnla.lblInfo.Caption = "Tabelle tblSYS wird angelegt"
frmDbAnla.Refresh
tblSYS
frmDbAnla.lblInfo.Caption = "Tabelle tblMA wird angelegt"
frmDbAnla.Refresh
tblMA
frmDbAnla.lblInfo.Caption = "Tabelle tblKD wird angelegt"
frmDbAnla.Refresh
tblKD
frmDbAnla.lblInfo.Caption = "Tabelle tblVER wird angelegt"
frmDbAnla.Refresh
tblVER
frmDbAnla.lblInfo.Caption = "Tabelle tblART wird angelegt"
frmDbAnla.Refresh
tblART
frmDbAnla.lblInfo.Caption = "Tabelle tblZahl wird angelegt"
frmDbAnla.Refresh
tblZahl
frmDbAnla.lblInfo.Caption = "Tabelle tblNR wird angelegt"
frmDbAnla.Refresh
tblNR
frmDbAnla.lblInfo.Caption = "Tabelle tblAN wird angelegt"
frmDbAnla.Refresh
tblAN
frmDbAnla.lblInfo.Caption = "Tabelle tblAU wird angelegt"
frmDbAnla.Refresh
tblAU
frmDbAnla.lblInfo.Caption = "Tabelle tblRE wird angelegt"
frmDbAnla.Refresh
tblRE
frmDbAnla.lblInfo.Caption = "Tabelle tblZ wird angelegt"
frmDbAnla.Refresh
tblZ
frmDbAnla.lblInfo.Caption = "Tabelle tblPLZ wird angelegt"
frmDbAnla.Refresh
tblPLZ

frmDbAnla.lblInfo.Caption = "Beziehungen werden generiert"
frmDbAnla.Refresh
'Beziehungen anlegen
Beziehungen

frmDbAnla.lblInfo.Caption = "Standardwerte werden eingefügt"
frmDbAnla.Refresh
'Standardwerte hinterlegen
StdWerte

frmDbAnla.lblInfo.Caption = "Tabelle PLZ wird mit Daten gefüllt"
frmDbAnla.Refresh
'PLZ hinzufügen
PLZDaten

frmDbAnla.lblInfo.Caption = "Abfragen werden erstellt"
frmDbAnla.Refresh
'Abfragen anlegen
qrDok

frmDbAnla.lblInfo.Caption = "Fertig"
frmDbAnla.Refresh
'Datenbank schließen
DBSecMan.Close

'Fenster DbAnla schließen
Unload frmDbAnla

'Security Manager starten
Shell App.Path & "\SecMan.exe", vbNormalFocus
Else
mdlDBUpdate.Update Command$
End If

End Sub

Public Sub tblSYS()
Set Tdf = DBSecMan.CreateTableDef("SYS")

  Tdf.Fields.Append Tdf.CreateField("SysName", dbText, 6)
  Tdf.Fields.Append Tdf.CreateField("Version", dbText, 10)
  Tdf.Fields.Append Tdf.CreateField("BakDat", dbDate)

DBSecMan.TableDefs.Append Tdf

Set Tdf = Nothing
Set Fld = Nothing

End Sub

Public Sub tblMA()
Set Tdf = DBSecMan.CreateTableDef("MA")
    
Set Fld = Tdf.CreateField("MaId", dbLong, 6)
  Fld.Attributes = dbAutoIncrField
  Tdf.Fields.Append Fld
     
  Tdf.Fields.Append Tdf.CreateField("VName", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("NName", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Adr", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("PLZ", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Ort", dbText, 50)
    
Set Fld = Tdf.CreateField("Tel", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
Set Fld = Tdf.CreateField("Handy", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("SVNR", dbText, 4)
  Tdf.Fields.Append Tdf.CreateField("GebDat", dbDate)
  Tdf.Fields.Append Tdf.CreateField("FS", dbLong, 1)
    
Set Fld = Tdf.CreateField("KG", dbText, 5)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
      
Set Fld = Tdf.CreateField("Anm", dbMemo)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
DBSecMan.TableDefs.Append Tdf


Set Idx = Tdf.CreateIndex("idxMA")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("MaId")
  Tdf.Indexes.Append Idx
    
Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblKD()
Set Tdf = DBSecMan.CreateTableDef("KD")
    
Set Fld = Tdf.CreateField("KdId", dbLong, 6)
  Fld.Attributes = dbAutoIncrField
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("VName", dbText, 50)
    
Set Fld = Tdf.CreateField("NName", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("Adr", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("PLZ", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Ort", dbText, 50)
    
Set Fld = Tdf.CreateField("Tel", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
Set Fld = Tdf.CreateField("Handy", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
Set Fld = Tdf.CreateField("Fax", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
Set Fld = Tdf.CreateField("EMail", dbText, 50)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
Set Fld = Tdf.CreateField("Anm", dbMemo)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
  
Tdf.Fields.Append Tdf.CreateField("Anr", dbText, 5)
         
DBSecMan.TableDefs.Append Tdf

Set Idx = Tdf.CreateIndex("idxKD")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("KdId")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblVER()
Set Tdf = DBSecMan.CreateTableDef("VER")
    
Set Fld = Tdf.CreateField("VerId", dbLong, 6)
  Fld.Attributes = dbAutoIncrField
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("VName", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Adr", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("PLZ", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Ort", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("SP", dbText, 50)
    
Set Fld = Tdf.CreateField("Anm", dbMemo)
  Fld.AllowZeroLength = True
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("KdId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("Stat", dbLong, 1)
        
DBSecMan.TableDefs.Append Tdf

Set Idx = Tdf.CreateIndex("idxVER")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("VerId")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

Set Tdf = DBSecMan.CreateTableDef("VERZeit")

  Tdf.Fields.Append Tdf.CreateField("VerId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("BegDat", dbDate)
  Tdf.Fields.Append Tdf.CreateField("BegZeit", dbDate)
  Tdf.Fields.Append Tdf.CreateField("EndDat", dbDate)
  Tdf.Fields.Append Tdf.CreateField("EndZeit", dbDate)

DBSecMan.TableDefs.Append Tdf

Set Tdf = Nothing
Set Fld = Nothing

End Sub

Public Sub tblART()
Set Tdf = DBSecMan.CreateTableDef("ART")
    
Set Fld = Tdf.CreateField("ArtId", dbLong, 6)
  Fld.Attributes = dbAutoIncrField
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("Bez", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Einh", dbLong, 1)
  Tdf.Fields.Append Tdf.CreateField("Preis", dbCurrency)
  Tdf.Fields.Append Tdf.CreateField("Ust", dbLong, 3)

DBSecMan.TableDefs.Append Tdf

Set Idx = Tdf.CreateIndex("idxART")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("ArtId")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblZahl()
Set Tdf = DBSecMan.CreateTableDef("ZAHL")
    
Set Fld = Tdf.CreateField("ZahlId", dbLong, 6)
  Fld.Attributes = dbAutoIncrField
  Tdf.Fields.Append Fld
    
  Tdf.Fields.Append Tdf.CreateField("Bez", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("Text", dbMemo)

DBSecMan.TableDefs.Append Tdf

Set Idx = Tdf.CreateIndex("idxZahl")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("ZahlId")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblNR()
Set Tdf = DBSecMan.CreateTableDef("NR")
    
  Tdf.Fields.Append Tdf.CreateField("NrId", dbText, 2)
  Tdf.Fields.Append Tdf.CreateField("Nummer", dbText, 8)

DBSecMan.TableDefs.Append Tdf

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblAN()
Set Tdf = DBSecMan.CreateTableDef("AN")
    
  Tdf.Fields.Append Tdf.CreateField("VerId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("AnNr", dbText, 10)
  Tdf.Fields.Append Tdf.CreateField("Dat", dbDate)
  Tdf.Fields.Append Tdf.CreateField("Wert", dbCurrency)
  Tdf.Fields.Append Tdf.CreateField("Stat", dbLong, 1)
  Tdf.Fields.Append Tdf.CreateField("ZahlId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("UstWert", dbCurrency)
    
DBSecMan.TableDefs.Append Tdf
  
Set Idx = Tdf.CreateIndex("idxAN")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("AnNr")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblAU()
Set Tdf = DBSecMan.CreateTableDef("AU")
    
  Tdf.Fields.Append Tdf.CreateField("VerId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("AuNr", dbText, 10)
  Tdf.Fields.Append Tdf.CreateField("Dat", dbDate)
  Tdf.Fields.Append Tdf.CreateField("Wert", dbCurrency)
  Tdf.Fields.Append Tdf.CreateField("Stat", dbLong, 1)
  Tdf.Fields.Append Tdf.CreateField("ZahlId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("UstWert", dbCurrency)
    
DBSecMan.TableDefs.Append Tdf
  
Set Idx = Tdf.CreateIndex("idxAU")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("AuNr")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblRE()
Set Tdf = DBSecMan.CreateTableDef("RE")
    
  Tdf.Fields.Append Tdf.CreateField("VerId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("ReNr", dbText, 10)
  Tdf.Fields.Append Tdf.CreateField("Dat", dbDate)
  Tdf.Fields.Append Tdf.CreateField("Wert", dbCurrency)
  Tdf.Fields.Append Tdf.CreateField("Stat", dbLong, 1)
  Tdf.Fields.Append Tdf.CreateField("ZahlId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("UstWert", dbCurrency)
    
DBSecMan.TableDefs.Append Tdf
  
Set Idx = Tdf.CreateIndex("idxRE")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("ReNr")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub tblZ()
Set Tdf = DBSecMan.CreateTableDef("Z")
      
  Tdf.Fields.Append Tdf.CreateField("DokId", dbText, 10)
  Tdf.Fields.Append Tdf.CreateField("ArtId", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("Bez", dbText, 50)
  Tdf.Fields.Append Tdf.CreateField("EPreis", dbCurrency)
  Tdf.Fields.Append Tdf.CreateField("Anzahl", dbLong, 6)
  Tdf.Fields.Append Tdf.CreateField("GPreis", dbCurrency)
  Tdf.Fields.Append Tdf.CreateField("UstBetrag", dbCurrency)

DBSecMan.TableDefs.Append Tdf

Set Tdf = Nothing
Set Fld = Nothing

End Sub

Public Sub tblPLZ()
Set Tdf = DBSecMan.CreateTableDef("PLZ")
    Tdf.Fields.Append Tdf.CreateField("PLZ", dbLong, 4)
    Tdf.Fields.Append Tdf.CreateField("Ort", dbText, 50)
    
DBSecMan.TableDefs.Append Tdf

Set Idx = Tdf.CreateIndex("idxPLZ")
  Idx.Primary = True
  Idx.Required = True
  Idx.Fields.Append Tdf.CreateField("PLZ")
  Tdf.Indexes.Append Idx

Set Tdf = Nothing
Set Fld = Nothing
Set Idx = Nothing

End Sub

Public Sub Beziehungen()
Set Rel = DBSecMan.CreateRelation("ARTZ", "ART", "Z", 2)
  Rel.Fields.Append Rel.CreateField("ArtId")
  Rel.Fields!ArtId.ForeignName = "ArtId"
  DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("ZAN", "Z", "AN", 2)
  Rel.Fields.Append Rel.CreateField("DokId")
  Rel.Fields!DokId.ForeignName = "AnNr"
  DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("ZAU", "Z", "AU", 2)
  Rel.Fields.Append Rel.CreateField("DokId")
  Rel.Fields!DokId.ForeignName = "AuNr"
  DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("ZRE", "Z", "RE", 2)
  Rel.Fields.Append Rel.CreateField("DokId")
  Rel.Fields!DokId.ForeignName = "ReNr"
  DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("VERKD", "VER", "KD", 2)
  Rel.Fields.Append Rel.CreateField("KdId")
  Rel.Fields!KdId.ForeignName = "KdId"
  DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("VERVERZeit", "VER", "VERZeit", 2)
  Rel.Fields.Append Rel.CreateField("VerId")
  Rel.Fields!VerId.ForeignName = "VerId"
DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("ANVER", "AN", "VER", 2)
  Rel.Fields.Append Rel.CreateField("VerId")
  Rel.Fields!VerId.ForeignName = "VerId"
DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("AUVER", "AU", "VER", 2)
  Rel.Fields.Append Rel.CreateField("VerId")
  Rel.Fields!VerId.ForeignName = "VerId"
DBSecMan.Relations.Append Rel
Set Rel = Nothing

Set Rel = DBSecMan.CreateRelation("REVER", "RE", "VER", 2)
  Rel.Fields.Append Rel.CreateField("VerId")
  Rel.Fields!VerId.ForeignName = "VerId"
DBSecMan.Relations.Append Rel
Set Rel = Nothing

End Sub

Public Sub StdWerte()
Set rs = DBSecMan.OpenRecordset("SYS")
  rs.AddNew
  rs("SysName").Value = "SecMan"
  rs("Version").Value = App.Major & "." & App.Minor & "." & App.Revision
  rs.Update
rs.Close

Set rs = DBSecMan.OpenRecordset("NR")
  rs.AddNew
  rs("NrId").Value = "AN"
  rs("Nummer").Value = "001/2007"
  rs.Update
  
  rs.AddNew
  rs("NrId").Value = "AU"
  rs("Nummer").Value = "001/2007"
  rs.Update

  rs.AddNew
  rs("NrId").Value = "RE"
  rs("Nummer").Value = "001/2007"
  rs.Update
rs.Close

End Sub

Public Sub PLZDaten()
Dim i As Integer
Dim strZeile As String
Dim aText() As String

F = FreeFile
Open App.Path & "\PLZ.csv" For Input As #F
Do Until EOF(F)
  Line Input #F, strZeile
  aText = Split(strZeile, ";", -1)
  DBSecMan.Execute ("Insert into PLZ values ('" & aText(0) & "','" & aText(1) & "')")
Loop
Close #F
Kill App.Path & "\PLZ.csv"
End Sub

Public Sub qrDok()
strSQL = "SELECT AN.AnNr as Nr, VER.VName, AN.Dat, AN.Wert, AN.Stat FROM AN INNER JOIN VER ON AN.VerId=VER.VerId;"
Set qr = DBSecMan.CreateQueryDef("qrAN", strSQL)
Set qr = Nothing

strSQL = "SELECT AU.AuNr as Nr, VER.VName, AU.Dat, AU.Wert, AU.Stat FROM AU INNER JOIN VER ON AU.VerId = VER.VerId;"
Set qr = DBSecMan.CreateQueryDef("qrAU", strSQL)
Set qr = Nothing

strSQL = "SELECT RE.ReNr as Nr, VER.VName, RE.Dat, RE.Wert, RE.Stat FROM RE INNER JOIN VER ON RE.VerId=VER.VerId"
Set qr = DBSecMan.CreateQueryDef("qrRE", strSQL)
Set qr = Nothing

'Querry wird vom Programm gewartet
strSQL = "Select * from AN"
Set qr = DBSecMan.CreateQueryDef("qrANDruck", strSQL)
Set qr = Nothing

'Querry wird vom Programm gewartet
strSQL = "Select * from AU"
Set qr = DBSecMan.CreateQueryDef("qrAUDruck", strSQL)
Set qr = Nothing

'Querry wird vom Programm gewartet
strSQL = "Select * from RE"
Set qr = DBSecMan.CreateQueryDef("qrREDruck", strSQL)
Set qr = Nothing

strSQL = "SELECT VER.*, KD.KdId, KD.VName, KD.NName " & _
         "FROM VER INNER JOIN KD ON VER.KdId = KD.KdId;"
Set qr = DBSecMan.CreateQueryDef("qrVERDruck", strSQL)
Set qr = Nothing
End Sub



