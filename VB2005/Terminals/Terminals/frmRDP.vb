Public Class frmRDP

    Private Sub frmRDP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myRDP.Disconnect()
        'MsgBox("Closing")
    End Sub

    Private Sub frmRDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RDPSettings()
        RDPConnect()
    End Sub

    Private Sub myRDP_OnDisconnected(ByVal sender As Object, ByVal e As AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent) Handles myRDP.OnDisconnected
        Me.Close()
    End Sub

    Private Sub RDPSettings()
        'Fenstergröße setzen
        Me.Height = mdlMain.i_Y + 24
        Me.Width = mdlMain.i_X + 6

        'Remotedesktopgröße setzten
        myRDP.Height = mdlMain.i_Y
        myRDP.Width = mdlMain.i_X

        If mdlMain.i_X = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width And mdlMain.i_Y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height Then
            myRDP.FullScreen = True
        Else
            'Remotedesktopeinstellungen
            myRDP.DesktopHeight = mdlMain.i_Y
            myRDP.DesktopWidth = mdlMain.i_X
        End If

        'Remotedesktopeinstellungen
        myRDP.Server = mdlMain.s_Server
        myRDP.AdvancedSettings2.RDPPort = mdlMain.i_Port
        myRDP.UserName = mdlMain.s_User
        myRDP.AdvancedSettings2.ClearTextPassword = mdlMain.s_Pass

        myRDP.AdvancedSettings2.SmartSizing = True
    End Sub

    Private Sub RDPConnect()
        myRDP.Connect()
    End Sub

    Private Sub RDPDisconnect()
        If myRDP.Connected <> 0 Then
            myRDP.Disconnect()
        End If
    End Sub
End Class