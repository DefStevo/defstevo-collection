<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTST
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
        Me.txtVorname = New System.Windows.Forms.TextBox
        Me.txtStrasse = New System.Windows.Forms.TextBox
        Me.txtNachname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPLZ = New System.Windows.Forms.TextBox
        Me.txtOrt = New System.Windows.Forms.TextBox
        Me.btnSpeichern = New System.Windows.Forms.Button
        Me.btnLaden = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(79, 6)
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(186, 20)
        Me.txtVorname.TabIndex = 0
        '
        'txtStrasse
        '
        Me.txtStrasse.Location = New System.Drawing.Point(79, 58)
        Me.txtStrasse.Name = "txtStrasse"
        Me.txtStrasse.Size = New System.Drawing.Size(186, 20)
        Me.txtStrasse.TabIndex = 1
        '
        'txtNachname
        '
        Me.txtNachname.Location = New System.Drawing.Point(79, 32)
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(186, 20)
        Me.txtNachname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vorname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nachname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Straße"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PLZ/Ort"
        '
        'txtPLZ
        '
        Me.txtPLZ.Location = New System.Drawing.Point(79, 84)
        Me.txtPLZ.Name = "txtPLZ"
        Me.txtPLZ.Size = New System.Drawing.Size(66, 20)
        Me.txtPLZ.TabIndex = 8
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(151, 84)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(114, 20)
        Me.txtOrt.TabIndex = 9
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(15, 120)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(250, 23)
        Me.btnSpeichern.TabIndex = 10
        Me.btnSpeichern.Text = "&Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnLaden
        '
        Me.btnLaden.Location = New System.Drawing.Point(15, 149)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(250, 23)
        Me.btnLaden.TabIndex = 11
        Me.btnLaden.Text = "&Laden"
        Me.btnLaden.UseVisualStyleBackColor = True
        '
        'frmTST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 183)
        Me.Controls.Add(Me.btnLaden)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.txtPLZ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNachname)
        Me.Controls.Add(Me.txtStrasse)
        Me.Controls.Add(Me.txtVorname)
        Me.Name = "frmTST"
        Me.Text = "frmTST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVorname As System.Windows.Forms.TextBox
    Friend WithEvents txtStrasse As System.Windows.Forms.TextBox
    Friend WithEvents txtNachname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPLZ As System.Windows.Forms.TextBox
    Friend WithEvents txtOrt As System.Windows.Forms.TextBox
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnLaden As System.Windows.Forms.Button
End Class
