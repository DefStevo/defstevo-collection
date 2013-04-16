Public Class frmHaupt

    Private Sub frmHaupt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myRDP.Server = "192.168.1.3"
        myRDP.AdvancedSettings2.RDPPort = "3389"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myRDP.Connect()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myRDP.Disconnect()
    End Sub

    Private Sub myRDP_OnConnected(ByVal sender As Object, ByVal e As System.EventArgs) Handles myRDP.OnConnected
        Label1.Text = "Connected"
    End Sub

    
    Private Sub myRDP_OnConnecting(ByVal sender As Object, ByVal e As System.EventArgs) Handles myRDP.OnConnecting
        Label1.Text = "Connecting"
    End Sub

    Private Sub myRDP_OnDisconnected(ByVal sender As Object, ByVal e As AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent) Handles myRDP.OnDisconnected
        Label1.Text = "Disconnected"
    End Sub
End Class
