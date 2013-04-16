Public Class clsDB

#Region "Declaration"
    Private _bInit As Boolean = False
    Private _DBConn As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private _DBCommand As OleDb.OleDbCommand = New OleDb.OleDbCommand
    Private _DBReader As OleDb.OleDbDataReader
#End Region

#Region "Sub/Function"

    Public Sub Open_DB(strPath As String)
        'Connection String erstellen
        Dim _ConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""" + strPath + """"
        _DBConn.ConnectionString = _ConnString

        'Datenbank öffnen
        _DBConn.Open()

    End Sub

    Public Sub Close_DB()
        'Datenbank schließen
        _DBConn.Close()
    End Sub

    Public Sub Add_File(file_GUID As String, _
                        file_name As String, _
                        file_Path As String, _
                        file_Type As String, _
                        object_GUID As String, _
                        file_Version As String, _
                        sDescr As String, _
                        sKeywords As String, _
                        sGroup As String)

        Dim _fGUID As String = ""
        Dim _oGUID As String = ""

        'Aktuelle Verbindung zuweise
        _DBCommand.Connection = _DBConn

        'Wenn file_GUID leer dann ist es eine Neue Datei
        If file_GUID Is Nothing Then
            _fGUID = frmTrashBox.Create_GUID()
            _DBCommand.CommandText = "Insert into tblFile(file_GUID, file_NAME, file_TEXT, file_TYPE) " + _
                                     "VALUES('" + _fGUID + "','" + file_name + "','','')"
            _DBCommand.ExecuteNonQuery()
        Else
            _fGUID = file_GUID
        End If

        'Wenn object_GUID leer dann neue Version
        If object_GUID Is Nothing Then
            _oGUID = frmTrashBox.Create_GUID()
            System.IO.File.Copy(file_Path, frmTrashBox.cSettings.sTrashPath + "\" + _oGUID)
        Else
            _oGUID = object_GUID
            System.IO.File.Replace(file_Path, frmTrashBox.cSettings.sTrashPath + "\" + _oGUID, Nothing)
        End If

        'Neues Object anlegen
        _DBCommand.CommandText = "Insert into tblObject(object_GUID, object_VERSION)" + _
                                 "VALUES('" + _oGUID + "','" + file_Version + "')"
        _DBCommand.ExecuteNonQuery()

        'Verknüpfung zwischen Datei und Objekt herstellen
        _DBCommand.CommandText = "Insert into lnkFile_Object(file_GUID, object_GUID) " + _
                                 "VALUES('" + _fGUID + "','" + _oGUID + "')"
        _DBCommand.ExecuteNonQuery()

        'Beschlagwortung durchführen
        Create_KeyWords(_fGUID, Split_Keywords(sKeywords))

        'Gruppenzuordnung durchführen
        Create_Group(_fGUID, sGroup)

    End Sub

    Private Function Split_Keywords(sKeywords As String) As String()

        If Not sKeywords.Split(" ").Length = -1 Then
            Return sKeywords.Split(" ")
        End If

        If Not sKeywords.Split(";").Length = -1 Then

            Return sKeywords.Split(";")
        End If

        Return Nothing
    End Function

    Private Sub Create_KeyWords(file_GUID As String, KeyWords As String())
        Dim _kGUID As String = ""
        For Each KeyWord In KeyWords

            _DBCommand.CommandText = "SELECT key_GUID, key_NAME " + _
                                     "FROM tblKeyWords " + _
                                     "WHERE UCASEx(key_NAME) = '" + KeyWord.ToUpper + "'"

            _DBReader = _DBCommand.ExecuteReader()

            Do While _DBReader.Read()
                If Not _DBReader.GetString("key_GUID") Is Nothing Then
                    'GUID zu Keyword ermitteln
                    _kGUID = _DBReader.GetString("key_GUID")
                Else
                    'Keyword neu anlegen
                    _kGUID = frmTrashBox.Create_GUID
                    _DBCommand.CommandText = "Insert into tblKeywords(key_GUID, key_WORD, key_DATE) " + _
                                             "VALUES('" + _kGUID + "','" + KeyWord + "',GETDATE())"
                    _DBCommand.ExecuteNonQuery()
                End If
            Loop
            _DBReader.Close()

            'Datei mit Keyword verlinken
            _DBCommand.CommandText = "Insert into lnkFile_Keywords (file_GUID, key_GUID) " + _
                                     "VALUES ('" + file_GUID + "','" + _kGUID + "')"
            _DBCommand.ExecuteNonQuery()


        Next
    End Sub

    Private Sub Create_Group(file_GUID As String, Group As String)
        Dim _gGUID As String = ""

        _DBCommand.CommandText = "Select group_GUID, group_NAME " + _
                                 "FROM tblGroups " + _
                                 "WHERE UCASE(group_NAME)='" + Group + "'"

        _DBReader = _DBCommand.ExecuteReader

        Do While _DBReader.Read
            If Not _DBReader.GetString("group_GUID") Is Nothing Then
                'GUID zu Gruppe ermitteln
                _gGUID = _DBReader.GetString("group_GUID")
            Else
                'Gruppe neu anlegen
                _gGUID = frmTrashBox.Create_GUID
                _DBCommand.CommandText = "Insert into tblGROUP(group_GUID, group_NAME, group_DATE) " + _
                                         "VALUES('" + _gGUID + "','" + Group + "',GETDATE())"
                _DBCommand.ExecuteNonQuery()
            End If
        Loop

        'Datei mit Gruppe verlinken
        _DBCommand.CommandText = "Insert into lnkFile_Group(file_GUID, group_GUID) " + _
                                 "VALUES('" + file_GUID + "','" + _gGUID + "')"

    End Sub

#End Region

End Class
