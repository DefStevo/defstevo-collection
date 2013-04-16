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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgUser = New System.Windows.Forms.DataGridView()
        Me.cUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgProperties = New System.Windows.Forms.DataGridView()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cWert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(162, 4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(56, 6)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 1
        Me.txtServer.Text = "SBG-DC01"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server"
        '
        'dgUser
        '
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        Me.dgUser.AllowUserToOrderColumns = True
        Me.dgUser.AllowUserToResizeRows = False
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cUser, Me.cPath})
        Me.dgUser.Location = New System.Drawing.Point(12, 85)
        Me.dgUser.MultiSelect = False
        Me.dgUser.Name = "dgUser"
        Me.dgUser.RowHeadersWidth = 10
        Me.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUser.Size = New System.Drawing.Size(450, 150)
        Me.dgUser.TabIndex = 3
        '
        'cUser
        '
        Me.cUser.HeaderText = "Benutzer"
        Me.cUser.Name = "cUser"
        Me.cUser.Width = 120
        '
        'cPath
        '
        Me.cPath.HeaderText = "Pfad"
        Me.cPath.Name = "cPath"
        Me.cPath.Width = 300
        '
        'dgProperties
        '
        Me.dgProperties.AllowUserToAddRows = False
        Me.dgProperties.AllowUserToDeleteRows = False
        Me.dgProperties.AllowUserToOrderColumns = True
        Me.dgProperties.AllowUserToResizeRows = False
        Me.dgProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProperties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cName, Me.cWert})
        Me.dgProperties.Location = New System.Drawing.Point(12, 241)
        Me.dgProperties.MultiSelect = False
        Me.dgProperties.Name = "dgProperties"
        Me.dgProperties.RowHeadersWidth = 10
        Me.dgProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProperties.Size = New System.Drawing.Size(450, 150)
        Me.dgProperties.TabIndex = 4
        '
        'cName
        '
        Me.cName.HeaderText = "Name"
        Me.cName.Name = "cName"
        Me.cName.Width = 210
        '
        'cWert
        '
        Me.cWert.HeaderText = "Wert"
        Me.cWert.Name = "cWert"
        Me.cWert.Width = 210
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(56, 33)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(407, 20)
        Me.txt1.TabIndex = 5
        Me.txt1.Text = "&(ObjectClass=Person)"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(56, 59)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(407, 20)
        Me.txt2.TabIndex = 6
        Me.txt2.Text = "(cn=Stefan*)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 399)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.dgProperties)
        Me.Controls.Add(Me.dgUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frmMain"
        Me.Text = "LDAP-Tool"
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgUser As System.Windows.Forms.DataGridView
    Friend WithEvents dgProperties As System.Windows.Forms.DataGridView
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cWert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox

End Class
