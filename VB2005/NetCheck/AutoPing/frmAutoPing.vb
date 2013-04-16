Public Class frmAutoPing
  Private iConn As New Icon("Connected.ico")
  Private iDisConn As New Icon("Disconnected.ico")

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    Dim strLine As String
    Dim iPos As Integer
    Using sr As System.IO.StreamReader = New System.IO.StreamReader("Host.txt")
      Do While Not sr.EndOfStream
        strLine = sr.ReadLine()
        iPos = PosTrennzeichen(strLine, ";")
        If Ping(strLine.Substring(0, iPos), strLine.Substring(iPos + 1, strLine.Length - (iPos + 1))) = True Then
          nIcon.Icon = iConn
        Else
          nIcon.Icon = iDisConn
        End If
      Loop
      sr.Close()
    End Using
  End Sub

  Private Function Ping(ByVal strHost As String, ByVal iAnzahl As String) As Boolean
    Dim i As Integer
    For i = 1 To iAnzahl
      If My.Computer.Network.Ping(strHost) = False Then
        Return False
      End If
    Next
    Return True
  End Function

  Private Function PosTrennzeichen(ByVal Text As String, ByVal Zeichen As String) As Integer
    Dim i As Integer
    For i = 0 To Text.Length - 1
      If Text.Substring(i, 1) = Zeichen Then
        Return i
      End If
    Next
  End Function
End Class
