Public Class frmEinstellungen
  Private Sub frmEinstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'app.config auslesen
    LadeRouter()
    LadeEinstellungen()
  End Sub

  Private Sub btnHinzufügen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHinzufügen.Click
    frmRouter.ID = lstRouter.Items.Count + 1
    frmRouter.ShowDialog()
  End Sub

  Private Sub btnBeenden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeenden.Click
    Me.Close()
  End Sub

  Public Sub LadeRouter()
    lstRouter.Items.Clear()
    If Not My.Settings.Name1 = "" Then
      lstRouter.Items.Add(My.Settings.Name1)
      lstRouter.Items(0).SubItems.Add(My.Settings.IP1)
      lstRouter.Items(0).SubItems.Add(My.Settings.Gate1)
      btnBearbeiten.Enabled = True
      btnEntfernen.Enabled = True
    End If
    If Not My.Settings.Name2 = "" Then
      lstRouter.Items.Add(My.Settings.Name2)
      lstRouter.Items(1).SubItems.Add(My.Settings.IP2)
      lstRouter.Items(1).SubItems.Add(My.Settings.Gate2)
      btnBearbeiten.Enabled = True
      btnEntfernen.Enabled = True
    End If
    If Not My.Settings.Name3 = "" Then
      lstRouter.Items.Add(My.Settings.Name3)
      lstRouter.Items(2).SubItems.Add(My.Settings.IP3)
      lstRouter.Items(2).SubItems.Add(My.Settings.Gate3)
      btnBearbeiten.Enabled = True
      btnEntfernen.Enabled = True
    End If
    If Not My.Settings.Name4 = "" Then
      lstRouter.Items.Add(My.Settings.Name4)
      lstRouter.Items(3).SubItems.Add(My.Settings.IP4)
      lstRouter.Items(3).SubItems.Add(My.Settings.Gate4)
      btnBearbeiten.Enabled = True
      btnEntfernen.Enabled = True
    End If
    If Not My.Settings.Name5 = "" Then
      lstRouter.Items.Add(My.Settings.Name5)
      lstRouter.Items(4).SubItems.Add(My.Settings.IP5)
      lstRouter.Items(4).SubItems.Add(My.Settings.Gate5)
      btnBearbeiten.Enabled = True
      btnEntfernen.Enabled = True
      btnHinzufügen.Enabled = False
    End If
  End Sub

  Public Sub LadeEinstellungen()
    txtPort.Text = My.Settings.Port
  End Sub

  Private Sub btnEntfernen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntfernen.Click
    Try
      Select Case lstRouter.FocusedItem.Index + 1
        Case 1
          My.Settings.Name1 = ""
          My.Settings.IP1 = "0.0.0.0"
          My.Settings.Gate1 = "0.0.0.0"
          'Prüfen ob mehr als 1 Router vorhanden
          Select Case lstRouter.Items.Count
            Case 1
              'Kein Router mehr vorhanden daher werden die Buttons Disabled
              btnEntfernen.Enabled = False
              btnBearbeiten.Enabled = False
            Case 2
              'Werte von Router 2 werden auf Router 1 kopiert
              My.Settings.Name1 = My.Settings.Name2
              My.Settings.IP1 = My.Settings.IP2
              My.Settings.Gate1 = My.Settings.Gate2
              'Werte von Router 2 werden entfernt
              My.Settings.Name2 = ""
              My.Settings.IP2 = "0.0.0.0"
              My.Settings.Gate2 = "0.0.0.0"
            Case 3
              'Werte von Router 2 werden auf Router 1 kopiert
              My.Settings.Name1 = My.Settings.Name2
              My.Settings.IP1 = My.Settings.IP2
              My.Settings.Gate1 = My.Settings.Gate2
              'Werte von Router 3 werden auf Router 2 kopiert
              My.Settings.Name2 = My.Settings.Name3
              My.Settings.IP2 = My.Settings.IP3
              My.Settings.Gate2 = My.Settings.Gate3
              'Werte von Router 3 werden entfernt
              My.Settings.Name3 = ""
              My.Settings.IP3 = "0.0.0.0"
              My.Settings.Gate3 = "0.0.0.0"
            Case 4
              'Werte von Router 2 werden auf Router 1 kopiert
              My.Settings.Name1 = My.Settings.Name2
              My.Settings.IP1 = My.Settings.IP2
              My.Settings.Gate1 = My.Settings.Gate2
              'Werte von Router 3 werden auf Router 2 kopiert
              My.Settings.Name2 = My.Settings.Name3
              My.Settings.IP2 = My.Settings.IP3
              My.Settings.Gate2 = My.Settings.Gate3
              'Werte von Router 4 werden auf Router 3 kopiert
              My.Settings.Name3 = My.Settings.Name4
              My.Settings.IP3 = My.Settings.IP4
              My.Settings.Gate3 = My.Settings.Gate4
              'Werte von Router 4 werden entfernt
              My.Settings.Name4 = ""
              My.Settings.IP4 = "0.0.0.0"
              My.Settings.Gate4 = "0.0.0.0"
            Case 5
              'Werte von Router 2 werden auf Router 1 kopiert
              My.Settings.Name1 = My.Settings.Name2
              My.Settings.IP1 = My.Settings.IP2
              My.Settings.Gate1 = My.Settings.Gate2
              'Werte von Router 3 werden auf Router 2 kopiert
              My.Settings.Name2 = My.Settings.Name3
              My.Settings.IP2 = My.Settings.IP3
              My.Settings.Gate2 = My.Settings.Gate3
              'Werte von Router 4 werden auf Router 3 kopiert
              My.Settings.Name3 = My.Settings.Name4
              My.Settings.IP3 = My.Settings.IP4
              My.Settings.Gate3 = My.Settings.Gate4
              'Werte von Router 5 werden auf Router 4 kopiert
              My.Settings.Name4 = My.Settings.Name5
              My.Settings.IP4 = My.Settings.IP5
              My.Settings.Gate4 = My.Settings.Gate5
              'Werte von Router 5 werden entfernt
              My.Settings.Name5 = ""
              My.Settings.IP5 = "0.0.0.0"
              My.Settings.Gate5 = "0.0.0.0"
              btnHinzufügen.Enabled = True
          End Select
        Case 2
          My.Settings.Name2 = ""
          My.Settings.IP2 = "0.0.0.0"
          My.Settings.Gate2 = "0.0.0.0"
          'Prüfen ob mehr als 2 Router vorhanden
          If lstRouter.Items.Count > 2 Then
            Select Case lstRouter.Items.Count
              Case 3
                'Werte von Router 3 werden auf Router 2 kopiert
                My.Settings.Name2 = My.Settings.Name3
                My.Settings.IP2 = My.Settings.IP3
                My.Settings.Gate2 = My.Settings.Gate3
                'Werte von Router 3 werden entfernt
                My.Settings.Name3 = ""
                My.Settings.IP3 = "0.0.0.0"
                My.Settings.Gate3 = "0.0.0.0"
              Case 4
                'Werte von Router 3 werden auf Router 2 kopiert
                My.Settings.Name2 = My.Settings.Name3
                My.Settings.IP2 = My.Settings.IP3
                My.Settings.Gate2 = My.Settings.Gate3
                'Werte von Router 4 werden auf Router 3 kopiert
                My.Settings.Name3 = My.Settings.Name4
                My.Settings.IP3 = My.Settings.IP4
                My.Settings.Gate3 = My.Settings.Gate4
                'Werte von Router 4 werden entfernt
                My.Settings.Name4 = ""
                My.Settings.IP4 = "0.0.0.0"
                My.Settings.Gate4 = "0.0.0.0"
              Case 5
                'Werte von Router 3 werden auf Router 2 kopiert
                My.Settings.Name2 = My.Settings.Name3
                My.Settings.IP2 = My.Settings.IP3
                My.Settings.Gate2 = My.Settings.Gate3
                'Werte von Router 4 werden auf Router 3 kopiert
                My.Settings.Name3 = My.Settings.Name4
                My.Settings.IP3 = My.Settings.IP4
                My.Settings.Gate3 = My.Settings.Gate4
                'Werte von Router 5 werden auf Router 4 kopiert
                My.Settings.Name4 = My.Settings.Name5
                My.Settings.IP4 = My.Settings.IP5
                My.Settings.Gate4 = My.Settings.Gate5
                'Werte von Router 5 werden entfernt
                My.Settings.Name5 = ""
                My.Settings.IP5 = "0.0.0.0"
                My.Settings.Gate5 = "0.0.0.0"
                btnHinzufügen.Enabled = True
            End Select
          End If
        Case 3
          My.Settings.Name3 = ""
          My.Settings.IP3 = "0.0.0.0"
          My.Settings.Gate3 = "0.0.0.0"
          'Prüfen ob mehr als 3 Router vorhanden
          If lstRouter.Items.Count > 3 Then
            Select Case lstRouter.Items.Count
              Case 4
                'Werte von Router 4 werden auf Router 3 kopiert
                My.Settings.Name3 = My.Settings.Name4
                My.Settings.IP3 = My.Settings.IP4
                My.Settings.Gate3 = My.Settings.Gate4
                'Werte von Router 4 werden entfernt
                My.Settings.Name4 = ""
                My.Settings.IP4 = "0.0.0.0"
                My.Settings.Gate4 = "0.0.0.0"
              Case 5
                'Werte von Router 4 werden auf Router 3 kopiert
                My.Settings.Name3 = My.Settings.Name4
                My.Settings.IP3 = My.Settings.IP4
                My.Settings.Gate3 = My.Settings.Gate4
                'Werte von Router 5 werden auf Router 4 kopiert
                My.Settings.Name4 = My.Settings.Name5
                My.Settings.IP4 = My.Settings.IP5
                My.Settings.Gate4 = My.Settings.Gate5
                'Werte von Router 5 werden entfernt
                My.Settings.Name5 = ""
                My.Settings.IP5 = "0.0.0.0"
                My.Settings.Gate5 = "0.0.0.0"
                btnHinzufügen.Enabled = True
            End Select
          End If
        Case 4
          My.Settings.Name4 = ""
          My.Settings.IP4 = "0.0.0.0"
          My.Settings.Gate4 = "0.0.0.0"
          'Prüfen ob mehr als 4 Router vorhanden
          If lstRouter.Items.Count > 4 Then
            Select Case lstRouter.Items.Count
              Case 5
                'Werte von Router 5 werden auf Router 4 kopiert
                My.Settings.Name4 = My.Settings.Name5
                My.Settings.IP4 = My.Settings.IP5
                My.Settings.Gate4 = My.Settings.Gate5
                'Werte von Router 5 werden entfernt
                My.Settings.Name5 = ""
                My.Settings.IP5 = "0.0.0.0"
                My.Settings.Gate5 = "0.0.0.0"
                btnHinzufügen.Enabled = True
            End Select
          End If
        Case 5
          My.Settings.Name5 = ""
          My.Settings.IP5 = "0.0.0.0"
          My.Settings.Gate5 = "0.0.0.0"
          btnHinzufügen.Enabled = True
      End Select
      LadeRouter()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub btnBearbeiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBearbeiten.Click
    Try
      frmRouter.ID = lstRouter.FocusedItem.Index + 1
      frmRouter.ShowDialog()
    Catch ex As Exception

    End Try
  End Sub
End Class
