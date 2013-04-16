<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dgMachines = New System.Windows.Forms.DataGridView
        Me.MId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOS = New System.Windows.Forms.DataGridViewImageColumn
        Me.MName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnPerformance = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.grpType = New System.Windows.Forms.GroupBox
        Me.rdNoGui = New System.Windows.Forms.RadioButton
        Me.rdVRDP = New System.Windows.Forms.RadioButton
        Me.rdSDL = New System.Windows.Forms.RadioButton
        Me.rdHEADLESS = New System.Windows.Forms.RadioButton
        Me.rdGUI = New System.Windows.Forms.RadioButton
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.lblSTATUS = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblOS = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblSplit1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblIP = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblSplit2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblRAM = New System.Windows.Forms.ToolStripStatusLabel
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStartGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStartHeadlessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStartSdlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStartVrdpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStartNoGuiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMStopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VMPerformanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormMaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.NotifyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMachines
        '
        Me.dgMachines.AllowUserToAddRows = False
        Me.dgMachines.AllowUserToDeleteRows = False
        Me.dgMachines.AllowUserToResizeColumns = False
        Me.dgMachines.AllowUserToResizeRows = False
        Me.dgMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMachines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MId, Me.MOS, Me.MName})
        Me.dgMachines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgMachines.Location = New System.Drawing.Point(0, 0)
        Me.dgMachines.MultiSelect = False
        Me.dgMachines.Name = "dgMachines"
        Me.dgMachines.ReadOnly = True
        Me.dgMachines.RowHeadersWidth = 20
        Me.dgMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMachines.Size = New System.Drawing.Size(245, 68)
        Me.dgMachines.TabIndex = 1
        '
        'MId
        '
        Me.MId.HeaderText = "ID"
        Me.MId.Name = "MId"
        Me.MId.ReadOnly = True
        Me.MId.Visible = False
        '
        'MOS
        '
        Me.MOS.HeaderText = "OS"
        Me.MOS.Name = "MOS"
        Me.MOS.ReadOnly = True
        Me.MOS.Width = 30
        '
        'MName
        '
        Me.MName.HeaderText = "Name"
        Me.MName.Name = "MName"
        Me.MName.ReadOnly = True
        Me.MName.Width = 175
        '
        'btnStart
        '
        Me.btnStart.Image = Global.VBControl.My.Resources.Resources.STAT_ON
        Me.btnStart.Location = New System.Drawing.Point(245, 0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(23, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPerformance
        '
        Me.btnPerformance.Image = Global.VBControl.My.Resources.Resources.VBOX_Details
        Me.btnPerformance.Location = New System.Drawing.Point(245, 22)
        Me.btnPerformance.Name = "btnPerformance"
        Me.btnPerformance.Size = New System.Drawing.Size(23, 23)
        Me.btnPerformance.TabIndex = 3
        Me.btnPerformance.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Image = Global.VBControl.My.Resources.Resources.STAT_OFF
        Me.btnStop.Location = New System.Drawing.Point(245, 0)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(23, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 2000
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdNoGui)
        Me.grpType.Controls.Add(Me.rdVRDP)
        Me.grpType.Controls.Add(Me.rdSDL)
        Me.grpType.Controls.Add(Me.rdHEADLESS)
        Me.grpType.Controls.Add(Me.rdGUI)
        Me.grpType.Location = New System.Drawing.Point(268, 1)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(226, 68)
        Me.grpType.TabIndex = 7
        Me.grpType.TabStop = False
        Me.grpType.Text = "Start Type"
        '
        'rdNoGui
        '
        Me.rdNoGui.AutoSize = True
        Me.rdNoGui.Location = New System.Drawing.Point(78, 42)
        Me.rdNoGui.Name = "rdNoGui"
        Me.rdNoGui.Size = New System.Drawing.Size(55, 17)
        Me.rdNoGui.TabIndex = 4
        Me.rdNoGui.Tag = "4"
        Me.rdNoGui.Text = "NoGui"
        Me.rdNoGui.UseVisualStyleBackColor = True
        '
        'rdVRDP
        '
        Me.rdVRDP.AutoSize = True
        Me.rdVRDP.Location = New System.Drawing.Point(6, 42)
        Me.rdVRDP.Name = "rdVRDP"
        Me.rdVRDP.Size = New System.Drawing.Size(55, 17)
        Me.rdVRDP.TabIndex = 3
        Me.rdVRDP.Tag = "3"
        Me.rdVRDP.Text = "VRDP"
        Me.rdVRDP.UseVisualStyleBackColor = True
        '
        'rdSDL
        '
        Me.rdSDL.AutoSize = True
        Me.rdSDL.Location = New System.Drawing.Point(160, 19)
        Me.rdSDL.Name = "rdSDL"
        Me.rdSDL.Size = New System.Drawing.Size(46, 17)
        Me.rdSDL.TabIndex = 2
        Me.rdSDL.Tag = "2"
        Me.rdSDL.Text = "SDL"
        Me.rdSDL.UseVisualStyleBackColor = True
        '
        'rdHEADLESS
        '
        Me.rdHEADLESS.AutoSize = True
        Me.rdHEADLESS.Location = New System.Drawing.Point(78, 19)
        Me.rdHEADLESS.Name = "rdHEADLESS"
        Me.rdHEADLESS.Size = New System.Drawing.Size(69, 17)
        Me.rdHEADLESS.TabIndex = 1
        Me.rdHEADLESS.Tag = "1"
        Me.rdHEADLESS.Text = "Headless"
        Me.rdHEADLESS.UseVisualStyleBackColor = True
        '
        'rdGUI
        '
        Me.rdGUI.AutoSize = True
        Me.rdGUI.Checked = True
        Me.rdGUI.Location = New System.Drawing.Point(6, 19)
        Me.rdGUI.Name = "rdGUI"
        Me.rdGUI.Size = New System.Drawing.Size(41, 17)
        Me.rdGUI.TabIndex = 0
        Me.rdGUI.TabStop = True
        Me.rdGUI.Tag = "0"
        Me.rdGUI.Text = "Gui"
        Me.rdGUI.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.AllowItemReorder = True
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSTATUS, Me.lblOS, Me.lblSplit1, Me.lblIP, Me.lblSplit2, Me.lblRAM})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 68)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(495, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblSTATUS
        '
        Me.lblSTATUS.Image = Global.VBControl.My.Resources.Resources.STAT_OFF
        Me.lblSTATUS.Name = "lblSTATUS"
        Me.lblSTATUS.Size = New System.Drawing.Size(16, 17)
        '
        'lblOS
        '
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(25, 17)
        Me.lblOS.Text = "OS:"
        Me.lblOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSplit1
        '
        Me.lblSplit1.AutoSize = False
        Me.lblSplit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSplit1.Name = "lblSplit1"
        Me.lblSplit1.Size = New System.Drawing.Size(2, 17)
        Me.lblSplit1.Text = "|"
        '
        'lblIP
        '
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(20, 17)
        Me.lblIP.Text = "IP:"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSplit2
        '
        Me.lblSplit2.AutoSize = False
        Me.lblSplit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSplit2.Name = "lblSplit2"
        Me.lblSplit2.Size = New System.Drawing.Size(2, 17)
        Me.lblSplit2.Text = "|"
        '
        'lblRAM
        '
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(39, 17)
        Me.lblRAM.Text = "RAM: "
        Me.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Virtual Box Control läuft als Tray-Symbol..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mit der Rechten Maustaste erhalte" & _
            "n Sie das Menü" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NotifyIcon.BalloonTipTitle = "Virtual Box Control"
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Virtual Box Control"
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VMToolStripMenuItem, Me.FormMaxToolStripMenuItem, Me.FormCloseToolStripMenuItem})
        Me.NotifyMenu.Name = "NotifyMenu"
        Me.NotifyMenu.Size = New System.Drawing.Size(137, 70)
        '
        'VMToolStripMenuItem
        '
        Me.VMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VMStartToolStripMenuItem, Me.VMStopToolStripMenuItem, Me.VMPerformanceToolStripMenuItem})
        Me.VMToolStripMenuItem.Name = "VMToolStripMenuItem"
        Me.VMToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.VMToolStripMenuItem.Text = "VM"
        '
        'VMStartToolStripMenuItem
        '
        Me.VMStartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VMStartGUIToolStripMenuItem, Me.VMStartHeadlessToolStripMenuItem, Me.VMStartSdlToolStripMenuItem, Me.VMStartVrdpToolStripMenuItem, Me.VMStartNoGuiToolStripMenuItem})
        Me.VMStartToolStripMenuItem.Name = "VMStartToolStripMenuItem"
        Me.VMStartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStartToolStripMenuItem.Text = "Start"
        '
        'VMStartGUIToolStripMenuItem
        '
        Me.VMStartGUIToolStripMenuItem.Name = "VMStartGUIToolStripMenuItem"
        Me.VMStartGUIToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStartGUIToolStripMenuItem.Tag = "0"
        Me.VMStartGUIToolStripMenuItem.Text = "Gui"
        '
        'VMStartHeadlessToolStripMenuItem
        '
        Me.VMStartHeadlessToolStripMenuItem.Name = "VMStartHeadlessToolStripMenuItem"
        Me.VMStartHeadlessToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStartHeadlessToolStripMenuItem.Tag = "1"
        Me.VMStartHeadlessToolStripMenuItem.Text = "Headless"
        '
        'VMStartSdlToolStripMenuItem
        '
        Me.VMStartSdlToolStripMenuItem.Name = "VMStartSdlToolStripMenuItem"
        Me.VMStartSdlToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStartSdlToolStripMenuItem.Tag = "2"
        Me.VMStartSdlToolStripMenuItem.Text = "SDL"
        '
        'VMStartVrdpToolStripMenuItem
        '
        Me.VMStartVrdpToolStripMenuItem.Name = "VMStartVrdpToolStripMenuItem"
        Me.VMStartVrdpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStartVrdpToolStripMenuItem.Tag = "3"
        Me.VMStartVrdpToolStripMenuItem.Text = "VRDP"
        '
        'VMStartNoGuiToolStripMenuItem
        '
        Me.VMStartNoGuiToolStripMenuItem.Name = "VMStartNoGuiToolStripMenuItem"
        Me.VMStartNoGuiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStartNoGuiToolStripMenuItem.Tag = "4"
        Me.VMStartNoGuiToolStripMenuItem.Text = "NoGui"
        '
        'VMStopToolStripMenuItem
        '
        Me.VMStopToolStripMenuItem.Name = "VMStopToolStripMenuItem"
        Me.VMStopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMStopToolStripMenuItem.Text = "Stop"
        '
        'VMPerformanceToolStripMenuItem
        '
        Me.VMPerformanceToolStripMenuItem.Name = "VMPerformanceToolStripMenuItem"
        Me.VMPerformanceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMPerformanceToolStripMenuItem.Text = "Performance"
        '
        'FormMaxToolStripMenuItem
        '
        Me.FormMaxToolStripMenuItem.Name = "FormMaxToolStripMenuItem"
        Me.FormMaxToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.FormMaxToolStripMenuItem.Text = "Maximieren"
        '
        'FormCloseToolStripMenuItem
        '
        Me.FormCloseToolStripMenuItem.Name = "FormCloseToolStripMenuItem"
        Me.FormCloseToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.FormCloseToolStripMenuItem.Text = "Beenden"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 90)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPerformance)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.dgMachines)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Virtual Box Control"
        CType(Me.dgMachines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.NotifyMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgMachines As System.Windows.Forms.DataGridView
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnPerformance As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents rdVRDP As System.Windows.Forms.RadioButton
    Friend WithEvents rdSDL As System.Windows.Forms.RadioButton
    Friend WithEvents rdHEADLESS As System.Windows.Forms.RadioButton
    Friend WithEvents rdGUI As System.Windows.Forms.RadioButton
    Friend WithEvents rdNoGui As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblSTATUS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSplit1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblOS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSplit2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblIP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblRAM As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotifyMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FormMaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStartGUIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStartHeadlessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStartSdlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStartVrdpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMStartNoGuiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMPerformanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
