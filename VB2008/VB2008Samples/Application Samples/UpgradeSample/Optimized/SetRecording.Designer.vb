Public Partial Class SetRecording
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
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.lblCaption_2 = New System.Windows.Forms.Label
        Me.lblCaption_1 = New System.Windows.Forms.Label
        Me.lblCaption_0 = New System.Windows.Forms.Label
        Me.txtChannel = New System.Windows.Forms.TextBox
        Me.txtEnd = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtStart = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.CausesValidation = False
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(273, 120)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(273, 72)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(81, 33)
        Me.cmdOK.TabIndex = 14
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'lblCaption_2
        '
        Me.lblCaption_2.BackColor = System.Drawing.SystemColors.Control
        Me.lblCaption_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCaption_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaption_2.Location = New System.Drawing.Point(49, 176)
        Me.lblCaption_2.Name = "lblCaption_2"
        Me.lblCaption_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCaption_2.Size = New System.Drawing.Size(73, 17)
        Me.lblCaption_2.TabIndex = 10
        Me.lblCaption_2.Text = "Channel"
        Me.lblCaption_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCaption_1
        '
        Me.lblCaption_1.BackColor = System.Drawing.SystemColors.Control
        Me.lblCaption_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCaption_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaption_1.Location = New System.Drawing.Point(49, 128)
        Me.lblCaption_1.Name = "lblCaption_1"
        Me.lblCaption_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCaption_1.Size = New System.Drawing.Size(73, 17)
        Me.lblCaption_1.TabIndex = 9
        Me.lblCaption_1.Text = "End Time"
        Me.lblCaption_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCaption_0
        '
        Me.lblCaption_0.BackColor = System.Drawing.SystemColors.Control
        Me.lblCaption_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCaption_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaption_0.Location = New System.Drawing.Point(49, 80)
        Me.lblCaption_0.Name = "lblCaption_0"
        Me.lblCaption_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCaption_0.Size = New System.Drawing.Size(73, 17)
        Me.lblCaption_0.TabIndex = 8
        Me.lblCaption_0.Text = "Start Time"
        Me.lblCaption_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtChannel
        '
        Me.txtChannel.AcceptsReturn = True
        Me.txtChannel.AutoSize = False
        Me.txtChannel.BackColor = System.Drawing.SystemColors.Window
        Me.txtChannel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChannel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChannel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChannel.Location = New System.Drawing.Point(129, 168)
        Me.txtChannel.MaxLength = 0
        Me.txtChannel.Name = "txtChannel"
        Me.txtChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChannel.Size = New System.Drawing.Size(41, 25)
        Me.txtChannel.TabIndex = 13
        Me.txtChannel.Text = "3"
        Me.ToolTip1.SetToolTip(Me.txtChannel, "Enter the channel to record")
        '
        'txtEnd
        '
        Me.txtEnd.AcceptsReturn = True
        Me.txtEnd.AutoSize = False
        Me.txtEnd.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnd.Location = New System.Drawing.Point(129, 120)
        Me.txtEnd.MaxLength = 0
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnd.Size = New System.Drawing.Size(81, 25)
        Me.txtEnd.TabIndex = 12
        Me.txtEnd.Text = "12:30 AM"
        Me.ToolTip1.SetToolTip(Me.txtEnd, "Enter the time to stop recording")
        '
        'txtStart
        '
        Me.txtStart.AcceptsReturn = True
        Me.txtStart.AutoSize = False
        Me.txtStart.BackColor = System.Drawing.SystemColors.Window
        Me.txtStart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStart.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStart.Location = New System.Drawing.Point(129, 72)
        Me.txtStart.MaxLength = 0
        Me.txtStart.Name = "txtStart"
        Me.txtStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStart.Size = New System.Drawing.Size(81, 25)
        Me.txtStart.TabIndex = 11
        Me.txtStart.Text = "12:00 AM"
        Me.ToolTip1.SetToolTip(Me.txtStart, "Enter the time to start  recording")
        '
        'SetRecording
        '
        Me.ClientSize = New System.Drawing.Size(403, 265)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblCaption_2)
        Me.Controls.Add(Me.lblCaption_1)
        Me.Controls.Add(Me.lblCaption_0)
        Me.Controls.Add(Me.txtChannel)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.cmdCancel)
        Me.Name = "SetRecording"
        Me.Text = "SetRecording"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents lblCaption_2 As System.Windows.Forms.Label
    Public WithEvents lblCaption_1 As System.Windows.Forms.Label
    Public WithEvents lblCaption_0 As System.Windows.Forms.Label
    Public WithEvents txtChannel As System.Windows.Forms.TextBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtEnd As System.Windows.Forms.TextBox
    Public WithEvents txtStart As System.Windows.Forms.TextBox
End Class
