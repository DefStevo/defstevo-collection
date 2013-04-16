Imports AppConfig

Module mdlToDo
    Public _Config As New clsConfig
    Public _Crypter As New clsCrypter
    Public Const _sKey As String = "Key:ToDo16+07+08?"
    Public Const _sZeilenTrenn As String = "|"
    Public Const _sSpaltenTrenn As String = ";"
    Public Const _sEscCode As String = "<#>"
    Public _sDatei As String = Application.StartupPath & "\ToDo.apcfg"
    Public _sIndiv As String
    Public _sLetzteDatei() As String

    Sub Main()
        InitToDo()
        frmMenu.ShowDialog()
        ExitTodo()
    End Sub

    Function InitToDo() As Boolean
        _Crypter.Key = _sKey
        _Config.Crypter = _Crypter
        _Config.File = _sDatei
        _Config.ReadConfig(True)
        _Config.ReadVar(Nothing, Nothing, Nothing, Nothing, Nothing, _sIndiv)
        _sLetzteDatei = _sIndiv.Split(_sSpaltenTrenn)
        _sIndiv = Nothing
        Return True
        Exit Function
        Return False
    End Function

    Function ExitTodo() As Boolean
        For i As Integer = 0 To _sLetzteDatei.Length
            If i = _sLetzteDatei.Length - 1 Or i = 4 Then
                _sIndiv = _sIndiv & _sLetzteDatei(i).ToString
                Exit For
            Else
                _sIndiv = _sIndiv & _sLetzteDatei(i).ToString & _sSpaltenTrenn
            End If
        Next
        _Config.ClearVar()
        _Config.WriteVar(0, Nothing, Nothing, Nothing, Nothing, _sIndiv)
        _Config.WriteConfig(True)
    End Function

    Public Function LeseToDo(ByVal sDatei) As String
        Dim _strBuffer As String
        If System.IO.File.Exists(sDatei) Then
            Using sr As System.IO.StreamReader = System.IO.File.OpenText(sDatei)
                _strBuffer = sr.ReadToEnd
                sr.Close()
                _Crypter.DeCrypt(_strBuffer)
                Return _strBuffer.Replace(_sEscCode, Chr(13) & Chr(10))
            End Using
        Else
            Return ""
        End If
    End Function

    Public Function SchreibeToDo(ByVal sDatei As String, ByVal sTodo As String) As Boolean
        sTodo = sTodo.Replace(Chr(13) & Chr(10), _sEscCode)
        _Crypter.Crypt(sTodo)
        Using _sw As New System.IO.StreamWriter(sDatei)
            _sw.Write(sTodo.ToString)
            _sw.Close()
        End Using
        Return True
    End Function

    Public Function NeueLetzteDatei(ByVal sDatei As String) As Boolean
        For i As Integer = 0 To _sLetzteDatei.Length - 1
            If Not sDatei.Contains(_sLetzteDatei(i).ToString) Then
                sDatei = sDatei & _sSpaltenTrenn & _sLetzteDatei(i).ToString
            End If
        Next
        _sLetzteDatei = sDatei.Split(_sSpaltenTrenn)
        frmMenu.InitMenu()
    End Function
End Module
