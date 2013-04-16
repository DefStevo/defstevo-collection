<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEinstellungen
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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.btnBearbeiten = New System.Windows.Forms.Button
    Me.btnEntfernen = New System.Windows.Forms.Button
    Me.btnHinzufügen = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.lstRouter = New System.Windows.Forms.ListView
    Me.colName = New System.Windows.Forms.ColumnHeader
    Me.colIP = New System.Windows.Forms.ColumnHeader
    Me.colGate = New System.Windows.Forms.ColumnHeader
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.txtPort = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.btnBeenden = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.btnBearbeiten)
    Me.GroupBox1.Controls.Add(Me.btnEntfernen)
    Me.GroupBox1.Controls.Add(Me.btnHinzufügen)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.lstRouter)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(431, 167)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Router"
    '
    'btnBearbeiten
    '
    Me.btnBearbeiten.Enabled = False
    Me.btnBearbeiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBearbeiten.Location = New System.Drawing.Point(154, 129)
    Me.btnBearbeiten.Name = "btnBearbeiten"
    Me.btnBearbeiten.Size = New System.Drawing.Size(124, 30)
    Me.btnBearbeiten.TabIndex = 4
    Me.btnBearbeiten.Text = "Router &Bearbeiten"
    Me.btnBearbeiten.UseVisualStyleBackColor = True
    '
    'btnEntfernen
    '
    Me.btnEntfernen.Enabled = False
    Me.btnEntfernen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEntfernen.Location = New System.Drawing.Point(302, 129)
    Me.btnEntfernen.Name = "btnEntfernen"
    Me.btnEntfernen.Size = New System.Drawing.Size(124, 30)
    Me.btnEntfernen.TabIndex = 3
    Me.btnEntfernen.Text = "Router &Entfernen"
    Me.btnEntfernen.UseVisualStyleBackColor = True
    '
    'btnHinzufügen
    '
    Me.btnHinzufügen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnHinzufügen.Location = New System.Drawing.Point(7, 129)
    Me.btnHinzufügen.Name = "btnHinzufügen"
    Me.btnHinzufügen.Size = New System.Drawing.Size(124, 30)
    Me.btnHinzufügen.TabIndex = 2
    Me.btnHinzufügen.Text = "Router &Hinzufügen"
    Me.btnHinzufügen.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(7, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Vorhande Router"
    '
    'lstRouter
    '
    Me.lstRouter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colIP, Me.colGate})
    Me.lstRouter.FullRowSelect = True
    Me.lstRouter.GridLines = True
    Me.lstRouter.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.lstRouter.Location = New System.Drawing.Point(7, 32)
    Me.lstRouter.Name = "lstRouter"
    Me.lstRouter.Size = New System.Drawing.Size(419, 91)
    Me.lstRouter.TabIndex = 0
    Me.lstRouter.UseCompatibleStateImageBehavior = False
    Me.lstRouter.View = System.Windows.Forms.View.Details
    '
    'colName
    '
    Me.colName.Text = "Name"
    Me.colName.Width = 212
    '
    'colIP
    '
    Me.colIP.Text = "IP-Adresse"
    Me.colIP.Width = 100
    '
    'colGate
    '
    Me.colGate.Text = "Gateway"
    Me.colGate.Width = 102
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txtPort)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(5, 181)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(431, 175)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Sonstiges"
    '
    'txtPort
    '
    Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPort.Location = New System.Drawing.Point(7, 34)
    Me.txtPort.MaxLength = 5
    Me.txtPort.Name = "txtPort"
    Me.txtPort.Size = New System.Drawing.Size(86, 20)
    Me.txtPort.TabIndex = 1
    Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(4, 18)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(89, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Verwendeter Port"
    '
    'btnBeenden
    '
    Me.btnBeenden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBeenden.Location = New System.Drawing.Point(312, 362)
    Me.btnBeenden.Name = "btnBeenden"
    Me.btnBeenden.Size = New System.Drawing.Size(124, 30)
    Me.btnBeenden.TabIndex = 4
    Me.btnBeenden.Text = "Bee&nden"
    Me.btnBeenden.UseVisualStyleBackColor = True
    '
    'frmEinstellungen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(448, 386)
    Me.Controls.Add(Me.btnBeenden)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "frmEinstellungen"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmEinstellungen"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lstRouter As System.Windows.Forms.ListView
  Friend WithEvents colName As System.Windows.Forms.ColumnHeader
  Friend WithEvents colIP As System.Windows.Forms.ColumnHeader
  Friend WithEvents colGate As System.Windows.Forms.ColumnHeader
  Friend WithEvents btnEntfernen As System.Windows.Forms.Button
  Friend WithEvents btnHinzufügen As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents txtPort As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnBearbeiten As System.Windows.Forms.Button
  Friend WithEvents btnBeenden As System.Windows.Forms.Button
End Class
