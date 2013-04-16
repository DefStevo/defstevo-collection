Public Class frmAutostart
  Private Sub btnWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart0.Click
    Ausf�hren("Winword", "")
  End Sub

  Private Sub btnWord�ffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWord�ffnen.Click
    OpenFile.Filter = "Word Dokument (*.doc)|*.doc"
    OpenFile.ShowDialog()
    If Not OpenFile.FileName = "" Then
      Ausf�hren(OpenFile.FileName, "")
    End If
    OpenFile.FileName = Nothing
  End Sub

  Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
    Ausf�hren("Excel", "")
  End Sub

  Private Sub btnExcel�ffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel�ffnen.Click
    OpenFile.Filter = "Excel Dokument (*.xls)|*.xls"
    OpenFile.ShowDialog()
    If Not OpenFile.FileName = "" Then
      Ausf�hren(OpenFile.FileName, "")
    End If
    OpenFile.FileName = Nothing
  End Sub

  Private Sub btnOutlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutlook.Click
    Ausf�hren("Msimn", "")
  End Sub

  Private Sub btnFreeCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeCell.Click
    Ausf�hren("FreeCell", "")
  End Sub

  Private Sub btnIExpolre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIExpolre.Click
    Ausf�hren("Iexplore", "")
  End Sub

  Private Sub btnIExplore�ffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIExplore�ffnen.Click
    Dim strSeite As String
    strSeite = InputBox("Bitte Seite eingeben", "Internet Explorer", "http://")
    If Not strSeite = "http://" And Not strSeite = "" Then
      Ausf�hren("iexplore", strSeite)
    End If
  End Sub

  Private Sub btnExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorer.Click
    Ausf�hren("Explorer", "")
  End Sub

  Private Sub btnExplorerEigeneDateien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorerEigeneDateien.Click
    Ausf�hren("Explorer", "D:\Eigene Dateien")
  End Sub

  Private Sub btnScanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanner.Click
    'Scannersoftware starten
  End Sub

  Private Sub btnScannerVorschau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScannerVorschau.Click
    'Twain Schnittstelle zum mit Vorschau Scannen
  End Sub

  Private Sub btnScannerSofort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScannerSofort.Click
    'Twain Schnittstelle zum Softortscannen
  End Sub

  Private Sub Ausf�hren(ByVal strAnwendung As String, ByVal strArgument As String)
    If strArgument = "" Then
      System.Diagnostics.Process.Start(strAnwendung)
    Else
      System.Diagnostics.Process.Start(strAnwendung, strArgument)
    End If
  End Sub
End Class
