<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEinst
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
    Me.grpStandard = New System.Windows.Forms.GroupBox
    Me.txtGegBestand = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtAdr = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtKto = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtBestand = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.ttMenü = New System.Windows.Forms.ToolStrip
    Me.btnSpeichern = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEnde = New System.Windows.Forms.ToolStripButton
    Me.grpStandard.SuspendLayout()
    Me.ttMenü.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpStandard
    '
    Me.grpStandard.Controls.Add(Me.txtGegBestand)
    Me.grpStandard.Controls.Add(Me.Label5)
    Me.grpStandard.Controls.Add(Me.txtAdr)
    Me.grpStandard.Controls.Add(Me.Label4)
    Me.grpStandard.Controls.Add(Me.txtKto)
    Me.grpStandard.Controls.Add(Me.Label3)
    Me.grpStandard.Controls.Add(Me.txtBestand)
    Me.grpStandard.Controls.Add(Me.Label2)
    Me.grpStandard.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpStandard.Location = New System.Drawing.Point(12, 28)
    Me.grpStandard.Name = "grpStandard"
    Me.grpStandard.Size = New System.Drawing.Size(211, 131)
    Me.grpStandard.TabIndex = 8
    Me.grpStandard.TabStop = False
    Me.grpStandard.Text = "Standardkonten"
    '
    'txtGegBestand
    '
    Me.txtGegBestand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtGegBestand.Location = New System.Drawing.Point(116, 102)
    Me.txtGegBestand.MaxLength = 4
    Me.txtGegBestand.Name = "txtGegBestand"
    Me.txtGegBestand.Size = New System.Drawing.Size(84, 21)
    Me.txtGegBestand.TabIndex = 14
    Me.txtGegBestand.Text = "0000"
    Me.txtGegBestand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(6, 105)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(107, 13)
    Me.Label5.TabIndex = 15
    Me.Label5.Text = "Bestand Gegenkonto"
    '
    'txtAdr
    '
    Me.txtAdr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdr.Location = New System.Drawing.Point(116, 75)
    Me.txtAdr.MaxLength = 4
    Me.txtAdr.Name = "txtAdr"
    Me.txtAdr.Size = New System.Drawing.Size(84, 21)
    Me.txtAdr.TabIndex = 12
    Me.txtAdr.Text = "0000"
    Me.txtAdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(6, 78)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(46, 13)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "Adresse"
    '
    'txtKto
    '
    Me.txtKto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtKto.Location = New System.Drawing.Point(116, 48)
    Me.txtKto.MaxLength = 4
    Me.txtKto.Name = "txtKto"
    Me.txtKto.Size = New System.Drawing.Size(84, 21)
    Me.txtKto.TabIndex = 10
    Me.txtKto.Text = "0000"
    Me.txtKto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(6, 51)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(65, 13)
    Me.Label3.TabIndex = 11
    Me.Label3.Text = "Gegenkonto"
    '
    'txtBestand
    '
    Me.txtBestand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBestand.Location = New System.Drawing.Point(116, 21)
    Me.txtBestand.MaxLength = 4
    Me.txtBestand.Name = "txtBestand"
    Me.txtBestand.Size = New System.Drawing.Size(84, 21)
    Me.txtBestand.TabIndex = 8
    Me.txtBestand.Text = "0000"
    Me.txtBestand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(6, 24)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 9
    Me.Label2.Text = "Bestand"
    '
    'ttMenü
    '
    Me.ttMenü.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSpeichern, Me.ToolStripSeparator2, Me.btnEnde})
    Me.ttMenü.Location = New System.Drawing.Point(0, 0)
    Me.ttMenü.Name = "ttMenü"
    Me.ttMenü.Size = New System.Drawing.Size(233, 25)
    Me.ttMenü.TabIndex = 9
    Me.ttMenü.TabStop = True
    Me.ttMenü.Text = "ToolStrip1"
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
    'btnEnde
    '
    Me.btnEnde.Image = Global.PBH.My.Resources.Resources.Beenden
    Me.btnEnde.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnEnde.ImageTransparentColor = System.Drawing.Color.Lime
    Me.btnEnde.Name = "btnEnde"
    Me.btnEnde.Size = New System.Drawing.Size(69, 22)
    Me.btnEnde.Text = "Beenden"
    '
    'frmEinst
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(233, 166)
    Me.Controls.Add(Me.ttMenü)
    Me.Controls.Add(Me.grpStandard)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmEinst"
    Me.Text = "Einstellungen"
    Me.grpStandard.ResumeLayout(False)
    Me.grpStandard.PerformLayout()
    Me.ttMenü.ResumeLayout(False)
    Me.ttMenü.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grpStandard As System.Windows.Forms.GroupBox
  Friend WithEvents txtBestand As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtGegBestand As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtAdr As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtKto As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents ttMenü As System.Windows.Forms.ToolStrip
  Friend WithEvents btnSpeichern As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnEnde As System.Windows.Forms.ToolStripButton
End Class
