<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuStripe
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNewChildThread = New System.Windows.Forms.Button()
        Me.btnExtForm = New System.Windows.Forms.Button()
        Me.btnNewChild = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VScrollBar1)
        Me.Panel1.Controls.Add(Me.btnNewChildThread)
        Me.Panel1.Controls.Add(Me.btnExtForm)
        Me.Panel1.Controls.Add(Me.btnNewChild)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 376)
        Me.Panel1.TabIndex = 3
        '
        'btnNewChildThread
        '
        Me.btnNewChildThread.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNewChildThread.Location = New System.Drawing.Point(0, 66)
        Me.btnNewChildThread.Name = "btnNewChildThread"
        Me.btnNewChildThread.Size = New System.Drawing.Size(108, 310)
        Me.btnNewChildThread.TabIndex = 5
        Me.btnNewChildThread.Text = "Neues Fenster Thread"
        Me.btnNewChildThread.UseVisualStyleBackColor = True
        '
        'btnExtForm
        '
        Me.btnExtForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExtForm.Location = New System.Drawing.Point(0, 33)
        Me.btnExtForm.Name = "btnExtForm"
        Me.btnExtForm.Size = New System.Drawing.Size(173, 33)
        Me.btnExtForm.TabIndex = 4
        Me.btnExtForm.Text = "Neues Externes Form"
        Me.btnExtForm.UseVisualStyleBackColor = True
        '
        'btnNewChild
        '
        Me.btnNewChild.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewChild.Location = New System.Drawing.Point(0, 0)
        Me.btnNewChild.Name = "btnNewChild"
        Me.btnNewChild.Size = New System.Drawing.Size(173, 33)
        Me.btnNewChild.TabIndex = 3
        Me.btnNewChild.Text = "Neues Fenster"
        Me.btnNewChild.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(163, 66)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(10, 310)
        Me.VScrollBar1.TabIndex = 6
        '
        'frmMenuStripe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(173, 376)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMenuStripe"
        Me.Text = "frmMenuStripe"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewChildThread As System.Windows.Forms.Button
    Friend WithEvents btnExtForm As System.Windows.Forms.Button
    Friend WithEvents btnNewChild As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
End Class
