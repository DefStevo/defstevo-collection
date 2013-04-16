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
        Me.btnProjektNeu = New System.Windows.Forms.Button
        Me.cbProjektAktiv = New System.Windows.Forms.CheckBox
        Me.btnProjektSchließen = New System.Windows.Forms.Button
        Me.btnProjektSpeichern = New System.Windows.Forms.Button
        Me.lblProjekt = New System.Windows.Forms.Label
        Me.txtProjektBez = New System.Windows.Forms.TextBox
        Me.txtProjekt = New System.Windows.Forms.TextBox
        Me.dgProjekt = New System.Windows.Forms.DataGridView
        Me.tbPhasen = New System.Windows.Forms.TabPage
        Me.cbPhaseStatus = New System.Windows.Forms.CheckBox
        Me.txtPhaseBez = New System.Windows.Forms.TextBox
        Me.txtPhase = New System.Windows.Forms.TextBox
        Me.lblPhase = New System.Windows.Forms.Label
        Me.btnPhaseNeu = New System.Windows.Forms.Button
        Me.cbPhaseVerrechenbar = New System.Windows.Forms.CheckBox
        Me.btnPhaseSchließen = New System.Windows.Forms.Button
        Me.btnPhaseSpeichern = New System.Windows.Forms.Button
        Me.lblPhaseProjekt = New System.Windows.Forms.Label
        Me.txtPhaseProjektBez = New System.Windows.Forms.TextBox
        Me.txtPhaseProjekt = New System.Windows.Forms.TextBox
        Me.dgPhasen = New System.Windows.Forms.DataGridView
        Me.TabControl1.SuspendLayout()
        Me.tbProjekt.SuspendLayout()
        CType(Me.dgProjekt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPhasen.SuspendLayout()
        CType(Me.dgPhasen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbProjekt.Controls.Add(Me.btnProjektNeu)
        Me.tbProjekt.Controls.Add(Me.cbProjektAktiv)
        Me.tbProjekt.Controls.Add(Me.btnProjektSchließen)
        Me.tbProjekt.Controls.Add(Me.btnProjektSpeichern)
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
        'btnProjektNeu
        '
        Me.btnProjektNeu.Location = New System.Drawing.Point(6, 316)
        Me.btnProjektNeu.Name = "btnProjektNeu"
        Me.btnProjektNeu.Size = New System.Drawing.Size(140, 24)
        Me.btnProjektNeu.TabIndex = 19
        Me.btnProjektNeu.Text = "Neu"
        Me.btnProjektNeu.UseVisualStyleBackColor = True
        '
        'cbProjektAktiv
        '
        Me.cbProjektAktiv.AutoSize = True
        Me.cbProjektAktiv.Checked = True
        Me.cbProjektAktiv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbProjektAktiv.Location = New System.Drawing.Point(432, 8)
        Me.cbProjektAktiv.Name = "cbProjektAktiv"
        Me.cbProjektAktiv.Size = New System.Drawing.Size(50, 17)
        Me.cbProjektAktiv.TabIndex = 18
        Me.cbProjektAktiv.Text = "Aktiv"
        Me.cbProjektAktiv.UseVisualStyleBackColor = True
        '
        'btnProjektSchließen
        '
        Me.btnProjektSchließen.Location = New System.Drawing.Point(345, 316)
        Me.btnProjektSchließen.Name = "btnProjektSchließen"
        Me.btnProjektSchließen.Size = New System.Drawing.Size(140, 24)
        Me.btnProjektSchließen.TabIndex = 16
        Me.btnProjektSchließen.Text = "Schließen"
        Me.btnProjektSchließen.UseVisualStyleBackColor = True
        '
        'btnProjektSpeichern
        '
        Me.btnProjektSpeichern.Location = New System.Drawing.Point(175, 316)
        Me.btnProjektSpeichern.Name = "btnProjektSpeichern"
        Me.btnProjektSpeichern.Size = New System.Drawing.Size(140, 24)
        Me.btnProjektSpeichern.TabIndex = 15
        Me.btnProjektSpeichern.Text = "Speichern"
        Me.btnProjektSpeichern.UseVisualStyleBackColor = True
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
        Me.txtProjektBez.Location = New System.Drawing.Point(153, 6)
        Me.txtProjektBez.Name = "txtProjektBez"
        Me.txtProjektBez.Size = New System.Drawing.Size(273, 20)
        Me.txtProjektBez.TabIndex = 13
        '
        'txtProjekt
        '
        Me.txtProjekt.Location = New System.Drawing.Point(59, 6)
        Me.txtProjekt.Name = "txtProjekt"
        Me.txtProjekt.Size = New System.Drawing.Size(88, 20)
        Me.txtProjekt.TabIndex = 12
        '
        'dgProjekt
        '
        Me.dgProjekt.AllowUserToAddRows = False
        Me.dgProjekt.AllowUserToDeleteRows = False
        Me.dgProjekt.AllowUserToResizeRows = False
        Me.dgProjekt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProjekt.Location = New System.Drawing.Point(3, 32)
        Me.dgProjekt.MultiSelect = False
        Me.dgProjekt.Name = "dgProjekt"
        Me.dgProjekt.ReadOnly = True
        Me.dgProjekt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgProjekt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProjekt.Size = New System.Drawing.Size(482, 278)
        Me.dgProjekt.TabIndex = 0
        '
        'tbPhasen
        '
        Me.tbPhasen.Controls.Add(Me.cbPhaseStatus)
        Me.tbPhasen.Controls.Add(Me.txtPhaseBez)
        Me.tbPhasen.Controls.Add(Me.txtPhase)
        Me.tbPhasen.Controls.Add(Me.lblPhase)
        Me.tbPhasen.Controls.Add(Me.btnPhaseNeu)
        Me.tbPhasen.Controls.Add(Me.cbPhaseVerrechenbar)
        Me.tbPhasen.Controls.Add(Me.btnPhaseSchließen)
        Me.tbPhasen.Controls.Add(Me.btnPhaseSpeichern)
        Me.tbPhasen.Controls.Add(Me.lblPhaseProjekt)
        Me.tbPhasen.Controls.Add(Me.txtPhaseProjektBez)
        Me.tbPhasen.Controls.Add(Me.txtPhaseProjekt)
        Me.tbPhasen.Controls.Add(Me.dgPhasen)
        Me.tbPhasen.Location = New System.Drawing.Point(4, 22)
        Me.tbPhasen.Name = "tbPhasen"
        Me.tbPhasen.Size = New System.Drawing.Size(488, 343)
        Me.tbPhasen.TabIndex = 2
        Me.tbPhasen.Text = "Phasen"
        Me.tbPhasen.UseVisualStyleBackColor = True
        '
        'cbPhaseStatus
        '
        Me.cbPhaseStatus.AutoSize = True
        Me.cbPhaseStatus.Checked = True
        Me.cbPhaseStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPhaseStatus.Location = New System.Drawing.Point(432, 12)
        Me.cbPhaseStatus.Name = "cbPhaseStatus"
        Me.cbPhaseStatus.Size = New System.Drawing.Size(50, 17)
        Me.cbPhaseStatus.TabIndex = 31
        Me.cbPhaseStatus.Text = "Aktiv"
        Me.cbPhaseStatus.UseVisualStyleBackColor = True
        '
        'txtPhaseBez
        '
        Me.txtPhaseBez.Location = New System.Drawing.Point(153, 30)
        Me.txtPhaseBez.Name = "txtPhaseBez"
        Me.txtPhaseBez.Size = New System.Drawing.Size(273, 20)
        Me.txtPhaseBez.TabIndex = 30
        '
        'txtPhase
        '
        Me.txtPhase.Location = New System.Drawing.Point(59, 30)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.Size = New System.Drawing.Size(88, 20)
        Me.txtPhase.TabIndex = 29
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Location = New System.Drawing.Point(10, 33)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(37, 13)
        Me.lblPhase.TabIndex = 28
        Me.lblPhase.Text = "Phase"
        '
        'btnPhaseNeu
        '
        Me.btnPhaseNeu.Location = New System.Drawing.Point(6, 314)
        Me.btnPhaseNeu.Name = "btnPhaseNeu"
        Me.btnPhaseNeu.Size = New System.Drawing.Size(140, 24)
        Me.btnPhaseNeu.TabIndex = 27
        Me.btnPhaseNeu.Text = "Neu"
        Me.btnPhaseNeu.UseVisualStyleBackColor = True
        '
        'cbPhaseVerrechenbar
        '
        Me.cbPhaseVerrechenbar.AutoSize = True
        Me.cbPhaseVerrechenbar.Checked = True
        Me.cbPhaseVerrechenbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPhaseVerrechenbar.Location = New System.Drawing.Point(432, 35)
        Me.cbPhaseVerrechenbar.Name = "cbPhaseVerrechenbar"
        Me.cbPhaseVerrechenbar.Size = New System.Drawing.Size(48, 17)
        Me.cbPhaseVerrechenbar.TabIndex = 26
        Me.cbPhaseVerrechenbar.Text = "Verr."
        Me.cbPhaseVerrechenbar.UseVisualStyleBackColor = True
        '
        'btnPhaseSchließen
        '
        Me.btnPhaseSchließen.Location = New System.Drawing.Point(345, 314)
        Me.btnPhaseSchließen.Name = "btnPhaseSchließen"
        Me.btnPhaseSchließen.Size = New System.Drawing.Size(140, 24)
        Me.btnPhaseSchließen.TabIndex = 25
        Me.btnPhaseSchließen.Text = "Schließen"
        Me.btnPhaseSchließen.UseVisualStyleBackColor = True
        '
        'btnPhaseSpeichern
        '
        Me.btnPhaseSpeichern.Location = New System.Drawing.Point(175, 314)
        Me.btnPhaseSpeichern.Name = "btnPhaseSpeichern"
        Me.btnPhaseSpeichern.Size = New System.Drawing.Size(140, 24)
        Me.btnPhaseSpeichern.TabIndex = 24
        Me.btnPhaseSpeichern.Text = "Speichern"
        Me.btnPhaseSpeichern.UseVisualStyleBackColor = True
        '
        'lblPhaseProjekt
        '
        Me.lblPhaseProjekt.AutoSize = True
        Me.lblPhaseProjekt.Location = New System.Drawing.Point(10, 7)
        Me.lblPhaseProjekt.Name = "lblPhaseProjekt"
        Me.lblPhaseProjekt.Size = New System.Drawing.Size(40, 13)
        Me.lblPhaseProjekt.TabIndex = 23
        Me.lblPhaseProjekt.Text = "Projekt"
        '
        'txtPhaseProjektBez
        '
        Me.txtPhaseProjektBez.Location = New System.Drawing.Point(153, 4)
        Me.txtPhaseProjektBez.Name = "txtPhaseProjektBez"
        Me.txtPhaseProjektBez.ReadOnly = True
        Me.txtPhaseProjektBez.Size = New System.Drawing.Size(273, 20)
        Me.txtPhaseProjektBez.TabIndex = 22
        '
        'txtPhaseProjekt
        '
        Me.txtPhaseProjekt.Location = New System.Drawing.Point(59, 4)
        Me.txtPhaseProjekt.Name = "txtPhaseProjekt"
        Me.txtPhaseProjekt.Size = New System.Drawing.Size(88, 20)
        Me.txtPhaseProjekt.TabIndex = 21
        '
        'dgPhasen
        '
        Me.dgPhasen.AllowUserToAddRows = False
        Me.dgPhasen.AllowUserToDeleteRows = False
        Me.dgPhasen.AllowUserToResizeRows = False
        Me.dgPhasen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPhasen.Location = New System.Drawing.Point(3, 58)
        Me.dgPhasen.MultiSelect = False
        Me.dgPhasen.Name = "dgPhasen"
        Me.dgPhasen.ReadOnly = True
        Me.dgPhasen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPhasen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPhasen.Size = New System.Drawing.Size(482, 250)
        Me.dgPhasen.TabIndex = 20
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
        Me.tbPhasen.ResumeLayout(False)
        Me.tbPhasen.PerformLayout()
        CType(Me.dgPhasen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbAllgemein As System.Windows.Forms.TabPage
    Friend WithEvents tbProjekt As System.Windows.Forms.TabPage
    Friend WithEvents tbPhasen As System.Windows.Forms.TabPage
    Friend WithEvents dgProjekt As System.Windows.Forms.DataGridView
    Friend WithEvents lblProjekt As System.Windows.Forms.Label
    Friend WithEvents txtProjektBez As System.Windows.Forms.TextBox
    Friend WithEvents txtProjekt As System.Windows.Forms.TextBox
    Friend WithEvents btnProjektSchließen As System.Windows.Forms.Button
    Friend WithEvents btnProjektSpeichern As System.Windows.Forms.Button
    Friend WithEvents cbProjektAktiv As System.Windows.Forms.CheckBox
    Friend WithEvents btnProjektNeu As System.Windows.Forms.Button
    Friend WithEvents txtPhaseBez As System.Windows.Forms.TextBox
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents btnPhaseNeu As System.Windows.Forms.Button
    Friend WithEvents cbPhaseVerrechenbar As System.Windows.Forms.CheckBox
    Friend WithEvents btnPhaseSchließen As System.Windows.Forms.Button
    Friend WithEvents btnPhaseSpeichern As System.Windows.Forms.Button
    Friend WithEvents lblPhaseProjekt As System.Windows.Forms.Label
    Friend WithEvents txtPhaseProjektBez As System.Windows.Forms.TextBox
    Friend WithEvents txtPhaseProjekt As System.Windows.Forms.TextBox
    Friend WithEvents dgPhasen As System.Windows.Forms.DataGridView
    Friend WithEvents cbPhaseStatus As System.Windows.Forms.CheckBox
End Class
