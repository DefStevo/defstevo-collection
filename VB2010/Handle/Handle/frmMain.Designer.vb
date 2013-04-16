<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblHandle = New System.Windows.Forms.Label()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.lblWindowText = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblHandle
        '
        Me.lblHandle.AutoSize = True
        Me.lblHandle.Location = New System.Drawing.Point(12, 9)
        Me.lblHandle.Name = "lblHandle"
        Me.lblHandle.Size = New System.Drawing.Size(41, 13)
        Me.lblHandle.TabIndex = 0
        Me.lblHandle.Text = "Handle"
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(12, 31)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(25, 13)
        Me.lblPos.TabIndex = 1
        Me.lblPos.Text = "Pos"
        '
        'lblWindowText
        '
        Me.lblWindowText.AutoSize = True
        Me.lblWindowText.Location = New System.Drawing.Point(12, 55)
        Me.lblWindowText.Name = "lblWindowText"
        Me.lblWindowText.Size = New System.Drawing.Size(70, 13)
        Me.lblWindowText.TabIndex = 2
        Me.lblWindowText.Text = "Window Text"
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(12, 83)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(241, 23)
        Me.cmdStart.TabIndex = 3
        Me.cmdStart.Text = "Button1"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 110)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblWindowText)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.lblHandle)
        Me.Name = "frmMain"
        Me.Text = "Fenster-Handle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHandle As System.Windows.Forms.Label
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents lblWindowText As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer

End Class
