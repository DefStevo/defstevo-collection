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
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtHost = New System.Windows.Forms.TextBox
    Me.btnHinzufügen = New System.Windows.Forms.Button
    Me.lstHost = New System.Windows.Forms.ListView
    Me.colHost = New System.Windows.Forms.ColumnHeader
    Me.colAnzahl = New System.Windows.Forms.ColumnHeader
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtAnzahl = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(49, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Host"
    '
    'txtHost
    '
    Me.txtHost.Location = New System.Drawing.Point(94, 5)
    Me.txtHost.Name = "txtHost"
    Me.txtHost.Size = New System.Drawing.Size(146, 20)
    Me.txtHost.TabIndex = 3
    '
    'btnHinzufügen
    '
    Me.btnHinzufügen.Location = New System.Drawing.Point(160, 25)
    Me.btnHinzufügen.Name = "btnHinzufügen"
    Me.btnHinzufügen.Size = New System.Drawing.Size(80, 20)
    Me.btnHinzufügen.TabIndex = 5
    Me.btnHinzufügen.Text = "Hinzufügen"
    Me.btnHinzufügen.UseVisualStyleBackColor = True
    '
    'lstHost
    '
    Me.lstHost.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colHost, Me.colAnzahl})
    Me.lstHost.FullRowSelect = True
    Me.lstHost.GridLines = True
    Me.lstHost.Location = New System.Drawing.Point(12, 51)
    Me.lstHost.Name = "lstHost"
    Me.lstHost.Size = New System.Drawing.Size(277, 242)
    Me.lstHost.TabIndex = 6
    Me.lstHost.UseCompatibleStateImageBehavior = False
    Me.lstHost.View = System.Windows.Forms.View.Details
    '
    'colHost
    '
    Me.colHost.Text = "Host"
    Me.colHost.Width = 195
    '
    'colAnzahl
    '
    Me.colAnzahl.Text = "Anzahl"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(-2, 296)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(308, 13)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Doppelklick um Host zu entfernen"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(49, 28)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(39, 13)
    Me.Label3.TabIndex = 9
    Me.Label3.Text = "Anzahl"
    '
    'txtAnzahl
    '
    Me.txtAnzahl.Location = New System.Drawing.Point(94, 25)
    Me.txtAnzahl.Name = "txtAnzahl"
    Me.txtAnzahl.Size = New System.Drawing.Size(56, 20)
    Me.txtAnzahl.TabIndex = 8
    Me.txtAnzahl.Text = "10"
    Me.txtAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'frmEinstellungen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(303, 313)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtAnzahl)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lstHost)
    Me.Controls.Add(Me.btnHinzufügen)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtHost)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEinstellungen"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Einstellungen"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtHost As System.Windows.Forms.TextBox
  Friend WithEvents btnHinzufügen As System.Windows.Forms.Button
  Friend WithEvents lstHost As System.Windows.Forms.ListView
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents colHost As System.Windows.Forms.ColumnHeader
  Friend WithEvents colAnzahl As System.Windows.Forms.ColumnHeader
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtAnzahl As System.Windows.Forms.TextBox
End Class
