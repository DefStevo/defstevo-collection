<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.txtKeywords = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.dgFiles = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.cfile_GUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTyp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cobject_GUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNewVersion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKeywords
        '
        Me.txtKeywords.Location = New System.Drawing.Point(87, 38)
        Me.txtKeywords.Multiline = True
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(459, 33)
        Me.txtKeywords.TabIndex = 0
        Me.txtKeywords.Text = "Zeile1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zeile2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zeile3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stichworte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gruppe"
        '
        'txtGroup
        '
        Me.txtGroup.Location = New System.Drawing.Point(87, 77)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(459, 20)
        Me.txtGroup.TabIndex = 3
        '
        'dgFiles
        '
        Me.dgFiles.AllowUserToAddRows = False
        Me.dgFiles.AllowUserToDeleteRows = False
        Me.dgFiles.AllowUserToOrderColumns = True
        Me.dgFiles.AllowUserToResizeColumns = False
        Me.dgFiles.AllowUserToResizeRows = False
        Me.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cfile_GUID, Me.cName, Me.cPath, Me.cTyp, Me.cobject_GUID, Me.cVersion, Me.cNewVersion})
        Me.dgFiles.Location = New System.Drawing.Point(12, 121)
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.RowHeadersWidth = 20
        Me.dgFiles.Size = New System.Drawing.Size(539, 122)
        Me.dgFiles.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dateien"
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(12, 249)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(534, 23)
        Me.cmdImport.TabIndex = 6
        Me.cmdImport.Text = "Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cfile_GUID
        '
        Me.cfile_GUID.HeaderText = "Datei GUID"
        Me.cfile_GUID.Name = "cfile_GUID"
        Me.cfile_GUID.ReadOnly = True
        '
        'cName
        '
        Me.cName.HeaderText = "Name"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        '
        'cPath
        '
        Me.cPath.HeaderText = "Pfad"
        Me.cPath.Name = "cPath"
        Me.cPath.ReadOnly = True
        '
        'cTyp
        '
        Me.cTyp.HeaderText = "Typ"
        Me.cTyp.Name = "cTyp"
        '
        'cobject_GUID
        '
        Me.cobject_GUID.HeaderText = "Objekt GUID"
        Me.cobject_GUID.Name = "cobject_GUID"
        '
        'cVersion
        '
        Me.cVersion.HeaderText = "Version"
        Me.cVersion.Name = "cVersion"
        Me.cVersion.ReadOnly = True
        '
        'cNewVersion
        '
        Me.cNewVersion.HeaderText = "Neue Version"
        Me.cNewVersion.Name = "cNewVersion"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(87, 12)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(459, 20)
        Me.txtDescr.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Bezeichnung"
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 278)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgFiles)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKeywords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmImport"
        Me.Text = "Import"
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKeywords As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents dgFiles As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdImport As System.Windows.Forms.Button
    Friend WithEvents cfile_GUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTyp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cobject_GUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNewVersion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
