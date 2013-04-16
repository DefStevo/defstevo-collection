Module mdlSonst
  Function TabellenErstellen() As Boolean
    'Funktion wird nur zur Anlage mehrere Tabellen benötigt
    'Datenbank.TabelleErstellen("KTO", "KtoNr INT, KtoBestand INT, KtoStatus CHAR(1), KtoName VARCHAR(38), KtoSaldo MONEY, KtoMemo VARCHAR(296)")
    'Datenbank.TabelleErstellen("ADR", "AdrNr INT, AdrStatus CHAR(1), AdrName VARCHAR(38), AdrSaldo MONEY, AdrMemo VARCHAR(296)")
    'Datenbank.TabelleErstellen("BUCH", "BuchNr INT, BuchDat DATETIME, BuchArt CHAR(1), BuchStatus CHAR(1), BuchAdr INT, BuchKtoBestand INT, BuchKto INT, BuchBetrag MONEY, BuchText VARCHAR(56), BuchMemo VARCHAR(296)")
    Datenbank.TabelleErstellen("EINST", "StdKtoBestand INT, StdKto INT, StdAdr INT, StdKtoGegBestand INT")
    Return True
  End Function

  Sub Infos()
    'Anzeige Cascade
    frmMenu.LayoutMdi(MdiLayout.Cascade)

    'Anzeige TileVerticale
    frmMenu.LayoutMdi(MdiLayout.TileVertical)

    'Anzeige TileHorizontal
    frmMenu.LayoutMdi(MdiLayout.TileHorizontal)

    'Anzeige ArrangeIcons
    frmMenu.LayoutMdi(MdiLayout.ArrangeIcons)

    'Clipboard Copy,Paste, Cut
    'my.Computer.Clipboard

    'Neues Fenster
    Dim nChildForm As New System.Windows.Forms.Form
    nChildForm.MdiParent = frmMenu
    'frmMenu.m_ChildFormNumber += 1
    'nChildForm.Text = "Fenster " & frmMenu.m_ChildFormNumber
    nChildForm.Show()

    'Alle Fenster schließen
    For Each sChildForm As Form In frmMenu.MdiChildren
      sChildForm.Close()
    Next

    'Anwendung Beenden
    Global.System.Windows.Forms.Application.Exit()
  End Sub
End Module
