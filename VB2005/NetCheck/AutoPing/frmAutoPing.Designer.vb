<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoPing
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
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoPing))
    Me.nIcon = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.cMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.BeendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.cMenu.SuspendLayout()
    Me.SuspendLayout()
    '
    'nIcon
    '
    Me.nIcon.ContextMenuStrip = Me.cMenu
    Me.nIcon.Icon = CType(resources.GetObject("nIcon.Icon"), System.Drawing.Icon)
    Me.nIcon.Text = "AutoPing"
    Me.nIcon.Visible = True
    '
    'cMenu
    '
    Me.cMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem, Me.PingToolStripMenuItem, Me.BeendenToolStripMenuItem1})
    Me.cMenu.Name = "cMenu"
    Me.cMenu.Size = New System.Drawing.Size(128, 70)
    '
    'BeendenToolStripMenuItem
    '
    Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
    Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
    Me.BeendenToolStripMenuItem.Text = "Status"
    '
    'PingToolStripMenuItem
    '
    Me.PingToolStripMenuItem.Name = "PingToolStripMenuItem"
    Me.PingToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
    Me.PingToolStripMenuItem.Text = "Ping"
    '
    'BeendenToolStripMenuItem1
    '
    Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
    Me.BeendenToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
    Me.BeendenToolStripMenuItem1.Text = "Beenden"
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 10000
    '
    'frmAutoPing
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 141)
    Me.Name = "frmAutoPing"
    Me.ShowInTaskbar = False
    Me.Text = "AutoPing"
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    Me.cMenu.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents nIcon As System.Windows.Forms.NotifyIcon
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents cMenu As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BeendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
