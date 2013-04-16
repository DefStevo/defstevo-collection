Public Class frmEinstellungen

    Private RS As ADODB.Recordset
    Private CMD As ADODB.Command

    Private _bProjektNeu As Boolean
    Private _bPhaseNeu
    Dim X As String

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'Allgemein

            Case 1 'Projekt
                ListeProjekte()
                _bProjektNeu = True
                txtProjekt.Text = ""
                txtProjekt.ReadOnly = False
                txtProjektBez.Text = ""
                cbProjektAktiv.Checked = True
            Case 2 'Phasen
                ListePhasen()
                _bPhaseNeu = True
                txtPhaseProjekt.Text = ""
                txtPhaseProjekt.ReadOnly = False
                txtPhaseProjektBez.Text = ""
                txtPhase.Text = ""
                txtPhase.ReadOnly = False
                txtPhaseBez.Text = ""
                cbPhaseVerrechenbar.Checked = True
        End Select
    End Sub

#Region "Projekt"
#Region "Funktionen"
    Function ListeProjekte() As Boolean
        While dgProjekt.Columns.Count <> 0
            dgProjekt.Columns.Remove(dgProjekt.Columns(0).Name)
        End While
        RS = frmHaupt.DB.OpenRS("Select Projekt, Bezeichnung, Status from tblProjekt order by Status, Projekt")
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
        Return True
    End Function

    Function LadeProjekt(ByVal Id As Integer) As Boolean
        txtProjekt.Text = dgProjekt.Rows(Id).Cells("Projekt").Value
        txtProjektBez.Text = dgProjekt.Rows(Id).Cells("Bezeichnung").Value
        If dgProjekt.Rows(Id).Cells("Status").Value = "A" Then
            cbProjektAktiv.Checked = True
        Else
            cbProjektAktiv.Checked = False
        End If
        _bProjektNeu = False
        txtProjekt.ReadOnly = True
        Return True
    End Function
#End Region

#Region "Subs"
    Private Sub dgProjekt_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgProjekt.CellMouseDoubleClick
        LadeProjekt(dgProjekt.Rows(dgProjekt.SelectedRows.Item(0).Index).Index)
    End Sub

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProjektNeu.Click
        txtProjekt.Text = ""
        txtProjektBez.Text = ""
        cbProjektAktiv.Checked = True
        _bProjektNeu = True
        txtProjekt.ReadOnly = False
    End Sub

    Private Sub btnProjektSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProjektSpeichern.Click
        Dim strStatus As String = ""

        If cbProjektAktiv.Checked = True Then
            strStatus = "A"
        Else
            strStatus = "I"
        End If

        If _bProjektNeu = True Then 'Neues Projekt
            frmHaupt.DB.RunCommand("Insert into tblProjekt (Projekt, Bezeichnung, Status) " + _
                                   "Values ('" & txtProjekt.Text & "','" + txtProjektBez.Text + "','" + strStatus + "')")
        Else 'Update auf bestehendes Projekt
            frmHaupt.DB.RunCommand("Update tblProjekt set Bezeichnung = '" + txtProjektBez.Text + "' " + _
                                   ", Status = '" + strStatus + "' " + _
                                   "where Projekt = '" + txtProjekt.Text + "'")
        End If
        ListeProjekte()
        btnNeu_Click(sender, e)
    End Sub

    Private Sub btnSchließen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProjektSchließen.Click
        Me.Close()
    End Sub
#End Region
#End Region

