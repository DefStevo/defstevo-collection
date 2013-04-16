Public Class frmListe

#Region "Deklarationen"
    Private _RS As ADODB.Recordset
    Private _ListeWeite As Integer
    Private _strSelect As String
    Private _strFrom As String
    Private _strWhere As String
    Private _strOrder As String
    Private _strGroup As String
    Private _strSQL As String
    Private _strWert As String
#End Region

#Region "Eigenschaften"
    Property RS() As ADODB.Recordset
        Get
            Return _RS
        End Get
        Set(ByVal value As ADODB.Recordset)
            _RS = value
        End Set
    End Property

    ReadOnly Property Wert() As String
        Get
            Return _strWert
        End Get
    End Property
#End Region

#Region "Sub"
#Region "FormLaden"
    Private Sub frmListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not _RS Is Nothing Then 'Recordset wurde übergeben
            If Not _RS.RecordCount = 0 Then 'Recordset beinhaltet Daten
                RS.MoveFirst() 'Ersten Datensatz anwählen
                'For i As Integer = 0 To RS.Fields.Count - 1 'Schleife über Anzahl der Felder des RS
                'dgListe.Columns.Add(RS.Fields(i).Name, RS.Fields(i).Name) 'Felder in Datagrid aufnehmen
                'Next

                While RS.EOF = False
                    dgListe.Rows.Add() 'Zeile hinzufügen
                    For i2 As Integer = 0 To RS.Fields.Count - 1
                        dgListe.Rows(RS.AbsolutePosition - 1).Cells(i2).Value = RS.Fields(i2).Value 'Werte des Recordset einfügen
                    Next
                    RS.MoveNext()
                End While
            End If
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub dgListe_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgListe.CellMouseDoubleClick
        _strWert = dgListe.Rows(dgListe.SelectedRows.Item(0).Index).Cells(0).Value '1 Spalte in _strWert schreiben
        Me.Close()
    End Sub

    Private Sub btnAuswahl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuswahl.Click
        _strWert = dgListe.Rows(dgListe.SelectedRows.Item(0).Index).Cells(0).Value '1 Spalte in _strWert schreiben
        Me.Close()
    End Sub

    Private Sub btnAbbrechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbbrechen.Click
        _strWert = Nothing '_strWert leeren
        Me.Close()
    End Sub
#End Region

#End Region

