<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
    Me.ToolStrip = New System.Windows.Forms.ToolStrip
    Me.mnuAdr = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuKto = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuBuch = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuSys = New System.Windows.Forms.ToolStripButton
    Me.StatusStrip = New System.Windows.Forms.StatusStrip
    Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
    Me.mnuAuswert = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuPrüf = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuImpExp = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStrip.SuspendLayout()
    Me.StatusStrip.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStrip
    '
    Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdr, Me.ToolStripSeparator1, Me.mnuKto, Me.ToolStripSeparator2, Me.mnuBuch, Me.ToolStripSeparator3, Me.mnuAuswert, Me.ToolStripSeparator4, Me.mnuPrüf, Me.ToolStripSeparator5, Me.mnuImpExp, Me.ToolStripSeparator6, Me.mnuSys})
    Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip.Name = "ToolStrip"
    Me.ToolStrip.Size = New System.Drawing.Size(756, 36)
    Me.ToolStrip.TabIndex = 6
    Me.ToolStrip.Text = "ToolStrip"
    '
    'mnuAdr
    '
    Me.mnuAdr.Image = CType(resources.GetObject("mnuAdr.Image"), System.Drawing.Image)
    Me.mnuAdr.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuAdr.Name = "mnuAdr"
    Me.mnuAdr.Size = New System.Drawing.Size(110, 33)
    Me.mnuAdr.Text = "Adressenverwaltung"
    Me.mnuAdr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
    '
    'mnuKto
    '
    Me.mnuKto.Image = CType(resources.GetObject("mnuKto.Image"), System.Drawing.Image)
    Me.mnuKto.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuKto.Name = "mnuKto"
    Me.mnuKto.Size = New System.Drawing.Size(99, 33)
    Me.mnuKto.Text = "Kontenverwaltung"
    Me.mnuKto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
    '
    'mnuBuch
    '
    Me.mnuBuch.Image = CType(resources.GetObject("mnuBuch.Image"), System.Drawing.Image)
    Me.mnuBuch.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuBuch.Name = "mnuBuch"
    Me.mnuBuch.Size = New System.Drawing.Size(97, 33)
    Me.mnuBuch.Text = "Buchung erfassen"
    Me.mnuBuch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
    '
    'mnuSys
    '
    Me.mnuSys.Image = CType(resources.GetObject("mnuSys.Image"), System.Drawing.Image)
    Me.mnuSys.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuSys.Name = "mnuSys"
    Me.mnuSys.Size = New System.Drawing.Size(46, 33)
    Me.mnuSys.Text = "System"
    Me.mnuSys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'StatusStrip
    '
    Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
    Me.StatusStrip.Location = New System.Drawing.Point(0, 552)
    Me.StatusStrip.Name = "StatusStrip"
    Me.StatusStrip.Size = New System.Drawing.Size(756, 22)
    Me.StatusStrip.TabIndex = 7
    Me.StatusStrip.Text = "StatusStrip"
    '
    'lblStatus
    '
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(38, 17)
    Me.lblStatus.Text = "Status"
    Me.lblStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
    '
    'mnuAuswert
    '
    Me.mnuAuswert.Image = CType(resources.GetObject("mnuAuswert.Image"), System.Drawing.Image)
    Me.mnuAuswert.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuAuswert.Name = "mnuAuswert"
    Me.mnuAuswert.Size = New System.Drawing.Size(81, 33)
    Me.mnuAuswert.Text = "Auswertungen"
    Me.mnuAuswert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
    '
    'mnuPrüf
    '
    Me.mnuPrüf.Image = CType(resources.GetObject("mnuPrüf.Image"), System.Drawing.Image)
    Me.mnuPrüf.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuPrüf.Name = "mnuPrüf"
    Me.mnuPrüf.Size = New System.Drawing.Size(78, 33)
    Me.mnuPrüf.Text = "Datenprüfung"
    Me.mnuPrüf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripSeparator5
    '
    Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
    '
    'mnuImpExp
    '
    Me.mnuImpExp.Image = CType(resources.GetObject("mnuImpExp.Image"), System.Drawing.Image)
    Me.mnuImpExp.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnuImpExp.Name = "mnuImpExp"
    Me.mnuImpExp.Size = New System.Drawing.Size(85, 33)
    Me.mnuImpExp.Text = "Import / Export"
    Me.mnuImpExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripSeparator6
    '
    Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
    Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 36)
    '
    'frmMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(756, 574)
    Me.Controls.Add(Me.ToolStrip)
    Me.Controls.Add(Me.StatusStrip)
    Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.IsMdiContainer = True
    Me.MinimumSize = New System.Drawing.Size(354, 91)
    Me.Name = "frmMenu"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "PBH.net"
    Me.ToolStrip.ResumeLayout(False)
    Me.ToolStrip.PerformLayout()
    Me.StatusStrip.ResumeLayout(False)
    Me.StatusStrip.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents mnuAdr As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuKto As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuBuch As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuSys As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnuAuswert As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuPrüf As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuImpExp As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
