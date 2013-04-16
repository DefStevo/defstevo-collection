' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.Messaging

Public Class MainForm

    ' Places an order in the message queue.
    Private Sub OrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderButton.Click

        ' Place the order in the message queue.
        ' The body of each message could contain more order info.
        Try
            If Hamburger.Checked Then
                qOrders.Send("", "Hamburger")
            ElseIf Hotdog.Checked Then
                qOrders.Send("", "Hot Dog")
            ElseIf Drink.Checked Then
                qOrders.Send("", "Drink")
            Else
                qOrders.Send("", "Fries")
            End If
        Catch ex As Exception
            MsgBox("Message queueing is not installed or is not properly configured")
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Creates the private queue if it does not exist.
        Try
            If Not MessageQueue.Exists(".\private$\orders") Then
                MessageQueue.Create(".\private$\orders")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
