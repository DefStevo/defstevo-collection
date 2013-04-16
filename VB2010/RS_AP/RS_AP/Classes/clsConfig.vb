Public Class clsConfig

#Region "Const"
    Private Const _strNone = "Kein"

#End Region

#Region "Strukturen"
    Structure sSettings
        Dim strName As String

        Dim strValue1 As String
        Dim strValue2 As String
        Dim strValue3 As String

        Sub New(ByVal Name As String, ByVal Value1 As String, ByVal Value2 As String, ByVal Value3 As String)
            strName = Name
            strValue1 = Value1
            strValue2 = Value2
            strValue3 = Value3
        End Sub
    End Structure
#End Region

#Region "Enum"
    Public Enum ESettings
        None = 0
        DB_Server
        DB_Datenbank
        DB_Benutzer
        DB_Kennwort
        RS_User
        RS_Wegzeit
        RS_Vorlage
        RS_Range_AP
        RS_Range_Kunde
        RS_Range_Projekt
        RS_Range_Ort
        RS_Range_PL
        RS_Range_Detail_Datum
        RS_Range_Detail_Tätigkeit
        RS_Range_Detail_Zeit
        RS_Range_Detail_Fahrzeit
        RS_Range_Detail_Zusatz
    End Enum

#End Region

#Region "Deklarationen"
    Private _strDateiSettings As String = My.Application.Info.DirectoryPath & "\Config\RS_AP.Settings.cfg"
    Private _srSettings As System.IO.StreamReader
    Private _swSettings As System.IO.StreamWriter
    Private _bInitStatus As Boolean
    Public oSettingsL As List(Of sSettings)
    Private oSettingsZ As sSettings

#End Region

#Region "Funktionen"
    Function InitConfig(ByVal Settings As Boolean) As Boolean
        If Settings = True Then
            oSettingsL = New List(Of sSettings)
            If ReadConfigSettings() = False Then
                MsgBox("Datei kann nicht gelesen werden" & vbCrLf & _
                       _strDateiSettings, MsgBoxStyle.Critical, "Fehler beim Lesen der Konfiguration")
            End If
        End If

        _bInitStatus = True

        Return True
    End Function

    Function UnloadConfig() As Boolean
        If _bInitStatus = True Then
            _strDateiSettings = Nothing
            _srSettings = Nothing
            _swSettings = Nothing
            oSettingsL = Nothing
            oSettingsZ = Nothing
            _bInitStatus = False
            Return True
        End If
        Return False
    End Function

#Region "Datei Funktionen"
    Private Function ReadConfigSettings() As Boolean
        Dim strBuffer As String

        Dim strName As String = ""
        Dim strValue1 As String = ""
        Dim strValue2 As String = ""
        Dim strValue3 As String = ""

        If System.IO.File.Exists(_strDateiSettings) Then
            _srSettings = New System.IO.StreamReader(_strDateiSettings)

            strBuffer = _srSettings.ReadLine

            While Not strBuffer Is Nothing
                strName = ""
                strValue1 = ""
                strValue2 = ""
                strValue3 = ""

                If strBuffer.Split("=").Length = 2 Then
                    strName = strBuffer.Split("=")(0)

                    Select Case strBuffer.Split("=")(1).Split(";").Length
                        Case 1
                            strValue1 = strBuffer.Split("=")(1).Split(";")(0)
                        Case 2
                            strValue1 = strBuffer.Split("=")(1).Split(";")(0)
                            strValue2 = strBuffer.Split("=")(1).Split(";")(1)
                        Case 3
                            strValue1 = strBuffer.Split("=")(1).Split(";")(0)
                            strValue2 = strBuffer.Split("=")(1).Split(";")(1)
                            strValue3 = strBuffer.Split("=")(1).Split(";")(2)
                    End Select

                    AddSettings(strName, strValue1, strValue2, strValue3)
                Else
                    'Die Einstellung beinhalte kein =
                    MsgBox("Der Wert '" & strBuffer & "' konnte nicht umgewandelt werden" & vbCrLf & "Die Einstellung beinhaltet kein '='", MsgBoxStyle.Critical, "Fehler beim Lesen der Einstellungen")

                End If

                strBuffer = _srSettings.ReadLine
            End While

            _srSettings.Close()

            Return True

        Else
            Return False
        End If
    End Function

    Function WriteConfigSettings() As Boolean
        Dim strBuffer As String = ""

        If Not System.IO.File.Exists(_strDateiSettings) Then
            System.IO.File.Create(_strDateiSettings)
        End If

        _swSettings = New System.IO.StreamWriter(_strDateiSettings, False)

        For i As Integer = 0 To oSettingsL.Count - 1
            With oSettingsL(i)
                strBuffer = strBuffer & _
                            .strName & "=" & _
                            .strValue1 & ";" & _
                            .strValue2 & ";" & _
                            .strValue3 & vbCrLf
            End With
        Next

        _swSettings.Write(strBuffer)
        _swSettings.Flush()
        _swSettings.Close()

        Return True

    End Function

#End Region

#Region "Settings Funktionen"
    Function SearchSettings(ByVal eName As ESettings, Optional ByVal sName As String = "") As Integer
        Dim bMatchSetting As Boolean = False

        For i As Integer = 0 To oSettingsL.Count - 1
            If eName.ToString = oSettingsL(i).strName Or sName = oSettingsL(i).strName Then
                bMatchSetting = True
            End If

            If bMatchSetting = True Then
                Return i
            End If
        Next

        Return -1
    End Function

    Function AddSettings(ByVal Name As String, ByVal Value1 As String, ByVal Value2 As String, ByVal Value3 As String)

        If Name Is Nothing Then
            Return False
        End If

        If Not SearchSettings(ESettings.None, Name) = -1 Then
            Return False
        End If

        'Objekt in Liste aufnehmen
        oSettingsZ = New sSettings(Name, Value1, Value2, Value3)
        oSettingsL.Add(oSettingsZ)
        Return True

    End Function

    Function GetSettings(ByVal Name As ESettings, Optional ByVal Value As Integer = 1) As String

        If Not Name.ToString Is Nothing Then
            For i As Integer = 0 To oSettingsL.Count - 1
                If Name.ToString = oSettingsL(i).strName Then
                    With oSettingsL(i)
                        Select Case Value
                            Case 3
                                Return .strValue3
                            Case 2
                                Return .strValue2
                            Case Else
                                Return .strValue1
                        End Select
                    End With
                End If
            Next
        End If

        Return Nothing

    End Function

    Function SetSettings(ByVal Name As ESettings, Optional ByVal Value1 As String = Nothing, Optional ByVal Value2 As String = Nothing, Optional ByVal Value3 As String = Nothing)
        Dim i As Integer

        i = SearchSettings(Name)

        If Not i = -1 Then
            oSettingsZ.strName = oSettingsL(i).strName
            oSettingsZ.strValue1 = oSettingsL(i).strValue1
            oSettingsZ.strValue2 = oSettingsL(i).strValue2
            oSettingsZ.strValue3 = oSettingsL(i).strValue3

            With oSettingsZ
                .strValue1 = Value1
                .strValue2 = Value2
                .strValue3 = Value3
            End With

            oSettingsL(i) = oSettingsZ
        Else
            AddSettings(Name.ToString, Value1, Value2, Value3)
        End If

        Return True
    End Function

#End Region

#End Region


End Class
