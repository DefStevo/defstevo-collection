


Public Class frmImport

    Private i As Integer = 0

    Private Sub frmImport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not frmTrashBox.fFiles Is Nothing Then
            For Each oFile As String In frmTrashBox.fFiles
                If Is_Folder(oFile) Then
                    'Datei ist ein Ordner
                    For Each oFFile As String In Get_Files_from_Folder(oFile)
                        'Datei dem Datagrid hinzufügen
                        DG_Add_Row(Nothing, _
                                   Get_Name_from_Path(oFFile), _
                                   oFFile, _
                                   Get_Type_from_Name(Get_Name_from_Path(oFFile)), _
                                   Nothing, _
                                   "1.0", _
                                   True)
                    Next

                Else
                    'Ist Datei
                    'Datei dem Datagrid hinzufügen
                    DG_Add_Row(Nothing, _
                               Get_Name_from_Path(oFile), _
                               oFile, _
                               Get_Type_from_NAme(Get_Name_from_Path(oFile)), _
                               Nothing, _
                               "1.0", _
                               True)
                End If

            Next



        End If
    End Sub

    Private Sub DG_Add_Row(file_GUID As String, _
                           Name As String, _
                           Path As String, _
                           Typ As String, _
                           object_GUID As String, _
                           Version As String, _
                           NewVersion As Boolean)
        dgFiles.Rows.Add()
        dgFiles.Rows(i).Cells("cfile_GUID").Value = file_GUID
        dgFiles.Rows(i).Cells("cName").Value = Name
        dgFiles.Rows(i).Cells("cPath").Value = Path
        dgFiles.Rows(i).Cells("cTyp").Value = Typ
        dgFiles.Rows(i).Cells("cobject_GUID").Value = object_GUID
        dgFiles.Rows(i).Cells("cVersion").Value = Version
        dgFiles.Rows(i).Cells("cNewVersion").Value = NewVersion
        dgFiles.Refresh()
        i += 1
    End Sub

    Private Function Is_Folder(oFile As String) As Boolean
        'Prpfen ob es sich um einen Ordner handelt
        If oFile.LastIndexOf(".") = -1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Get_Type_from_Name(oFile As String) As String
        'Dateityp aus Name ermitteln
        If Not oFile.Split(".").Length = -1 Then
            Return oFile.Split(".")(oFile.Split(".").Length - 1)
        Else
            Return Nothing
        End If

    End Function

    Private Function Get_Name_from_Path(oFile As String) As String
        'Datiename aus Pfad ermitteln
        If Not oFile.Split("\").Length = -1 Then
            Return oFile.Split("\")(oFile.Split("\").Length - 1)
        Else
            Return Nothing
        End If

    End Function

    Private Function Get_Files_from_Folder(oFolder As String) As String()
        'Alle Dateien eines Ordner ermitteln
        Dim oFiles As String() = System.IO.Directory.GetFiles(oFolder)

        If Not oFiles.Length = 0 Then
            Return oFiles
        Else
            Return Nothing
        End If

    End Function

    Private Sub cmdImport_Click(sender As System.Object, e As System.EventArgs) Handles cmdImport.Click
        Do While dgFiles.Rows.Count > 0
            frmTrashBox.cDB.Add_File(dgFiles.Rows(0).Cells("cfile_GUID").Value, _
                                     dgFiles.Rows(0).Cells("cName").Value, _
                                     dgFiles.Rows(0).Cells("cPath").Value, _
                                     dgFiles.Rows(0).Cells("cTyp").Value, _
                                     dgFiles.Rows(0).Cells("cobject_GUID").Value, _
                                     dgFiles.Rows(0).Cells("cVersion").Value, _
                                     txtDescr.Text, _
                                     txtKeywords.Text, _
                                     txtGroup.Text)
            dgFiles.Rows.Remove(dgFiles.Rows(0))
        Loop
    End Sub
End Class