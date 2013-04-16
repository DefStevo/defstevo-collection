<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKto
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKto))
    Me.TextBox2 = New System.Windows.Forms.TextBox
    Me.TextBox3 = New System.Windows.Forms.TextBox
    Me.ComboBox1 = New System.Windows.Forms.ComboBox
    Me.ComboBox2 = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.TextBox4 = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.ttMenü = New System.Windows.Forms.ToolStrip
    Me.btnNeu = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnSpeichern = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnSuchen = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEnde = New System.Windows.Forms.ToolStripButton
    Me.btnListe = New System.Windows.Forms.Button
    Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
    Me.ttMenü.SuspendLayout()
    Me.SuspendLayout()
    '
    'TextBox2
    '
    Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox2.Location = New System.Drawing.Point(60, 57)
    Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox2.MaxLength = 38
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(236, 21)
    Me.TextBox2.TabIndex = 1
    Me.TextBox2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'TextBox3
    '
    Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox3.Location = New System.Drawing.Point(60, 107)
    Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox3.MaxLength = 296
    Me.TextBox3.Multiline = True
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(236, 112)
    Me.TextBox3.TabIndex = 2
    Me.TextBox3.Text = resources.GetString("TextBox3.Text")
    '
    'ComboBox1
    '
    Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Items.AddRange(New Object() {"Einnahmen", "Ausgaben"})
    Me.ComboBox1.Location = New System.Drawing.Point(60, 82)
    Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(85, 21)
    Me.ComboBox1.TabIndex = 3
    '
    'ComboBox2
    '
    Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBox2.FormattingEnabled = True
    Me.ComboBox2.Items.AddRange(New Object() {"Aktiv", "Inaktiv"})
    Me.ComboBox2.Location = New System.Drawing.Point(203, 82)
    Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.ComboBox2.Name = "ComboBox2"
    Me.ComboBox2.Size = New System.Drawing.Size(93, 21)
    Me.ComboBox2.TabIndex = 4
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(8, 36)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Nummer"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(8, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(34, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Name"
    '
    'TextBox4
    '
    Me.TextBox4.Enabled = False
    Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox4.Location = New System.Drawing.Point(203, 32)
    Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.TextBox4.Name = "TextBox4"
    Me.TextBox4.Size = New System.Drawing.Size(68, 21)
    Me.TextBox4.TabIndex = 7
    Me.TextBox4.Text = "00.000,00 €"
    Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(8, 84)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(22, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Art"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(164, 85)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(38, 13)
    Me.Label4.TabIndex = 9
    Me.Label4.Text = "Status"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(164, 36)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(33, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "Saldo"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(8, 110)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(35, 13)
    Me.Label6.TabIndex = 11
    Me.Label6.Text = "Memo"
    '
    'ttMenü
    '
    Me.ttMenü.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNeu, Me.ToolStripSeparator1, Me.btnSpeichern, Me.ToolStripSeparator2, Me.btnSuchen, Me.ToolStripSeparator3, Me.btnEnde})
    Me.ttMenü.Location = New System.Drawing.Point(0, 0)
    Me.ttMenü.Name = "ttMenü"
    Me.ttMenü.Size = New System.Drawing.Size(305, 25)
    Me.ttMenü.TabIndex = 12
    Me.ttMenü.Text = "ToolStrip1"
    '
    'btnNeu
    '
    Me.btnNeu.Image = Global.PBH.My.Resources.Resources.Neu
    Me.btnNeu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnNeu.ImageTransparentColor = System.Drawing.Color.Lime
    Me.btnNeu.Name = "btnNeu"
    Me.btnNeu.Size = New System.Drawing.Size(46, 22)
    Me.btnNeu.Text = "Neu"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnSpeichern
    '
    Me.btnSpeichern.Image = Global.PBH.My.Resources.Resources.Speichern
    Me.btnSpeichern.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnSpeichern.ImageTransparentColor = System.Drawing.Color.Lime
    Me.btnSpeichern.Name = "btnSpeichern"
    Me.btnSpeichern.Size = New System.Drawing.Size(74, 22)
    Me.btnSpeichern.Text = "Speichern"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnSuchen
    '
    Me.btnSuchen.Image = Global.PBH.My.Resources.Resources.Suchen
    Me.btnSuchen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnSuchen.ImageTransparentColor = System.Drawing.Color.Lime
    Me.btnSuchen.Name = "btnSuchen"
    Me.btnSuchen.Size = New System.Drawing.Size(62, 22)
    Me.btnSuchen.Text = "Suchen"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
    '
    'btnEnde
    '
    Me.btnEnde.Image = Global.PBH.My.Resources.Resources.Beenden
    Me.btnEnde.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnEnde.ImageTransparentColor = System.Drawing.Color.Lime
    Me.btnEnde.Name = "btnEnde"
    Me.btnEnde.Size = New System.Drawing.Size(69, 22)
    Me.btnEnde.Text = "Beenden"
    '
    'btnListe
    '
    Me.btnListe.Enabled = False
    Me.btnListe.Location = New System.Drawing.Point(270, 32)
    Me.btnListe.Name = "btnListe"
    Me.btnListe.Size = New System.Drawing.Size(26, 21)
    Me.btnListe.TabIndex = 13
    Me.btnListe.Text = "..."
    Me.btnListe.UseVisualStyleBackColor = True
    '
    'MaskedTextBox1
    '
    Me.MaskedTextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MaskedTextBox1.Location = New System.Drawing.Point(60, 32)
    Me.MaskedTextBox1.Mask = "0000"
    Me.MaskedTextBox1.Name = "MaskedTextBox1"
    Me.MaskedTextBox1.Size = New System.Drawing.Size(85, 21)
    Me.MaskedTextBox1.TabIndex = 14
    Me.MaskedTextBox1.Text = "0000"
    '
    'frmKto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.ClientSize = New System.Drawing.Size(305, 224)
    Me.Controls.Add(Me.MaskedTextBox1)
    Me.Controls.Add(Me.btnListe)
    Me.Controls.Add(Me.ttMenü)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.TextBox4)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBox2)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.TextBox3)
    Me.Controls.Add(Me.TextBox2)
    Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "frmKto"
    Me.Text = "Kontoverwaltung"
    Me.ttMenü.ResumeLayout(False)
    Me.ttMenü.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents ttMenü As System.Windows.Forms.ToolStrip
  Friend WithEvents btnNeu As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnSpeichern As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnSuchen As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnEnde As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnListe As System.Windows.Forms.Button
  Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
