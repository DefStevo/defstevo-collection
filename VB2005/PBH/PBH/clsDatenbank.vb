Public Class clsDatenbank
  'Verbindung zum SQL-Server wird ¸ber ADO hergestellt
  Private objConn As New ADODB.Connection
  Private objRS As New ADODB.Recordset
  Private objCmd As New ADODB.Command
  Private strSrv As String = "R400\SQLEXPRESS"
  Private strDB As String = "PBH"
  Private strRS As String

  Property Server()
    Get
      Return strSrv
    End Get
    Set(ByVal value)
      strSrv = value
    End Set
  End Property

  Property Datenbank()
    Get
      Return strDB
    End Get
    Set(ByVal value)
      strDB = value
    End Set
  End Property

  Function DBVerbinden() As Boolean
    objConn = CreateObject("ADODB.Connection")
    objConn = New ADODB.Connection
    objConn.Open("DRIVER={SQL Server}; SERVER=" & strSrv & "; DATABASE=" & strDB & "; OPTION=3")
    objRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
    objRS.ActiveConnection = objConn
    objCmd.ActiveConnection = objConn
    Return True
  End Function

  Function Tabelle÷ffnen(ByVal Abfrage As String) As ADODB.Recordset
    TabelleSchlieﬂen()
    Try
      objRS.Open(Abfrage)
    Catch ex As Exception
      Return Nothing
    End Try
    Return objRS
  End Function

  Function TabelleSchlieﬂen() As Boolean
    On Error Resume Next
    objRS.Close()
  End Function

  Function TabelleErstellen(ByVal Tabelle As String, ByVal Spalten As String) As Boolean
    objCmd.CommandText = "CREATE TABLE " & Tabelle & " (" & Spalten & ")"
    objCmd.Execute()
    Return True
  End Function

  Function DBTrennen() As Boolean
    objConn.Close()
    objConn = Nothing
    Return True
  End Function
End Class
