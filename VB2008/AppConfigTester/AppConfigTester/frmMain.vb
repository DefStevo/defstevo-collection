

Public Class frmMain

#Region "Config"
    Private CFG As New AppConfig.clsConfig

    Private Sub btnDatei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        cfgFileDialog.ShowDialog()
        txtFile.Text = cfgFileDialog.FileName
    End Sub

    Private Sub btnReadCfg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadCfg.Click
        Dim sDummy As String = ""
        CFG.ReadConfig(False, txtFile.Text)
        txtConfig.Text = CFG.ConfigText
        CFG.ReadVar(sDummy, txtDBServer.Text, txtDBDatabase.Text, txtDBUser.Text, txtDBPass.Text, txtIndiv.Text)
        txtDBTyp.Text = txtDBTyp.Items(CFG.DBTyp)
    End Sub

    Private Sub btnWriteCfg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteCfg.Click
        CFG.WriteVar(txtDBTyp.Text.Substring(0, 1), txtDBServer.Text, txtDBDatabase.Text, txtDBUser.Text, txtDBPass.Text, txtIndiv.Text)
        CFG.WriteConfig(False, txtFile.Text, True)
        txtConfig.Text = CFG.ConfigText
    End Sub

    Private Sub btnCreateCfg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateCfg.Click
        CFG.WriteVar(txtDBTyp.Text.Substring(0, 1), txtDBServer.Text, txtDBDatabase.Text, txtDBUser.Text, txtDBPass.Text, txtIndiv.Text)
        CFG.WriteConfig(False, txtFile.Text, False)
        txtConfig.Text = CFG.ConfigText
    End Sub

    Private Sub btnReadCryptCFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadCryptCFG.Click
        Dim sDummy As String = ""
        CFG.Crypter = CRYPTER
        CFG.ReadConfig(True, txtFile.Text)
        txtConfig.Text = CFG.ConfigText
        CFG.ReadVar(sDummy, txtDBServer.Text, txtDBDatabase.Text, txtDBUser.Text, txtDBPass.Text, txtIndiv.Text)
        txtDBTyp.Text = txtDBTyp.Items(CFG.DBTyp)
    End Sub

    Private Sub btnWriteCryptCFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteCryptCFG.Click
        CFG.Crypter = CRYPTER
        CFG.WriteVar(txtDBTyp.Text.Substring(0, 1), txtDBServer.Text, txtDBDatabase.Text, txtDBUser.Text, txtDBPass.Text, txtIndiv.Text)
        CFG.WriteConfig(True, txtFile.Text, True)
        txtConfig.Text = CFG.ConfigText
    End Sub

    Private Sub btnCreateCryptCfg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateCryptCfg.Click
        CFG.Crypter = CRYPTER
        CFG.WriteVar(txtDBTyp.Text.Substring(0, 1), txtDBServer.Text, txtDBDatabase.Text, txtDBUser.Text, txtDBPass.Text, txtIndiv.Text)
        CFG.WriteConfig(True, txtFile.Text, False)
        txtConfig.Text = CFG.ConfigText
    End Sub

#End Region

#Region "Crypter"
    Private CRYPTER As New AppConfig.clsCrypter

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        If txtKey.Text = "" Then
            txtKey.Text = CRYPTER.Key
        Else
            CRYPTER.Key = txtKey.Text
        End If

        txtText2.Text = txtText1.Text
        CRYPTER.Crypt(txtText2.Text)
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        If txtKey.Text = "" Then
            txtKey.Text = CRYPTER.Key
        Else
            CRYPTER.Key = txtKey.Text
        End If

        txtText2.Text = txtText1.Text
        CRYPTER.DeCrypt(txtText2.Text)
    End Sub

#End Region

    Private cDB As New AppConfig.clsDB
    Private cReader As OleDb.OleDbDataReader

    Private Sub btnDBCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBCheck.Click
        cDB.SetConnectionInfo(txtTyp.Text.Substring(0, 1), txtServer.Text, txtDB.Text, txtUser.Text, txtPass.Text)

        cDB.ConnectDB()

        cReader = cDB.OpenRS(txtSQL.Text)

        If Not cReader Is Nothing Then

            While cReader.Read
                For i As Integer = 0 To cReader.FieldCount - 1
                    txtResult.Text = txtResult.Text & cReader.GetValue(i).ToString & vbTab
                Next
                txtResult.Text = txtResult.Text & vbNewLine

            End While

        Else
            txtResult.Text = "Keine Datensätze vorhanden"

        End If


    End Sub
End Class
