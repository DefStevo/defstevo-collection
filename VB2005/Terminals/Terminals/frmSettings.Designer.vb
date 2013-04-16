<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.grpBase = New System.Windows.Forms.GroupBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.grpDisplay = New System.Windows.Forms.GroupBox
        Me.lblResolution = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbResolution = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.grpBase.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        CType(Me.tbResolution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(15, 376)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(135, 30)
        Me.btnConnect.TabIndex = 9
        Me.btnConnect.Text = "&Verbindung herstellen"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(336, 376)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 30)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "B&eenden"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(174, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 30)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Speichern"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpBase
        '
        Me.grpBase.Controls.Add(Me.txtPort)
        Me.grpBase.Controls.Add(Me.Label4)
        Me.grpBase.Controls.Add(Me.Label3)
        Me.grpBase.Controls.Add(Me.Label2)
        Me.grpBase.Controls.Add(Me.txtPass)
        Me.grpBase.Controls.Add(Me.txtUser)
        Me.grpBase.Controls.Add(Me.Label1)
        Me.grpBase.Controls.Add(Me.txtServer)
        Me.grpBase.Location = New System.Drawing.Point(15, 12)
        Me.grpBase.Name = "grpBase"
        Me.grpBase.Size = New System.Drawing.Size(456, 101)
        Me.grpBase.TabIndex = 12
        Me.grpBase.TabStop = False
        Me.grpBase.Text = "Allgemein"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(345, 19)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(105, 20)
        Me.txtPort.TabIndex = 16
        Me.txtPort.Text = "3389"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Kennwort:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Benutzername:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(89, 71)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(206, 20)
        Me.txtPass.TabIndex = 12
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(89, 45)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(206, 20)
        Me.txtUser.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Server:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(89, 19)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(206, 20)
        Me.txtServer.TabIndex = 9
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lblResolution)
        Me.grpDisplay.Controls.Add(Me.Label6)
        Me.grpDisplay.Controls.Add(Me.Label5)
        Me.grpDisplay.Controls.Add(Me.tbResolution)
        Me.grpDisplay.Controls.Add(Me.Label8)
        Me.grpDisplay.Location = New System.Drawing.Point(15, 130)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(456, 192)
        Me.grpDisplay.TabIndex = 17
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Anzeige"
        '
        'lblResolution
        '
        Me.lblResolution.Location = New System.Drawing.Point(123, 58)
        Me.lblResolution.Name = "lblResolution"
        Me.lblResolution.Size = New System.Drawing.Size(169, 13)
        Me.lblResolution.TabIndex = 14
        Me.lblResolution.Text = "XXX"
        Me.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Vollbild"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "640x480"
        '
        'tbResolution
        '
        Me.tbResolution.AutoSize = False
        Me.tbResolution.Location = New System.Drawing.Point(126, 26)
        Me.tbResolution.Maximum = 5
        Me.tbResolution.Name = "tbResolution"
        Me.tbResolution.Size = New System.Drawing.Size(169, 29)
        Me.tbResolution.TabIndex = 11
        Me.tbResolution.Value = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Auflösung:"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(487, 418)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.grpBase)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConnect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Verbindung herstellen"
        Me.grpBase.ResumeLayout(False)
        Me.grpBase.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        CType(Me.tbResolution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpBase As System.Windows.Forms.GroupBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents grpDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbResolution As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblResolution As System.Windows.Forms.Label
End Class
