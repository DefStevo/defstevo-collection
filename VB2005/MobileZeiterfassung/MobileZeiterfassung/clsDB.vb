'-------------------------------------------------------------------------------------
'Autor: Stefan Dehner
'© Stevo Software 2008
'Beginn 11.06.2008
'
'Klasse zur Herstellung der Datenbankverbindung (SQL-Server oder Access)
'-------------------------------------------------------------------------------------
'clsDB Version 1.0 - 21.06.2008
'
'Deklarationen:
'_DBConn = Private Variabel zum Herstellen der Datenbankverbindung
'_DBRS = Private Variable die das Recordset beinhaltet
'_DBCmd = Private Variable zum Ausführen eines Datenbankkommandos
'_strSQL = Private Variable für das SQL-Statement
'_strDB = Private Variable die den Namen der Datenbank beinhaltet
'
'Eigenschaften:
'DB = wird zum schreiben oder lesen der Variable _strDB benötigt
'RS = wird zum lesen der Variable _DBRS benötigt
'
'Funktionen:
'SetConnectionInfo = Funktion zum setzen aller Variablen für die Verbindung
'GetConnectionInfo = Funktion zum auslesen aller Variablen der Verbindung
'ConnectDB = Verbindung mit der DB herstellen
'DisconnectDB = Verbindung trennen
'-------------------------------------------------------------------------------------
Public Class clsDB

#Region "Deklarationen"
    Private _DBConn As New ADODB.Connection
    Private _DBRS As New ADODB.Recordset
    Private _DBCmd As New ADODB.Command
    Private _strSQL As String
    Private _strDB As String
#End Region

#Region "Eigenschaften"
    Property DB() As String
        Get
            Return _strDB
        End Get
        Set(ByVal value As String)
            _strDB = value
        End Set
    End Property

    ReadOnly Property RS() As ADODB.Recordset
        Get
            Return _DBRS
        End Get
    End Property

#End Region

#Region "Funktionen"
    Function SetConnectionInfo(ByVal Database As String) As Boolean
        _strDB = Database
    End Function

    Function GetConnectionInfo(ByRef Database As String, ByRef Status As String) As Boolean
        Database = _strDB
        Status = _DBConn.State.ToString
        Return True
    End Function

    Function ConnectDB() As Boolean
        With _DBConn
            .Provider = "Microsoft.Access.OLEDB.10.0"
            .Properties("Data Provider").Value = "Microsoft.Jet.OLEDB.4.0"
            .Properties("Data Source").Value = _strDB
            .Open()
        End With

        _DBRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
        _DBRS.ActiveConnection = _DBConn
        _DBCmd.ActiveConnection = _DBConn
        Return True
    End Function

    Function DisconnectDB() As Boolean
        If _DBRS.State = 1 Then
            _DBRS.Close()
            _DBRS = Nothing
        End If
        If _DBCmd.State = 1 Then
            _DBCmd.Cancel()
            _DBCmd = Nothing
        End If
        If _DBConn.State = 1 Then
            _DBConn.Close()
        End If

        Return True
    End Function

    Function OpenRS(ByVal Sql As String) As ADODB.Recordset
        If _DBRS.State = 1 Then
            _DBRS.Close()
        End If
        _strSQL = Sql
        _DBRS.Open(_strSQL)
        Return _DBRS
    End Function

    Function RunCommand(ByVal Sql As String) As Boolean
        _DBCmd.CommandText = Sql
        _DBCmd.Execute()
        Return True
    End Function

#End Region

End Class
