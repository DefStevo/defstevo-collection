Module mdlMain
    Public fSettings As New frmSettings
    Public fRDP As New frmRDP

    Public s_Server As String
    Public i_Port As Integer
    Public s_User As String
    Public s_Pass As String
    Public i_X As Integer
    Public i_Y As Integer

    Private Const s_Help As String = "Folgende Aufrufparameter sind möglich:" & vbNewLine & _
                                     "/s Server:Port" & vbNewLine & _
                                     "/u Benutzer" & vbNewLine & _
                                     "/p Kennwort" & vbNewLine & _
                                     "/r Auflösung (zB /r 1024x768)" & vbNewLine & vbNewLine & _
                                     "Beispiel ""/s 10.0.0.1:3389 /u Administrator /p admin /r 1024x768"""


    Sub Main()
        Dim OpenArgs As [String]() = System.Environment.GetCommandLineArgs()

        If OpenArgs.Length <> 1 Then
            i_X = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width
            i_X = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width
            s_Server = "localhost"
            i_Port = 3389
            s_User = ""
            s_Pass = ""

            For i As Integer = 0 To OpenArgs.Length - 1
                Select Case OpenArgs(i).ToString
                    Case "/?"
                        MsgBox(s_Help, MsgBoxStyle.OkOnly, "Terminals: Syntax")
                        Exit Sub
                    Case "/s"
                        i = +1
                        Dim a_Help() As String = Split(OpenArgs(i).ToString, ":", 2)
                        s_Server = a_Help(0).ToString
                        i_Port = System.Convert.ToInt16(a_Help(1).ToString)
                        a_Help = Nothing
                    Case "/u"
                        i = +1
                        s_User = OpenArgs(i).ToString
                    Case "/p"
                        i = +1
                        s_Pass = OpenArgs(i).ToString
                    Case "/r"
                        i = +1
                        Dim a_Help() As String = Split(OpenArgs(i).ToString, "x", 2)
                        i_X = System.Convert.ToInt16(a_Help(0).ToString)
                        i_Y = System.Convert.ToInt16(a_Help(1).ToString)
                        a_Help = Nothing
                End Select
            Next
            fRDP.ShowDialog()
        Else
            fSettings.ShowDialog()
        End If
    End Sub


End Module
