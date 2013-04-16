<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPage
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
        Me.lblPage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPage
        '
        Me.lblPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPage.Location = New System.Drawing.Point(0, 0)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(284, 261)
        Me.lblPage.TabIndex = 0
        Me.lblPage.Text = "Page"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPage)
        Me.Name = "frmPage"
        Me.Text = "frmPage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPage As System.Windows.Forms.Label
End Class
