Attribute VB_Name = "mdlDB"
Public WSP As Workspace
Public DB As Database
Public RS As Recordset
Public TDF As TableDef
Public FLD As Field
Public Idx As Index

Public Function DBAnla() As Boolean
On Error GoTo Err
Set WSP = DBEngine.Workspaces(0)
'Datenbank wird angelegt
Set DB = WSP.CreateDatabase(App.Path & "\PBH.mdb", dbLangGeneral & ";pwd=DBpbh")

'Tabelle Kto anlegen
Set TDF = DB.CreateTableDef("Kto")
TDF.Fields.Append TDF.CreateField("KtoNr", dbText, 4) '4 Stellige Kontonummer
TDF.Fields.Append TDF.CreateField("KtoArt", dbText, 1) 'A=Aufwand, E=Ertrag, B=Bestand, U=Umbuchung
TDF.Fields.Append TDF.CreateField("KtoStatus", dbText, 1) 'I=Inaktiv, A=Aktiv
TDF.Fields.Append TDF.CreateField("KtoName", dbText, 25) 'Kontoname
TDF.Fields.Append TDF.CreateField("KtoSaldo", dbCurrency) 'Saldo
TDF.Fields.Append TDF.CreateField("KtoAnlag", dbDate) 'Anlagedatum/Uhrzeit
TDF.Fields.Append TDF.CreateField("KtoUserAnlag", dbText, 3) 'Benutzer Anlage
TDF.Fields.Append TDF.CreateField("KtoAendg", dbDate) 'Änderungsdatum/Uhrzeit
TDF.Fields.Append TDF.CreateField("KtoUserAendg", dbText, 3) 'Benutzer Änderung
Set FLD = TDF.CreateField("KtoMemo", dbMemo) 'Memo
FLD.AllowZeroLength = True
TDF.Fields.Append FLD
DB.TableDefs.Append TDF

'Tabelle Adr anlegen
Set TDF = DB.CreateTableDef("Adr")
TDF.Fields.Append TDF.CreateField("AdrNr", dbText, 4) '4 Stellige Adressnummer
TDF.Fields.Append TDF.CreateField("AdrTyp", dbText, 1) 'E=Einnahmen, A=Ausgaben
TDF.Fields.Append TDF.CreateField("AdrStatus", dbText, 1) 'I=Inaktiv, A=Aktiv
TDF.Fields.Append TDF.CreateField("AdrName", dbText, 25) 'Adressname
TDF.Fields.Append TDF.CreateField("AdrSaldo", dbCurrency) 'Saldo
TDF.Fields.Append TDF.CreateField("AdrKto", dbText, 4) 'Standardkonto
TDF.Fields.Append TDF.CreateField("AdrAnlag", dbDate) 'Anlagedatum/Uhrzeit
TDF.Fields.Append TDF.CreateField("AdrUserAnlag", dbText, 3) 'Benutzer Anlage
TDF.Fields.Append TDF.CreateField("AdrAendg", dbDate) 'Änderungsdatum/Uhrzeit
TDF.Fields.Append TDF.CreateField("AdrUserAendg", dbText, 3) 'Benutzer Änderung
Set FLD = TDF.CreateField("AdrMemo", dbMemo) 'Memo
FLD.AllowZeroLength = True
TDF.Fields.Append FLD
DB.TableDefs.Append TDF

'Tabelle Buch anlegen
Set TDF = DB.CreateTableDef("Buch")
TDF.Fields.Append TDF.CreateField("BuchID", dbLong) 'BuchungsID
TDF.Fields.Append TDF.CreateField("BuchDat", dbDate) 'Buchungsdatum
TDF.Fields.Append TDF.CreateField("BuchArt", dbText, 1) 'E=Einnahme, A=Ausgabe
TDF.Fields.Append TDF.CreateField("BuchStatus", dbText, 1) 'S=Stoniert, N=Neu, V=Verbucht, I=Import, IV=Import Verbucht
Set FLD = TDF.CreateField("BuchAdr", dbMemo) 'Adressnummer
FLD.AllowZeroLength = True
TDF.Fields.Append FLD
TDF.Fields.Append TDF.CreateField("BuchKtoBestand", dbText, 4) 'Bestandskonto
TDF.Fields.Append TDF.CreateField("BuchKto", dbText, 4) 'Kontonummer
TDF.Fields.Append TDF.CreateField("BuchKtoBetrag", dbCurrency) 'Betrag1
TDF.Fields.Append TDF.CreateField("BuchText", dbText, 55) 'Buchungstext
Set FLD = TDF.CreateField("BuchMemo", dbMemo) 'Memo
FLD.AllowZeroLength = True
TDF.Fields.Append FLD
DB.TableDefs.Append TDF

DBAnla = True
Exit Function
Err:
DBAnla = False
FehlerText = "Fehler: " & Err.Number & vbCrLf & _
             Err.Description
End Function
