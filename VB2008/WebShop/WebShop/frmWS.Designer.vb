<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWS
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
        Me.txtDatei = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPage = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDatei = New System.Windows.Forms.Button
        Me.btnUpload = New System.Windows.Forms.Button
        Me.BrowseDialog = New System.Windows.Forms.OpenFileDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtWiederholung = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtDatei
        '
        Me.txtDatei.Location = New System.Drawing.Point(96, 6)
        Me.txtDatei.Name = "txtDatei"
        Me.txtDatei.Size = New System.Drawing.Size(216, 20)
        Me.txtDatei.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datei"
        '
        'txtPage
        '
        Me.txtPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPage.FormattingEnabled = True
        Me.txtPage.Items.AddRange(New Object() {"Artikel Detail", "Artikel Großhandel", "Kunden", "Preislisten", "Regionen", "Währungen"})
        Me.txtPage.Location = New System.Drawing.Point(96, 31)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(249, 21)
        Me.txtPage.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modul/Page"
        '
        'btnDatei
        '
        Me.btnDatei.Location = New System.Drawing.Point(312, 6)
        Me.btnDatei.Name = "btnDatei"
        Me.btnDatei.Size = New System.Drawing.Size(33, 20)
        Me.btnDatei.TabIndex = 4
        Me.btnDatei.Text = "..."
        Me.btnDatei.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(15, 84)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(330, 25)
        Me.btnUpload.TabIndex = 5
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'BrowseDialog
        '
        Me.BrowseDialog.FileName = "*.*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wiederholung"
        '
        'txtWiederholung
        '
        Me.txtWiederholung.Location = New System.Drawing.Point(96, 58)
        Me.txtWiederholung.Name = "txtWiederholung"
        Me.txtWiederholung.Size = New System.Drawing.Size(55, 20)
        Me.txtWiederholung.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "bei Fehlerhaften Upload"
        '
        'frmWS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 117)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWiederholung)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDatei)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDatei)
        Me.Name = "frmWS"
        Me.Text = "frmWS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDatei As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPage As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDatei As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents BrowseDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWiederholung As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
