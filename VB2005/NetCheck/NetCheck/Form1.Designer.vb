<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPing
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
    Me.txtHost = New System.Windows.Forms.TextBox
    Me.Button1 = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtResultat = New System.Windows.Forms.TextBox
    Me.txtAnzahl = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtTimeout = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'txtHost
    '
    Me.txtHost.Location = New System.Drawing.Point(38, 6)
    Me.txtHost.Name = "txtHost"
    Me.txtHost.Size = New System.Drawing.Size(156, 20)
    Me.txtHost.TabIndex = 0
    Me.txtHost.Text = "www.google.at"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(6, 32)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(188, 32)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Ping"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Host"
    '
    'txtResultat
    '
    Me.txtResultat.Location = New System.Drawing.Point(6, 70)
    Me.txtResultat.Multiline = True
    Me.txtResultat.Name = "txtResultat"
    Me.txtResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtResultat.Size = New System.Drawing.Size(334, 150)
    Me.txtResultat.TabIndex = 3
    '
    'txtAnzahl
    '
    Me.txtAnzahl.Location = New System.Drawing.Point(284, 6)
    Me.txtAnzahl.Name = "txtAnzahl"
    Me.txtAnzahl.Size = New System.Drawing.Size(56, 20)
    Me.txtAnzahl.TabIndex = 4
    Me.txtAnzahl.Text = "10"
    Me.txtAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(200, 9)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(39, 13)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Anzahl"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(200, 36)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(78, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Timeout (in ms)"
    '
    'txtTimeout
    '
    Me.txtTimeout.Enabled = False
    Me.txtTimeout.Location = New System.Drawing.Point(284, 36)
    Me.txtTimeout.Name = "txtTimeout"
    Me.txtTimeout.Size = New System.Drawing.Size(56, 20)
    Me.txtTimeout.TabIndex = 7
    Me.txtTimeout.Text = "500"
    Me.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'frmPing
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(350, 226)
    Me.Controls.Add(Me.txtTimeout)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtAnzahl)
    Me.Controls.Add(Me.txtResultat)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.txtHost)
    Me.Name = "frmPing"
    Me.Text = "Ping"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtHost As System.Windows.Forms.TextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtResultat As System.Windows.Forms.TextBox
  Friend WithEvents txtAnzahl As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtTimeout As System.Windows.Forms.TextBox

End Class
