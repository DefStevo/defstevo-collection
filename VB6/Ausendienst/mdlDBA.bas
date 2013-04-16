Attribute VB_Name = "mdlDBA"
Public DBA As Database
Public RS As Recordset
Public ErrNr As Integer
Public ErrDes As String

Function DBOpen() As Boolean
On Error GoTo Err
Set DBA = DBEngine.OpenDatabase(App.Path & "\Ausendienst.mdb", False, False, ";pwd=DBAusendienst")
DBOpen = True
Exit Function

Err:
ErrNr = Err.Number
ErrDes = Err.Description
DBOpen = False
End Function
