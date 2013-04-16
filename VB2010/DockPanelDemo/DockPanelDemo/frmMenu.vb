Imports WeifenLuo.WinFormsUI.Docking

Public Class frmMenu

    Private iChildCount = 0

    Private Sub NeuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        Dim frmChild As New frmChildForm
        iChildCount += 1
        frmChild.iChildIndex = iChildCount
        frmChild.Show(oDockPanel, DockState.Document)
    End Sub

    Private Sub oDockPanel_ActiveContentChanged(sender As System.Object, e As System.EventArgs) Handles oDockPanel.ActiveContentChanged

    End Sub

    Public Sub NewChild(oChild As WeifenLuo.WinFormsUI.Docking.DockContent)
        Dim NewForm As New WeifenLuo.WinFormsUI.Docking.DockContent
        NewForm = oChild
        iChildCount += 1
        NewForm.Tag = iChildCount.ToString
        NewForm.Show(oDockPanel, DockState.Document)
        'oChild.Show(oDockPanel, DockState.Document)
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Load Menu
        frmMenuStripe.CloseButton = False
        frmMenuStripe.Show(oDockMenu, DockState.Document)
    End Sub
End Class
