Public Class frmToDo

    Public _Pfad As String = ""

    Public Sub InitToDo(ByVal Neu As Boolean, ByVal Pfad As String, ByVal Name As String)
        _Pfad = Pfad
        Me.Text = "ToDo-Listen Verwaltung: " & Name
        If Neu = True Then
            Me.Show()
        Else
            If _Pfad = "" Then
                fdLaden.ShowDialog()
                LadeToDo(mdlToDo.LeseToDo(fdLaden.FileName))
                Me.Show()
            Else
                LadeToDo(mdlToDo.LeseToDo(_Pfad))
                Me.Show()
            End If
        End If
    End Sub

    Private Sub LadeToDo(ByVal ToDo As String)
        Dim _ArrTodo() As String
        Dim _ArrTodo2() As String
        _ArrTodo = ToDo.Split(mdlToDo._sZeilenTrenn)
        For i As Integer = 0 To _ArrTodo.Length - 1
            dgToDo.Rows.Add()
            _ArrTodo2 = _ArrTodo(i).Split(mdlToDo._sSpaltenTrenn)
            For i2 As Integer = 0 To _ArrTodo2.Length - 1
                dgToDo.Rows(i).Cells(i2).Value = _ArrTodo2(i2).ToString
            Next
            _ArrTodo2 = Nothing
        Next
        _ArrTodo = Nothing
    End Sub

    Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
        Dim _sTodo As String = ""
        fdSpeichern.FileName = _Pfad
        fdSpeichern.ShowDialog()
        _Pfad = fdSpeichern.FileName
        For i As Integer = 0 To dgToDo.Rows.Count - 2
            For i2 As Integer = 0 To dgToDo.Columns.Count - 1
                _sTodo = _sTodo & dgToDo.Rows(i).Cells(i2).Value
                If Not i2 = dgToDo.Columns.Count - 1 Then
                    _sTodo = _sTodo & mdlToDo._sSpaltenTrenn
                End If
            Next
            If Not i = dgToDo.Rows.Count - 2 Then
                _sTodo = _sTodo & mdlToDo._sZeilenTrenn
            End If

        Next
        If mdlToDo.SchreibeToDo(_Pfad.ToString, _sTodo.ToString) = True Then
            mdlToDo.NeueLetzteDatei(_Pfad.ToString)
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        'Dim _AppExecl As New Microsoft.
    End Sub

    Private Sub frmToDo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class