Imports AppConfig

Public Class Form1

    Public _crypter As New clsCrypter
    Public _config As New clsConfig
    Public _DB As New clsDB
    Dim _RS As ADODB.Recordset

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _crypter.Crypt(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _crypter.DeCrypt(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _crypter.Key = My.Application.Info.AssemblyName
        TextBox2.Text = My.Application.Info.AssemblyName
        _config.File = My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".apcfg"
        _config.Crypter = _crypter
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _config.WriteVar(TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text)
        _config.WriteConfig(True)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        _config.ReadConfig(True)
        _config.ReadVar(TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text)
        _config.ClearVar()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        _DB.SetConnectionInfo(TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text)
        If _DB.ConnectDB() = True Then
            Button5.Text = "Datenbank Verbindung erfolgreich"
        Else
            Button5.Text = "Datenbank Verbindung fehlgeschlagen"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        _RS = _DB.OpenRS(TextBox8.Text)
        _RS.MoveFirst()
        Do While _RS.EOF = False
            TextBox1.Text = TextBox1.Text & _RS("TST_ID").Value & _RS("TST_NAME").Value & vbNewLine
            _RS.MoveNext()
        Loop
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim strName As String
        Dim arrFelder As String() = {"ID", "Name", "Name2"}
        Dim arrTyp As String() = {"INTEGER NOT NULL", "VARCHAR(50) NOT NULL", "VARCHAR(50) NULL"}
        strName = InputBox("Tabellenname?", "Bitte Tabellenname angeben")
        _DB.CreateTable(strName, arrFelder, arrTyp)
    End Sub
End Class
