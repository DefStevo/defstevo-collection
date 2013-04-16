Imports RS_AP.clsConfig

Public Class frmHaupt
    Public Shared cConfig As New clsConfig
    Public Shared cExcel As New clsExcel

    Private Sub frmHaupt_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cExcel.Close(txtFile.Text)

    End Sub

    Private Sub frmHaupt_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & _
                 " (v. " & _
                 My.Application.Info.Version.Major.ToString & "." & _
                 My.Application.Info.Version.Minor.ToString & "." & _
                 My.Application.Info.Version.Build.ToString & ")"

        Timer1.Interval = 1
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Cursor.Current = Cursors.WaitCursor
        Me.Focus()

        Cursor.Current = Cursors.WaitCursor

        cConfig.InitConfig(True)

        txtFile.Text = cConfig.GetSettings(ESettings.RS_Vorlage).Replace(".\", My.Application.Info.DirectoryPath + "\")
        txtRange.Text = "E1"
        txtRange2.Text = "E1"
        txtValue.Text = "Wert"

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmChangeLog.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        cExcel.Open(txtFile.Text)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        txtResult.Text = cExcel.ReadRange(txtRange.Text)
    End Sub

    Private Sub txtFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFile.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        cExcel.WriteRange(txtRange2.Text, txtValue.Text)

    End Sub
End Class
