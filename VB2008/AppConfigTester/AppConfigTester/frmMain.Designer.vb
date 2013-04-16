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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnCreateCryptCfg = New System.Windows.Forms.Button
        Me.btnWriteCryptCFG = New System.Windows.Forms.Button
        Me.btnReadCryptCFG = New System.Windows.Forms.Button
        Me.txtConfig = New System.Windows.Forms.TextBox
        Me.btnCreateCfg = New System.Windows.Forms.Button
        Me.btnWriteCfg = New System.Windows.Forms.Button
        Me.btnReadCfg = New System.Windows.Forms.Button
        Me.txtDBTyp = New System.Windows.Forms.ComboBox
        Me.btnFile = New System.Windows.Forms.Button
        Me.txtIndiv = New System.Windows.Forms.TextBox
        Me.txtDBPass = New System.Windows.Forms.TextBox
        Me.txtDBUser = New System.Windows.Forms.TextBox
        Me.txtDBDatabase = New System.Windows.Forms.TextBox
        Me.txtDBServer = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnDecrypt = New System.Windows.Forms.Button
        Me.txtText2 = New System.Windows.Forms.TextBox
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnEncrypt = New System.Windows.Forms.Button
        Me.txtText1 = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.cfgFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnDBCheck = New System.Windows.Forms.Button
        Me.txtTyp = New System.Windows.Forms.ComboBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtDB = New System.Windows.Forms.TextBox
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSQL = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(630, 475)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCreateCryptCfg)
        Me.TabPage1.Controls.Add(Me.btnWriteCryptCFG)
        Me.TabPage1.Controls.Add(Me.btnReadCryptCFG)
        Me.TabPage1.Controls.Add(Me.txtConfig)
        Me.TabPage1.Controls.Add(Me.btnCreateCfg)
        Me.TabPage1.Controls.Add(Me.btnWriteCfg)
        Me.TabPage1.Controls.Add(Me.btnReadCfg)
        Me.TabPage1.Controls.Add(Me.txtDBTyp)
        Me.TabPage1.Controls.Add(Me.btnFile)
        Me.TabPage1.Controls.Add(Me.txtIndiv)
        Me.TabPage1.Controls.Add(Me.txtDBPass)
        Me.TabPage1.Controls.Add(Me.txtDBUser)
        Me.TabPage1.Controls.Add(Me.txtDBDatabase)
        Me.TabPage1.Controls.Add(Me.txtDBServer)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtFile)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(622, 449)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Config"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCreateCryptCfg
        '
        Me.btnCreateCryptCfg.Location = New System.Drawing.Point(316, 249)
        Me.btnCreateCryptCfg.Name = "btnCreateCryptCfg"
        Me.btnCreateCryptCfg.Size = New System.Drawing.Size(300, 24)
        Me.btnCreateCryptCfg.TabIndex = 23
        Me.btnCreateCryptCfg.Text = "Generiere Konfiguration Verschlüsselt"
        Me.btnCreateCryptCfg.UseVisualStyleBackColor = True
        '
        'btnWriteCryptCFG
        '
        Me.btnWriteCryptCFG.Location = New System.Drawing.Point(316, 218)
        Me.btnWriteCryptCFG.Name = "btnWriteCryptCFG"
        Me.btnWriteCryptCFG.Size = New System.Drawing.Size(300, 24)
        Me.btnWriteCryptCFG.TabIndex = 22
        Me.btnWriteCryptCFG.Text = "Schreibe Konfiguration Verschlüsselt (Datei)"
        Me.btnWriteCryptCFG.UseVisualStyleBackColor = True
        '
        'btnReadCryptCFG
        '
        Me.btnReadCryptCFG.Location = New System.Drawing.Point(316, 188)
        Me.btnReadCryptCFG.Name = "btnReadCryptCFG"
        Me.btnReadCryptCFG.Size = New System.Drawing.Size(300, 24)
        Me.btnReadCryptCFG.TabIndex = 21
        Me.btnReadCryptCFG.Text = "Lese Konfiguration Verschlüsselt (Datei)"
        Me.btnReadCryptCFG.UseVisualStyleBackColor = True
        '
        'txtConfig
        '
        Me.txtConfig.Location = New System.Drawing.Point(9, 279)
        Me.txtConfig.Multiline = True
        Me.txtConfig.Name = "txtConfig"
        Me.txtConfig.ReadOnly = True
        Me.txtConfig.Size = New System.Drawing.Size(607, 164)
        Me.txtConfig.TabIndex = 20
        Me.txtConfig.TabStop = False
        '
        'btnCreateCfg
        '
        Me.btnCreateCfg.Location = New System.Drawing.Point(9, 248)
        Me.btnCreateCfg.Name = "btnCreateCfg"
        Me.btnCreateCfg.Size = New System.Drawing.Size(300, 24)
        Me.btnCreateCfg.TabIndex = 10
        Me.btnCreateCfg.Text = "Generiere Konfiguration"
        Me.btnCreateCfg.UseVisualStyleBackColor = True
        '
        'btnWriteCfg
        '
        Me.btnWriteCfg.Location = New System.Drawing.Point(9, 218)
        Me.btnWriteCfg.Name = "btnWriteCfg"
        Me.btnWriteCfg.Size = New System.Drawing.Size(300, 24)
        Me.btnWriteCfg.TabIndex = 9
        Me.btnWriteCfg.Text = "Schreibe Konfiguration (Datei)"
        Me.btnWriteCfg.UseVisualStyleBackColor = True
        '
        'btnReadCfg
        '
        Me.btnReadCfg.Location = New System.Drawing.Point(9, 188)
        Me.btnReadCfg.Name = "btnReadCfg"
        Me.btnReadCfg.Size = New System.Drawing.Size(300, 24)
        Me.btnReadCfg.TabIndex = 8
        Me.btnReadCfg.Text = "Lese Konfiguration (Datei)"
        Me.btnReadCfg.UseVisualStyleBackColor = True
        '
        'txtDBTyp
        '
        Me.txtDBTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDBTyp.FormattingEnabled = True
        Me.txtDBTyp.Items.AddRange(New Object() {"0 = Keine DB", "1 = Access (*.mdb)", "2 = SQL-Server", "3 = Oracle"})
        Me.txtDBTyp.Location = New System.Drawing.Point(86, 30)
        Me.txtDBTyp.Name = "txtDBTyp"
        Me.txtDBTyp.Size = New System.Drawing.Size(530, 21)
        Me.txtDBTyp.TabIndex = 2
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(591, 6)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(25, 20)
        Me.btnFile.TabIndex = 1
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'txtIndiv
        '
        Me.txtIndiv.Location = New System.Drawing.Point(86, 161)
        Me.txtIndiv.Name = "txtIndiv"
        Me.txtIndiv.Size = New System.Drawing.Size(530, 20)
        Me.txtIndiv.TabIndex = 7
        '
        'txtDBPass
        '
        Me.txtDBPass.Location = New System.Drawing.Point(86, 135)
        Me.txtDBPass.Name = "txtDBPass"
        Me.txtDBPass.Size = New System.Drawing.Size(530, 20)
        Me.txtDBPass.TabIndex = 6
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(86, 109)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(530, 20)
        Me.txtDBUser.TabIndex = 5
        '
        'txtDBDatabase
        '
        Me.txtDBDatabase.Location = New System.Drawing.Point(86, 83)
        Me.txtDBDatabase.Name = "txtDBDatabase"
        Me.txtDBDatabase.Size = New System.Drawing.Size(530, 20)
        Me.txtDBDatabase.TabIndex = 4
        '
        'txtDBServer
        '
        Me.txtDBServer.Location = New System.Drawing.Point(86, 57)
        Me.txtDBServer.Name = "txtDBServer"
        Me.txtDBServer.Size = New System.Drawing.Size(530, 20)
        Me.txtDBServer.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Indiv"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DB-Pass"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DB-User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DB-Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DB-Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DB-Typ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Config-Datei"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(86, 6)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(505, 20)
        Me.txtFile.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDecrypt)
        Me.TabPage2.Controls.Add(Me.txtText2)
        Me.TabPage2.Controls.Add(Me.txtKey)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnEncrypt)
        Me.TabPage2.Controls.Add(Me.txtText1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(622, 449)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Crypter"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(316, 223)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(300, 24)
        Me.btnDecrypt.TabIndex = 14
        Me.btnDecrypt.Text = "Entschlüsseln"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtText2
        '
        Me.txtText2.Location = New System.Drawing.Point(6, 253)
        Me.txtText2.Multiline = True
        Me.txtText2.Name = "txtText2"
        Me.txtText2.ReadOnly = True
        Me.txtText2.Size = New System.Drawing.Size(610, 185)
        Me.txtText2.TabIndex = 0
        Me.txtText2.TabStop = False
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(86, 6)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(530, 20)
        Me.txtKey.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Key"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(6, 223)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(300, 24)
        Me.btnEncrypt.TabIndex = 13
        Me.btnEncrypt.Text = "Verschlüsseln"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'txtText1
        '
        Me.txtText1.Location = New System.Drawing.Point(6, 32)
        Me.txtText1.Multiline = True
        Me.txtText1.Name = "txtText1"
        Me.txtText1.Size = New System.Drawing.Size(610, 185)
        Me.txtText1.TabIndex = 12
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtResult)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtSQL)
        Me.TabPage3.Controls.Add(Me.txtTyp)
        Me.TabPage3.Controls.Add(Me.txtPass)
        Me.TabPage3.Controls.Add(Me.txtUser)
        Me.TabPage3.Controls.Add(Me.txtDB)
        Me.TabPage3.Controls.Add(Me.txtServer)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.btnDBCheck)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(622, 449)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DB"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(622, 449)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Error"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cfgFileDialog
        '
        Me.cfgFileDialog.CheckFileExists = False
        Me.cfgFileDialog.FileName = "AppConfigTester"
        Me.cfgFileDialog.Filter = "App-Config|*.apcfg"
        '
        'btnDBCheck
        '
        Me.btnDBCheck.Location = New System.Drawing.Point(6, 245)
        Me.btnDBCheck.Name = "btnDBCheck"
        Me.btnDBCheck.Size = New System.Drawing.Size(610, 50)
        Me.btnDBCheck.TabIndex = 0
        Me.btnDBCheck.Text = "Verbinden"
        Me.btnDBCheck.UseVisualStyleBackColor = True
        '
        'txtTyp
        '
        Me.txtTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTyp.FormattingEnabled = True
        Me.txtTyp.Items.AddRange(New Object() {"0 = Keine DB", "1 = Access (*.mdb)", "2 = SQL-Server", "3 = Oracle"})
        Me.txtTyp.Location = New System.Drawing.Point(86, 6)
        Me.txtTyp.Name = "txtTyp"
        Me.txtTyp.Size = New System.Drawing.Size(530, 21)
        Me.txtTyp.TabIndex = 8
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(86, 111)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(530, 20)
        Me.txtPass.TabIndex = 15
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(86, 85)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(530, 20)
        Me.txtUser.TabIndex = 14
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(86, 59)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(530, 20)
        Me.txtDB.TabIndex = 12
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(86, 33)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(530, 20)
        Me.txtServer.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "DB-Pass"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DB-User"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "DB-Database"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "DB-Server"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "DB-Typ"
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(86, 137)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(530, 102)
        Me.txtSQL.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Statement"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(9, 301)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(607, 145)
        Me.txtResult.TabIndex = 20
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents txtIndiv As System.Windows.Forms.TextBox
    Friend WithEvents txtDBPass As System.Windows.Forms.TextBox
    Friend WithEvents txtDBUser As System.Windows.Forms.TextBox
    Friend WithEvents txtDBDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtDBServer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDBTyp As System.Windows.Forms.ComboBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents cfgFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtConfig As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateCfg As System.Windows.Forms.Button
    Friend WithEvents btnWriteCfg As System.Windows.Forms.Button
    Friend WithEvents btnReadCfg As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtText2 As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtText1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateCryptCfg As System.Windows.Forms.Button
    Friend WithEvents btnWriteCryptCFG As System.Windows.Forms.Button
    Friend WithEvents btnReadCryptCFG As System.Windows.Forms.Button
    Friend WithEvents btnDBCheck As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents txtTyp As System.Windows.Forms.ComboBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtDB As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
