
Public Class frmHaupt

    Private cRoulette As New clsRouletteSimulator

    Private Sub btnStarten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStarten.Click
        If nKapital.Text = "" _
            Or nEinsatz.Text = "" _
            Or nRunden.Text = "" Then
            Exit Sub
        End If

        Do While frmStatistik.dgStatistik.Rows.Count > 0
            frmStatistik.dgStatistik.Rows.RemoveAt(0)
        Loop

        cRoulette.Start()

    End Sub
End Class
