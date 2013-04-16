Public Class frmMain

#Region "Declaration"

    Public clsVBox As New clsVirtualBox

#End Region

#Region "Form Activities"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim saMachine As String()
        Dim saMachines As List(Of String())
        Dim i As Integer = 0

        'Get Machine Information UUID, Name, OS Type
        saMachines = clsVBox.VBox_Machines

        For Each saMachine In saMachines
            'Add to List
            dgMachines.Rows.Add()
            dgMachines.Rows(i).Cells("MId").Value = saMachine(0)
            dgMachines.Rows(i).Cells("MName").Value = saMachine(1)

            'Add Logo (Linux or Windows)

            'TODO (3) Implement other Logos (Dos, ...)
            If saMachine(2) = "" Then
                dgMachines.Rows(i).Cells("MOS").Value = VBControl.My.Resources.OS_None
            Else
                If saMachine(2) = "Linux" Then
                    dgMachines.Rows(i).Cells("MOS").Value = VBControl.My.Resources.OS_Linux
                ElseIf saMachine(2).Substring(0, 7) = "Windows" Then
                    dgMachines.Rows(i).Cells("MOS").Value = VBControl.My.Resources.OS_Windows
                Else
                    dgMachines.Rows(i).Cells("MOS").Value = VBControl.My.Resources.OS_Standard
                End If
            End If
            i = i + 1
        Next

        For Each sArgument As String In Environment.GetCommandLineArgs()
            If sArgument = "/Silent" Or sArgument = "Silent" Then
                'Start as Tray
                Me.WindowState = FormWindowState.Minimized
            End If

            If sArgument.Substring(0, 5) = "/UUID" Or sArgument.Substring(0, 4) = "UUID" Then
                'Select Item in dgView by UUID
                Dim sArgUUID As String = ""
                sArgUUID = sArgument.Split("=")(1)
                SelectDGbyUUID(sArgUUID)

            End If

            If sArgument.Substring(0, 5) = "/Name" Or sArgument.Substring(0, 4) = "Name" Then
                'Select Item in dgView by Name
                Dim sArgName As String = ""
                sArgName = sArgument.Split("=")(1)
                SelectDGbyName(sArgName)
            End If
        Next

        Timer.Enabled = True



    End Sub

    Private Sub frmHaupt_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon.Visible = True
            NotifyIcon.ShowBalloonTip(5000)
        End If

        If Me.WindowState = FormWindowState.Normal Then
            Me.ShowInTaskbar = True
            NotifyIcon.Visible = False
        End If
    End Sub

#End Region

#Region "Start VM"

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim sUUID As String = GetUUID()
        Dim iType As Integer = 0
        If rdGUI.Checked = True Then
            iType = rdGUI.Tag
        ElseIf rdHEADLESS.Checked = True Then
            iType = rdHEADLESS.Tag
        ElseIf rdSDL.Checked = True Then
            iType = rdSDL.Tag
        ElseIf rdVRDP.Checked = True Then
            'TODO (1) Check posibility of VRDP/VRDE
            iType = rdVRDP.Tag
        ElseIf rdNoGui.Checked = True Then
            iType = rdNoGui.Tag
        End If
        clsVBox.StartMachine(sUUID, iType)
    End Sub

    Private Sub MaximierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormMaxToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormCloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VMStartGUIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMStartGUIToolStripMenuItem.Click
        clsVBox.StartMachine(GetUUID(), VMStartGUIToolStripMenuItem.Tag)
    End Sub

    Private Sub VMStartHeadlessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMStartHeadlessToolStripMenuItem.Click
        clsVBox.StartMachine(GetUUID(), VMStartHeadlessToolStripMenuItem.Tag)
    End Sub

    Private Sub VMStartSdlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMStartSdlToolStripMenuItem.Click
        clsVBox.StartMachine(GetUUID(), VMStartSdlToolStripMenuItem.Tag)
    End Sub

    Private Sub VMStartVrdpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMStartVrdpToolStripMenuItem.Click
        clsVBox.StartMachine(GetUUID(), VMStartVrdpToolStripMenuItem.Tag)
    End Sub

    Private Sub VMStartNoGuiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMStartNoGuiToolStripMenuItem.Click
        clsVBox.StartMachine(GetUUID(), VMStartNoGuiToolStripMenuItem.Tag)
    End Sub

