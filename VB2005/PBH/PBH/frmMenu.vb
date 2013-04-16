Public Class frmMenu
  Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = "PBH.net   (" & Datenbank.Server & "\" & Datenbank.Datenbank & ")"
    frmSplash.Close()
  End Sub

  Private Sub mnuAdr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdr.Click
    Dim frmAdr As New frmAdrKto
    If FensterOffen("Adr") = True Then
      frmAdr.MdiParent = Me
      frmAdr.Tag = "Adr"
      frmAdr.Show()
    End If
  End Sub

  Private Sub mnuKto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKto.Click
    Dim frmKto As New frmAdrKto
    If FensterOffen("Kto") = True Then
      frmKto.MdiParent = Me
      frmKto.Tag = "Kto"
      frmKto.Show()
    End If
  End Sub

  Private Sub mnuBuch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuch.Click
    Dim frmBuch As New frmBuch
    If FensterOffen("Buch") = True Then
      frmBuch.MdiParent = Me
      frmBuch.Tag = "Buch"
      frmBuch.Show()
    End If
  End Sub

  Private Sub mnuSys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSys.Click
    Dim frmEinst As New frmEinst
    If FensterOffen("Einst") = True Then
      frmEinst.MdiParent = Me
      frmEinst.Tag = "Einst"
      frmEinst.Show()
    End If
  End Sub

  Function FensterOffen(ByVal Name As String) As Boolean
    For Each frmMDI As Form In Me.MdiChildren
      If frmMDI.Tag = Name Then
        Return False
      End If
    Next
    Return True
  End Function

End Class
