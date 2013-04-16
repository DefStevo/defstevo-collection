Public Partial Class VCRScreen
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Line2 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.frameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblBrand = New System.Windows.Forms.Label
        Me.imgTapeSlot = New System.Windows.Forms.PictureBox
        Me.cmdSet = New System.Windows.Forms.Button
        Me.cmdDown = New System.Windows.Forms.Button
        Me.cmdUp = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdPause = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdRec = New System.Windows.Forms.Button
        Me.cmdForward = New System.Windows.Forms.Button
        Me.cmdRewind = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.cmdPlay = New System.Windows.Forms.Button
        Me.lblChannel = New System.Windows.Forms.Label
        Me.picTV = New System.Windows.Forms.PictureBox
        CType(Me.imgTapeSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Line2.Location = New System.Drawing.Point(1, 326)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(472, 1)
        Me.Line2.TabIndex = 38
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.White
        Me.Line1.Location = New System.Drawing.Point(1, 329)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(472, 1)
        Me.Line1.TabIndex = 39
        '
        'tmr1
        '
        Me.tmr1.Enabled = True
        Me.tmr1.Interval = 1000
        '
        'frameTimer
        '
        Me.frameTimer.Enabled = True
        Me.frameTimer.Interval = 500
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(33, 343)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(129, 41)
        Me.lblTime.TabIndex = 36
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBrand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(209, 359)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBrand.Size = New System.Drawing.Size(208, 25)
        Me.lblBrand.TabIndex = 33
        Me.lblBrand.Text = "Microsoft Visual Basic VCR - Version 1.0"
        '
        'imgTapeSlot
        '
        Me.imgTapeSlot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgTapeSlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTapeSlot.Location = New System.Drawing.Point(177, 343)
        Me.imgTapeSlot.Name = "imgTapeSlot"
        Me.imgTapeSlot.Size = New System.Drawing.Size(281, 49)
        Me.imgTapeSlot.TabIndex = 47
        Me.imgTapeSlot.TabStop = False
        '
        'cmdSet
        '
        Me.cmdSet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSet.Location = New System.Drawing.Point(305, 415)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSet.Size = New System.Drawing.Size(57, 24)
        Me.cmdSet.TabIndex = 37
        Me.cmdSet.Text = "Set"
        Me.ToolTip1.SetToolTip(Me.cmdSet, "Set the Timer for Recording")
        '
        'cmdDown
        '
        Me.cmdDown.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDown.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDown.Location = New System.Drawing.Point(409, 111)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDown.Size = New System.Drawing.Size(56, 22)
        Me.cmdDown.TabIndex = 35
        Me.cmdDown.Text = "Down"
        Me.ToolTip1.SetToolTip(Me.cmdDown, "Channel selector")
        '
        'cmdUp
        '
        Me.cmdUp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUp.Location = New System.Drawing.Point(409, 87)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUp.Size = New System.Drawing.Size(56, 22)
        Me.cmdUp.TabIndex = 34
        Me.cmdUp.Text = "Up"
        Me.ToolTip1.SetToolTip(Me.cmdUp, "Channel selector")
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(385, 415)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(73, 24)
        Me.cmdExit.TabIndex = 31
        Me.cmdExit.Text = "Eject"
        Me.ToolTip1.SetToolTip(Me.cmdExit, "Exit VBTV")
        '
        'cmdPause
        '
        Me.cmdPause.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPause.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPause.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPause.Location = New System.Drawing.Point(68, 415)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPause.Size = New System.Drawing.Size(41, 24)
        Me.cmdPause.TabIndex = 30
        Me.cmdPause.Text = "ll"
        Me.ToolTip1.SetToolTip(Me.cmdPause, "Pause")
        '
        'cmdRec
        '
        Me.cmdRec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRec.Location = New System.Drawing.Point(111, 415)
        Me.cmdRec.Name = "cmdRec"
        Me.cmdRec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRec.Size = New System.Drawing.Size(41, 24)
        Me.cmdRec.TabIndex = 29
        Me.cmdRec.Text = "Rec"
        Me.ToolTip1.SetToolTip(Me.cmdRec, "Record")
        '
        'cmdForward
        '
        Me.cmdForward.BackColor = System.Drawing.SystemColors.Control
        Me.cmdForward.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdForward.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdForward.Location = New System.Drawing.Point(198, 415)
        Me.cmdForward.Name = "cmdForward"
        Me.cmdForward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdForward.Size = New System.Drawing.Size(41, 24)
        Me.cmdForward.TabIndex = 28
        Me.cmdForward.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.cmdForward, "Fast Forward")
        '
        'cmdRewind
        '
        Me.cmdRewind.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRewind.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRewind.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRewind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRewind.Location = New System.Drawing.Point(155, 415)
        Me.cmdRewind.Name = "cmdRewind"
        Me.cmdRewind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRewind.Size = New System.Drawing.Size(41, 24)
        Me.cmdRewind.TabIndex = 27
        Me.cmdRewind.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.cmdRewind, "Rewind")
        '
        'cmdStop
        '
        Me.cmdStop.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStop.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStop.Location = New System.Drawing.Point(241, 415)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStop.Size = New System.Drawing.Size(41, 24)
        Me.cmdStop.TabIndex = 26
        Me.cmdStop.Text = "Stop"
        Me.ToolTip1.SetToolTip(Me.cmdStop, "Stop")
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlay.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPlay.Location = New System.Drawing.Point(25, 415)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPlay.Size = New System.Drawing.Size(41, 24)
        Me.cmdPlay.TabIndex = 24
        Me.cmdPlay.Text = ">"
        Me.ToolTip1.SetToolTip(Me.cmdPlay, "Play")
        '
        'lblChannel
        '
        Me.lblChannel.BackColor = System.Drawing.Color.Transparent
        Me.lblChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChannel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChannel.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannel.ForeColor = System.Drawing.Color.Lime
        Me.lblChannel.Location = New System.Drawing.Point(409, 31)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChannel.Size = New System.Drawing.Size(56, 41)
        Me.lblChannel.TabIndex = 32
        Me.lblChannel.Text = "3"
        Me.lblChannel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.lblChannel, "Channel display")
        '
        'picTV
        '
        Me.picTV.BackColor = System.Drawing.Color.Silver
        Me.picTV.Cursor = System.Windows.Forms.Cursors.Default
        Me.picTV.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picTV.ForeColor = System.Drawing.Color.White
        Me.picTV.Location = New System.Drawing.Point(25, 31)
        Me.picTV.Name = "picTV"
        Me.picTV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picTV.Size = New System.Drawing.Size(369, 281)
        Me.picTV.TabIndex = 25
        Me.picTV.TabStop = False
        '
        'VCRScreen
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(474, 451)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.imgTapeSlot)
        Me.Controls.Add(Me.cmdSet)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdRec)
        Me.Controls.Add(Me.cmdForward)
        Me.Controls.Add(Me.cmdRewind)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.picTV)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.lblChannel)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Name = "VCRScreen"
        Me.Text = "VBTV"
        CType(Me.imgTapeSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents frameTimer As System.Windows.Forms.Timer
    Public WithEvents lblTime As System.Windows.Forms.Label
    Public WithEvents lblBrand As System.Windows.Forms.Label
    Public WithEvents imgTapeSlot As System.Windows.Forms.PictureBox
    Public WithEvents cmdSet As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdDown As System.Windows.Forms.Button
    Public WithEvents cmdUp As System.Windows.Forms.Button
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdPause As System.Windows.Forms.Button
    Public WithEvents cmdRec As System.Windows.Forms.Button
    Public WithEvents cmdForward As System.Windows.Forms.Button
    Public WithEvents cmdRewind As System.Windows.Forms.Button
    Public WithEvents cmdStop As System.Windows.Forms.Button
    Public WithEvents cmdPlay As System.Windows.Forms.Button
    Public WithEvents lblChannel As System.Windows.Forms.Label
    Public WithEvents picTV As System.Windows.Forms.PictureBox
End Class
