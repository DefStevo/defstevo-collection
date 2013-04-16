<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrashBox
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
        Me.components = New System.ComponentModel.Container()
        Me.pTrashBox = New System.Windows.Forms.Panel()
        Me.tVisibility = New System.Windows.Forms.Timer(Me.components)
        Me.tCapture = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pTrashBox
        '
        Me.pTrashBox.AllowDrop = True
        Me.pTrashBox.Location = New System.Drawing.Point(0, 0)
        Me.pTrashBox.Name = "pTrashBox"
        Me.pTrashBox.Size = New System.Drawing.Size(94, 71)
        Me.pTrashBox.TabIndex = 0
        '
        'tVisibility
        '
        Me.tVisibility.Interval = 50
        '
        'tCapture
        '
        '
        'frmTrashBox
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(94, 71)
        Me.Controls.Add(Me.pTrashBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTrashBox"
        Me.Opacity = 0.1R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "TrashBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTrashBox As System.Windows.Forms.Panel
    Friend WithEvents tVisibility As System.Windows.Forms.Timer
    Friend WithEvents tCapture As System.Windows.Forms.Timer

End Class
