<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbSingle = New System.Windows.Forms.RadioButton
        Me.rbClient = New System.Windows.Forms.RadioButton
        Me.cmdUpdateAndGet = New System.Windows.Forms.Button
        Me.cmdDebugData = New System.Windows.Forms.Button
        Me.txtNewAge = New System.Windows.Forms.TextBox
        Me.txtNewName = New System.Windows.Forms.TextBox
        Me.cmdRelease = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSingleDebug = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDefAgeValue = New System.Windows.Forms.Label
        Me.cmdSingleCall = New System.Windows.Forms.Button
        Me.lblDefNameValue = New System.Windows.Forms.Label
        Me.gbSingle = New System.Windows.Forms.GroupBox
        Me.lblDefAge = New System.Windows.Forms.Label
        Me.lblDefName = New System.Windows.Forms.Label
        Me.gbInputData = New System.Windows.Forms.GroupBox
        Me.gbTwo = New System.Windows.Forms.GroupBox
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdGet = New System.Windows.Forms.Button
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.lstResponses = New System.Windows.Forms.ListBox
        Me.cmdClear = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gbSingle.SuspendLayout()
        Me.gbInputData.SuspendLayout()
        Me.gbTwo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbSingle
        '
        Me.rbSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbSingle.Location = New System.Drawing.Point(8, 48)
        Me.rbSingle.Name = "rbSingle"
        Me.rbSingle.Size = New System.Drawing.Size(150, 23)
        Me.rbSingle.TabIndex = 16
        Me.rbSingle.Text = "&Singleton"
        '
        'rbClient
        '
        Me.rbClient.Checked = True
        Me.rbClient.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rbClient.Location = New System.Drawing.Point(8, 24)
        Me.rbClient.Name = "rbClient"
        Me.rbClient.Size = New System.Drawing.Size(150, 23)
        Me.rbClient.TabIndex = 15
        Me.rbClient.Text = "Client &Activated"
        '
        'cmdUpdateAndGet
        '
        Me.cmdUpdateAndGet.Enabled = False
        Me.cmdUpdateAndGet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUpdateAndGet.Location = New System.Drawing.Point(8, 176)
        Me.cmdUpdateAndGet.Name = "cmdUpdateAndGet"
        Me.cmdUpdateAndGet.Size = New System.Drawing.Size(150, 23)
        Me.cmdUpdateAndGet.TabIndex = 14
        Me.cmdUpdateAndGet.Text = "Update && Ge&t Values"
        '
        'cmdDebugData
        '
        Me.cmdDebugData.Enabled = False
        Me.cmdDebugData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDebugData.Location = New System.Drawing.Point(8, 208)
        Me.cmdDebugData.Name = "cmdDebugData"
        Me.cmdDebugData.Size = New System.Drawing.Size(150, 23)
        Me.cmdDebugData.TabIndex = 13
        Me.cmdDebugData.Text = "Get &Debug Data"
        '
        'txtNewAge
        '
        Me.txtNewAge.Location = New System.Drawing.Point(112, 104)
        Me.txtNewAge.Name = "txtNewAge"
        Me.txtNewAge.Size = New System.Drawing.Size(40, 20)
        Me.txtNewAge.TabIndex = 24
        Me.txtNewAge.Text = "29"
        Me.txtNewAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(112, 80)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(100, 20)
        Me.txtNewName.TabIndex = 23
        Me.txtNewName.Text = "Denise Smith"
        '
        'cmdRelease
        '
        Me.cmdRelease.Enabled = False
        Me.cmdRelease.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRelease.Location = New System.Drawing.Point(8, 240)
        Me.cmdRelease.Name = "cmdRelease"
        Me.cmdRelease.Size = New System.Drawing.Size(150, 23)
        Me.cmdRelease.TabIndex = 12
        Me.cmdRelease.Text = "&Release Instance"
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(8, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Ne&w Age"
        '
        'cmdSingleDebug
        '
        Me.cmdSingleDebug.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSingleDebug.Location = New System.Drawing.Point(8, 56)
        Me.cmdSingleDebug.Name = "cmdSingleDebug"
        Me.cmdSingleDebug.Size = New System.Drawing.Size(150, 23)
        Me.cmdSingleDebug.TabIndex = 20
        Me.cmdSingleDebug.Text = "Single Call Deb&ug Data"
        '
        'Label2
        '
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "New &Name"
        '
        'lblDefAgeValue
        '
        Me.lblDefAgeValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefAgeValue.Location = New System.Drawing.Point(112, 48)
        Me.lblDefAgeValue.Name = "lblDefAgeValue"
        Me.lblDefAgeValue.Size = New System.Drawing.Size(40, 23)
        Me.lblDefAgeValue.TabIndex = 20
        Me.lblDefAgeValue.Text = "30"
        Me.lblDefAgeValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdSingleCall
        '
        Me.cmdSingleCall.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSingleCall.Location = New System.Drawing.Point(8, 24)
        Me.cmdSingleCall.Name = "cmdSingleCall"
        Me.cmdSingleCall.Size = New System.Drawing.Size(150, 23)
        Me.cmdSingleCall.TabIndex = 19
        Me.cmdSingleCall.Text = "Update && Get &Values"
        '
        'lblDefNameValue
        '
        Me.lblDefNameValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefNameValue.Location = New System.Drawing.Point(112, 24)
        Me.lblDefNameValue.Name = "lblDefNameValue"
        Me.lblDefNameValue.Size = New System.Drawing.Size(100, 23)
        Me.lblDefNameValue.TabIndex = 19
        Me.lblDefNameValue.Text = "John Smith"
        '
        'gbSingle
        '
        Me.gbSingle.Controls.Add(Me.cmdSingleDebug)
        Me.gbSingle.Controls.Add(Me.cmdSingleCall)
        Me.gbSingle.Location = New System.Drawing.Point(182, 180)
        Me.gbSingle.Name = "gbSingle"
        Me.gbSingle.Size = New System.Drawing.Size(168, 128)
        Me.gbSingle.TabIndex = 24
        Me.gbSingle.TabStop = False
        Me.gbSingle.Text = "Single Call"
        '
        'lblDefAge
        '
        Me.lblDefAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefAge.Location = New System.Drawing.Point(8, 48)
        Me.lblDefAge.Name = "lblDefAge"
        Me.lblDefAge.Size = New System.Drawing.Size(100, 23)
        Me.lblDefAge.TabIndex = 18
        Me.lblDefAge.Text = "Default Age"
        '
        'lblDefName
        '
        Me.lblDefName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefName.Location = New System.Drawing.Point(8, 24)
        Me.lblDefName.Name = "lblDefName"
        Me.lblDefName.Size = New System.Drawing.Size(100, 23)
        Me.lblDefName.TabIndex = 17
        Me.lblDefName.Text = "Default Name"
        '
        'gbInputData
        '
        Me.gbInputData.Controls.Add(Me.txtNewAge)
        Me.gbInputData.Controls.Add(Me.txtNewName)
        Me.gbInputData.Controls.Add(Me.Label1)
        Me.gbInputData.Controls.Add(Me.Label2)
        Me.gbInputData.Controls.Add(Me.lblDefAgeValue)
        Me.gbInputData.Controls.Add(Me.lblDefNameValue)
        Me.gbInputData.Controls.Add(Me.lblDefAge)
        Me.gbInputData.Controls.Add(Me.lblDefName)
        Me.gbInputData.Location = New System.Drawing.Point(182, 36)
        Me.gbInputData.Name = "gbInputData"
        Me.gbInputData.Size = New System.Drawing.Size(224, 136)
        Me.gbInputData.TabIndex = 23
        Me.gbInputData.TabStop = False
        Me.gbInputData.Text = "Input Data"
        '
        'gbTwo
        '
        Me.gbTwo.Controls.Add(Me.rbSingle)
        Me.gbTwo.Controls.Add(Me.rbClient)
        Me.gbTwo.Controls.Add(Me.cmdUpdateAndGet)
        Me.gbTwo.Controls.Add(Me.cmdDebugData)
        Me.gbTwo.Controls.Add(Me.cmdRelease)
        Me.gbTwo.Controls.Add(Me.cmdUpdate)
        Me.gbTwo.Controls.Add(Me.cmdGet)
        Me.gbTwo.Controls.Add(Me.cmdCreate)
        Me.gbTwo.Location = New System.Drawing.Point(6, 36)
        Me.gbTwo.Name = "gbTwo"
        Me.gbTwo.Size = New System.Drawing.Size(168, 272)
        Me.gbTwo.TabIndex = 22
        Me.gbTwo.TabStop = False
        Me.gbTwo.Text = "Client Activated or Singleton"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUpdate.Location = New System.Drawing.Point(8, 144)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(150, 23)
        Me.cmdUpdate.TabIndex = 11
        Me.cmdUpdate.Text = "&Update Values"
        '
        'cmdGet
        '
        Me.cmdGet.Enabled = False
        Me.cmdGet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGet.Location = New System.Drawing.Point(8, 112)
        Me.cmdGet.Name = "cmdGet"
        Me.cmdGet.Size = New System.Drawing.Size(150, 23)
        Me.cmdGet.TabIndex = 10
        Me.cmdGet.Text = "&Get Current Values"
        '
        'cmdCreate
        '
        Me.cmdCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCreate.Location = New System.Drawing.Point(8, 80)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(150, 23)
        Me.cmdCreate.TabIndex = 9
        Me.cmdCreate.Text = "Create &Instance"
        '
        'lstResponses
        '
        Me.lstResponses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResponses.FormattingEnabled = True
        Me.lstResponses.Location = New System.Drawing.Point(6, 316)
        Me.lstResponses.Name = "lstResponses"
        Me.lstResponses.Size = New System.Drawing.Size(398, 121)
        Me.lstResponses.TabIndex = 21
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(252, 446)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(150, 23)
        Me.cmdClear.TabIndex = 20
        Me.cmdClear.Text = "Clear &List"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(412, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 504)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbInputData)
        Me.Controls.Add(Me.gbTwo)
        Me.Controls.Add(Me.lstResponses)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.gbSingle)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Remoting Client Sample"
        Me.gbSingle.ResumeLayout(False)
        Me.gbInputData.ResumeLayout(False)
        Me.gbInputData.PerformLayout()
        Me.gbTwo.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbSingle As System.Windows.Forms.RadioButton
    Friend WithEvents rbClient As System.Windows.Forms.RadioButton
    Friend WithEvents cmdUpdateAndGet As System.Windows.Forms.Button
    Friend WithEvents cmdDebugData As System.Windows.Forms.Button
    Friend WithEvents txtNewAge As System.Windows.Forms.TextBox
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents cmdRelease As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSingleDebug As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDefAgeValue As System.Windows.Forms.Label
    Friend WithEvents cmdSingleCall As System.Windows.Forms.Button
    Friend WithEvents lblDefNameValue As System.Windows.Forms.Label
    Friend WithEvents gbSingle As System.Windows.Forms.GroupBox
    Friend WithEvents lblDefAge As System.Windows.Forms.Label
    Friend WithEvents lblDefName As System.Windows.Forms.Label
    Friend WithEvents gbInputData As System.Windows.Forms.GroupBox
    Friend WithEvents gbTwo As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdGet As System.Windows.Forms.Button
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents lstResponses As System.Windows.Forms.ListBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
