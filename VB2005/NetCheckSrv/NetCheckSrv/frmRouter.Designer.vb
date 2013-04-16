<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRouter
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtName = New System.Windows.Forms.TextBox
    Me.txtIP = New System.Windows.Forms.TextBox
    Me.btnSpeichern = New System.Windows.Forms.Button
    Me.txtGateway = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(38, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Name:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 35)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(20, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "IP:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 61)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(52, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Gateway:"
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(70, 6)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(129, 20)
    Me.txtName.TabIndex = 0
    '
    'txtIP
    '
    Me.txtIP.Location = New System.Drawing.Point(70, 32)
    Me.txtIP.Name = "txtIP"
    Me.txtIP.Size = New System.Drawing.Size(129, 20)
    Me.txtIP.TabIndex = 1
    '
    'btnSpeichern
    '
    Me.btnSpeichern.Location = New System.Drawing.Point(14, 90)
    Me.btnSpeichern.Name = "btnSpeichern"
    Me.btnSpeichern.Size = New System.Drawing.Size(185, 38)
    Me.btnSpeichern.TabIndex = 3
    Me.btnSpeichern.Text = "&Speichern"
    Me.btnSpeichern.UseVisualStyleBackColor = True
    '
    'txtGateway
    '
    Me.txtGateway.Location = New System.Drawing.Point(70, 58)
    Me.txtGateway.Name = "txtGateway"
    Me.txtGateway.Size = New System.Drawing.Size(129, 20)
    Me.txtGateway.TabIndex = 2
    '
    'frmRouter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(214, 135)
    Me.Controls.Add(Me.txtGateway)
    Me.Controls.Add(Me.btnSpeichern)
    Me.Controls.Add(Me.txtIP)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmRouter"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Router"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents txtIP As System.Windows.Forms.TextBox
  Friend WithEvents btnSpeichern As System.Windows.Forms.Button
  Friend WithEvents txtGateway As System.Windows.Forms.TextBox
End Class
