Public Class frmAutostart
  Private Sub btnWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart0.Click
    Ausführen("Winword", "")
  End Sub

  Private Sub btnWordÖffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWordÖffnen.Click
    OpenFile.Filter = "Word Dokument (*.doc)|*.doc"
    OpenFile.ShowDialog()
    If Not OpenFile.FileName = "" Then
      Ausführen(OpenFile.FileName, "")
    End If
    OpenFile.FileName = Nothing
  End Sub

  Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
    Ausführen("Excel", "")
  End Sub

  Private Sub btnExcelÖffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelÖffnen.Click
    OpenFile.Filter = "Excel Dokument (*.xls)|*.xls"
    OpenFile.ShowDialog()
    If Not OpenFile.FileName = "" Then
      Ausführen(OpenFile.FileName, "")
    End If
    OpenFile.FileName = Nothing
  End Sub

  Private Sub btnOutlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutlook.Click
    Ausführen("Msimn", "")
  End Sub

  Private Sub btnFreeCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeCell.Click
    Ausführen("FreeCell", "")
  End Sub

  Private Sub btnIExpolre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIExpolre.Click
    Ausführen("Iexplore", "")
  End Sub

  Private Sub btnIExploreÖffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIExploreÖffnen.Click
    Dim strSeite As String
    strSeite = InputBox("Bitte Seite eingeben", "Internet Explorer", "http://")
    If Not strSeite = "http://" And Not strSeite = "" Then
      Ausführen("iexplore", strSeite)
    End If
  End Sub

  Private Sub btnExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorer.Click
    Ausführen("Explorer", "")
  End Sub

  Private Sub btnExplorerEigeneDateien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorerEigeneDateien.Click
    Ausführen("Explorer", "D:\Eigene Dateien")
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

  Private Sub Ausführen(ByVal strAnwendung As String, ByVal strArgument As String)
    If strArgument = "" Then
      System.Diagnostics.Process.Start(strAnwendung)
    Else
      System.Diagnostics.Process.Start(strAnwendung, strArgument)
    End If
  End Sub
End Class
