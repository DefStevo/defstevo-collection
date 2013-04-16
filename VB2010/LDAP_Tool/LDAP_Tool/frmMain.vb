Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class frmMain

    Private _Entry As DirectoryEntry
    Private _Searcher As DirectorySearcher
    Private _ResultColl As SearchResultCollection

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        _Entry = New DirectoryEntry("LDAP://" + txtServer.Text)
        _Searcher = New DirectorySearcher(_Entry)

        'Einschränkung für LDAP Anfrage
        _Searcher.Filter = "(" + txt1.Text + txt2.Text + ")"

        'Anfrage auf LDAP
        _ResultColl = _Searcher.FindAll

        Dim _Result As SearchResult

        Do While dgUser.Rows.Count > 0
            dgUser.Rows.Remove(dgUser.Rows(0))
        Loop

        Do While dgProperties.Rows.Count > 0
            dgProperties.Rows.Remove(dgProperties.Rows(0))
        Loop

        Dim x As Integer = 0

        For Each _Result In _ResultColl
            dgUser.Rows.Add()
            dgUser.Item("cUser", x).Value = _Result.Properties("name").Item(0).ToString
            dgUser.Item("cPath", x).Value = _Result.Path
            x += 1
        Next
    End Sub

    Private Sub dgUser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUser.CellClick
        _Searcher.Filter = "(" + txt1.Text + "(cn=" + dgUser.Rows(dgUser.SelectedCells.Item(0).RowIndex).Cells(0).Value + "))"

        _ResultColl = _Searcher.FindAll

        Dim _Result As SearchResult

        Do While dgProperties.Rows.Count > 0
            dgProperties.Rows.Remove(dgProperties.Rows(0))
        Loop

        If _ResultColl.Count > 0 Then
            _Result = _ResultColl.Item(0)

            For i As Integer = 0 To _Result.Properties.Count - 1
                dgProperties.Rows.Add()
                dgProperties.Item("cName", i).Value = _Result.Properties.PropertyNames(i).ToString
                dgProperties.Item("cWert", i).Value = _Result.Properties(_Result.Properties.PropertyNames(i)).Item(0).ToString

            Next

        End If
    End Sub
   
End Class
