Namespace My

    Class MyApplication

        'Startup: Raised when the application starts, before the startup form is created.
        'Shutdown: Raised after all application forms are closed.  This event is not raised if the application is terminating abnormally.
        'UnhandledException: Raised if the application encounters an unhandled exception.
        'StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
        'NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

        ''' <summary>
        ''' Update the network connectivity status on the main form each time the connection status changes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            SetConnectionStatus(e.IsNetworkAvailable)
        End Sub

        ''' <summary>
        ''' Include logic here that should be performed before any forms are loaded
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' When the application starts, set the connection status on the status strip
            SetConnectionStatus(My.Computer.Network.IsAvailable)
        End Sub

        ''' <summary>
        ''' Update the status strip to denote the current network connection status
        ''' </summary>
        ''' <param name="connected"></param>
        ''' <remarks></remarks>
        Public Sub SetConnectionStatus(ByVal connected As Boolean)
            With My.Forms.MainForm.ConnectedStatusLabel
                If (connected) Then
                    .Image = My.Resources.connected.ToBitmap
                    .Text = My.Resources.ConnectedText
                Else
                    .Image = My.Resources.disconnected.ToBitmap
                    .Text = My.Resources.DisconnectedText
                End If
            End With
        End Sub

    End Class
End Namespace

