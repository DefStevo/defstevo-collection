<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToDo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.fdLaden = New System.Windows.Forms.OpenFileDialog
        Me.fdSpeichern = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnSpeichern = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgToDo = New System.Windows.Forms.DataGridView
        Me.NUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KAT = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BEZ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRIO = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ANLAGBEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ANLAGZEIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ERLBEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ERLZEIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DAU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgToDo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fdLaden
        '
        Me.fdLaden.FileName = "OpenFileDialog1"
        Me.fdLaden.Filter = "ToDo-Listen|*.ToDo|Alle Dateien|*.*"
        '
        'fdSpeichern
        '
        Me.fdSpeichern.Filter = "ToDo-Liste|*.ToDo|Alle Dateien|*.*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.btnSpeichern)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 717)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Einschränkungen"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(16, 55)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(105, 24)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(16, 25)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(105, 24)
        Me.btnSpeichern.TabIndex = 0
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgToDo)
        Me.GroupBox2.Location = New System.Drawing.Point(160, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(853, 717)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ToDo-Liste"
        '
        'dgToDo
        '
        Me.dgToDo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgToDo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUM, Me.KAT, Me.BEZ, Me.BES, Me.PRIO, Me.ANLAGBEN, Me.ANLAGZEIT, Me.ERLBEN, Me.ERLZEIT, Me.SOLL, Me.DAU})
        Me.dgToDo.Location = New System.Drawing.Point(6, 19)
        Me.dgToDo.Name = "dgToDo"
        Me.dgToDo.Size = New System.Drawing.Size(838, 692)
        Me.dgToDo.TabIndex = 1
        '
        'NUM
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.NUM.DefaultCellStyle = DataGridViewCellStyle1
        Me.NUM.HeaderText = "#"
        Me.NUM.Name = "NUM"
        Me.NUM.Width = 25
        '
        'KAT
        '
        Me.KAT.HeaderText = "Kategorie"
        Me.KAT.Items.AddRange(New Object() {"I", "S", "Z", "?"})
        Me.KAT.Name = "KAT"
        Me.KAT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KAT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.KAT.Width = 70
        '
        'BEZ
        '
        Me.BEZ.HeaderText = "Bezeichnung"
        Me.BEZ.Name = "BEZ"
        '
        'BES
        '
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BES.DefaultCellStyle = DataGridViewCellStyle2
        Me.BES.HeaderText = "Beschreibung"
        Me.BES.Name = "BES"
        Me.BES.Width = 250
        '
        'PRIO
        '
        Me.PRIO.HeaderText = "Priorität"
        Me.PRIO.Items.AddRange(New Object() {"1", "2", "3", "?"})
        Me.PRIO.Name = "PRIO"
        Me.PRIO.Width = 50
        '
        'ANLAGBEN
        '
        Me.ANLAGBEN.HeaderText = "Benutzer Anl."
        Me.ANLAGBEN.Name = "ANLAGBEN"
        Me.ANLAGBEN.Width = 50
        '
        'ANLAGZEIT
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ANLAGZEIT.DefaultCellStyle = DataGridViewCellStyle3
        Me.ANLAGZEIT.HeaderText = "Zeit Anl."
        Me.ANLAGZEIT.Name = "ANLAGZEIT"
        Me.ANLAGZEIT.Width = 50
        '
        'ERLBEN
        '
        Me.ERLBEN.HeaderText = "Benutzer Erl."
        Me.ERLBEN.Name = "ERLBEN"
        Me.ERLBEN.Width = 50
        '
        'ERLZEIT
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ERLZEIT.DefaultCellStyle = DataGridViewCellStyle4
        Me.ERLZEIT.HeaderText = "Zeit Erl."
        Me.ERLZEIT.Name = "ERLZEIT"
        Me.ERLZEIT.Width = 50
        '
        'SOLL
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SOLL.DefaultCellStyle = DataGridViewCellStyle5
        Me.SOLL.HeaderText = "Soll"
        Me.SOLL.Name = "SOLL"
        Me.SOLL.Width = 50
        '
        'DAU
        '
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DAU.DefaultCellStyle = DataGridViewCellStyle6
        Me.DAU.HeaderText = "Dauer"
        Me.DAU.Name = "DAU"
        Me.DAU.Width = 50
        '
        'frmToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmToDo"
        Me.Text = "ToDo-Listen Verwaltung: Neue ToDo-Liste"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgToDo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fdLaden As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fdSpeichern As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgToDo As System.Windows.Forms.DataGridView
    Friend WithEvents NUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KAT As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BEZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRIO As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ANLAGBEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ANLAGZEIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERLBEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ERLZEIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DAU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
