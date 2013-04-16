<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm
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
        Me.TabControl = New Crownwood.Magic.Controls.TabControl()
        Me.TabPage = New Crownwood.Magic.Controls.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNewPage = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = Crownwood.Magic.Controls.TabControl.VisualAppearance.MultiDocument
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.IDEPixelArea = True
        Me.TabControl.IDEPixelBorder = False
        Me.TabControl.Location = New System.Drawing.Point(0, 100)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Size = New System.Drawing.Size(933, 436)
        Me.TabControl.TabIndex = 0
        '
        'TabPage
        '
        Me.TabPage.Location = New System.Drawing.Point(0, 0)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.Selected = False
        Me.TabPage.Size = New System.Drawing.Size(200, 100)
        Me.TabPage.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNewPage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 100)
        Me.Panel1.TabIndex = 4
        '
        'btnNewPage
        '
        Me.btnNewPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNewPage.Location = New System.Drawing.Point(0, 0)
        Me.btnNewPage.Name = "btnNewPage"
        Me.btnNewPage.Size = New System.Drawing.Size(933, 100)
        Me.btnNewPage.TabIndex = 2
        Me.btnNewPage.Text = "New Page"
        Me.btnNewPage.UseVisualStyleBackColor = True
        '
        'frmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 536)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmForm"
        Me.Text = "frmLeer"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As Crownwood.Magic.Controls.TabControl
    Friend WithEvents TabPage As Crownwood.Magic.Controls.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewPage As System.Windows.Forms.Button
End Class
