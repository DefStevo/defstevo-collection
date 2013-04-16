<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbersicht
  Inherits System.Windows.Forms.Form

  'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.grpCPU = New System.Windows.Forms.GroupBox
    Me.txtCPUTyp = New System.Windows.Forms.TextBox
    Me.txtCPUTakt = New System.Windows.Forms.TextBox
    Me.lblCPUTakt = New System.Windows.Forms.Label
    Me.lblCPUSpann = New System.Windows.Forms.Label
    Me.txtCPUSpann = New System.Windows.Forms.TextBox
    Me.txtCPUFan = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblCPUTemp = New System.Windows.Forms.Label
    Me.txtCPUTemp = New System.Windows.Forms.TextBox
    Me.grpGPU = New System.Windows.Forms.GroupBox
    Me.txtGPUTakt = New System.Windows.Forms.TextBox
    Me.lblGPUTakt = New System.Windows.Forms.Label
    Me.lblGPUSpann = New System.Windows.Forms.Label
    Me.txtGPUSpann = New System.Windows.Forms.TextBox
    Me.txtGPUFan = New System.Windows.Forms.TextBox
    Me.lblGPUFan = New System.Windows.Forms.Label
    Me.lblGPUTemp = New System.Windows.Forms.Label
    Me.txtGPUTemp = New System.Windows.Forms.TextBox
    Me.grpCPU.SuspendLayout()
    Me.grpGPU.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpCPU
    '
    Me.grpCPU.Controls.Add(Me.txtCPUTyp)
    Me.grpCPU.Controls.Add(Me.txtCPUTakt)
    Me.grpCPU.Controls.Add(Me.lblCPUTakt)
    Me.grpCPU.Controls.Add(Me.lblCPUSpann)
    Me.grpCPU.Controls.Add(Me.txtCPUSpann)
    Me.grpCPU.Controls.Add(Me.txtCPUFan)
    Me.grpCPU.Controls.Add(Me.Label1)
    Me.grpCPU.Controls.Add(Me.lblCPUTemp)
    Me.grpCPU.Controls.Add(Me.txtCPUTemp)
    Me.grpCPU.Location = New System.Drawing.Point(12, 12)
    Me.grpCPU.Name = "grpCPU"
    Me.grpCPU.Size = New System.Drawing.Size(205, 155)
    Me.grpCPU.TabIndex = 0
    Me.grpCPU.TabStop = False
    Me.grpCPU.Text = "CPU-Informationen"
    '
    'txtCPUTyp
    '
    Me.txtCPUTyp.Enabled = False
    Me.txtCPUTyp.Location = New System.Drawing.Point(9, 19)
    Me.txtCPUTyp.Name = "txtCPUTyp"
    Me.txtCPUTyp.Size = New System.Drawing.Size(189, 20)
    Me.txtCPUTyp.TabIndex = 8
    Me.txtCPUTyp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtCPUTakt
    '
    Me.txtCPUTakt.Enabled = False
    Me.txtCPUTakt.Location = New System.Drawing.Point(99, 71)
    Me.txtCPUTakt.Name = "txtCPUTakt"
    Me.txtCPUTakt.Size = New System.Drawing.Size(100, 20)
    Me.txtCPUTakt.TabIndex = 7
    Me.txtCPUTakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblCPUTakt
    '
    Me.lblCPUTakt.AutoSize = True
    Me.lblCPUTakt.Location = New System.Drawing.Point(6, 74)
    Me.lblCPUTakt.Name = "lblCPUTakt"
    Me.lblCPUTakt.Size = New System.Drawing.Size(54, 13)
    Me.lblCPUTakt.TabIndex = 6
    Me.lblCPUTakt.Text = "CPU-Takt"
    '
    'lblCPUSpann
    '
    Me.lblCPUSpann.AutoSize = True
    Me.lblCPUSpann.Location = New System.Drawing.Point(6, 48)
    Me.lblCPUSpann.Name = "lblCPUSpann"
    Me.lblCPUSpann.Size = New System.Drawing.Size(81, 13)
    Me.lblCPUSpann.TabIndex = 5
    Me.lblCPUSpann.Text = "CPU-Spannung"
    '
    'txtCPUSpann
    '
    Me.txtCPUSpann.Enabled = False
    Me.txtCPUSpann.Location = New System.Drawing.Point(98, 45)
    Me.txtCPUSpann.Name = "txtCPUSpann"
    Me.txtCPUSpann.Size = New System.Drawing.Size(100, 20)
    Me.txtCPUSpann.TabIndex = 4
    '
    'txtCPUFan
    '
    Me.txtCPUFan.Enabled = False
    Me.txtCPUFan.Location = New System.Drawing.Point(99, 121)
    Me.txtCPUFan.Name = "txtCPUFan"
    Me.txtCPUFan.Size = New System.Drawing.Size(100, 20)
    Me.txtCPUFan.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 124)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(50, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "CPU-Fan"
    '
    'lblCPUTemp
    '
    Me.lblCPUTemp.AutoSize = True
    Me.lblCPUTemp.Location = New System.Drawing.Point(6, 98)
    Me.lblCPUTemp.Name = "lblCPUTemp"
    Me.lblCPUTemp.Size = New System.Drawing.Size(86, 13)
    Me.lblCPUTemp.TabIndex = 1
    Me.lblCPUTemp.Text = "CPU-Temperatur"
    '
    'txtCPUTemp
    '
    Me.txtCPUTemp.Enabled = False
    Me.txtCPUTemp.Location = New System.Drawing.Point(98, 95)
    Me.txtCPUTemp.Name = "txtCPUTemp"
    Me.txtCPUTemp.Size = New System.Drawing.Size(100, 20)
    Me.txtCPUTemp.TabIndex = 0
    '
    'grpGPU
    '
    Me.grpGPU.Controls.Add(Me.txtGPUTakt)
    Me.grpGPU.Controls.Add(Me.lblGPUTakt)
    Me.grpGPU.Controls.Add(Me.lblGPUSpann)
    Me.grpGPU.Controls.Add(Me.txtGPUSpann)
    Me.grpGPU.Controls.Add(Me.txtGPUFan)
    Me.grpGPU.Controls.Add(Me.lblGPUFan)
    Me.grpGPU.Controls.Add(Me.lblGPUTemp)
    Me.grpGPU.Controls.Add(Me.txtGPUTemp)
    Me.grpGPU.Location = New System.Drawing.Point(12, 173)
    Me.grpGPU.Name = "grpGPU"
    Me.grpGPU.Size = New System.Drawing.Size(205, 125)
    Me.grpGPU.TabIndex = 1
    Me.grpGPU.TabStop = False
    Me.grpGPU.Text = "GPU-Informationen"
    '
    'txtGPUTakt
    '
    Me.txtGPUTakt.Enabled = False
    Me.txtGPUTakt.Location = New System.Drawing.Point(99, 45)
    Me.txtGPUTakt.Name = "txtGPUTakt"
    Me.txtGPUTakt.Size = New System.Drawing.Size(100, 20)
    Me.txtGPUTakt.TabIndex = 7
    '
    'lblGPUTakt
    '
    Me.lblGPUTakt.AutoSize = True
    Me.lblGPUTakt.Location = New System.Drawing.Point(6, 48)
    Me.lblGPUTakt.Name = "lblGPUTakt"
    Me.lblGPUTakt.Size = New System.Drawing.Size(55, 13)
    Me.lblGPUTakt.TabIndex = 6
    Me.lblGPUTakt.Text = "GPU-Takt"
    '
    'lblGPUSpann
    '
    Me.lblGPUSpann.AutoSize = True
    Me.lblGPUSpann.Location = New System.Drawing.Point(6, 22)
    Me.lblGPUSpann.Name = "lblGPUSpann"
    Me.lblGPUSpann.Size = New System.Drawing.Size(82, 13)
    Me.lblGPUSpann.TabIndex = 5
    Me.lblGPUSpann.Text = "GPU-Spannung"
    '
    'txtGPUSpann
    '
    Me.txtGPUSpann.Enabled = False
    Me.txtGPUSpann.Location = New System.Drawing.Point(98, 19)
    Me.txtGPUSpann.Name = "txtGPUSpann"
    Me.txtGPUSpann.Size = New System.Drawing.Size(100, 20)
    Me.txtGPUSpann.TabIndex = 4
    '
    'txtGPUFan
    '
    Me.txtGPUFan.Enabled = False
    Me.txtGPUFan.Location = New System.Drawing.Point(99, 95)
    Me.txtGPUFan.Name = "txtGPUFan"
    Me.txtGPUFan.Size = New System.Drawing.Size(100, 20)
    Me.txtGPUFan.TabIndex = 3
    '
    'lblGPUFan
    '
    Me.lblGPUFan.AutoSize = True
    Me.lblGPUFan.Location = New System.Drawing.Point(6, 98)
    Me.lblGPUFan.Name = "lblGPUFan"
    Me.lblGPUFan.Size = New System.Drawing.Size(51, 13)
    Me.lblGPUFan.TabIndex = 2
    Me.lblGPUFan.Text = "GPU-Fan"
    '
    'lblGPUTemp
    '
    Me.lblGPUTemp.AutoSize = True
    Me.lblGPUTemp.Location = New System.Drawing.Point(6, 72)
    Me.lblGPUTemp.Name = "lblGPUTemp"
    Me.lblGPUTemp.Size = New System.Drawing.Size(87, 13)
    Me.lblGPUTemp.TabIndex = 1
    Me.lblGPUTemp.Text = "GPU-Temperatur"
    '
    'txtGPUTemp
    '
    Me.txtGPUTemp.Enabled = False
    Me.txtGPUTemp.Location = New System.Drawing.Point(98, 69)
    Me.txtGPUTemp.Name = "txtGPUTemp"
    Me.txtGPUTemp.Size = New System.Drawing.Size(100, 20)
    Me.txtGPUTemp.TabIndex = 0
    '
    'frmUbersicht
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(227, 310)
    Me.Controls.Add(Me.grpGPU)
    Me.Controls.Add(Me.grpCPU)
    Me.Name = "frmUbersicht"
    Me.Text = "CPU/GPU Übersicht"
    Me.grpCPU.ResumeLayout(False)
    Me.grpCPU.PerformLayout()
    Me.grpGPU.ResumeLayout(False)
    Me.grpGPU.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grpCPU As System.Windows.Forms.GroupBox
  Friend WithEvents txtCPUTakt As System.Windows.Forms.TextBox
  Friend WithEvents lblCPUTakt As System.Windows.Forms.Label
  Friend WithEvents lblCPUSpann As System.Windows.Forms.Label
  Friend WithEvents txtCPUSpann As System.Windows.Forms.TextBox
  Friend WithEvents txtCPUFan As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblCPUTemp As System.Windows.Forms.Label
  Friend WithEvents txtCPUTemp As System.Windows.Forms.TextBox
  Friend WithEvents grpGPU As System.Windows.Forms.GroupBox
  Friend WithEvents txtGPUTakt As System.Windows.Forms.TextBox
  Friend WithEvents lblGPUTakt As System.Windows.Forms.Label
  Friend WithEvents lblGPUSpann As System.Windows.Forms.Label
  Friend WithEvents txtGPUSpann As System.Windows.Forms.TextBox
  Friend WithEvents txtGPUFan As System.Windows.Forms.TextBox
  Friend WithEvents lblGPUFan As System.Windows.Forms.Label
  Friend WithEvents lblGPUTemp As System.Windows.Forms.Label
  Friend WithEvents txtGPUTemp As System.Windows.Forms.TextBox
  Friend WithEvents txtCPUTyp As System.Windows.Forms.TextBox

End Class