#End Region

#Region "Stop VM"

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        clsVBox.StopMachine(GetUUID())
    End Sub

    Private Sub VMStopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMStopToolStripMenuItem.Click
        clsVBox.StopMachine(GetUUID())
    End Sub

#End Region

#Region "VM Info"

    Public Function GetUUID() As String
        'Get UUID from dgView "0" if no Machine
        If Not dgMachines.SelectedRows.Count = 0 Then
            Return dgMachines.Rows(dgMachines.SelectedRows(0).Index).Cells("MId").Value()
        End If
        Return ""
    End Function

    Private Sub dgMachines_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMachines.CellEnter
        GetVBoxInfo()
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        GetVBoxInfo()
    End Sub

    Private Sub GetVBoxInfo()
        Dim sUUID As String = GetUUID()

        'Set info to Labels in StatusStrip
        lblOS.Text = "OS: " + clsVBox.Machine_OS(sUUID)
        lblIP.Text = "IP: " + clsVBox.Machine_IP(sUUID)
        lblRAM.Text = "RAM: " + clsVBox.Machine_RAM(sUUID)

        'Set Logo (Stopped, Running, Paused, Saved) in StatusStrip
        'TODO (3) Implement other Stats (Aborted, ...)
        Select Case clsVBox.Machine_State(sUUID)
            Case clsVBox.sMachine_Status_Running
                lblSTATUS.Image = VBControl.My.Resources.STAT_ON
                SetButtons(False, True, True, False)
            Case clsVBox.sMachine_Status_Paused
                lblSTATUS.Image = VBControl.My.Resources.STAT_PAUSE
                SetButtons(True, True, False, False)
            Case clsVBox.sMachine_Status_Saved
                lblSTATUS.Image = VBControl.My.Resources.STAT_SAVED
                SetButtons(True, False, False, True)
            Case Else
                lblSTATUS.Image = VBControl.My.Resources.STAT_OFF
                SetButtons(True, False, False, True)
        End Select

        'Info to Notify MenuStrip
        If sUUID = "0" Then
            VMToolStripMenuItem.Visible = False
            SetButtons(False, False, False, False)
        Else
            VMToolStripMenuItem.Visible = True
            VMToolStripMenuItem.Text = clsVBox.Machine_Name(sUUID)
        End If

    End Sub

    Private Sub SetButtons(ByVal bStart As Boolean, ByVal bStop As Boolean, ByVal bPerformance As Boolean, ByVal bGrpStartType As Boolean)
        btnStart.Enabled = bStart
        btnStart.Visible = bStart
        btnStop.Enabled = bStop
        btnStop.Visible = bStop
        btnPerformance.Enabled = bPerformance
        grpType.Enabled = bGrpStartType
        VMStartToolStripMenuItem.Enabled = bStart
        VMStopToolStripMenuItem.Enabled = bStop
        VMPerformanceToolStripMenuItem.Enabled = bPerformance

    End Sub

    Private Sub SelectDGbyUUID(ByVal UUID As String)
        If UUID = "0" Then
            Exit Sub
        End If

        For i As Integer = 0 To dgMachines.Rows.Count() - 1
            If dgMachines.Rows(i).Cells("MID").Value = UUID Then
                dgMachines.Rows(i).Selected = True
            End If
        Next
    End Sub

    Private Sub SelectDGbyName(ByVal Name As String)
        If Name = "" Then
            Exit Sub
        End If

        For i As Integer = 0 To dgMachines.Rows.Count() - 1
            If dgMachines.Rows(i).Cells("MName").Value = Name Then
                dgMachines.Rows(i).Selected = True
            End If
        Next
    End Sub

#End Region

#Region "Performance"
    Private Sub btnPerformance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformance.Click
        frmPerformance.ShowDialog()
    End Sub

    Private Sub VMPerformanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMPerformanceToolStripMenuItem.Click
        frmPerformance.ShowDialog()
    End Sub

#End Region
   
End Class

