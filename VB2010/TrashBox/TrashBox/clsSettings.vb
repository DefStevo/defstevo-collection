Imports Microsoft.Win32

Public Class clsSettings

#Region "Deklaration"
    Public sDBPath As String = ""
    Public sTrashPath As String = ""
    Private _FolderBrowser As FolderBrowserDialog

#End Region

#Region "Subs/Function"

    Public Function Init_Settings() As Boolean
        ' Prüfen ob Registry Eintrag vorhanden
        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware") Is Nothing Then
            If Not Create_Reg() Then
                Return False
            End If
        End If

        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware").OpenSubKey("Trashbox") Is Nothing Then
            If Not Create_Reg() Then
                Return False
            End If

        End If

        'Werte aus Registry lesen
        sDBPath = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware").OpenSubKey("Trashbox").GetValue("DBPath")
        sTrashPath = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware").OpenSubKey("Trashbox").GetValue("TrashPath")

        If Not System.IO.File.Exists(sDBPath + "\" + "TrashBox.accdb") Then
            If Not Create_DB() Then
                Return False
            End If
        End If

        Return True
    End Function

    Private Function Create_Reg() As Boolean
        Dim _sDBPAth As String = ""
        Dim _sTrashPath As String = ""
        _FolderBrowser = New FolderBrowserDialog
        _FolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer
        _FolderBrowser.ShowNewFolderButton = True

        If MsgBox("Datenbankverzeichnis nocht nicht vorhanden," + vbNewLine + "wollen Sie diese anlegen?", vbYesNo, "TrashBox - Einstellungen") = MsgBoxResult.Yes Then
            'Verzeichnis für DB-Auswählen
            _FolderBrowser.SelectedPath = ""
            _FolderBrowser.ShowDialog()
            _sDBPAth = _FolderBrowser.SelectedPath
        Else
            Return False
        End If

        If MsgBox("Dateiverzeichnis nocht nicht vorhanden," + vbNewLine + " wollen Sie dieses anlegen?", vbYesNo, "TrashBox - Einstellungen") = MsgBoxResult.Yes Then
            'Verzeichnis für Dateien
            _FolderBrowser.SelectedPath = ""
            _FolderBrowser.ShowDialog()
            _sTrashPath = _FolderBrowser.SelectedPath
        Else
            Return False
        End If

        If Not _sDBPAth = "" And Not _sTrashPath = "" Then
            'Registry Eintrag erzeugen
            Registry.CurrentUser.OpenSubKey("Software", True).CreateSubKey("StevoSoftware")
            Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware", True).CreateSubKey("TrashBox")

            'Registry Werte schreiben
            Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware").OpenSubKey("TrashBox", True).SetValue("DBPath", _sDBPAth)
            Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("StevoSoftware").OpenSubKey("TrashBox", True).SetValue("TrashPath", _sTrashPath)

        End If

        Return True
    End Function

    Private Function Create_DB() As Boolean
        'Datenbank kopieren
        System.IO.File.Copy(Application.ExecutablePath + "\Trashbox.accdb", sDBPath + "\TrashBox.accdb")

        Return True

    End Function

#End Region


End Class
