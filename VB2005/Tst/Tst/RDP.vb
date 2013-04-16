Public Class RDP
    Friend WithEvents myRDP As MSTSCLib.IMsTscAx

    Private Sub RDP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myRDP = New MSTSCLib.MsTscAx

    End Sub
End Class