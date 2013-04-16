Public Class frmListe
  Private Tabelle As New ADODB.Recordset
  Private strID As String

  Function Liste(ByVal strSelect As String, ByVal strFrom As String, ByVal strWhere As String, ByVal strOrder As String) As String
    Dim StrSql As String
    'SQL Abfrage erstellen
    StrSql = "Select " & strSelect & " from " & strFrom
    If Not strWhere = "" Then 'Falls Where-Bedingung mit angegeben wird
      StrSql = StrSql & " where " & strWhere
    End If
    If Not strOrder = "" Then 'Falls Order-Bedingung mit angegeben wird
      StrSql = StrSql & " Order By " & strOrder
    End If
    Tabelle = Datenbank.Tabelle÷ffnen(StrSql)
    If Not Tabelle.BOF And Not Tabelle.EOF Then
      Tabelle.MoveFirst()
      While Not Tabelle.EOF
        Dim LV As ListViewItem = Me.lstListe.Items.Add(Tabelle.Fields(0).Value)
        LV.SubItems.Add(Tabelle.Fields(1).Value)
        LV.SubItems.Add(FormatCurrency(Tabelle.Fields(2).Value, 2, TriState.True, TriState.True, TriState.True))
        Tabelle.MoveNext()
      End While
      Me.ShowDialog()
      Return strID
    Else
      Return "0"
    End If
  End Function

  Private Sub lstListe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListe.DoubleClick
    strID = lstListe.FocusedItem.SubItems(0).Text
    Me.Close()
  End Sub

  Private Sub btnAusw‰hlen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAusw‰hlen.Click
    strID = lstListe.FocusedItem.SubItems(0).Text
    Me.Close()
  End Sub

  Private Sub btnSchlieﬂen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchlieﬂen.Click
    strID = "0"
    Me.Close()
  End Sub
End Class