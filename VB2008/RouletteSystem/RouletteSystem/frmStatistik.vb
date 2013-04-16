Public Class frmStatistik

    Private Sub frmStatistik_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        FensterGröße()
    End Sub

    Private Sub frmStatistik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FensterGröße()
    End Sub

    Private Sub FensterGröße()
        'Tab Container und Grid View neu positionieren
        TabStatistik.Width = Me.Width - 29
        TabStatistik.Height = Me.Height - 55
        TabStatistikÜbersicht.Width = Me.Width - 37
        TabStatistikÜbersicht.Height = Me.Height - 81
        TabStatistikDetail.Width = Me.Width - 37
        TabStatistikDetail.Height = Me.Height - 81
        dgStatistik.Width = TabStatistikDetail.Width
        dgStatistik.Height = TabStatistikDetail.Height
        DiagStatistik.Width = TabStatistikGrafik.Width
        DiagStatistik.Height = TabStatistikGrafik.Height
    End Sub
End Class