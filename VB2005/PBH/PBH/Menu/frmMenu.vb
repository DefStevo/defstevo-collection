Imports System.Windows.Forms

Public Class frmMenu

  Private m_ChildFormNumber As Integer = 0

  Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = "PBH.net   (" & Datenbank.Server & "\" & Datenbank.Datenbank & ")"
  End Sub

  Private Sub mnuSys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSys.Click
    If InputBox("Geschützter Bereich, bitte Kennwort eingeben!", "Systemverwaltung") = "x" & System.DateTime.Today.Day.ToString Then
      'TODO: Fenster für Systemverwaltung erstellen
    End If
  End Sub
End Class
