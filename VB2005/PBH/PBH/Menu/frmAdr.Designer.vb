<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdr
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
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.TextBox2 = New System.Windows.Forms.TextBox
    Me.TextBox3 = New System.Windows.Forms.TextBox
    Me.ComboBox1 = New System.Windows.Forms.ComboBox
    Me.ComboBox2 = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.TextBox4 = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(71, 15)
    Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(137, 16)
    Me.TextBox1.TabIndex = 0
    '
    'TextBox2
    '
    Me.TextBox2.Location = New System.Drawing.Point(71, 39)
    Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox2.Multiline = True
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(137, 16)
    Me.TextBox2.TabIndex = 1
    '
    'TextBox3
    '
    Me.TextBox3.Location = New System.Drawing.Point(71, 139)
    Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox3.Multiline = True
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(179, 79)
    Me.TextBox3.TabIndex = 2
    '
    'ComboBox1
    '
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(71, 94)
    Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(137, 24)
    Me.ComboBox1.TabIndex = 3
    '
    'ComboBox2
    '
    Me.ComboBox2.FormattingEnabled = True
    Me.ComboBox2.Location = New System.Drawing.Point(189, 94)
    Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ComboBox2.Name = "ComboBox2"
    Me.ComboBox2.Size = New System.Drawing.Size(137, 24)
    Me.ComboBox2.TabIndex = 4
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 16)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Adr-Nr"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 39)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(41, 16)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Adr-Nr"
    '
    'TextBox4
    '
    Me.TextBox4.Location = New System.Drawing.Point(155, 126)
    Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox4.Multiline = True
    Me.TextBox4.Name = "TextBox4"
    Me.TextBox4.Size = New System.Drawing.Size(137, 16)
    Me.TextBox4.TabIndex = 7
    '
    'frmAdr
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(341, 336)
    Me.Controls.Add(Me.TextBox4)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBox2)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.TextBox3)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.TextBox1)
    Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmAdr"
    Me.Text = "Adressenverwaltung"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
