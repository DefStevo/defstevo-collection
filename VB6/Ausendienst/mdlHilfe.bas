Attribute VB_Name = "mdlHilfe"
Public DB As Database
Public Wsp As Workspace
Public Tdf As TableDef
Public Fld As Field
Public Idx As Index
Public Rel As Relation
Public qr As QueryDef

Sub DBAnla()
Set Wsp = DBEngine.Workspaces(0)

'Datenbank anlegen in den selben Pfad wie die Exe mit Kennwort DBAusendienst
Set DBS = Wsp.CreateDatabase(App.Path & "\Ausendienst.mdb", dbLangGeneral & ";pwd=DBAusendienst")
End Sub
