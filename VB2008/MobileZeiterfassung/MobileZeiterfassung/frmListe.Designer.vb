<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListe
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
        Me.dgListe = New System.Windows.Forms.DataGridView
        Me.btnAuswahl = New System.Windows.Forms.Button
        Me.btnAbbrechen = New System.Windows.Forms.Button
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgListe
        '
        Me.dgListe.AllowUserToAddRows = False
        Me.dgListe.AllowUserToDeleteRows = False
        Me.dgListe.AllowUserToResizeRows = False
        Me.dgListe.ColumnHeadersHeight = 24
        Me.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgListe.Location = New System.Drawing.Point(0, 1)
        Me.dgListe.MultiSelect = False
        Me.dgListe.Name = "dgListe"
        Me.dgListe.ReadOnly = True
        Me.dgListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListe.Size = New System.Drawing.Size(285, 237)
        Me.dgListe.TabIndex = 0
        '
        'btnAuswahl
        '
        Me.btnAuswahl.Location = New System.Drawing.Point(0, 244)
        Me.btnAuswahl.Name = "btnAuswahl"
        Me.btnAuswahl.Size = New System.Drawing.Size(140, 24)
        Me.btnAuswahl.TabIndex = 1
        Me.btnAuswahl.Text = "Auswählen"
        Me.btnAuswahl.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(145, 244)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(140, 24)
        Me.btnAbbrechen.TabIndex = 2
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'frmListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnAuswahl)
        Me.Controls.Add(Me.dgListe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListe"
        Me.Text = "frmListe"
        CType(Me.dgListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgListe As System.Windows.Forms.DataGridView
    Friend WithEvents btnAuswahl As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
End Class
