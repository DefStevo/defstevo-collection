<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdrKto
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdrKto))
    Me.txtName = New System.Windows.Forms.TextBox
    Me.txtMemo = New System.Windows.Forms.TextBox
    Me.txtStatus = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtSaldo = New System.Windows.Forms.TextBox
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
    Me.btnBuchungen = New System.Windows.Forms.Button
    Me.txtNr = New System.Windows.Forms.TextBox
    Me.cbBestand = New System.Windows.Forms.CheckBox
    Me.ttMenü.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtName
    '
    Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtName.Location = New System.Drawing.Point(55, 58)
    Me.txtName.MaxLength = 38
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(239, 21)
    Me.txtName.TabIndex = 2
    Me.txtName.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'txtMemo
    '
    Me.txtMemo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMemo.Location = New System.Drawing.Point(55, 112)
    Me.txtMemo.MaxLength = 296
    Me.txtMemo.Multiline = True
    Me.txtMemo.Name = "txtMemo"
    Me.txtMemo.Size = New System.Drawing.Size(239, 112)
    Me.txtMemo.TabIndex = 5
    Me.txtMemo.Text = resources.GetString("txtMemo.Text")
    '
    'txtStatus
    '
    Me.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtStatus.FormattingEnabled = True
    Me.txtStatus.Items.AddRange(New Object() {"", "Aktiv", "Inaktiv"})
    Me.txtStatus.Location = New System.Drawing.Point(55, 85)
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Size = New System.Drawing.Size(84, 21)
    Me.txtStatus.TabIndex = 4
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(3, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Nummer"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(3, 61)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(34, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Name"
    '
    'txtSaldo
    '
    Me.txtSaldo.Enabled = False
    Me.txtSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSaldo.Location = New System.Drawing.Point(184, 31)
    Me.txtSaldo.MaxLength = 12
    Me.txtSaldo.Name = "txtSaldo"
    Me.txtSaldo.Size = New System.Drawing.Size(73, 21)
    Me.txtSaldo.TabIndex = 7
    Me.txtSaldo.Text = "00.000,00 €"
    Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(3, 88)
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
    Me.Label5.Location = New System.Drawing.Point(145, 34)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(33, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "Saldo"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(3, 115)
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
    Me.ttMenü.Size = New System.Drawing.Size(300, 25)
    Me.ttMenü.TabIndex = 6
    Me.ttMenü.TabStop = True
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
    'btnBuchungen
    '
    Me.btnBuchungen.Enabled = False
    Me.btnBuchungen.Location = New System.Drawing.Point(263, 31)
    Me.btnBuchungen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.btnBuchungen.Name = "btnBuchungen"
    Me.btnBuchungen.Size = New System.Drawing.Size(31, 21)
    Me.btnBuchungen.TabIndex = 1
    Me.btnBuchungen.Text = "..."
    Me.btnBuchungen.UseVisualStyleBackColor = True
    '
    'txtNr
    '
    Me.txtNr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNr.Location = New System.Drawing.Point(55, 31)
    Me.txtNr.MaxLength = 4
    Me.txtNr.Name = "txtNr"
    Me.txtNr.Size = New System.Drawing.Size(84, 21)
    Me.txtNr.TabIndex = 0
    Me.txtNr.Text = "0000"
    Me.txtNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cbBestand
    '
    Me.cbBestand.AutoSize = True
    Me.cbBestand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbBestand.Location = New System.Drawing.Point(197, 87)
    Me.cbBestand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.cbBestand.Name = "cbBestand"
    Me.cbBestand.Size = New System.Drawing.Size(97, 17)
    Me.cbBestand.TabIndex = 14
    Me.cbBestand.Text = "Bestandskonto"
    Me.cbBestand.UseVisualStyleBackColor = True
    Me.cbBestand.Visible = False
    '
    'frmAdrKto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.ClientSize = New System.Drawing.Size(300, 230)
    Me.Controls.Add(Me.cbBestand)
    Me.Controls.Add(Me.txtNr)
    Me.Controls.Add(Me.btnBuchungen)
    Me.Controls.Add(Me.ttMenü)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtSaldo)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtStatus)
    Me.Controls.Add(Me.txtMemo)
    Me.Controls.Add(Me.txtName)
    Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmAdrKto"
    Me.Text = "Adressen/Kontoverwaltung"
    Me.ttMenü.ResumeLayout(False)
    Me.ttMenü.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents txtMemo As System.Windows.Forms.TextBox
  Friend WithEvents txtStatus As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
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
  Friend WithEvents btnBuchungen As System.Windows.Forms.Button
  Friend WithEvents txtNr As System.Windows.Forms.TextBox
  Friend WithEvents cbBestand As System.Windows.Forms.CheckBox
End Class
