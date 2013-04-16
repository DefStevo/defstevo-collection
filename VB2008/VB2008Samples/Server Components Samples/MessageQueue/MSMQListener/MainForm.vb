' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.Messaging

Public Class MainForm

    Private m_Path As String = ".\private$\orders"

    ' Starts reading messages from the queue.
    Private Sub HookQueue()
        Try
            ' when we are stopped.
            If qOrders Is Nothing Then
                qOrders = New System.Messaging.MessageQueue(m_Path)
            End If

            ' Start waiting for messages to arrive.
            qOrders.BeginReceive()

        Catch exp As MessageQueueException
            My.Application.Log.WriteEntry(exp.Message)
        Catch exp As Exception
            My.Application.Log.WriteEntry(exp.Message)
        End Try
    End Sub

    ' Stops reading messages from the queue.
    Private Sub UnhookQueue()
        Try
            qOrders.Close()
        Catch exp As Exception
            My.Application.Log.WriteEntry(exp.Message)
        End Try
    End Sub

    ' Event Handler for message recieved event.
    Private Sub qOrders_ReceiveCompleted(ByVal sender As Object, ByVal e As System.Messaging.ReceiveCompletedEventArgs) Handles qOrders.ReceiveCompleted
        Try
            ' Get the message.
            Dim m As Message
            m = qOrders.EndReceive(e.AsyncResult)

            ' Add the message to the Listbox.
            OrderListbox.Items.Add(m.Label)

            ' Now continue listening for messages.
            qOrders.BeginReceive()

        Catch exp As MessageQueueException
            My.Application.Log.WriteEntry(exp.Message)
        Catch exp As Exception
            My.Application.Log.WriteEntry(exp.Message)
        End Try
    End Sub

    ' Clears the Listbox.
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        OrderListbox.Items.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Create the private queue if it does not exist.
        Try
            If Not MessageQueue.Exists(".\private$\orders") Then
                MessageQueue.Create(".\private$\orders")
            End If
        Catch ex As Exception

        End Try
    End Sub



    ' Toggles listening for messages.
    Private Sub Listen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listen.CheckedChanged
        If Listen.Checked Then
            Try
                HookQueue()
            Catch exp As MessageQueueException
                My.Application.Log.WriteEntry(exp.Message)
            Catch exp As Exception
                My.Application.Log.WriteEntry(exp.Message)
            End Try
        Else
            UnhookQueue()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
