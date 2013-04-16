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
        Me.btnStarten = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdMartingale = New System.Windows.Forms.RadioButton
        Me.rdMarch = New System.Windows.Forms.RadioButton
        Me.rd8er = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nRunden = New RouletteSystem.NumericTextBox
        Me.nKapital = New RouletteSystem.NumericTextBox
        Me.nEinsatz = New RouletteSystem.NumericTextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStarten
        '
        Me.btnStarten.Location = New System.Drawing.Point(14, 106)
        Me.btnStarten.Name = "btnStarten"
        Me.btnStarten.Size = New System.Drawing.Size(462, 59)
        Me.btnStarten.TabIndex = 0
        Me.btnStarten.Text = "Starten"
        Me.btnStarten.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdMartingale)
        Me.GroupBox1.Controls.Add(Me.rdMarch)
        Me.GroupBox1.Controls.Add(Me.rd8er)
        Me.GroupBox1.Location = New System.Drawing.Point(250, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System"
        '
        'rdMartingale
        '
        Me.rdMartingale.AutoSize = True
        Me.rdMartingale.Enabled = False
        Me.rdMartingale.Location = New System.Drawing.Point(6, 65)
        Me.rdMartingale.Name = "rdMartingale"
        Me.rdMartingale.Size = New System.Drawing.Size(95, 17)
        Me.rdMartingale.TabIndex = 2
        Me.rdMartingale.Text = "Martingalespiel"
        Me.rdMartingale.UseVisualStyleBackColor = True
        '
        'rdMarch
        '
        Me.rdMarch.AutoSize = True
        Me.rdMarch.Enabled = False
        Me.rdMarch.Location = New System.Drawing.Point(6, 42)
        Me.rdMarch.Name = "rdMarch"
        Me.rdMarch.Size = New System.Drawing.Size(55, 17)
        Me.rdMarch.TabIndex = 1
        Me.rdMarch.Text = "March"
        Me.rdMarch.UseVisualStyleBackColor = True
        '
        'rd8er
        '
        Me.rd8er.AutoSize = True
        Me.rd8er.Checked = True
        Me.rd8er.Location = New System.Drawing.Point(6, 19)
        Me.rd8er.Name = "rd8er"
        Me.rd8er.Size = New System.Drawing.Size(66, 17)
        Me.rd8er.TabIndex = 0
        Me.rd8er.TabStop = True
        Me.rd8er.Text = "8er Spiel"
        Me.rd8er.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kapital"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Min. Einsatz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Runden"
        '
        'nRunden
        '
        Me.nRunden.IsInteger = True
        Me.nRunden.Location = New System.Drawing.Point(81, 64)
        Me.nRunden.Name = "nRunden"
        Me.nRunden.Size = New System.Drawing.Size(155, 20)
        Me.nRunden.StartsWithNull = False
        Me.nRunden.TabIndex = 10
        Me.nRunden.Text = "100"
        Me.nRunden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nKapital
        '
        Me.nKapital.IsInteger = True
        Me.nKapital.Location = New System.Drawing.Point(81, 12)
        Me.nKapital.Name = "nKapital"
        Me.nKapital.Size = New System.Drawing.Size(155, 20)
        Me.nKapital.StartsWithNull = False
        Me.nKapital.TabIndex = 9
        Me.nKapital.Text = "100"
        Me.nKapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nEinsatz
        '
        Me.nEinsatz.IsInteger = True
        Me.nEinsatz.Location = New System.Drawing.Point(81, 38)
        Me.nEinsatz.Name = "nEinsatz"
        Me.nEinsatz.Size = New System.Drawing.Size(155, 20)
        Me.nEinsatz.StartsWithNull = False
        Me.nEinsatz.TabIndex = 8
        Me.nEinsatz.Text = "1"
        Me.nEinsatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmHaupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 171)
        Me.Controls.Add(Me.nRunden)
        Me.Controls.Add(Me.nKapital)
        Me.Controls.Add(Me.nEinsatz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStarten)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmHaupt"
        Me.Text = "Roulette System Simulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStarten As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdMarch As System.Windows.Forms.RadioButton
    Friend WithEvents rd8er As System.Windows.Forms.RadioButton
    Friend WithEvents rdMartingale As System.Windows.Forms.RadioButton
    Friend WithEvents nEinsatz As RouletteSystem.NumericTextBox
    Friend WithEvents nKapital As RouletteSystem.NumericTextBox
    Friend WithEvents nRunden As RouletteSystem.NumericTextBox

End Class
