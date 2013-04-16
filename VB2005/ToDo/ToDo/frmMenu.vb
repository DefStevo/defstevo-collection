Public Class frmMenu
    Public Sub InitMenu()
        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        For i As Integer = 0 To mdlToDo._sLetzteDatei.Length - 1
            If i = 0 And Not mdlToDo._sLetzteDatei(i).ToString = "" Then
                With btn1
                    .Text = mdlToDo._sLetzteDatei(i).Substring(mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1, mdlToDo._sLetzteDatei(i).Length - (mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1))
                    .Tag = mdlToDo._sLetzteDatei(i).ToString
                    .Visible = True
                End With
            ElseIf i = 1 Then
                With btn2
                    .Text = mdlToDo._sLetzteDatei(i).Substring(mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1, mdlToDo._sLetzteDatei(i).Length - (mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1))
                    .Tag = mdlToDo._sLetzteDatei(i).ToString
                    .Visible = True
                End With
            ElseIf i = 2 Then
                With btn3
                    .Text = mdlToDo._sLetzteDatei(i).Substring(mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1, mdlToDo._sLetzteDatei(i).Length - (mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1))
                    .Tag = mdlToDo._sLetzteDatei(i).ToString
                    .Visible = True
                End With
            ElseIf i = 3 Then
                With btn4
                    .Text = mdlToDo._sLetzteDatei(i).Substring(mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1, mdlToDo._sLetzteDatei(i).Length - (mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1))
                    .Tag = mdlToDo._sLetzteDatei(i).ToString
                    .Visible = True
                End With
            ElseIf i = 4 Then
                With btn5
                    .Text = mdlToDo._sLetzteDatei(i).Substring(mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1, mdlToDo._sLetzteDatei(i).Length - (mdlToDo._sLetzteDatei(i).LastIndexOf("\") + 1))
                    .Tag = mdlToDo._sLetzteDatei(i).ToString
                    .Visible = True
                End With
            End If
        Next
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitMenu()
    End Sub

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        frmToDo.InitToDo(True, "", "")
    End Sub

    Private Sub btnLaden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaden.Click
        frmToDo.InitToDo(False, "", "")
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        frmToDo.InitToDo(False, btn1.Tag, btn1.Text)
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        frmToDo.InitToDo(False, btn2.Tag, btn2.Text)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        frmToDo.InitToDo(False, btn3.Tag, btn3.Text)
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        frmToDo.InitToDo(False, btn4.Tag, btn4.Text)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        frmToDo.InitToDo(False, btn5.Tag, btn5.Text)
    End Sub
End Class