Public Class DB
  Public objConn As New ADODB.Connection
  Public objRS As New ADODB.Recordset
  Public objCmd As New ADODB.Command
  Public strSQL As String
  Private bolConn As Boolean

  Function Connect() As Boolean
    objConn = CreateObject("ADODB.Connection")
    objConn = New ADODB.Connection
    objConn.Open("DRIVER={SQL Server}; SERVER=" & My.Settings.Server & "; DATABASE=" & My.Settings.Datenbank & "; OPTION=3")
    objRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
    objRS.ActiveConnection = objConn
    objCmd.ActiveConnection = objConn
    isConnected = True
    Return True
  End Function

  Function OpenRS(ByVal strRS As String) As Boolean
    objRS.Open(strRS)
    Return True
  End Function

  Function ErstelleTabelle(ByVal tblName As String, ByVal arrSpalten As String()) As Boolean
    objCmd.CommandText = "CREATE TABLE " & tblName & " ("
    For i As Integer = 0 To arrSpalten.Length - 1
      objCmd.CommandText = objCmd.CommandText & arrSpalten(i).ToString
      If i <> arrSpalten.Length - 1 Then
        objCmd.CommandText = objCmd.CommandText & ", "
      Else
        objCmd.CommandText = objCmd.CommandText & ")"
      End If
    Next i
    objCmd.Execute()
    Return True
  End Function

  Function Disconnect() As Boolean
    objConn = Nothing
    objRS = Nothing
    objCmd = Nothing
    isConnected = False
  End Function

  Property isConnected() As Boolean
    Get
      Return bolConn
    End Get
    Set(ByVal value As Boolean)
      bolConn = value
    End Set
  End Property
End Class