#Region "Funktionen"
    Public Function LadeListe(ByVal Liste As String, ByVal ZusatzWhere As String) As String
        _RS = frmHaupt.DB.OpenRS("SELECT * " & _
                                 "FROM tblSysListen " & _
                                 "WHERE Liste='" & Liste & "'") 'Liste auswählen

        If Not _RS.BOF = True And Not _RS.EOF = True Then
            _RS.MoveFirst()
            Me.Text = "Auswahlliste " & _RS.Fields("Bezeichnung").Value 'Fenstertitel setzen

            'Select für Liste erstellen
            _RS = frmHaupt.DB.OpenRS("SELECT DBSpalte, Bezeichnung, Breite, Reihenfolge " & _
                                     "FROM tblSysListenSpalten " & _
                                     "WHERE Liste = '" & Liste & "'" & _
                                     "AND Typ = 'S'" & _
                                     "ORDER BY Reihenfolge")

            If Not _RS.BOF = True And Not _RS.EOF = True Then
                _RS.MoveFirst()
                _strSelect = "SELECT "
                While _RS.EOF = False
                    _strSelect = _strSelect & _RS.Fields("DBSpalte").Value 'Select zusammensetzen
                    dgListe.Columns.Add(_RS.Fields("DBSpalte").Value, _RS.Fields("Bezeichnung").Value)
                    dgListe.Columns(_RS.Fields("Reihenfolge").Value - 1).Width = _RS.Fields("Breite").Value
                    _ListeWeite = _ListeWeite + _RS.Fields("Breite").Value
                    _RS.MoveNext()
                    If Not RS.EOF = True Then 'Wenn Letzer Datensatz kein ,
                        _strSelect = _strSelect & ", "
                    End If
                End While
            End If

            'From für Liste erstellen
            _RS = frmHaupt.DB.OpenRS("SELECT DBSpalte " & _
                                     "FROM tblSysListenSpalten " & _
                                     "WHERE Liste = '" & Liste & "'" & _
                                     "AND Typ = 'F'" & _
                                     "ORDER BY Reihenfolge")

            If Not _RS.BOF = True And Not _RS.EOF = True Then
                _RS.MoveFirst()
                _strFrom = "FROM "
                While _RS.EOF = False
                    _strFrom = _strFrom & _RS.Fields("DBSpalte").Value 'From zusammensetzen

                    _RS.MoveNext()
                    If Not RS.EOF = True Then 'Wenn Letzer Datensatz kein ,
                        _strFrom = _strFrom & ", "
                    End If
                End While
            End If

            'Where für Liste erstellen
            _RS = frmHaupt.DB.OpenRS("SELECT DBSpalte " & _
                                     "FROM tblSysListenSpalten " & _
                                     "WHERE Liste = '" & Liste & "'" & _
                                     "AND Typ = 'W'" & _
                                     "ORDER BY Reihenfolge")

            If Not _RS.BOF = True And Not _RS.EOF = True Then
                _RS.MoveFirst()
                _strWhere = "WHERE "
                While _RS.EOF = False
                    _strWhere = _strWhere & _RS.Fields("DBSpalte").Value 'Where zusammensetzen

                    _RS.MoveNext()
                    If Not RS.EOF = True Then 'Wenn Letzer Datensatz kein AND
                        _strWhere = _strWhere & vbCrLf & "AND "
                    End If
                End While
            End If

            'Liste und Fenstergröße Anpassen
            dgListe.Width = _ListeWeite + 60
            Me.Width = _ListeWeite + 68
            Me.Height = dgListe.Height + 49
            btnAuswahl.Width = Me.Width / 2 - 3
            btnAuswahl.Left = 0
            btnAuswahl.Top = Me.Height - 48
            btnAbbrechen.Width = Me.Width / 2 - 3
            btnAbbrechen.Left = Me.Width - btnAbbrechen.Width - 6
            btnAbbrechen.Top = Me.Height - 48


            If Not ZusatzWhere = "" Then
                If _strWhere.Substring(0, 5) = "WHERE" Then
                    _strWhere = _strWhere & vbCrLf & "AND " & ZusatzWhere
                Else
                    _strWhere = "WHERE " & ZusatzWhere
                End If
            End If

            'Group für Liste erstellen
            _RS = frmHaupt.DB.OpenRS("SELECT DBSpalte " & _
                                     "FROM tblSysListenSpalten " & _
                                     "WHERE Liste = '" & Liste & "'" & _
                                     "AND Typ = 'G'" & _
                                     "ORDER BY Reihenfolge")

            If Not _RS.BOF = True And Not _RS.EOF = True Then
                _RS.MoveFirst()
                _strGroup = "GROUP BY "
                While _RS.EOF = False
                    _strGroup = _strGroup & _RS.Fields("DBSpalte").Value 'Order zusammensetzen

                    _RS.MoveNext()
                    If Not RS.EOF = True Then 'Wenn Letzer Datensatz kein ,
                        _strGroup = _strGroup & vbCrLf & ", "
                    End If
                End While
            End If

            'Order für Liste erstellen
            _RS = frmHaupt.DB.OpenRS("SELECT DBSpalte " & _
                                     "FROM tblSysListenSpalten " & _
                                     "WHERE Liste = '" & Liste & "'" & _
                                     "AND Typ = 'O'" & _
                                     "ORDER BY Reihenfolge")

            If Not _RS.BOF = True And Not _RS.EOF = True Then
                _RS.MoveFirst()
                _strOrder = "ORDER BY "
                While _RS.EOF = False
                    _strOrder = _strOrder & _RS.Fields("DBSpalte").Value 'Order zusammensetzen

                    _RS.MoveNext()
                    If Not RS.EOF = True Then 'Wenn Letzer Datensatz kein ,
                        _strOrder = _strOrder & vbCrLf & ", "
                    End If
                End While
            End If

            'SQL Statement erstellen
            _strSQL = _strSelect & vbCrLf & _strFrom

            If Not _strWhere = "" Then
                _strSQL = _strSQL & vbCrLf & _strWhere
            End If

            If Not _strGroup = "" Then
                _strSQL = _strSQL & vbCrLf & _strGroup
            End If

            If Not _strOrder = "" Then
                _strSQL = _strSQL & vbCrLf & _strOrder
            End If

            _RS = frmHaupt.DB.OpenRS(_strSQL)
            Me.ShowDialog()
            Return _strWert '_strWert zurückgeben
        Else
            Return _strWert
        End If
    End Function

#End Region
End Class