<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.btnLaden = New System.Windows.Forms.Button
        Me.btnNeu = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(33, 224)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(152, 20)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "ToDo5"
        Me.btn5.UseVisualStyleBackColor = True
        Me.btn5.Visible = False
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(33, 198)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(152, 20)
        Me.btn4.TabIndex = 12
        Me.btn4.Text = "ToDo4"
        Me.btn4.UseVisualStyleBackColor = True
        Me.btn4.Visible = False
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(33, 172)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(152, 20)
        Me.btn3.TabIndex = 11
        Me.btn3.Text = "ToDo3"
        Me.btn3.UseVisualStyleBackColor = True
        Me.btn3.Visible = False
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(33, 146)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(152, 20)
        Me.btn2.TabIndex = 10
        Me.btn2.Text = "ToDo2"
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(33, 120)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(152, 20)
        Me.btn1.TabIndex = 9
        Me.btn1.Text = "ToDo1"
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btnLaden
        '
        Me.btnLaden.Location = New System.Drawing.Point(33, 59)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(152, 40)
        Me.btnLaden.TabIndex = 8
        Me.btnLaden.Text = "ToDo-Liste &laden"
        Me.btnLaden.UseVisualStyleBackColor = True
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(33, 13)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(152, 40)
        Me.btnNeu.TabIndex = 7
        Me.btnNeu.Text = "&Neue ToDo-Liste"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 252)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnLaden)
        Me.Controls.Add(Me.btnNeu)
        Me.Name = "frmMenu"
        Me.Text = "ToDo-Listen Verwaltung"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btnLaden As System.Windows.Forms.Button
    Friend WithEvents btnNeu As System.Windows.Forms.Button
End Class