#Region "Phasen"
#Region "Funktionen"
    Function ListePhasen() As Boolean
        Dim sSql As String

        While dgPhasen.Columns.Count <> 0
            dgPhasen.Columns.Remove(dgPhasen.Columns(0).Name)
        End While

        sSql = "Select Pr.Projekt, Pr.Bezeichnung as ProjektBezeichnung, Ph.Phase, Ph.Bezeichnung, Ph.Status, Ph.Verrechenbar " + _
               "from tblProjekt Pr, tblPhase Ph " + _
               "where Pr.Projekt = Ph.Projekt "

        If Not txtPhaseProjekt.Text = "" Then
            sSql = sSql + _
                   "and Pr.Projekt = '" + txtPhaseProjekt.Text + "' "
        End If

        sSql = sSql + _
               "order by Pr.Projekt, Ph.Status, Ph.Phase"

        RS = frmHaupt.DB.OpenRS(sSql)

        RS.MoveFirst() 'Ersten Datensatz anwählen
        For i As Integer = 0 To RS.Fields.Count - 1 'Schleife über Anzahl der Felder des RS
            dgPhasen.Columns.Add(RS.Fields(i).Name, RS.Fields(i).Name) 'Felder in Datagrid aufnehmen
        Next

        While RS.EOF = False
            dgPhasen.Rows.Add() 'Zeile hinzufügen
            For i2 As Integer = 0 To RS.Fields.Count - 1
                dgPhasen.Rows(RS.AbsolutePosition - 1).Cells(i2).Value = RS.Fields(i2).Value 'Werte des Recordset einfügen
            Next
            RS.MoveNext()
        End While



    End Function

    Function LadePhase(ByVal Id As Integer) As Boolean
        txtPhaseProjekt.Text = dgPhasen.Rows(Id).Cells("Projekt").Value
        txtPhaseProjektBez.Text = dgPhasen.Rows(Id).Cells("ProjektBezeichnung").Value
        txtPhase.Text = dgPhasen.Rows(Id).Cells("Phase").Value
        txtPhaseBez.Text = dgPhasen.Rows(Id).Cells("Bezeichnung").Value

        If dgPhasen.Rows(Id).Cells("Status").Value = "A" Then
            cbPhaseStatus.Checked = True
        Else
            cbPhaseStatus.Checked = False
        End If

        If dgPhasen.Rows(Id).Cells("Verrechenbar").Value = "J" Then
            cbPhaseVerrechenbar.Checked = True
        Else
            cbPhaseVerrechenbar.Checked = False
        End If
        _bPhaseNeu = False
        txtPhaseProjekt.ReadOnly = True
        txtPhase.ReadOnly = True
    End Function
#End Region

#Region "Subs"
    Private Sub dgPhasen_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgPhasen.CellMouseDoubleClick
        LadePhase(dgPhasen.Rows(dgPhasen.SelectedRows.Item(0).Index).Index)
    End Sub

    Private Sub btnPhaseNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhaseNeu.Click
        txtPhaseProjekt.Text = ""
        txtPhaseProjekt.ReadOnly = False
        txtPhaseProjektBez.Text = ""
        txtPhase.Text = ""
        txtPhase.ReadOnly = False
        txtPhaseBez.Text = ""
        cbPhaseStatus.Checked = True
        cbPhaseVerrechenbar.Checked = True
        _bPhaseNeu = True
    End Sub

#End Region

#End Region


    Private Sub btnPhaseSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhaseSpeichern.Click
        Dim strStatus As String = ""
        Dim strVerr As String = ""

        If cbPhaseStatus.Checked = True Then
            strStatus = "A"
        Else
            strStatus = "I"
        End If

        If cbPhaseVerrechenbar.Checked = True Then
            strVerr = "J"
        Else
            strVerr = "N"
        End If

        If _bPhaseNeu = True Then 'Neues Projekt
            frmHaupt.DB.RunCommand("Insert into tblPhase (Projekt, Phase, Bezeichnung, Status, Verrechenbar) " + _
                                   "Values ('" & txtPhaseProjekt.Text & "','" + txtPhase.Text + "','" + txtPhaseBez.Text + "','" + strStatus + "','" + strVerr + "')")
        Else 'Update auf bestehendes Projekt
            frmHaupt.DB.RunCommand("Update tblPhase set Bezeichnung = '" + txtPhaseBez.Text + "' " + _
                                   ", Status = '" + strStatus + "' " + _
                                   ", Verrechenbar = '" + strVerr + ", " + _
                                   "where Projekt = '" + txtPhaseProjekt.Text + "' " + _
                                   "and Phase = '" + txtPhase.Text + "'")
        End If
        txtPhase.Text = ""
        txtPhase.ReadOnly = False
        txtPhaseBez.Text = ""
        cbPhaseStatus.Checked = True
        cbPhaseVerrechenbar.Checked = True
        ListePhasen()
    End Sub
End Class