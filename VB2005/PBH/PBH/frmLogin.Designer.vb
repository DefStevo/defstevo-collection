<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents lblPass As System.Windows.Forms.Label
  Friend WithEvents txtUser As System.Windows.Forms.TextBox
  Friend WithEvents txtPass As System.Windows.Forms.TextBox
  Friend WithEvents OK As System.Windows.Forms.Button
  Friend WithEvents Cancel As System.Windows.Forms.Button

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox
    Me.lblUser = New System.Windows.Forms.Label
    Me.lblPass = New System.Windows.Forms.Label
    Me.txtUser = New System.Windows.Forms.TextBox
    Me.txtPass = New System.Windows.Forms.TextBox
    Me.OK = New System.Windows.Forms.Button
    Me.Cancel = New System.Windows.Forms.Button
    Me.txtDB = New System.Windows.Forms.TextBox
    Me.lblDB = New System.Windows.Forms.Label
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
    Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
    Me.LogoPictureBox.TabIndex = 0
    Me.LogoPictureBox.TabStop = False
    '
    'lblUser
    '
    Me.lblUser.Location = New System.Drawing.Point(171, 0)
    Me.lblUser.Name = "lblUser"
    Me.lblUser.Size = New System.Drawing.Size(220, 23)
    Me.lblUser.TabIndex = 0
    Me.lblUser.Text = "&Benutzername"
    Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblPass
    '
    Me.lblPass.Location = New System.Drawing.Point(171, 49)
    Me.lblPass.Name = "lblPass"
    Me.lblPass.Size = New System.Drawing.Size(220, 18)
    Me.lblPass.TabIndex = 2
    Me.lblPass.Text = "&Kennwort"
    Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtUser
    '
    Me.txtUser.Location = New System.Drawing.Point(174, 26)
    Me.txtUser.Name = "txtUser"
    Me.txtUser.Size = New System.Drawing.Size(220, 20)
    Me.txtUser.TabIndex = 1
    '
    'txtPass
    '
    Me.txtPass.Location = New System.Drawing.Point(174, 70)
    Me.txtPass.Name = "txtPass"
    Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPass.Size = New System.Drawing.Size(220, 20)
    Me.txtPass.TabIndex = 3
    '
    'OK
    '
    Me.OK.Location = New System.Drawing.Point(174, 145)
    Me.OK.Name = "OK"
    Me.OK.Size = New System.Drawing.Size(94, 23)
    Me.OK.TabIndex = 4
    Me.OK.Text = "&OK"
    '
    'Cancel
    '
    Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel.Location = New System.Drawing.Point(300, 145)
    Me.Cancel.Name = "Cancel"
    Me.Cancel.Size = New System.Drawing.Size(94, 23)
    Me.Cancel.TabIndex = 5
    Me.Cancel.Text = "&Abbrechen"
    '
    'txtDB
    '
    Me.txtDB.Enabled = False
    Me.txtDB.Location = New System.Drawing.Point(174, 119)
    Me.txtDB.Name = "txtDB"
    Me.txtDB.Size = New System.Drawing.Size(220, 20)
    Me.txtDB.TabIndex = 7
    '
    'lblDB
    '
    Me.lblDB.Location = New System.Drawing.Point(171, 93)
    Me.lblDB.Name = "lblDB"
    Me.lblDB.Size = New System.Drawing.Size(220, 23)
    Me.lblDB.TabIndex = 6
    Me.lblDB.Text = "&Datenbank"
    Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'frmLogin
    '
    Me.AcceptButton = Me.OK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel
    Me.ClientSize = New System.Drawing.Size(401, 175)
    Me.Controls.Add(Me.txtDB)
    Me.Controls.Add(Me.lblDB)
    Me.Controls.Add(Me.Cancel)
    Me.Controls.Add(Me.OK)
    Me.Controls.Add(Me.txtPass)
    Me.Controls.Add(Me.txtUser)
    Me.Controls.Add(Me.lblPass)
    Me.Controls.Add(Me.lblUser)
    Me.Controls.Add(Me.LogoPictureBox)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmLogin"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "PBH2007 - Anmeldung"
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtDB As System.Windows.Forms.TextBox
  Friend WithEvents lblDB As System.Windows.Forms.Label

End Class
