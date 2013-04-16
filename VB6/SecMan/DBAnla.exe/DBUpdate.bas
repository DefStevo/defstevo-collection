Attribute VB_Name = "mdlDBUpdate"
Public Sub Update(Version As String)
Set DBSecMan = DBEngine.OpenDatabase(App.Path & "\SecMan.mdb", False, False, ";pwd=DBSecMan")
frmDbAnla.Show
frmDbAnla.lblInfo.Caption = "Update wird durchgeführt"
frmDbAnla.Refresh
'Versionsnummer wird anhand des gesetzen Parameters übergeben
Select Case Version
  Case "1.0.0"
    GoTo Update100
  Case "1.0.1"
    GoTo Update101
  Case Else
    MsgBox "Error During Update"
End Select

Exit Sub

Update100:
frmDbAnla.lblInfo.Caption = "Tabelle ZAHL wird angelegt"
frmDbAnla.Refresh
'Tabelle für Zahlungsbedingung hinzufügen
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

frmDbAnla.lblInfo.Caption = "Tabelle AN wird um Feld ZahlId/UstWert erweitert"
frmDbAnla.Refresh
'Fehl ZahlId und UstWert in Tablle AN, AU und RE hinzufügen
Set Tdf = DBSecMan.TableDefs("AN")
Set Fld = Tdf.CreateField("ZahlId", dbLong, 6)
Tdf.Fields.Append Fld
Set Fld = Tdf.CreateField("UstWert", dbCurrency)
Tdf.Fields.Append Fld
Set Fld = Nothing
Set Tdf = Nothing

frmDbAnla.lblInfo.Caption = "Tabelle AU wird um Feld ZahlId/UstWert erweitert"
frmDbAnla.Refresh
Set Tdf = DBSecMan.TableDefs("AU")
Set Fld = Tdf.CreateField("ZahlId", dbLong, 6)
Tdf.Fields.Append Fld
Set Fld = Tdf.CreateField("UstWert", dbCurrency)
Tdf.Fields.Append Fld
Set Fld = Nothing
Set Tdf = Nothing

frmDbAnla.lblInfo.Caption = "Tabelle RE wird um Feld ZahlId/UstWert erweitert"
frmDbAnla.Refresh
Set Tdf = DBSecMan.TableDefs("RE")
Set Fld = Tdf.CreateField("ZahlId", dbLong, 6)
Tdf.Fields.Append Fld
Set Fld = Tdf.CreateField("UstWert", dbCurrency)
Tdf.Fields.Append Fld
Set Fld = Nothing
Set Tdf = Nothing

frmDbAnla.lblInfo.Caption = "Tabelle ART wird um Feld Ust/UstWert erweitert"
frmDbAnla.Refresh
'Feld Ust in Tablle ART hinzufügen
Set Tdf = DBSecMan.TableDefs("ART")
Set Fld = Tdf.CreateField("UST", dbLong, 3)
Tdf.Fields.Append Fld
Set Fld = Tdf.CreateField("UstWert", dbCurrency)
Tdf.Fields.Append Fld
Set Fld = Nothing
Set Tdf = Nothing

frmDbAnla.lblInfo.Caption = "Tabelle Z wird um Feld UstBetrag erweiter"
frmDbAnla.Refresh
'Feld Ust-Satz und Betrag in Tabelle Z einfügen
Set Tdf = DBSecMan.TableDefs("Z")
Set Fld = Tdf.CreateField("UstBetrag", dbCurrency)
Tdf.Fields.Append Fld
Set Fld = Nothing
Set Tdf = Nothing

frmDbAnla.lblInfo.Caption = "Tabelle KD wird um Feld Anrede erweitert"
frmDbAnla.Refresh
'Feld Anrede in Tabelle KD einfügen
Set Tdf = DBSecMan.TableDefs("KD")
Set Fld = Tdf.CreateField("Anr", dbText, 5)
Tdf.Fields.Append Fld
Set Fld = Nothing
Set Tdf = Nothing

frmDbAnla.lblInfo.Caption = "Version wird geschrieben"
frmDbAnla.Refresh
'Version in Tabelle Sys erhöhen
DBSecMan.Execute ("Update SYS set Version='1.0.1' where SysName='SecMan'")

Update101:
frmDbAnla.lblInfo.Caption = "Tabelle tblPLZ wird angelegt"
frmDbAnla.Refresh
tblPLZ

frmDbAnla.lblInfo.Caption = "Tabelle PLZ wird mit Daten gefüllt"
frmDbAnla.Refresh
mdlDbAnla.PLZDaten

frmDbAnla.lblInfo.Caption = "Version wird geschrieben"
frmDbAnla.Refresh
DBSecMan.Execute ("Update SYS set Version='1.0.2' where SysName='SecMan'")
End Sub

