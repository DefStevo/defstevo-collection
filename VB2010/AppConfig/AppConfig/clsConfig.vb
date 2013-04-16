'-------------------------------------------------------------------------------------
'Autor: Stefan Dehner
'© Stevo Software 2008
'Beginn 11.06.2008
'
'Klasse zum Lesen und Schreiben der Config Datei (*.apcfg)
'-------------------------------------------------------------------------------------
'clsConfig Version 1.0 - 20.06.2008
'
'Deklarationen:
'_File = Private Variable den Pfad sowie Dateinamen der Configdatei beinhaltet
'_Crypter = Deklartion der Crypter-Klasse (clsCrypter) um die Configdatei bei Bedarf
'           zu ver- bzw. entschlüssen.
'_DBTyp = Datenbanktyp (0=Keine Datenbank, 1=Access Datenbank, 2=SQL-Server)
'_DBServer = Datenbankserver (Nur bei _DBTyp=2)
'_DBDatabase = Datenbank
'_DBUser = Benutzername (Nur bei DBTyp=2)
'_DBPass = Kennwort
'_Indiv = Variable für Indiv Werte welche die Software benötigt
'
'Eigenschaften:
'File = wird zum schreiben oder lesen der Veriable _Datei verwendet
'DBTyp = wird zum schreiben oder lesen der Variable _DBTyp verwendet
'DBServer = wird zum schreiben oder lesen der Variable _DBServer verwendet
'DBDatabase = wird zum schreiben oder lesen der Variable _DBDatabase verwendet
'DBUser = wird zum schreiben oder lesen der Variable _DBUser verwendet
'DBPass = wird zum schreiben oder lesen der Variable _DBPass verwendet
'DBIndiv = wird zum schreiben oder lesen der Variable _DBIndiv verwendet
'Crypter = wird zum übergeben der Crypter Klasse benötigt
'
'Funktionen:
'ReadConfig = Funktion zum Auslesen der *.apcfg Datei
'SetVar = Funktion zum Setzten der aus der *.apcfg gelesenen Variablen
'WriteConfig = Funktion zum Schreiben der *.apcfg Datei
'GetVar = Funktion zum Auslesen der Variablen für das beschreiben der *.apcfg
'         Datei
'ClearVar = Funktion zum leeren der Variablen außer _Datei und _Crypter
'WriteVar = Funktion zum Setzen der Variablen für das beschreiben der *.apcfg Datei
'ReadVar = Funtion zum auslesen aller Variablen
'-------------------------------------------------------------------------------------
'clsConfig Version 1.1
'20.06.2008
'
'Deklaration:
'_Version = Versionsnummer der Config-File
'_ConfigText = Gesamte Config als String
'
'Konstanten
'Version = Aktuelle Version von clsConfig
'
'ToDo:
'Einbauen eines Vorlaufsatzes zum behandeln der Unterschiedlichen Config-Datei
'Versionen
'-------------------------------------------------------------------------------------

Public Class clsConfig
#Region "Deklarationen"
    Private _File As String
    Private _Crypter As clsCrypter
    Private _DBTyp As Integer
    Private _DBServer As String
    Private _DBDatabase As String
    Private _DBUser As String
    Private _DBPass As String
    Private _Indiv As String
    Private _Version As String
    Private _ConfigText As String
#End Region

#Region "Konstanten"
    Private Const Version As String = "1.1"
#End Region

#Region "Eigenschaften"
    Property File() As String
        Get
            Return _File
        End Get
        Set(ByVal value As String)
            _File = value
        End Set
    End Property

    Property DBTyp() As Integer
        Get
            Return _DBTyp
        End Get
        Set(ByVal value As Integer)
            _DBTyp = value
        End Set
    End Property

    Property DBServer() As String
        Get
            Return _DBServer
        End Get
        Set(ByVal value As String)
            _DBServer = value
        End Set
    End Property

    Property DBDatabase() As String
        Get
            Return _DBDatabase
        End Get
        Set(ByVal value As String)
            _DBDatabase = value
        End Set
    End Property

    Property DBUser() As String
        Get
            Return _DBUser
        End Get
        Set(ByVal value As String)
            _DBUser = value
        End Set
    End Property

    Property DBPass() As String
        Get
            Return _DBPass
        End Get
        Set(ByVal value As String)
            _DBPass = value
        End Set
    End Property

    Property Indiv() As String
        Get
            Return _Indiv
        End Get
        Set(ByVal value As String)
            _Indiv = value
        End Set
    End Property

    ReadOnly Property ConfigText() As String
        Get
            Return _ConfigText
        End Get
    End Property

    WriteOnly Property Crypter() As clsCrypter
        Set(ByVal value As clsCrypter)
            _Crypter = value
        End Set
    End Property
#End Region

