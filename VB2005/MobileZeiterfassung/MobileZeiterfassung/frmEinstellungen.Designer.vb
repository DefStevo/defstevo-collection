<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEinstellungen
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbAllgemein = New System.Windows.Forms.TabPage
        Me.tbProjekt = New System.Windows.Forms.TabPage
        Me.dgProjekt = New System.Windows.Forms.DataGridView
        Me.tbPhasen = New System.Windows.Forms.TabPage
        Me.lblProjekt = New System.Windows.Forms.Label
        Me.txtProjektBez = New System.Windows.Forms.TextBox
        Me.txtProjekt = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tbProjekt.SuspendLayout()
        CType(Me.dgProjekt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbAllgemein)
        Me.TabControl1.Controls.Add(Me.tbProjekt)
        Me.TabControl1.Controls.Add(Me.tbPhasen)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(496, 369)
        Me.TabControl1.TabIndex = 0
        '
        'tbAllgemein
        '
        Me.tbAllgemein.Location = New System.Drawing.Point(4, 22)
        Me.tbAllgemein.Name = "tbAllgemein"
        Me.tbAllgemein.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAllgemein.Size = New System.Drawing.Size(488, 343)
        Me.tbAllgemein.TabIndex = 0
        Me.tbAllgemein.Text = "Allgemein"
        Me.tbAllgemein.UseVisualStyleBackColor = True
        '
        'tbProjekt
        '
        Me.tbProjekt.Controls.Add(Me.lblStatus)
        Me.tbProjekt.Controls.Add(Me.lblProjekt)
        Me.tbProjekt.Controls.Add(Me.txtProjektBez)
        Me.tbProjekt.Controls.Add(Me.txtProjekt)
        Me.tbProjekt.Controls.Add(Me.dgProjekt)
        Me.tbProjekt.Location = New System.Drawing.Point(4, 22)
        Me.tbProjekt.Name = "tbProjekt"
        Me.tbProjekt.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProjekt.Size = New System.Drawing.Size(488, 343)
        Me.tbProjekt.TabIndex = 1
        Me.tbProjekt.Text = "Projekte"
        Me.tbProjekt.UseVisualStyleBackColor = True
        '
        'dgProjekt
        '
        Me.dgProjekt.AllowUserToAddRows = False
        Me.dgProjekt.AllowUserToResizeRows = False
        Me.dgProjekt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProjekt.Location = New System.Drawing.Point(3, 78)
        Me.dgProjekt.Name = "dgProjekt"
        Me.dgProjekt.ReadOnly = True
        Me.dgProjekt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProjekt.Size = New System.Drawing.Size(482, 262)
        Me.dgProjekt.TabIndex = 0
        '
        'tbPhasen
        '
        Me.tbPhasen.Location = New System.Drawing.Point(4, 22)
        Me.tbPhasen.Name = "tbPhasen"
        Me.tbPhasen.Size = New System.Drawing.Size(488, 343)
        Me.tbPhasen.TabIndex = 2
        Me.tbPhasen.Text = "Phasen"
        Me.tbPhasen.UseVisualStyleBackColor = True
        '
        'lblProjekt
        '
        Me.lblProjekt.AutoSize = True
        Me.lblProjekt.Location = New System.Drawing.Point(10, 9)
        Me.lblProjekt.Name = "lblProjekt"
        Me.lblProjekt.Size = New System.Drawing.Size(40, 13)
        Me.lblProjekt.TabIndex = 14
        Me.lblProjekt.Text = "Projekt"
        '
        'txtProjektBez
        '
        Me.txtProjektBez.Enabled = False
        Me.txtProjektBez.Location = New System.Drawing.Point(153, 6)
        Me.txtProjektBez.Name = "txtProjektBez"
        Me.txtProjektBez.Size = New System.Drawing.Size(309, 20)
        Me.txtProjektBez.TabIndex = 13
        '
        'txtProjekt
        '
        Me.txtProjekt.Location = New System.Drawing.Point(59, 6)
        Me.txtProjekt.Name = "txtProjekt"
        Me.txtProjekt.Size = New System.Drawing.Size(88, 20)
        Me.txtProjekt.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(10, 34)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Projekt"
        '
        'frmEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 367)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEinstellungen"
        Me.Text = "Mobile Zeiterfassung - Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.tbProjekt.ResumeLayout(False)
        Me.tbProjekt.PerformLayout()
        CType(Me.dgProjekt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbAllgemein As System.Windows.Forms.TabPage
    Friend WithEvents tbProjekt As System.Windows.Forms.TabPage
    Friend WithEvents tbPhasen As System.Windows.Forms.TabPage
    Friend WithEvents dgProjekt As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblProjekt As System.Windows.Forms.Label
    Friend WithEvents txtProjektBez As System.Windows.Forms.TextBox
    Friend WithEvents txtProjekt As System.Windows.Forms.TextBox
End Class
