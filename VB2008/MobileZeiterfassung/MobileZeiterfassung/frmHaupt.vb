Public Class frmHaupt

#Region "Deklarationen"
    Public DB As New clsDB
    Private _tStart As Date
    Private _tEnde As Date
    Private strDB As String = Application.StartupPath & "\mZeit.mdb"
    Private RS As ADODB.Recordset
#End Region

#Region "Sub"
    Private Sub frmHaupt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnStartStop.Image = mZeit.My.Resources.Start.ToBitmap
        btnStartStop.Tag = "STOP"
        btnNeu.Image = mZeit.My.Resources.Neu.ToBitmap
        Me.mnuHaupt.Visible = True
        Me.Tray.Icon = mZeit.My.Resources.Tray
        Me.Tray.Visible = True
        DB.DB = strDB
        DB.ConnectDB()
    End Sub

    Private Sub frmHaupt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Tray.Visible = False
        DB.DisconnectDB()
    End Sub

    Private Sub EinstellungenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem1.Click
        frmEinstellungen.ShowDialog()
    End Sub

#End Region

#Region "Buttons"
    Private Sub btnStartStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartStop.Click
        If Not txtProjekt.Text = "" And Not txtPhase.Text = "" And Not txtPhaseBez.Text = "" Then
            Select Case btnStartStop.Tag
                Case "START"
                    _tEnde = Now
                    btnStartStop.Image = mZeit.My.Resources.Start.ToBitmap
                    btnStartStop.Tag = "STOP"
                    ToolStripStatusLabel1.Text = "Aufzeichnung beendet um " & _tEnde.ToString
                    DB.RunCommand("UPDATE tblZeiten " & _
                                  "SET Ende = '" & _tEnde.ToString & "' " & _
                                  "WHERE Projekt = '" & txtProjekt.Text & "' " & _
                                  "AND Phase = '" & txtPhase.Text & "' " & _
                                  "AND Ende IS NULL")
                    txtPhase.Enabled = True
                    txtPhaseBez.Enabled = True
                Case "STOP"
                    _tStart = Now
                    btnStartStop.Image = mZeit.My.Resources._Stop.ToBitmap
                    btnStartStop.Tag = "START"
                    ToolStripStatusLabel1.Text = "Aufzeichnung begonnen um " & _tStart.ToString
                    DB.RunCommand("INSERT INTO tblZeiten (Projekt, Phase, Beginn, Beschreibung, Status)" & _
                                  "VALUES ('" & txtProjekt.Text & "', '" & txtPhase.Text & "', '" & _tStart.ToString & "', '" & txtPhaseBez.Text & "', 'A')")
                    txtProjekt.Enabled = False
                    txtPhase.Enabled = False
                    txtPhaseBez.Enabled = False
            End Select
        Else
            MsgBox("Bitte Projekt, Phase und Bezeichnung für Aufzeichnung angeben!", MsgBoxStyle.OkOnly, "Daten unvollständig")

            If txtProjekt.Text = "" Then
                txtProjekt.BackColor = Color.DarkRed
            End If

            If txtPhase.Text = "" Then
                txtPhase.BackColor = Color.DarkRed
            Else
                If txtPhaseBez.Text = "" Then
                    txtPhaseBez.BackColor = Color.DarkRed
                End If
            End If
        End If
    End Sub

    Private Sub btnNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeu.Click
        If btnStartStop.Tag = "START" Then
            Me.btnStartStop_Click("Intern", Nothing)
        End If
        txtProjekt.BackColor = Color.White
        txtPhase.BackColor = Color.White
        txtPhaseBez.BackColor = txtProjektBez.BackColor

        txtProjekt.Enabled = True
        txtPhase.Enabled = True
        txtPhaseBez.Enabled = False

        txtProjekt.Text = ""
        txtProjektBez.Text = ""
        txtPhase.Text = ""
        txtPhaseBez.Text = ""

    End Sub

#End Region

#Region "Menus"

    Private Sub AusblendenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AusblendenToolStripMenuItem2.Click
        Me.Hide()
    End Sub

    Private Sub BeendenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        frmEinstellungen.ShowDialog()
    End Sub

    Private Sub EinblendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinblendenToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub AusblendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AusblendenToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Feld Projekt"
    Private Sub txtProjekt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProjekt.KeyUp
        If e.KeyValue = 115 Then
            'RS = DB.OpenRS("SELECT Projekt, Bezeichnung FROM tblProjekt")
            Dim Liste As New frmListe
            txtProjekt.Text = Liste.LadeListe("Projekt", "")
        End If
    End Sub

    Private Sub txtProjekt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProjekt.LostFocus
        If Not txtProjekt.Text = "" Then
            RS = DB.OpenRS("SELECT Projekt, Bezeichnung FROM tblProjekt WHERE Projekt='" & txtProjekt.Text & "'")
            If RS.RecordCount = 0 Then
                MsgBox("Projekt nicht vorhanden")
                txtProjekt.Text = ""
                txtProjektBez.Text = ""
                txtPhase.Text = ""
                txtPhaseBez.Text = ""
                txtProjekt.Focus()
                Exit Sub
            Else
                RS.MoveFirst()
                txtProjekt.Enabled = False
                txtProjekt.BackColor = Color.White
                txtProjekt.Text = RS.Fields(0).Value
                txtProjektBez.Text = RS.Fields(1).Value
                txtPhaseBez.Text = ""
            End If

        End If
    End Sub

#End Region

#Region "Feld Phase"
    Private Sub txtPhase_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhase.KeyUp
        If e.KeyValue = 115 Then
            RS = DB.OpenRS("SELECT Phase, Bezeichnung FROM tblPhase WHERE Projekt = '" & txtProjekt.Text & "'")
            Dim Liste As New frmListe
            txtPhase.Text = Liste.LadeListe("Phasen", "Projekt = '" & txtProjekt.Text & "'")
        End If
    End Sub

    Private Sub txtPhase_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhase.LostFocus
        If Not txtPhase.Text = "" Then
            RS = DB.OpenRS("SELECT Phase, Bezeichnung FROM tblPhase WHERE Projekt='" & txtProjekt.Text & "' AND Phase='" & txtPhase.Text & "'")
            If RS.RecordCount = 0 Then
                MsgBox("Phase nicht vorhanden")
                txtPhase.Text = ""
                txtPhaseBez.Text = ""
                txtPhase.Focus()
                Exit Sub
            Else
                RS.MoveFirst()
                txtPhase.Text = RS.Fields(0).Value
                txtPhaseBez.Enabled = True
                txtPhaseBez.Text = RS.Fields(1).Value
                txtPhase.BackColor = Color.White
                txtPhaseBez.Focus()
            End If
        End If
    End Sub

    Private Sub txtPhasebez_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhaseBez.LostFocus
        txtPhaseBez.BackColor = Color.White
    End Sub

#End Region

End Class