Module mdlMain
  Public Datenbank As New clsDatenbank

  Sub Main()
    frmSplash.Show() 'Splash starten
    frmSplash.Refresh()
    'WartenSek(1) 'Wartezeit um SplashScreen korrekt anzuzeigen
    If Not Command$() = "" Then
      Datenbank.Datenbank = Command$() 'Datenbank wechseln
    End If
    If Datenbank.DBVerbinden = True Then 'Verbindung zur Datenbank herstellen
      Application.Run(New frmMenu) 'Menu anzeigen, frmSplash wird nach dem vollständigen Laden geschlossen
    End If
  End Sub

#Region "Warten (Millisekunden,Sekunden,Minuten)"
  Sub WartenMSek(ByVal Millisekunden As Integer)
    Dim dBeginn As Date
    Dim dZeit As TimeSpan
    dBeginn = Now
    dZeit = Now - dBeginn
    Do While dZeit.Milliseconds <= Millisekunden
      dZeit = Now - dBeginn
    Loop
  End Sub

  Sub WartenSek(ByVal Sekunden As Integer)
    Dim dBeginn As Date
    Dim dZeit As TimeSpan
    dBeginn = Now
    dZeit = Now - dBeginn
    Do While dZeit.Seconds <= Sekunden
      dZeit = Now - dBeginn
    Loop
  End Sub

  Sub WartenMin(ByVal Minuten As Integer)
    Dim dBeginn As Date
    Dim dZeit As TimeSpan
    dBeginn = Now
    dZeit = Now - dBeginn
    Do While dZeit.Minutes <= Minuten
      dZeit = Now - dBeginn
    Loop
  End Sub
#End Region

#Region "Fensterverwaltung"
  Sub FensterStandardwerte(ByVal Fenster As Form, ByVal Name As String)
    For Each CFeld As Control In Fenster.Controls
      If CFeld.Controls.Count = 0 Then
        CFeld.Text = PrüfeFeld(CFeld)
      Else
        For Each CFeld2 As Control In CFeld.Controls
          If CFeld2.Controls.Count = 0 Then
            CFeld2.Text = PrüfeFeld(CFeld2)
          Else
            For Each CFeld3 As Control In CFeld2.Controls
              CFeld3.Text = PrüfeFeld(CFeld3)
            Next
          End If
        Next
      End If
    Next
    Select Case Name
      Case "Adr"
        Fenster.Text = "Adressverwaltung"
      Case "Kto"
        Fenster.Text = "Kontoverwaltung"
      Case "Buch"
        Fenster.Text = "Buchung erfassen"
    End Select
  End Sub

  Private Function PrüfeFeld(ByVal Feld As Control) As String
    If TypeOf (Feld) Is TextBox Or TypeOf (Feld) Is MaskedTextBox Then
      Return ""
    Else
      Return Feld.Text
    End If
  End Function
#End Region
End Module
