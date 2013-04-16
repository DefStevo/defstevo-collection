<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHaupt
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHaupt))
        Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EinblendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AusblendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AusblendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeendenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EinstellungenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.txtProjekt = New System.Windows.Forms.TextBox
        Me.txtPhase = New System.Windows.Forms.TextBox
        Me.txtProjektBez = New System.Windows.Forms.TextBox
        Me.txtPhaseBez = New System.Windows.Forms.TextBox
        Me.btnStartStop = New System.Windows.Forms.Button
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnNeu = New System.Windows.Forms.Button
        Me.lblProjekt = New System.Windows.Forms.Label
        Me.lblPhase = New System.Windows.Forms.Label
        Me.cmTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tray
        '
        Me.Tray.ContextMenuStrip = Me.cmTray
        Me.Tray.Icon = CType(resources.GetObject("Tray.Icon"), System.Drawing.Icon)
        Me.Tray.Text = "NotifyIcon1"
        '
        'cmTray
        '
        Me.cmTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinblendenToolStripMenuItem, Me.AusblendenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.cmTray.Name = "ContextMenuStrip1"
        Me.cmTray.ShowImageMargin = False
        Me.cmTray.Size = New System.Drawing.Size(113, 70)
        '
        'EinblendenToolStripMenuItem
        '
        Me.EinblendenToolStripMenuItem.Name = "EinblendenToolStripMenuItem"
        Me.EinblendenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EinblendenToolStripMenuItem.Text = "Einblenden"
        '
        'AusblendenToolStripMenuItem
        '
        Me.AusblendenToolStripMenuItem.Name = "AusblendenToolStripMenuItem"
        Me.AusblendenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AusblendenToolStripMenuItem.Text = "Ausblenden"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusblendenToolStripMenuItem1, Me.ExcelToolStripMenuItem, Me.DruckenToolStripMenuItem, Me.BeendenToolStripMenuItem1})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'AusblendenToolStripMenuItem1
        '
        Me.AusblendenToolStripMenuItem1.Name = "AusblendenToolStripMenuItem1"
        Me.AusblendenToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.AusblendenToolStripMenuItem1.Text = "Ausblenden"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DruckenToolStripMenuItem.Text = "Drucken"
        '
        'BeendenToolStripMenuItem1
        '
        Me.BeendenToolStripMenuItem1.Name = "BeendenToolStripMenuItem1"
        Me.BeendenToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.BeendenToolStripMenuItem1.Text = "Beenden"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem1})
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionenToolStripMenuItem.Text = "Optionen"
        '
        'EinstellungenToolStripMenuItem1
        '
        Me.EinstellungenToolStripMenuItem1.Name = "EinstellungenToolStripMenuItem1"
        Me.EinstellungenToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenToolStripMenuItem1.Text = "Einstellungen"
        '
        'txtProjekt
        '
        Me.txtProjekt.Location = New System.Drawing.Point(61, 32)
        Me.txtProjekt.Name = "txtProjekt"
        Me.txtProjekt.Size = New System.Drawing.Size(88, 20)
        Me.txtProjekt.TabIndex = 7
        '
        'txtPhase
        '
        Me.txtPhase.Location = New System.Drawing.Point(61, 58)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.Size = New System.Drawing.Size(88, 20)
        Me.txtPhase.TabIndex = 8
        '
        'txtProjektBez
        '
        Me.txtProjektBez.Enabled = False
        Me.txtProjektBez.Location = New System.Drawing.Point(155, 32)
        Me.txtProjektBez.Name = "txtProjektBez"
        Me.txtProjektBez.Size = New System.Drawing.Size(309, 20)
        Me.txtProjektBez.TabIndex = 9
        '
        'txtPhaseBez
        '
        Me.txtPhaseBez.Enabled = False
        Me.txtPhaseBez.Location = New System.Drawing.Point(155, 58)
        Me.txtPhaseBez.Name = "txtPhaseBez"
        Me.txtPhaseBez.Size = New System.Drawing.Size(309, 20)
        Me.txtPhaseBez.TabIndex = 10
        '
        'btnStartStop
        '
        Me.btnStartStop.Location = New System.Drawing.Point(470, 55)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(23, 19)
        Me.btnStartStop.TabIndex = 13
        Me.btnStartStop.Tag = ""
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 90)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(501, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 14
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(500, 17)
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(470, 33)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(23, 19)
        Me.btnNeu.TabIndex = 15
        Me.btnNeu.Tag = ""
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'lblProjekt
        '
        Me.lblProjekt.AutoSize = True
        Me.lblProjekt.Location = New System.Drawing.Point(15, 35)
        Me.lblProjekt.Name = "lblProjekt"
        Me.lblProjekt.Size = New System.Drawing.Size(40, 13)
        Me.lblProjekt.TabIndex = 16
        Me.lblProjekt.Text = "Projekt"
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Location = New System.Drawing.Point(18, 61)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(37, 13)
        Me.lblPhase.TabIndex = 17
        Me.lblPhase.Text = "Phase"
        '
        'frmHaupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 112)
        Me.Controls.Add(Me.lblPhase)
        Me.Controls.Add(Me.lblProjekt)
        Me.Controls.Add(Me.btnNeu)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.txtPhaseBez)
        Me.Controls.Add(Me.txtProjektBez)
        Me.Controls.Add(Me.txtPhase)
        Me.Controls.Add(Me.txtProjekt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmHaupt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mobile Zeiterfassung - Menu"
        Me.cmTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tray As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EinblendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusblendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusblendenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtProjekt As System.Windows.Forms.TextBox
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents txtProjektBez As System.Windows.Forms.TextBox
    Friend WithEvents txtPhaseBez As System.Windows.Forms.TextBox
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnNeu As System.Windows.Forms.Button
    Friend WithEvents lblProjekt As System.Windows.Forms.Label
    Friend WithEvents lblPhase As System.Windows.Forms.Label
End Class
