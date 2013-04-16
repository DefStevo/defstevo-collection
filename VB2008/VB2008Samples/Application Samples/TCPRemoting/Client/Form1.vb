Imports System.Runtime.Remoting
Imports RemoteCustomer

Public Class Form1

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' To be used to obtain a reference to a Client Activated type
    ' This is similar to DCOM style programming.
    Private mCustomer As Customer

    ' This is to be used when we want multiple clients to connect
    ' to the same object instance on the server
    Private mSCustomer As SingletonCustomer

    Private Sub SetCtlState(ByVal NewState As Boolean)
        ' Ensable the create command button
        Me.cmdCreate.Enabled = NewState

        ' Disable other command buttons
        Me.cmdGet.Enabled = (Not NewState)
        Me.cmdUpdate.Enabled = (Not NewState)
        Me.cmdUpdateAndGet.Enabled = (Not NewState)
        Me.cmdDebugData.Enabled = (Not NewState)
        Me.cmdRelease.Enabled = (Not NewState)

        ' Set the radio buttons
        Me.rbClient.Enabled = NewState
        Me.rbSingle.Enabled = NewState

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'clear all items from the listbox
        Me.lstResponses.Items.Clear()
    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        Dim txt As String         ' Used in the catch handlers
        Try
            Dim objNotCreated As Boolean = False

            If Me.rbClient.Checked = True Then
                ' Use Client Activated Type
                ' Notice that in this call to New you can pass parameters to the constructor
                ' This type of object is very similar to a DCOM style object.
                mCustomer = New Customer(Me.lblDefNameValue.Text, CByte(Me.lblDefAgeValue.Text))
                objNotCreated = (mCustomer Is Nothing)
            Else
                ' Use Server Activated Type
                ' Notice that you can not pass values to a constructor in this case.
                ' this is becuase the server creates the instance and makes it available 
                ' to all as a singleton.  All we are doing is obtaining a reference to
                ' the running instance via a proxy.
                Dim args() As Object = Nothing
                mSCustomer = CType(Activator.CreateInstance(GetType(RemoteCustomer.SingletonCustomer), args), RemoteCustomer.SingletonCustomer)
                mSCustomer.NewClient()
                objNotCreated = (mSCustomer Is Nothing)
            End If

            ' Change the command buttons state
            SetCtlState(objNotCreated)

        Catch exp As RemotingException
            ' Will catch any generic Remoting exception
            txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace()

            MessageBox.Show(txt, "Remoting Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Catch exp As System.Net.Sockets.SocketException
            ' This will catch any Sockets exceptions.
            ' This can be caused since we're using the binary
            ' remoting interface which uses Sockets.
            txt = "I was unable to access the remote customer object." & vbCrLf & _
              "Is it possible the server is not running?" & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & _
              "  Error Code: " & exp.ErrorCode.ToString() & vbCrLf & _
              "  Native Error Code: " & exp.NativeErrorCode.ToString() & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace

            MessageBox.Show(txt, "Socket Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Catch exp As Exception
            ' Will catch any generic exception
            txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace

            MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Private Sub cmdDebugData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDebugData.Click
        ' Get debug data from the Client Activated type
        If ((Not mCustomer Is Nothing) Or (Not mSCustomer Is Nothing)) Then
            Try
                If Me.rbClient.Checked = True Then
                    With Me.lstResponses.Items
                        .Add("Debug data follows:")
                        .Add(String.Format("  Creation Time: {0}", mCustomer.DebugCreationTime.ToString))
                        .Add(String.Format("  Code Base: {0}", mCustomer.DebugCodeBase))
                        .Add(String.Format("  Fully Qualified Name: {0}", mCustomer.DebugFQName))
                        .Add(String.Format("  Remote Host Name: {0}", mCustomer.DebugHostName))
                        .Add("End Debug Data")
                    End With
                Else
                    With Me.lstResponses.Items
                        .Add("Debug data follows:")
                        .Add(String.Format("  Creation Time: {0}", mSCustomer.DebugCreationTime.ToString))
                        .Add(String.Format("  Code Base: {0}", mSCustomer.DebugCodeBase))
                        .Add(String.Format("  Fully Qualified Name: {0}", mSCustomer.DebugFQName))
                        .Add(String.Format("  Remote Host Name: {0}", mSCustomer.DebugHostName))
                        .Add(String.Format("  Number of connected clients: {0}", mSCustomer.Connected.ToString()))
                        .Add("End Debug Data")
                    End With
                End If
            Catch exp As Exception
                ' Will catch any generic exception
                ' See the code in cmdCreate for more detailed examples.
                Dim txt As String
                txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
                  "Detailed Error Information below:" & vbCrLf & vbCrLf & _
                  "  Message: " & exp.Message & vbCrLf & _
                  "  Source: " & exp.Source & vbCrLf & vbCrLf & _
                  "  Stack Trace:" & vbCrLf & _
                  exp.StackTrace

                MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
        End If
    End Sub

    Private Sub cmdGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        ' Ask the server for the customer data 
        Try
            If Me.rbClient.Checked = True Then
                Me.lstResponses.Items.Add(mCustomer.GetCustomerInfo())
            Else
                Me.lstResponses.Items.Add(mSCustomer.GetCustomerInfo())
            End If

        Catch exp As Exception
            ' Will catch any generic exception
            ' See the code in cmdCreate for more detailed examples.
            Dim txt As String
            txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace

            MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        ' Update the values on the server using public properties.
        ' Might not be the most effcient way to update data (esp. if you want a return value).
        ' See cmdUpdateAndGet for another example.
        If ((Not mCustomer Is Nothing) Or (Not mSCustomer Is Nothing)) Then
            Try
                If Me.rbClient.Checked = True Then
                    mCustomer.Name = Me.txtNewName.Text
                    mCustomer.Age = CByte(Me.txtNewAge.Text)
                Else
                    mSCustomer.Name = Me.txtNewName.Text
                    mSCustomer.Age = CByte(Me.txtNewAge.Text)
                End If

                Me.lstResponses.Items.Add("Update using properties successful!")

            Catch exp As Exception
                ' Will catch any generic exception
                ' See the code in cmdCreate for more detailed examples.
                Dim txt As String
                txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
                  "Detailed Error Information below:" & vbCrLf & vbCrLf & _
                  "  Message: " & exp.Message & vbCrLf & _
                  "  Source: " & exp.Source & vbCrLf & vbCrLf & _
                  "  Stack Trace:" & vbCrLf & _
                  exp.StackTrace

                MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
        End If
    End Sub

    Private Sub cmdUpdateAndGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateAndGet.Click
        ' Update the values on the server using a function that accepts both values
        ' and get the return data of the Client Activated type.
        ' This is generally a better format the code in cmdUpdate since it
        ' gets more work done in fewer round-trips.
        If ((Not mCustomer Is Nothing) Or (Not mSCustomer Is Nothing)) Then
            Try
                If Me.rbClient.Checked = True Then
                    With Me.lstResponses.Items
                        .Add(mCustomer.UpdateCustomerInfo(Me.txtNewName.Text, CByte(Me.txtNewAge.Text)))
                    End With
                Else
                    With Me.lstResponses.Items
                        .Add(mSCustomer.UpdateCustomerInfo(Me.txtNewName.Text, CByte(Me.txtNewAge.Text)))
                    End With
                End If

            Catch exp As Exception
                ' Will catch any generic exception
                ' See the code in cmdCreate for more detailed examples.
                Dim txt As String
                txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
                  "Detailed Error Information below:" & vbCrLf & vbCrLf & _
                  "  Message: " & exp.Message & vbCrLf & _
                  "  Source: " & exp.Source & vbCrLf & vbCrLf & _
                  "  Stack Trace:" & vbCrLf & _
                  exp.StackTrace

                MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub

    Private Sub cmdRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelease.Click
        ' Release our reference to the server object
        If ((Not mCustomer Is Nothing) Or (Not mSCustomer Is Nothing)) Then
            Dim objReleased As Boolean = False
            If rbClient.Checked = True Then
                ' Let go of the proxy reference
                mCustomer = Nothing
                objReleased = (mCustomer Is Nothing)
            Else
                ' Since the object exposes the method, we should call it.
                ' In our example it doesn't do anything fancy. It simply
                ' lowers the connected count.
                mSCustomer.Dispose()
                mSCustomer = Nothing
                objReleased = (mSCustomer Is Nothing)
            End If

            ' Change the command buttons state
            SetCtlState(objReleased)
        End If
    End Sub

    Private Sub cmdSingleCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSingleCall.Click
        ' SingleCall objects only live for the life of one method call.
        ' While the properties exist, they can only be used when the object is not
        ' being used in SingleCall mode.
        ' This model is very similar to a correct MTS/COM+ component implementation.

        ' Even though we're not providing arguments, we must pass
        ' array defined as object. Nothing won't work.
        Dim args() As Object = Nothing
        Dim cust As SingleCallCustomer

        Try
            cust = CType(Activator.CreateInstance(GetType(RemoteCustomer.SingleCallCustomer), args), RemoteCustomer.SingleCallCustomer)
            With Me.lstResponses.Items
                .Add("SingleCall.UpdateCustomerInfo: " & cust.UpdateCustomerInfo(Me.txtNewName.Text, CByte(Me.txtNewAge.Text)))
                .Add("Update Successful!")
            End With
        Catch exp As Exception
            ' Will catch any generic exception
            ' See the code in cmdCreate for more detailed examples.
            Dim txt As String
            txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace

            MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Private Sub cmdSingleDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSingleDebug.Click
        ' SingleCall objects only live for the life of one method call.
        ' Each time we go and get debug data, we're getting it from a 
        ' new instance of the object.

        ' Even though we're not providing arguments, we must pass
        ' array defined as object. Nothing won't work.
        Dim args() As Object = Nothing
        Dim scCust As SingleCallCustomer

        Try
            scCust = CType(Activator.CreateInstance(GetType(RemoteCustomer.SingleCallCustomer), args), RemoteCustomer.SingleCallCustomer)
            With Me.lstResponses.Items
                .Add("Debug data follows:")
                .Add(String.Format("  Creation Time: {0}", scCust.DebugCreationTime.ToString))
                .Add(String.Format("  Code Base: {0}", scCust.DebugCodeBase))
                .Add(String.Format("  Fully Qualified Name: {0}", scCust.DebugFQName))
                .Add(String.Format("  Remote Host Name: {0}", scCust.DebugHostName))
                ' Notice how the creation time is different!
                .Add(String.Format("  Creation Time: {0}", scCust.DebugCreationTime.ToString))
                .Add("End Debug Data")
            End With

        Catch exp As Exception
            ' Will catch any generic exception
            ' See the code in cmdCreate for more detailed examples.
            Dim txt As String
            txt = "I was unable to access the remote customer object." & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace

            MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try

    End Sub

    Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ' Let go of any objects we may still be holding on to
        If Not mCustomer Is Nothing Then
            mCustomer = Nothing
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Read in the application configuration file (client.exe.config).  This file has the remoting configuration
        'information for the client side remoting infrastructure.
        Try
            ' This assumes the file is in the same directory as this exe.
            RemotingConfiguration.Configure("client.exe.config", False)

        Catch exp As Exception
            ' Will catch any generic exception
            Dim txt As String
            txt = "I was unable to load the file config.xml." & vbCrLf & _
              "Please make sure it is located in the same directory as this exe " & _
              " and that it is in the correct format." & vbCrLf & _
              "Please see the Help, About box for the location of this exe." & vbCrLf & vbCrLf & _
              "Detailed Error Information below:" & vbCrLf & vbCrLf & _
              "  Message: " & exp.Message & vbCrLf & _
              "  Source: " & exp.Source & vbCrLf & vbCrLf & _
              "  Stack Trace:" & vbCrLf & _
              exp.StackTrace

            MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            ' turn of the create command buttons
            Me.cmdCreate.Enabled = False
        End Try

    End Sub

    Private Sub txtNewAge_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewAge.Validating
        ' Check to make sure only numeric values are entered
        ' and check to see if the datatype is a byte
        Try
            Dim d As Byte = CByte(Me.txtNewAge.Text)
        Catch exp As Exception
            Dim txt As String
            txt = "The value you entered, '{0}', for the Customer's New Age is incorrect." & vbCrLf & _
            "Please enter a value in the range of 0 to 255." & vbCrLf & _
            "The value will be reset to 0 by default."

            MessageBox.Show(String.Format(txt, Me.txtNewAge.Text), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Set the default value to 0 and cancel the field exit.
            Me.txtNewAge.Text = "0"
            e.Cancel = True
        End Try
    End Sub

End Class