#Region "Funktionen"
    Function ReadConfig(ByVal CryptConfig As Boolean, Optional ByVal sFile As String = Nothing) As Boolean

        If Not sFile = Nothing Then
            _File = sFile
        End If

        If System.IO.File.Exists(_File) Then
            Using sr As System.IO.StreamReader = System.IO.File.OpenText(_File)
                _ConfigText = sr.ReadToEnd
                sr.Close()
            End Using
            If CryptConfig = True Then
                _Crypter.DeCrypt(_ConfigText)
            End If
            If SetVar(_ConfigText) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function WriteConfig(ByVal CryptConfig As Boolean, Optional ByVal sFile As String = Nothing, Optional ByVal toFile As Boolean = False) As Boolean
        If Not sFile = Nothing Then
            _File = sFile
        End If

        GetVar(_ConfigText)

        If CryptConfig = True Then
            _Crypter.Crypt(_ConfigText)
        End If
        If Not _File Is Nothing And toFile = True Then
            Dim sw As New System.IO.StreamWriter(_File, False)
            sw.Write(_ConfigText)
            sw.Flush()
            sw.Close()
        End If
        Return False
    End Function

    Function ClearVar() As Boolean
        _DBTyp = Nothing
        _DBServer = Nothing
        _DBDatabase = Nothing
        _DBUser = Nothing
        _DBPass = Nothing
        _Indiv = Nothing
        Return True
    End Function

    Function WriteVar(ByVal Typ As String, ByVal Server As String, ByVal Database As String, ByVal User As String, ByVal Pass As String, ByVal Indiv As String) As Boolean
        _DBTyp = Typ
        _DBServer = Server
        _DBDatabase = Database
        _DBUser = User
        _DBPass = Pass
        _Indiv = Indiv
        Return True
    End Function

    Function ReadVar(ByRef Typ As String, ByRef Server As String, ByRef Database As String, ByRef User As String, ByRef Pass As String, ByRef Indiv As String) As Boolean
        Typ = _DBTyp
        Server = _DBServer
        Database = _DBDatabase
        User = _DBUser
        Pass = _DBPass
        Indiv = _Indiv
        Return True
    End Function

    Private Function GetVar(ByRef strBuffer) As String
        strBuffer = "Version=" & Version & "<#>" & vbNewLine
        strBuffer = strBuffer & "DBTyp=" & _DBTyp & "<#>" & vbNewLine

        If _DBTyp = 2 Then
            strBuffer = strBuffer & "DBServer=" & _DBServer & "<#>" & vbNewLine
            strBuffer = strBuffer & "DBUser=" & _DBUser & "<#>" & vbNewLine
        End If

        If Not _DBTyp = 0 Then
            strBuffer = strBuffer & "DBDatabase=" & _DBDatabase & "<#>" & vbNewLine
            strBuffer = strBuffer & "DBPass=" & _DBPass & "<#>" & vbNewLine
        End If

        strBuffer = strBuffer & "Indiv=" & _Indiv & "<#>"

        Return strBuffer
    End Function

    Private Function SetVar(ByVal strBuffer As String) As Boolean
        _Version = strBuffer.Substring(strBuffer.IndexOf("Version=") + 8, strBuffer.IndexOf("<#>", strBuffer.IndexOf("Version=") + 8) - (strBuffer.IndexOf("Version=") + 8))

        _DBTyp = strBuffer.Substring(strBuffer.IndexOf("DBTyp=") + 6, strBuffer.IndexOf("<#>", strBuffer.IndexOf("DBTyp=") + 6) - (strBuffer.IndexOf("DBTyp=") + 6))

        If _DBTyp = 2 Then
            _DBServer = strBuffer.Substring(strBuffer.IndexOf("DBServer=") + 9, strBuffer.IndexOf("<#>", strBuffer.IndexOf("DBServer=") + 9) - (strBuffer.IndexOf("DBServer=") + 9))
            _DBUser = strBuffer.Substring(strBuffer.IndexOf("DBUser=") + 7, strBuffer.IndexOf("<#>", strBuffer.IndexOf("DBUser=") + 7) - (strBuffer.IndexOf("DBUser=") + 7))
        End If

        If Not _DBTyp = 0 Then
            _DBDatabase = strBuffer.Substring(strBuffer.IndexOf("DBDatabase=") + 11, strBuffer.IndexOf("<#>", strBuffer.IndexOf("DBDatabase=") + 11) - (strBuffer.IndexOf("DBDatabase=") + 11))
            _DBPass = strBuffer.Substring(strBuffer.IndexOf("DBPass=") + 7, strBuffer.IndexOf("<#>", strBuffer.IndexOf("DBPass=") + 7) - (strBuffer.IndexOf("DBPass=") + 7))
        End If

        _Indiv = strBuffer.Substring(strBuffer.IndexOf("Indiv=") + 6, strBuffer.IndexOf("<#>", strBuffer.IndexOf("Indiv=") + 6) - (strBuffer.IndexOf("Indiv=") + 6))

        Return True
    End Function

#End Region

End Class
