Public Class frmSettings


    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResolution.Text = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width.ToString & _
                                     "x" & _
                                     System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height.ToString
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tbResolution_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbResolution.Scroll
        Select Case tbResolution.Value
            Case 0
                lblResolution.Text = "640x480"
            Case 1
                lblResolution.Text = "800x600"
            Case 2
                lblResolution.Text = "1024x768"
            Case 3
                lblResolution.Text = "1280x1024"
            Case 4
                lblResolution.Text = "1600x1200"
            Case 5
                lblResolution.Text = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width.ToString & _
                                     "x" & _
                                     System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height.ToString
        End Select
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        mdlMain.s_Server = txtServer.Text
        mdlMain.i_Port = System.Convert.ToInt16(txtPort.Text)
        mdlMain.s_User = txtUser.Text
        mdlMain.s_Pass = txtPass.Text
        Select Case tbResolution.Value
            Case 0
                mdlMain.i_X = 640
                mdlMain.i_Y = 480
            Case 1
                mdlMain.i_X = 800
                mdlMain.i_Y = 600
            Case 2
                mdlMain.i_X = 1024
                mdlMain.i_Y = 768
            Case 3
                mdlMain.i_X = 1280
                mdlMain.i_Y = 1024
            Case 4
                mdlMain.i_X = 1600
                mdlMain.i_Y = 1200
            Case 5
                mdlMain.i_X = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width
                mdlMain.i_Y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height
        End Select
        mdlMain.fRDP.ShowDialog()
    End Sub
End Class