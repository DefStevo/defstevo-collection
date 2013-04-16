Public Class frmTrashBox
#Region "Deklaration"
    Private nVisibility As Decimal = 1 'Sichtbarkeiswert (0.1 = Unsichtbar, 1 = Sichtbar)
    Private nSmoothInterval As Decimal = 50 'Interval (ms) für die Veränderung der Sichtbarkeit
    Private nSmoothValue As Decimal = 0.15 'Schritte für die Veränderung der Sichtbarkeit
    Private nWait As Decimal = 2000 'Pause zwischen dem Wechsel von sichtbar nach unsichtbar
    Private bWorking As Boolean = True 'Boolean der feststellt ob die Sichbarkeit gerade verändert wird
    Private eTaskBarPosition As ENUM_TaskBar_Position = 1 'Standardgemäß ist die Taskleiste unten

    Public Shared cSettings As clsSettings = New clsSettings
    Public Shared cDB As clsDB = New clsDB
    Public Shared fFiles As String()

    Private Enum ENUM_TaskBar_Position
        Top = 1
        Bottom = 2
        Left = 3
        Right = 4
    End Enum

#End Region

    Private Sub frmTrashBox_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If cSettings.Init_Settings Then
            Form_Position()
            Set_Form_Visible()
        Else
            MsgBox("Fehler beim Lesen der Einstellungen," + vbNewLine + "Programm wird beendet", MsgBoxStyle.Critical, "TrashBox")
            Me.Close()
        End If

        cDB.Open_DB(cSettings.sDBPath + "\TrashBox.accdb")
    End Sub

    Private Sub frmTrashBox_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cDB.Close_DB()
    End Sub


#Region "Form Position/Visibility"
    Private Sub frmTrashBox_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        'Fenster sichtbar machen
        Set_Form_Visible()

    End Sub

    Private Sub tCapture_Tick(sender As System.Object, e As System.EventArgs) Handles tCapture.Tick
        'Position des Cursors prüfen
        If Me.PointToClient(Cursor.Position).X >= -8 And _
           Me.PointToClient(Cursor.Position).X <= Me.Width And _
           Me.PointToClient(Cursor.Position).Y >= -30 And _
           Me.PointToClient(Cursor.Position).Y <= Me.Height - 22 Then
            'Cursor befindet sich im Fenster
            bWorking = True
            tVisibility.Interval = nSmoothInterval
            'Fenster sichtbar machen
            Set_Form_Visible()
        Else
            'Prüfen ob das Fenster gerade sichtbar wird
            If bWorking = False Then
                bWorking = True
                tVisibility.Interval = nWait
                'Fenster unsichtbar machen
                Set_Form_Invisible()
            End If
        End If

    End Sub

    Private Sub tVisibility_Tick(sender As Object, e As System.EventArgs) Handles tVisibility.Tick
        'Verändert die Sichtbarkeit des Fenster
        tVisibility.Interval = nSmoothInterval

        Dim nNewVal As Decimal = 0

        'Gewünschte Sichtbarkeit erreicht
        If Me.Opacity = nVisibility Then
            tVisibility.Enabled = False
        End If

        'Fenster wird unsichtbar
        If Me.Opacity > nVisibility Then
            nNewVal = Me.Opacity - nSmoothValue

            If nNewVal < nVisibility Then
                bWorking = False
                nNewVal = nVisibility
            End If

        Else 'Fenster wird sichtbar
            nNewVal = Me.Opacity + nSmoothValue

            If nNewVal > nVisibility Then
                bWorking = False
                nNewVal = nVisibility
            End If
        End If

        'Sichtbarkeit auf Fenster übertragen
        Me.Opacity = Decimal.Round(nNewVal, 2)
    End Sub

    Private Sub Set_Form_Visible()
        'Fenster sichtbar machen
        nVisibility = 1
        tVisibility.Enabled = True
    End Sub

    Private Sub Set_Form_Invisible()
        'Fenster unsichtbar machen
        nVisibility = 0.1
        tVisibility.Enabled = True
    End Sub

    Private Sub Form_Position()
        Dim nWidth As Integer = 0
        Dim nHeight As Integer = 0
        Dim nTop As Integer = 0
        Dim nBottom As Integer = 0
        Dim nLeft As Integer = 0
        Dim nRight As Integer = 0
        Dim bAutoHide As Boolean = False

        'Taskbar Informationen ermitteln
        mdlTaskBar.GetTaskbarState(nTop, nBottom, nLeft, nRight, nHeight, nWidth, bAutoHide)

        'Taskbar ist oben
        If nTop = 0 And Not nBottom = nHeight Then
            eTaskBarPosition = ENUM_TaskBar_Position.Top
        End If

        'Taskbar ist untern
        If Not nTop = 0 And nBottom = nHeight Then
            eTaskBarPosition = ENUM_TaskBar_Position.Bottom
        End If

        'Taskbar ist links
        If nLeft = 0 And Not nRight = nWidth Then
            eTaskBarPosition = ENUM_TaskBar_Position.Left
        End If

        'Taskbar ist rechts
        If Not nLeft = 0 And nRight = nWidth Then
            eTaskBarPosition = ENUM_TaskBar_Position.Right
        End If

        'Fenster Andocken
        Select Case eTaskBarPosition
            Case ENUM_TaskBar_Position.Top
                If bAutoHide Then
                    Me.Location = New Point(nWidth - Me.Width - 5, 5)
                Else
                    Me.Location = New Point(nWidth - Me.Width - 5, nBottom + 5)
                End If

            Case ENUM_TaskBar_Position.Bottom
                If bAutoHide Then
                    Me.Location = New Point(nWidth - Me.Width - 5, nBottom - Me.Height - 5)
                Else
                    Me.Location = New Point(nWidth - Me.Width - 5, nTop - Me.Height - 5)
                End If

            Case ENUM_TaskBar_Position.Left
                If bAutoHide Then
                    Me.Location = New Point(5, nHeight - Me.Height - 5)
                Else
                    Me.Location = New Point(nRight + 5, nHeight - Me.Height - 5)
                End If

            Case ENUM_TaskBar_Position.Right
                If bAutoHide Then
                    Me.Location = New Point(nWidth - Me.Width - 5, nHeight - Me.Height - 5)
                Else
                    Me.Location = New Point(nLeft - Me.Width - 5, nHeight - Me.Height - 5)
                End If

        End Select

    End Sub

#End Region

#Region "Drag/Drop"
    Private Sub pTrashBox_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles pTrashBox.DragEnter
        'Prüfen ob eine Datei gedroped wird
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'Kopiermodus aktivieren
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pTrashBox_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles pTrashBox.DragDrop
        'Dateinamen der gedropden Dateien
        fFiles = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())

        frmImport.ShowDialog()

    End Sub

#End Region

#Region "Settings"


#End Region

#Region "Import/Export"
    Private Sub pTrashBox_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pTrashBox.MouseDoubleClick
        MsgBox("Export")
    End Sub
#End Region

#Region "Sonstiges"
    Public Function Create_GUID() As String
        Dim g As Guid = New Guid
        g = Guid.NewGuid
        Return g.ToString
    End Function

#End Region



End Class

