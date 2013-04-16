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
    Me.btnEinstellungen = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnEinstellungen
    '
    Me.btnEinstellungen.Location = New System.Drawing.Point(27, 33)
    Me.btnEinstellungen.Name = "btnEinstellungen"
    Me.btnEinstellungen.Size = New System.Drawing.Size(93, 39)
    Me.btnEinstellungen.TabIndex = 0
    Me.btnEinstellungen.Text = "&Einstellungen"
    Me.btnEinstellungen.UseVisualStyleBackColor = True
    '
    'frmMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(365, 310)
    Me.Controls.Add(Me.btnEinstellungen)
    Me.Name = "frmMenu"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "NetChecker"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnEinstellungen As System.Windows.Forms.Button

End Class
