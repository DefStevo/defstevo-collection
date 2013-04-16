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
'_strServeR = Private Variable die den Serve Namen beinhaltet
'_strDB = Private Variable die den Namen der Datenbank beinhaltet
'_strUser = Private Variable die den Benutzernamen beinhaltet
'_strPass = Private Variable die das Kennwort beinhaltet
'
'Eigenschaften:
'Server = wird zum schreiben oder lesen der Variable _strServer benötigt
'DB = wird zum schreiben oder lesen der Variable _strDB benötigt
'USR = wird zum schreiben oder lesen der Variable _strUser benötigt
'PW = wird zum schreiben oder lesen der Variable _strPass benötigt
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
    Private _strServer As String
    Private _strDB As String
    Private _strUser As String
    Private _strPass As String
#End Region

#Region "Eigenschaften"
    Property Server() As String
        Get
            Return _strServer
        End Get
        Set(ByVal value As String)
            _strServer = value
        End Set
    End Property

    Property DB() As String
        Get
            Return _strDB
        End Get
        Set(ByVal value As String)
            _strDB = value
        End Set
    End Property

    Property USR() As String
        Get
            Return _strUser
        End Get
        Set(ByVal value As String)
            _strUser = value
        End Set
    End Property

    Property PW() As String
        Get
            Return _strPass
        End Get
        Set(ByVal value As String)
            _strPass = value
        End Set
    End Property

    ReadOnly Property RS() As ADODB.Recordset
        Get
            Return _DBRS
        End Get
    End Property

#End Region

#Region "Funktionen"
    Function SetConnectionInfo(ByVal Server As String, ByVal Database As String, ByVal User As String, ByVal Pass As String) As Boolean
        _strServer = Server
        _strDB = Database
        _strUser = User
        _strPass = Pass
    End Function

    Function GetConnectionInfo(ByRef Server As String, ByRef Database As String, ByRef User As String, ByRef Pass As String) As Boolean
        Server = _strServer
        Database = _strDB
        User = _strUser
        Pass = _strPass
        Return True
    End Function

    Function ConnectDB() As Boolean
        _DBConn = CreateObject("ADODB.Connection")
        _DBConn = New ADODB.Connection
        _DBConn.Open("DRIVER={SQL Server}; SERVER=" & _strServer & "; DATABASE=" & _strDB & "; UID=" & _strUser & "; PWD=" & _strPass & "; OPTION=3")
        _DBRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
        _DBRS.ActiveConnection = _DBConn
        _DBCmd.ActiveConnection = _DBConn
        Return True
    End Function

    Function DisconnectDB() As Boolean
        _DBRS.Close()
        _DBCmd = Nothing
        _DBConn.Close()
        Return True
    End Function

    Function OpenRS(ByVal Sql As String) As ADODB.Recordset
        _strSQL = Sql
        _DBRS.Open(_strSQL)
        Return _DBRS
    End Function

    Function CreateTable(ByVal Name As String, ByVal Felder As String(), ByVal Typ As String())
        _DBCmd.CommandText = "Create Table " & Name & " ("
        For i As Integer = 0 To Felder.Length - 1
            _DBCmd.CommandText = _DBCmd.CommandText & Felder(i).ToString & " " & Typ(i).ToString
            If i <> Felder.Length - 1 Then
                _DBCmd.CommandText = _DBCmd.CommandText & ", "
            Else
                _DBCmd.CommandText = _DBCmd.CommandText & ")"
            End If
        Next i
        _DBCmd.Execute()
        Return True
    End Function
#End Region
End Class
