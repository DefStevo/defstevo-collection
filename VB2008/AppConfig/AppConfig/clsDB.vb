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
'_intDBTyp = Private Variable die den Datenbanktyp bestimmt (1 = Access, 2 = SQL-Server, 3 = Oracle)
'_DBConn = Private Variabel zum Herstellen der Datenbankverbindung
'_DBCmd = Private Variable zum Ausführen eines Datenbankkommandos
'_DBReader = Private Variable zum Lesen von Daten
'_bConnStatus = Private Variable die den Verbindungsstatus anzeigt
'_strServeR = Private Variable die den Serve Namen beinhaltet
'_strDB = Private Variable die den Namen der Datenbank beinhaltet
'_strUser = Private Variable die den Benutzernamen beinhaltet
'_strPass = Private Variable die das Kennwort beinhaltet
'_strSQL = Private Variable für das SQL-Statement
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

#Region "Imports"
Imports System.Data.OleDb
#End Region

Public Class clsDB

#Region "Deklarationen"
    Private _intDBTyp As Integer
    Private _strProvider As String

    Private _DBConn As OleDbConnection
    Private _DBCmd As OleDbCommand
    Private _DBReader As OleDbDataReader

    Private _bConnStatus As Boolean = False

    Private _strServer As String
    Private _strDB As String
    Private _strUser As String
    Private _strPass As String
    Private _strSQL As String

    Public DBReader As OleDbDataReader
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

    Property Database() As String
        Get
            Return _strDB
        End Get
        Set(ByVal value As String)
            _strDB = value
        End Set
    End Property

    Property User() As String
        Get
            Return _strUser
        End Get
        Set(ByVal value As String)
            _strUser = value
        End Set
    End Property

    Property Pass() As String
        Get
            Return _strPass
        End Get
        Set(ByVal value As String)
            _strPass = value
        End Set
    End Property

#End Region

#Region "Funktionen"
    Function SetConnectionInfo(ByVal Typ As Integer, ByVal Server As String, ByVal Database As String, ByVal User As String, ByVal Pass As String) As Boolean
        If _bConnStatus = True Then
            Return False
            Exit Function
        End If
        _intDBTyp = Typ
        _strServer = Server
        _strDB = Database
        _strUser = User
        _strPass = Pass
        _bConnStatus = False
        Return True
    End Function

    Function GetConnectionInfo(ByVal Typ As Integer, ByRef Server As String, ByRef Database As String, ByRef User As String, ByRef Pass As String, ByVal Status As Boolean) As Boolean
        Typ = _intDBTyp
        Server = _strServer
        Database = _strDB
        User = _strUser
        Pass = _strPass
        Status = _bConnStatus
        Return True
    End Function

    Function ConnectDB() As Boolean
        If _bConnStatus = True Then
            Return False
            Exit Function
        End If

        If _intDBTyp = 0 Or _strServer = "" Or _strUser = "" Or _strPass = "" Then
            Return False
            Exit Function
        End If

        Select Case _intDBTyp
            Case 1 'Access
                _strProvider = "Microsoft.Jet.OLEDB.4.0"
            Case 2 'SQL-Server
                _strProvider = "SQLNCLI10"
            Case 3 'Oracle
                _strProvider = "MSDAORA.1"
        End Select

        _DBConn = New OleDbConnection("Provider=" & _strProvider & _
                                      ";Data Source=" & _strServer & _
                                       ";Database=" & _strDB & _
                                       ";User ID=" & _strUser & _
                                       ";Password=" & _strPass)

        _DBConn.Open()

        _bConnStatus = True

        Return True

    End Function

    Function DisconnectDB() As Boolean
        If _bConnStatus = False Then
            Return False
            Exit Function
        End If

        _DBConn.Close()
        _DBConn = Nothing
        _DBReader = Nothing
        _DBCmd = Nothing

        _strSQL = Nothing

        _intDBTyp = Nothing
        _strProvider = Nothing


        _strServer = Nothing
        _strDB = Nothing
        _strUser = Nothing
        _strPass = Nothing

        _bConnStatus = False

        Return True
    End Function

    Function OpenRS(ByVal Sql As String) As OleDbDataReader
        If _bConnStatus = False Then
            Return Nothing
            Exit Function
        End If

        _DBCmd = New OleDbCommand(Sql, _DBConn)
        _DBReader = _DBCmd.ExecuteReader

        Return _DBReader

    End Function
#End Region
End Class
