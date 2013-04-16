Public Class frmEinstellungen

  Private Sub btnHinzufügen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHinzufügen.Click
    Dim LV As ListViewItem = lstHost.Items.Add(txtHost.Text)
    LV.SubItems.Add(txtAnzahl.Text)
  End Sub

  Private Sub lstHost_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstHost.DoubleClick
    lstHost.FocusedItem.Remove()
  End Sub

  Private Sub frmEinstellungen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim i As Integer
    Using sw As System.IO.StreamWriter = New System.IO.StreamWriter("Host.txt")
      For i = 0 To lstHost.Items.Count - 1
        sw.WriteLine(lstHost.Items(i).SubItems(0).Text & ";" & lstHost.Items(i).SubItems(1).Text)
      Next
      sw.Close()
    End Using
  End Sub

  Private Sub frmEinstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim strHost As String
    Dim iPos As Integer
    Using sr As System.IO.StreamReader = New System.IO.StreamReader("Host.txt")
      Do While Not sr.EndOfStream
        strHost = sr.ReadLine()
        iPos = PosTrennzeichen(strHost, ";")
        Dim LV As ListViewItem = lstHost.Items.Add(strHost.Substring(0, iPos))
        LV.SubItems.Add(strHost.Substring(iPos + 1, strHost.Length - (iPos + 1)))
      Loop
      sr.Close()
    End Using
  End Sub

  Private Function PosTrennzeichen(ByVal Text As String, ByVal Zeichen As String) As Integer
    Dim i As Integer
    For i = 0 To Text.Length - 1
      If Text.Substring(i, 1) = Zeichen Then
        Return i
      End If
    Next
  End Function
End Class