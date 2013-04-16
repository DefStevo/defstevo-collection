Public Class DB
  Public objConn As New ADODB.Connection
  Public objRS As New ADODB.Recordset
  Public objCmd As New ADODB.Command
  Public strSQL As String
  Private strSrv As String
  Private strDB As String
  Private strRS As String

  Function ConnectDB() As Boolean
    objConn = CreateObject("ADODB.Connection")
    objConn = New ADODB.Connection
    objConn.Open("DRIVER={SQL Server}; SERVER=" & strSrv & "; DATABASE=" & strDB & "; OPTION=3")
    objRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
    objRS.ActiveConnection = objConn
    objCmd.ActiveConnection = objConn
    Return True
  End Function

  Function OpenRS() As Boolean
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

  Property Srv()
    Get
      Return strSrv
    End Get
    Set(ByVal value)
      strSrv = value
    End Set
  End Property

  Property DB()
    Get
      Return strDB
    End Get
    Set(ByVal value)
      strDB = value
    End Set
  End Property

  Property RS()
    Get
      Return strRS
    End Get
    Set(ByVal value)
      strRS = value
    End Set
  End Property


End Class
