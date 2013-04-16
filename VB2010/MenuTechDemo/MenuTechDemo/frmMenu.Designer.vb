<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim DockPanelSkin3 As WeifenLuo.WinFormsUI.Docking.DockPanelSkin = New WeifenLuo.WinFormsUI.Docking.DockPanelSkin()
        Dim AutoHideStripSkin3 As WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin = New WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin()
        Dim DockPanelGradient7 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient15 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripSkin3 As WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin = New WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin()
        Dim DockPaneStripGradient3 As WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient()
        Dim TabGradient16 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient8 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient17 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripToolWindowGradient3 As WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient()
        Dim TabGradient18 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient19 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient9 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient20 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient21 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Me.DockPanel = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNewForm = New System.Windows.Forms.Button()
        Me.MenuCommand1 = New Crownwood.Magic.Menus.MenuCommand()
        Me.MenuCommand2 = New Crownwood.Magic.Menus.MenuCommand()
        Me.MenuCommand3 = New Crownwood.Magic.Menus.MenuCommand()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.ActiveAutoHideContent = Nothing
        Me.DockPanel.AutoSize = True
        Me.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel.DockBackColor = System.Drawing.SystemColors.Control
        Me.DockPanel.Location = New System.Drawing.Point(0, 61)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.Size = New System.Drawing.Size(1010, 536)
        DockPanelGradient7.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient7.StartColor = System.Drawing.SystemColors.ControlLight
        AutoHideStripSkin3.DockStripGradient = DockPanelGradient7
        TabGradient15.EndColor = System.Drawing.SystemColors.Control
        TabGradient15.StartColor = System.Drawing.SystemColors.Control
        TabGradient15.TextColor = System.Drawing.SystemColors.ControlDarkDark
        AutoHideStripSkin3.TabGradient = TabGradient15
        AutoHideStripSkin3.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        DockPanelSkin3.AutoHideStripSkin = AutoHideStripSkin3
        TabGradient16.EndColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient16.StartColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient16.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient3.ActiveTabGradient = TabGradient16
        DockPanelGradient8.EndColor = System.Drawing.SystemColors.Control
        DockPanelGradient8.StartColor = System.Drawing.SystemColors.Control
        DockPaneStripGradient3.DockStripGradient = DockPanelGradient8
        TabGradient17.EndColor = System.Drawing.SystemColors.ControlLight
        TabGradient17.StartColor = System.Drawing.SystemColors.ControlLight
        TabGradient17.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripGradient3.InactiveTabGradient = TabGradient17
        DockPaneStripSkin3.DocumentGradient = DockPaneStripGradient3
        DockPaneStripSkin3.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        TabGradient18.EndColor = System.Drawing.SystemColors.ActiveCaption
        TabGradient18.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient18.StartColor = System.Drawing.SystemColors.GradientActiveCaption
        TabGradient18.TextColor = System.Drawing.SystemColors.ActiveCaptionText
        DockPaneStripToolWindowGradient3.ActiveCaptionGradient = TabGradient18
        TabGradient19.EndColor = System.Drawing.SystemColors.Control
        TabGradient19.StartColor = System.Drawing.SystemColors.Control
        TabGradient19.TextColor = System.Drawing.SystemColors.ControlText
        DockPaneStripToolWindowGradient3.ActiveTabGradient = TabGradient19
        DockPanelGradient9.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient9.StartColor = System.Drawing.SystemColors.ControlLight
        DockPaneStripToolWindowGradient3.DockStripGradient = DockPanelGradient9
        TabGradient20.EndColor = System.Drawing.SystemColors.InactiveCaption
        TabGradient20.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient20.StartColor = System.Drawing.SystemColors.GradientInactiveCaption
        TabGradient20.TextColor = System.Drawing.SystemColors.InactiveCaptionText
        DockPaneStripToolWindowGradient3.InactiveCaptionGradient = TabGradient20
        TabGradient21.EndColor = System.Drawing.Color.Transparent
        TabGradient21.StartColor = System.Drawing.Color.Transparent
        TabGradient21.TextColor = System.Drawing.SystemColors.ControlDarkDark
        DockPaneStripToolWindowGradient3.InactiveTabGradient = TabGradient21
        DockPaneStripSkin3.ToolWindowGradient = DockPaneStripToolWindowGradient3
        DockPanelSkin3.DockPaneStripSkin = DockPaneStripSkin3
        Me.DockPanel.Skin = DockPanelSkin3
        Me.DockPanel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNewForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 61)
        Me.Panel1.TabIndex = 7
        '
        'btnNewForm
        '
        Me.btnNewForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNewForm.Location = New System.Drawing.Point(0, 0)
        Me.btnNewForm.Name = "btnNewForm"
        Me.btnNewForm.Size = New System.Drawing.Size(1010, 61)
        Me.btnNewForm.TabIndex = 0
        Me.btnNewForm.Text = "NewForm"
        Me.btnNewForm.UseVisualStyleBackColor = True
        '
        'MenuCommand1
        '
        Me.MenuCommand1.Description = "MenuItem"
        Me.MenuCommand1.MenuCommands.AddRange(New Crownwood.Magic.Menus.MenuCommand() {Me.MenuCommand3})
        '
        'MenuCommand2
        '
        Me.MenuCommand2.Description = "MenuItem"
        '
        'MenuCommand3
        '
        Me.MenuCommand3.Description = "MenuItem"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 597)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockPanel As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewForm As System.Windows.Forms.Button
    Friend WithEvents MenuCommand1 As Crownwood.Magic.Menus.MenuCommand
    Friend WithEvents MenuCommand3 As Crownwood.Magic.Menus.MenuCommand
    Friend WithEvents MenuCommand2 As Crownwood.Magic.Menus.MenuCommand

End Class
