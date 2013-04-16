Attribute VB_Name = "mdlProjMan"
Public DBProjMan As Database
Public RSProjMan As Recordset
Public strSQL As String

Sub Main()
On Error GoTo Err

'Aufrufparameter Verarbeiten
If Not Command$ = "" Then
  Commands Command$
End If

'Verbindung zur DB herstellen#
If ConnectDBProjMan = True Then
  'Hauptmenu öffnen
  frmMenu.Show
End If
Exit Sub


'-----Errorhandling-----
Err:
ErrHandle "Sub Main", Err.Number, Err.Description
End Sub

Function ConnectDBProjMan() As Boolean
On Error GoTo Err

'Verbindung zur Datenbank herstellen (PW: DBProjMan2008)
Set DBSecMan = DBEngine.OpenDatabase(App.Path & "\ProjMan.mdb", False, False, ";pwd=DBProjMan2008")

ConnectDBProjMan = True
Exit Function
'-----Errorhandling-----
Err:
ConnectDBProjMan = False
ErrHandle "ConnectDBProjMan", Err.Number, Err.Description
End Function

Sub Commands(Command As String)
On Error GoTo Err


'-----Errorhandling-----
Err:
ErrHandle "Commands", Err.Number, Err.Description
End Sub

Public Sub ErrHandle(Prog As String, ErrNr As Integer, ErrTxt As String)
MsgBox "Fehler " & ErrNr & ", " & errtst, vbOKOnly, Prog
End Sub

