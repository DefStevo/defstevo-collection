<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChildForm
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(12, 12)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(260, 237)
        Me.btnMessage.TabIndex = 0
        Me.btnMessage.Text = "Hallo Welt"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'frmChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnMessage)
        Me.Name = "frmChildForm"
        Me.Text = "Child Fenster"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMessage As System.Windows.Forms.Button
End Class
