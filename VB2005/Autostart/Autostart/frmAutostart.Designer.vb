<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutostart
  Inherits System.Windows.Forms.Form

  'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.btnStart0 = New System.Windows.Forms.Button
    Me.btnExcel = New System.Windows.Forms.Button
    Me.btnOutlook = New System.Windows.Forms.Button
    Me.btnFreeCell = New System.Windows.Forms.Button
    Me.btnIExpolre = New System.Windows.Forms.Button
    Me.btnExplorer = New System.Windows.Forms.Button
    Me.btnExplorerEigeneDateien = New System.Windows.Forms.Button
    Me.btnWordÖffnen = New System.Windows.Forms.Button
    Me.btnExcelÖffnen = New System.Windows.Forms.Button
    Me.OpenFile = New System.Windows.Forms.OpenFileDialog
    Me.btnIExploreÖffnen = New System.Windows.Forms.Button
    Me.btnScanner = New System.Windows.Forms.Button
    Me.btnScannerVorschau = New System.Windows.Forms.Button
    Me.btnScannerSofort = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnStart0
    '
    Me.btnStart0.Location = New System.Drawing.Point(12, 12)
    Me.btnStart0.Name = "btnStart0"
    Me.btnStart0.Size = New System.Drawing.Size(162, 99)
    Me.btnStart0.TabIndex = 0
    Me.btnStart0.Tag = "winword"
    Me.btnStart0.Text = "Microsoft Word"
    Me.btnStart0.UseVisualStyleBackColor = True
    '
    'btnExcel
    '
    Me.btnExcel.Location = New System.Drawing.Point(12, 117)
    Me.btnExcel.Name = "btnExcel"
    Me.btnExcel.Size = New System.Drawing.Size(162, 99)
    Me.btnExcel.TabIndex = 1
    Me.btnExcel.Tag = "winword"
    Me.btnExcel.Text = "Microsoft Excel"
    Me.btnExcel.UseVisualStyleBackColor = True
    '
    'btnOutlook
    '
    Me.btnOutlook.Location = New System.Drawing.Point(12, 222)
    Me.btnOutlook.Name = "btnOutlook"
    Me.btnOutlook.Size = New System.Drawing.Size(162, 99)
    Me.btnOutlook.TabIndex = 2
    Me.btnOutlook.Tag = "msimn"
    Me.btnOutlook.Text = "Microsoft Outlook"
    Me.btnOutlook.UseVisualStyleBackColor = True
    '
    'btnFreeCell
    '
    Me.btnFreeCell.Location = New System.Drawing.Point(12, 327)
    Me.btnFreeCell.Name = "btnFreeCell"
    Me.btnFreeCell.Size = New System.Drawing.Size(162, 99)
    Me.btnFreeCell.TabIndex = 3
    Me.btnFreeCell.Tag = "freecell"
    Me.btnFreeCell.Text = "Free Cell"
    Me.btnFreeCell.UseVisualStyleBackColor = True
    '
    'btnIExpolre
    '
    Me.btnIExpolre.Location = New System.Drawing.Point(12, 432)
    Me.btnIExpolre.Name = "btnIExpolre"
    Me.btnIExpolre.Size = New System.Drawing.Size(162, 99)
    Me.btnIExpolre.TabIndex = 4
    Me.btnIExpolre.Tag = "iexplore"
    Me.btnIExpolre.Text = "Internet Explorer"
    Me.btnIExpolre.UseVisualStyleBackColor = True
    '
    'btnExplorer
    '
    Me.btnExplorer.Location = New System.Drawing.Point(12, 537)
    Me.btnExplorer.Name = "btnExplorer"
    Me.btnExplorer.Size = New System.Drawing.Size(162, 99)
    Me.btnExplorer.TabIndex = 5
    Me.btnExplorer.Tag = "explorer"
    Me.btnExplorer.Text = "Windows Explorer"
    Me.btnExplorer.UseVisualStyleBackColor = True
    '
    'btnExplorerEigeneDateien
    '
    Me.btnExplorerEigeneDateien.Location = New System.Drawing.Point(180, 537)
    Me.btnExplorerEigeneDateien.Name = "btnExplorerEigeneDateien"
    Me.btnExplorerEigeneDateien.Size = New System.Drawing.Size(162, 99)
    Me.btnExplorerEigeneDateien.TabIndex = 6
    Me.btnExplorerEigeneDateien.Tag = "explorer ""Eigene Dateien"""
    Me.btnExplorerEigeneDateien.Text = "Explorer => Eigene Dateien"
    Me.btnExplorerEigeneDateien.UseVisualStyleBackColor = True
    '
    'btnWordÖffnen
    '
    Me.btnWordÖffnen.Location = New System.Drawing.Point(180, 12)
    Me.btnWordÖffnen.Name = "btnWordÖffnen"
    Me.btnWordÖffnen.Size = New System.Drawing.Size(162, 99)
    Me.btnWordÖffnen.TabIndex = 7
    Me.btnWordÖffnen.Tag = ""
    Me.btnWordÖffnen.Text = "Word => Datei öffnen"
    Me.btnWordÖffnen.UseVisualStyleBackColor = True
    '
    'btnExcelÖffnen
    '
    Me.btnExcelÖffnen.Location = New System.Drawing.Point(180, 117)
    Me.btnExcelÖffnen.Name = "btnExcelÖffnen"
    Me.btnExcelÖffnen.Size = New System.Drawing.Size(162, 99)
    Me.btnExcelÖffnen.TabIndex = 8
    Me.btnExcelÖffnen.Tag = ""
    Me.btnExcelÖffnen.Text = "Excel => Datei öffnen"
    Me.btnExcelÖffnen.UseVisualStyleBackColor = True
    '
    'btnIExploreÖffnen
    '
    Me.btnIExploreÖffnen.Location = New System.Drawing.Point(180, 432)
    Me.btnIExploreÖffnen.Name = "btnIExploreÖffnen"
    Me.btnIExploreÖffnen.Size = New System.Drawing.Size(162, 99)
    Me.btnIExploreÖffnen.TabIndex = 9
    Me.btnIExploreÖffnen.Tag = ""
    Me.btnIExploreÖffnen.Text = "Internet => Seite öffnen"
    Me.btnIExploreÖffnen.UseVisualStyleBackColor = True
    '
    'btnScanner
    '
    Me.btnScanner.Location = New System.Drawing.Point(12, 642)
    Me.btnScanner.Name = "btnScanner"
    Me.btnScanner.Size = New System.Drawing.Size(162, 99)
    Me.btnScanner.TabIndex = 10
    Me.btnScanner.Tag = ""
    Me.btnScanner.Text = "Scanner"
    Me.btnScanner.UseVisualStyleBackColor = True
    '
    'btnScannerVorschau
    '
    Me.btnScannerVorschau.Location = New System.Drawing.Point(180, 642)
    Me.btnScannerVorschau.Name = "btnScannerVorschau"
    Me.btnScannerVorschau.Size = New System.Drawing.Size(162, 99)
    Me.btnScannerVorschau.TabIndex = 11
    Me.btnScannerVorschau.Tag = ""
    Me.btnScannerVorschau.Text = "mit Vorschau Scannen"
    Me.btnScannerVorschau.UseVisualStyleBackColor = True
    '
    'btnScannerSofort
    '
    Me.btnScannerSofort.Location = New System.Drawing.Point(348, 642)
    Me.btnScannerSofort.Name = "btnScannerSofort"
    Me.btnScannerSofort.Size = New System.Drawing.Size(162, 99)
    Me.btnScannerSofort.TabIndex = 12
    Me.btnScannerSofort.Tag = ""
    Me.btnScannerSofort.Text = "Sofortscannen"
    Me.btnScannerSofort.UseVisualStyleBackColor = True
    '
    'frmAutostart
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(527, 749)
    Me.Controls.Add(Me.btnScannerSofort)
    Me.Controls.Add(Me.btnScannerVorschau)
    Me.Controls.Add(Me.btnScanner)
    Me.Controls.Add(Me.btnIExploreÖffnen)
    Me.Controls.Add(Me.btnExcelÖffnen)
    Me.Controls.Add(Me.btnWordÖffnen)
    Me.Controls.Add(Me.btnExplorerEigeneDateien)
    Me.Controls.Add(Me.btnExplorer)
    Me.Controls.Add(Me.btnIExpolre)
    Me.Controls.Add(Me.btnFreeCell)
    Me.Controls.Add(Me.btnOutlook)
    Me.Controls.Add(Me.btnExcel)
    Me.Controls.Add(Me.btnStart0)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmAutostart"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Autostart"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnStart0 As System.Windows.Forms.Button
  Friend WithEvents btnExcel As System.Windows.Forms.Button
  Friend WithEvents btnOutlook As System.Windows.Forms.Button
  Friend WithEvents btnFreeCell As System.Windows.Forms.Button
  Friend WithEvents btnIExpolre As System.Windows.Forms.Button
  Friend WithEvents btnExplorer As System.Windows.Forms.Button
  Friend WithEvents btnExplorerEigeneDateien As System.Windows.Forms.Button
  Friend WithEvents btnWordÖffnen As System.Windows.Forms.Button
  Friend WithEvents btnExcelÖffnen As System.Windows.Forms.Button
  Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
  Friend WithEvents btnIExploreÖffnen As System.Windows.Forms.Button
  Friend WithEvents btnScanner As System.Windows.Forms.Button
  Friend WithEvents btnScannerVorschau As System.Windows.Forms.Button
  Friend WithEvents btnScannerSofort As System.Windows.Forms.Button

End Class
