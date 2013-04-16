Public Class frmEinstellungen

    Private RS As ADODB.Recordset
    Private CMD As ADODB.Command
    Dim X As String


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'Allgemein

            Case 1 'Projekt
                While dgProjekt.Columns.Count <> 0
                    dgProjekt.Columns.Remove(dgProjekt.Columns(0).Name)
                End While
                RS = frmHaupt.DB.OpenRS("tblProjekt")
                RS.MoveFirst() 'Ersten Datensatz anwählen
                For i As Integer = 0 To RS.Fields.Count - 1 'Schleife über Anzahl der Felder des RS
                    dgProjekt.Columns.Add(RS.Fields(i).Name, RS.Fields(i).Name) 'Felder in Datagrid aufnehmen
                Next

                While RS.EOF = False
                    dgProjekt.Rows.Add() 'Zeile hinzufügen
                    For i2 As Integer = 0 To RS.Fields.Count - 1
                        dgProjekt.Rows(RS.AbsolutePosition - 1).Cells(i2).Value = RS.Fields(i2).Value 'Werte des Recordset einfügen
                    Next
                    RS.MoveNext()
                End While
            Case 2 'Phasen

        End Select
    End Sub

End Class