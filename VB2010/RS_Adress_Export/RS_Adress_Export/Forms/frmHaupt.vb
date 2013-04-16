Public Class frmHaupt

#Region "Allgemein"
#Region "Deklaration"
    Private _cDB As New clsDatenbank
    Private _i As Integer = 0

    Private _sw As System.IO.StreamWriter

    Private _strCSV_Seperator As String = ";"
    Private _strCSV_Header As String = "Organization 1 - Name" & _strCSV_Seperator & _
                                       "Organization 1 - Title" & _strCSV_Seperator & _
                                       "Name" & _strCSV_Seperator & _
                                       "Given Name" & _strCSV_Seperator & _
                                       "Additional Name" & _strCSV_Seperator & _
                                       "Family Name" & _strCSV_Seperator & _
                                       "Nickname" & _strCSV_Seperator & _
                                       "Group Membership" & _strCSV_Seperator & _
                                       "E-mail 1 - Type" & _strCSV_Seperator & _
                                       "E-mail 1 - Value" & _strCSV_Seperator & _
                                       "Phone 1 - Type" & _strCSV_Seperator & _
                                       "Phone 1 - Value" & _strCSV_Seperator & _
                                       "Phone 2 - Type" & _strCSV_Seperator & _
                                       "Phone 2 - Value" & _strCSV_Seperator & _
                                       "Phone 3 - Type" & _strCSV_Seperator & _
                                       "Phone 3 - Value"

    Private _strSQL_Mitarbeiter As String
    Private _strSQL_Kunden As String

#End Region

    Private Sub frmHaupt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Height = My.Settings.Fenster_Hoehe
        Me.Width = My.Settings.Fenster_Breite
        Me.Location = New System.Drawing.Point(My.Settings.Fenster_X, My.Settings.Fenster_Y)
        frmHaupt_ResizeEnd(sender, e)

        Dim strDummy As String = ""

        'Einstellungen aktualisieren
        My.Settings.Upgrade()

        'Buttons deaktivern
        btnMitarbeiter_Laden.Enabled = False
        btnMitarbeiter_Export.Enabled = False
        btnMitarbeiter_Auswahl_Alle.Enabled = False
        btnMitarbeiter_Auswahl_Keine.Enabled = False
        btnMitarbeiter_Auswahl_Umkehren.Enabled = False
        btnKunden_Laden.Enabled = False
        btnKunden_Export.Enabled = False
        btnKunden_Auswahl_Alle.Enabled = False
        btnKunden_Auswahl_Keine.Enabled = False
        btnKunden_Auswahl_Umkehren.Enabled = False

        'Einstellungen laden
        txtMitarbeiter_Gruppe.Text = My.Settings.Mitarbeiter_Gruppe
        txtMitarbeiter_Datei.Text = My.Settings.Mitarbeiter_Datei
        txtKunden_Gruppe.Text = My.Settings.Kunden_Gruppe
        txtKunden_PL.Text = My.Settings.Kunden_PL
        txtKunden_Datei.Text = My.Settings.Kunden_Datei
        txtServer.Text = My.Settings.Server
        txtBenutzer.Text = My.Settings.Benutzer
        txtKennwort.Text = My.Settings.Kennwort

        'Verbindung herstellen
        Verbinden()

        If txtServer.Text = "" Or txtBenutzer.Text = "" Or txtKennwort.Text = "" Then
            grpEinstellungen.Visible = True
            txtServer.Focus()
        End If

    End Sub

    Private Sub Verbinden()
        Dim strDummy As String = ""

        'Verbindungsparameter übergeben
        _cDB.SetConnectionInfo(My.Settings.Server, _
                               My.Settings.Benutzer, _
                               My.Settings.Kennwort)

        'Verbindung herstellen
        strDummy = _cDB.ConnectDB()

        'Verbindungsstatus prüfen
        If _cDB.Status = True Then
            'Verbindung korrekt
            btnMitarbeiter_Laden.Enabled = True
            btnKunden_Laden.Enabled = True

        Else
            'Verbindung fehlgeschlagen
            MsgBox(strDummy, MsgBoxStyle.Critical, "Fehler")

        End If

    End Sub

    Private Sub frmHaupt_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        My.Settings.Fenster_Breite = Me.Width
        My.Settings.Fenster_Hoehe = Me.Height
        My.Settings.Fenster_X = Me.Location.X
        My.Settings.Fenster_Y = Me.Location.Y
        btnEinstellungen.Location = New System.Drawing.Point(Me.Width - 37, 0)
        grpEinstellungen.Location = New System.Drawing.Point(Me.Width - 237, 0)
        My.Settings.Save()

    End Sub

    Private Sub Clear_DataGrid()
        'Alle Zeilen rauslöschen
        Do While dgErgebnis.Rows.Count > 0
            dgErgebnis.Rows.Remove(dgErgebnis.Rows(0))

        Loop

        _i = 0

    End Sub

    Private Sub Datei_Auswählen(ByRef txtDatei As TextBox, _
                                ByRef btnExport As Button)
        Dim nReturn As Integer = 0

        If Not txtDatei.Text = "" Then
            SaveFileDialog.FileName = txtDatei.Text.Split("\")(txtDatei.Text.Split("\").Length - 1)
            SaveFileDialog.InitialDirectory = txtDatei.Text.Split(txtDatei.Text.Split("\")(txtDatei.Text.Split("\").Length - 1))(0)

        End If

        'Datei auswählen
        nReturn = SaveFileDialog.ShowDialog()

        If nReturn = 1 Then
            'Es wurde auf Speichern gedrückt
            txtDatei.Text = SaveFileDialog.FileName

            btnExport.Enabled = True

        ElseIf nReturn = 2 Then
            'Es wurde auf Abbrechen gedrückt
            txtDatei.Text = ""
            SaveFileDialog.FileName = "Google_Export.csv"
            SaveFileDialog.InitialDirectory = ""

            btnExport.Enabled = False

        Else
            'Was wurde hier gedückt???
            MsgBox("Was hast du gedrückt um den Wert: (" & nReturn.ToString & ") zu erhalten", MsgBoxStyle.Question, "???")

        End If

    End Sub

    Private Sub Daten_Laden(ByVal strSelect As String, _
                            ByRef txtInfo As TextBox, _
                            ByRef btnAuswahl_Alle As Button, _
                            ByRef btnAuswahl_Keine As Button, _
                            ByRef btnAuswahl_Umkehren As Button)

        txtInfo.Text = strSelect

        'Inhalt von Datagrid löschen
        Clear_DataGrid()

        'Daten selektieren
        _cDB.oReader = _cDB.OpenRS(strSelect)

        If Not _cDB.oReader Is Nothing Then
            While _cDB.oReader.Read
                'Zeile einfügen
                dgErgebnis.Rows.Add()

                'Werte setzen
                dgErgebnis.Rows(_i).Cells("colExport").Value = True
                dgErgebnis.Rows(_i).Cells("colFirma").Value = _cDB.oReader.Item("FIRMA")
                dgErgebnis.Rows(_i).Cells("colPosition").Value = _cDB.oReader.Item("POSITION")
                dgErgebnis.Rows(_i).Cells("colAnzeige_Name").Value = _cDB.oReader.Item("ANZEIGE_NAME")
                dgErgebnis.Rows(_i).Cells("colVorname").Value = _cDB.oReader.Item("VORNAME")
                dgErgebnis.Rows(_i).Cells("colName_Zusatz").Value = _cDB.oReader.Item("NAME_ZUSATZ")
                dgErgebnis.Rows(_i).Cells("colNachname").Value = _cDB.oReader.Item("NACHNAME")
                dgErgebnis.Rows(_i).Cells("colNickname").Value = _cDB.oReader.Item("NICKNAME")
                dgErgebnis.Rows(_i).Cells("colGruppe").Value = _cDB.oReader.Item("GRUPPE")
                dgErgebnis.Rows(_i).Cells("colMail_Type").Value = "* Work"
                dgErgebnis.Rows(_i).Cells("colMail").Value = _cDB.oReader.Item("MAIL")
                dgErgebnis.Rows(_i).Cells("colTelefon_Type").Value = "Work"
                dgErgebnis.Rows(_i).Cells("colTelefon").Value = _cDB.oReader.Item("TELEFON")
                dgErgebnis.Rows(_i).Cells("colKurzwahl_Type").Value = "Kurzwahl"
                dgErgebnis.Rows(_i).Cells("colKurzwahl").Value = _cDB.oReader.Item("KURZWAHL")
                dgErgebnis.Rows(_i).Cells("colMobil_Type").Value = "Mobile"
                dgErgebnis.Rows(_i).Cells("colMobil").Value = _cDB.oReader.Item("MOBIL")

                'Zäher erhöhen
                _i += 1

            End While

        End If

        'Ergebnis schreiben
        txtInfo.Text = dgErgebnis.Rows.Count.ToString & " Sätze geladen mit folgenden Select :" & vbNewLine & _
                       "---------------------------------------------------------" & vbNewLine & _
                       strSelect

        btnAuswahl_Alle.Enabled = True
        btnAuswahl_Keine.Enabled = True
        btnAuswahl_Umkehren.Enabled = True

    End Sub

    Private Sub Export_Datei(ByVal txtDatei As TextBox, _
                             ByRef txtInfo As TextBox)

        Dim strBuffer As String = ""
        Dim iCount As Integer = 0

        'Prüfen ob Datei existiert
        If System.IO.File.Exists(txtDatei.Text) Then
            'Datei löschen
            System.IO.File.Delete(txtDatei.Text)

        End If

        'StreamWriter definieren
        _sw = New System.IO.StreamWriter(txtDatei.Text)

        'Header schreiben
        _sw.WriteLine(_strCSV_Header)

        'Zeilenweise schreiben
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            'Buffer leeren
            strBuffer = ""

            If dgErgebnis.Rows(i).Cells("colExport").Value = True Then
                'Zeile zusammenstellen
                strBuffer = dgErgebnis.Rows(i).Cells("colFirma").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colPosition").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colAnzeige_Name").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colVorname").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colName_Zusatz").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colNachname").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colNickname").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colGruppe").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colMail_Type").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colMail").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colTelefon_Type").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colTelefon").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colKurzwahl_Type").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colKurzwahl").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colMobil_Type").Value & _strCSV_Seperator & _
                            dgErgebnis.Rows(i).Cells("colMobil").Value

                'Zeile schreiben
                _sw.WriteLine(strBuffer)

                iCount += 1

            End If

        Next

        'Datei schließen
        _sw.Close()

        txtInfo.Text = iCount.ToString & " Sätze exportiert => FERTIG"

    End Sub

#End Region

#Region "Mitarbeiter"

    Private Sub btnMitarbeiter_Datei_Auswählen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMitarbeiter_Datei_Auswählen.Click
        Datei_Auswählen(txtMitarbeiter_Datei, _
                        btnMitarbeiter_Export)

        If Not txtMitarbeiter_Datei.Text = "" Then
            My.Settings.Mitarbeiter_Datei = txtMitarbeiter_Datei.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnMitarbeiter_Laden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMitarbeiter_Laden.Click
        _strSQL_Mitarbeiter = "Select 'Ramsauer & Stürmer' FIRMA," & vbNewLine & _
                                            "       I.INTADR_FELD06 POSITION," & vbNewLine & _
                                            "       I.NAME1 ANZEIGE_NAME, " & vbNewLine & _
                                            "       A.ANSP_VORNAME VORNAME, " & vbNewLine & _
                                            "       A.TITEL_KURZ NAME_ZUSATZ, " & vbNewLine & _
                                            "       A.ANSP_NACHNAME NACHNAME, " & vbNewLine & _
                                            "       I.INTADR_FELD04 NICKNAME, " & vbNewLine & _
                                            "        '* My Contacts ::: " & txtMitarbeiter_Gruppe.Text & "' GRUPPE," & vbNewLine & _
                                            "       MAIL.TEL_RUFNR MAIL, " & vbNewLine & _
                                            "       FA.TEL_VW || FA.TEL_RUFNR || FA.TEL_DW TELEFON, " & vbNewLine & _
                                            "       DECODE(KW.TEL_VW,'','','90' || KW.TEL_VW) KURZWAHL, " & vbNewLine & _
                                            "       DECODE(KW.TEL_VW,'','',HANDY.TEL_VW || HANDY.TEL_RUFNR) MOBIL " & vbNewLine & _
                                            "       from S_INTADR I, S_IDGZ Z, S_ANSP A, S_TEL KW, S_TEL FA, S_TEL HANDY, S_TEL MAIL " & vbNewLine & _
                                            "       where I.FIRM_NR = Z.FIRM_NR " & vbNewLine & _
                                            "       and I.INTADR_NR = Z.INTADR_NR " & vbNewLine & _
                                            "       and I.FIRM_NR = A.FIRM_NR " & vbNewLine & _
                                            "       and I.INTADR_NR = A.INTADR_NR " & vbNewLine & _
                                            "       and A.ANSP_KZSTD = 'J' " & vbNewLine & _
                                            "       and A.FIRM_NR = FA.FIRM_NR(+) " & vbNewLine & _
                                            "       and A.INTADR_NR = FA.INTADR_NR(+) " & vbNewLine & _
                                            "       and A.ANSP_NR = FA.ANSP_NR(+) " & vbNewLine & _
                                            "       and 'TEL FA 1' = FA.TEL_CODE(+) " & vbNewLine & _
                                            "       and A.FIRM_NR = KW.FIRM_NR(+) " & vbNewLine & _
                                            "       and A.INTADR_NR = KW.INTADR_NR(+) " & vbNewLine & _
                                            "       and A.ANSP_NR = KW.ANSP_NR(+) " & vbNewLine & _
                                            "       and 'KURZWAHL' = KW.TEL_CODE(+) " & vbNewLine & _
                                            "       and A.FIRM_NR = HANDY.FIRM_NR(+) " & vbNewLine & _
                                            "       and A.INTADR_NR = HANDY.INTADR_NR(+) " & vbNewLine & _
                                            "       and A.ANSP_NR = HANDY.ANSP_NR(+) " & vbNewLine & _
                                            "       and 'MOBIL 1' = HANDY.TEL_CODE(+) " & vbNewLine & _
                                            "       and A.FIRM_NR = MAIL.FIRM_NR(+) " & vbNewLine & _
                                            "       and A.INTADR_NR = MAIL.INTADR_NR(+) " & vbNewLine & _
                                            "       and A.ANSP_NR = MAIL.ANSP_NR(+) " & vbNewLine & _
                                            "       and 'E-MAIL 1' = MAIL.TEL_CODE(+) " & vbNewLine & _
                                            "       and Z.ADGA_CD = 'AK' " & vbNewLine & _
                                            "       and Z.ADGR_CD = 'MA' " & vbNewLine & _
                                            "       and I.INTADR_FELD04 is not null " & vbNewLine & _
                                            "       and I.INTADR_STATUS = 'A' " & vbNewLine & _
                                            "       order by 1"

        'Daten Laden und Datagrid schreiben
        Daten_Laden(_strSQL_Mitarbeiter, _
                    txtMitarbeiter_Info, _
                    btnMitarbeiter_Auswahl_Alle, _
                    btnMitarbeiter_Auswahl_Keine, _
                    btnMitarbeiter_Auswahl_Umkehren)

    End Sub

    Private Sub btnMitarbeiter_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMitarbeiter_Export.Click
        Export_Datei(txtMitarbeiter_Datei, _
                     txtMitarbeiter_Info)

    End Sub

    Private Sub btnMitarbeiter_Auswahl_Alle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMitarbeiter_Auswahl_Alle.Click
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            dgErgebnis.Rows(i).Cells("colExport").Value = True

        Next
    End Sub

    Private Sub btnMitarbeiter_Auswahl_Keine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMitarbeiter_Auswahl_Keine.Click
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            dgErgebnis.Rows(i).Cells("colExport").Value = False

        Next
    End Sub

    Private Sub btnMitarbeiter_Auswahl_Umkehren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMitarbeiter_Auswahl_Umkehren.Click
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            If dgErgebnis.Rows(i).Cells("colExport").Value = True Then
                dgErgebnis.Rows(i).Cells("colExport").Value = False
            Else
                dgErgebnis.Rows(i).Cells("colExport").Value = True
            End If
        Next
    End Sub

    Private Sub txtMitarbeiter_Datei_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMitarbeiter_Datei.Validating
        'ErrorProvider zurücksetzen
        ErrorProvider.SetError(txtMitarbeiter_Datei, "")

        'Prüfen ob Feld leer ist
        If txtMitarbeiter_Datei.Text = "" Then
            e.Cancel = False
            Exit Sub

        End If

        'Prüfen ob \ in Pfad vorhanden
        If txtMitarbeiter_Datei.Text.Contains("\") Then
            'Prüfen ob Pfad existiert
            If System.IO.Directory.Exists(txtMitarbeiter_Datei.Text.Substring(0, txtMitarbeiter_Datei.Text.LastIndexOf("\"))) Then
                'Eingabe OK
                e.Cancel = False
                Exit Sub

            End If
        End If

        'Error Provider ausgeben
        ErrorProvider.SetError(txtMitarbeiter_Datei, "Verzeichnis nicht vorhanden!!!")
        e.Cancel = True

    End Sub

    Private Sub txtMitarbeiter_Gruppe_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMitarbeiter_Gruppe.Validated
        'Einstellung schreiben
        My.Settings.Mitarbeiter_Gruppe = txtMitarbeiter_Gruppe.Text
        My.Settings.Save()

    End Sub

#End Region

#Region "Kunden"
    Private Sub btnKunden_Datei_Auswählen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunden_Datei_Auswählen.Click
        Datei_Auswählen(txtKunden_Datei, _
                        btnKunden_Export)

        If Not txtKunden_Datei.Text = "" Then
            My.Settings.Kunden_Datei = txtKunden_Datei.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnKunden_Laden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunden_Laden.Click
        _strSQL_Kunden = "Select 	I.NAME1 FIRMA," & vbNewLine & _
                         "          '' POSITION," & vbNewLine & _
                         "          A.ANSP_NACHNAME || ' ' || A.ANSP_VORNAME || ' ' || A.TITEL_KURZ ANZEIGE_NAME," & vbNewLine & _
                         "          A.ANSP_VORNAME VORNAME," & vbNewLine & _
                         "          A.TITEL_KURZ NAME_ZUSATZ," & vbNewLine & _
                         "          A.ANSP_NACHNAME NACHNAME," & vbNewLine & _
                         "          '' NICKNAME," & vbNewLine & _
                         "          '* My Contacts ::: " & txtKunden_Gruppe.Text & "' GRUPPE," & vbNewLine & _
                         "          NVL(MAIL.TEL_RUFNR, MAIL0.TEL_RUFNR) MAIL," & vbNewLine & _
                         "          NVL(FA.TEL_VW || FA.TEL_RUFNR || FA.TEL_DW, FA0.TEL_VW || FA0.TEL_RUFNR || FA0.TEL_DW) TELEFON," & vbNewLine & _
                         "          NVL(DECODE(KW.TEL_VW,'','','90' || KW.TEL_VW), DECODE(KW0.TEL_VW,'','','90' || KW0.TEL_VW)) KURZWAHL," & vbNewLine & _
                         "          HANDY.TEL_VW || HANDY.TEL_RUFNR MOBIL" & vbNewLine & _
                         "from S_INTADR I,  RS_KUNDE KD," & vbNewLine & _
                         "	    S_ANSP A, S_TEL KW, S_TEL FA, S_TEL HANDY, S_TEL MAIL," & vbNewLine & _
                         "	    S_ANSP A0, S_TEL KW0, S_TEL FA0, S_TEL MAIL0" & vbNewLine & _
                         "where I.INTADR_FELD02 = KD.KUNDE_NR" & vbNewLine & _
                         "and I.FIRM_NR = A.FIRM_NR" & vbNewLine & _
                         "and I.INTADR_NR = A.INTADR_NR" & vbNewLine & _
                         "and '0' != A.ANSP_NR" & vbNewLine & _
                         "and I.FIRM_NR = A0.FIRM_NR" & vbNewLine & _
                         "and I.INTADR_NR = A0.INTADR_NR" & vbNewLine & _
                         "and '0' = A0.ANSP_NR" & vbNewLine & _
                         "and A.FIRM_NR = FA.FIRM_NR(+)" & vbNewLine & _
                         "and A.INTADR_NR = FA.INTADR_NR(+)" & vbNewLine & _
                         "and A.ANSP_NR = FA.ANSP_NR(+)" & vbNewLine & _
                         "and 'TEL FA 1' = FA.TEL_CODE(+)" & vbNewLine & _
                         "and A.FIRM_NR = KW.FIRM_NR(+)" & vbNewLine & _
                         "and A.INTADR_NR = KW.INTADR_NR(+)" & vbNewLine & _
                         "and A.ANSP_NR = KW.ANSP_NR(+)" & vbNewLine & _
                         "and 'KURZWAHL' = KW.TEL_CODE(+)" & vbNewLine & _
                         "and A.FIRM_NR = HANDY.FIRM_NR(+)" & vbNewLine & _
                         "and A.INTADR_NR = HANDY.INTADR_NR(+)" & vbNewLine & _
                         "and A.ANSP_NR = HANDY.ANSP_NR(+)" & vbNewLine & _
                         "and 'MOBIL 1' = HANDY.TEL_CODE(+)" & vbNewLine & _
                         "and A.FIRM_NR = MAIL.FIRM_NR(+)" & vbNewLine & _
                         "and A.INTADR_NR = MAIL.INTADR_NR(+)" & vbNewLine & _
                         "and A.ANSP_NR = MAIL.ANSP_NR(+)" & vbNewLine & _
                         "and 'E-MAIL 1' = MAIL.TEL_CODE(+)" & vbNewLine & _
                         "and A0.FIRM_NR = FA0.FIRM_NR(+)" & vbNewLine & _
                         "and A0.INTADR_NR = FA0.INTADR_NR(+)" & vbNewLine & _
                         "and A0.ANSP_NR = FA0.ANSP_NR(+)" & vbNewLine & _
                         "and 'TEL FA 1' = FA0.TEL_CODE(+)" & vbNewLine & _
                         "and A0.FIRM_NR = KW0.FIRM_NR(+)" & vbNewLine & _
                         "and A0.INTADR_NR = KW0.INTADR_NR(+)" & vbNewLine & _
                         "and A0.ANSP_NR = KW0.ANSP_NR(+)" & vbNewLine & _
                         "and 'KURZWAHL' = KW0.TEL_CODE(+)" & vbNewLine & _
                         "and A0.FIRM_NR = MAIL0.FIRM_NR(+)" & vbNewLine & _
                         "and A0.INTADR_NR = MAIL0.INTADR_NR(+)" & vbNewLine & _
                         "and A0.ANSP_NR = MAIL0.ANSP_NR(+)" & vbNewLine & _
                         "and 'E-MAIL 1' = MAIL0.TEL_CODE(+)" & vbNewLine & _
                         "and I.INTADR_STATUS = 'A'" & vbNewLine & _
                         "@USER@" & _
                         "order by I.NAME1"

        'Einschränkung auf Mitarbeiter
        If txtKunden_PL.Text = "*" Or txtKunden_PL.Text = "" Then
            'Einschränkung entfernen (= alle Mitarbeiter)
            _strSQL_Kunden = _strSQL_Kunden.Replace("@USER@", "")

        Else
            'Auf PL Einschränken
            _strSQL_Kunden = _strSQL_Kunden.Replace("@USER@", "and '" & txtKunden_PL.Text & "' in (KD.KUNDE_PL_REWE,KD.KUNDE_PL_WAWI)" & vbNewLine)

        End If

        'Daten Laden und Datagrid schreiben
        Daten_Laden(_strSQL_Kunden, _
                    txtKunden_Info, _
                    btnKunden_Auswahl_Alle, _
                    btnKunden_Auswahl_Keine, _
                    btnKunden_Auswahl_Umkehren)

    End Sub

    Private Sub btnKunden_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunden_Export.Click
        Export_Datei(txtKunden_Datei, _
                     txtKunden_Info)

    End Sub

    Private Sub btnKunden_Auswahl_Alle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunden_Auswahl_Alle.Click
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            dgErgebnis.Rows(i).Cells("colExport").Value = True

        Next
    End Sub

    Private Sub btnKunden_Auswahl_Keine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunden_Auswahl_Keine.Click
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            dgErgebnis.Rows(i).Cells("colExport").Value = False

        Next
    End Sub

    Private Sub btnKunden_Auswahl_Umkehren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKunden_Auswahl_Umkehren.Click
        For i As Integer = 0 To dgErgebnis.Rows.Count - 1
            If dgErgebnis.Rows(i).Cells("colExport").Value = True Then
                dgErgebnis.Rows(i).Cells("colExport").Value = False
            Else
                dgErgebnis.Rows(i).Cells("colExport").Value = True
            End If
        Next
    End Sub

    Private Sub txtKunden_Datei_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKunden_Datei.Validating
        'ErrorProvider zurücksetzen
        ErrorProvider.SetError(txtKunden_Datei, "")

        'Prüfen ob Feld leer ist
        If txtKunden_Datei.Text = "" Then
            e.Cancel = False
            Exit Sub

        End If

        'Prüfen ob \ in Pfad vorhanden
        If txtKunden_Datei.Text.Contains("\") Then
            'Prüfen ob Pfad existiert
            If System.IO.Directory.Exists(txtKunden_Datei.Text.Substring(0, txtKunden_Datei.Text.LastIndexOf("\"))) Then
                'Eingabe OK
                e.Cancel = False
                Exit Sub

            End If
        End If

        'Error Provider ausgeben
        ErrorProvider.SetError(txtKunden_Datei, "Verzeichnis nicht vorhanden!!!")
        e.Cancel = True

    End Sub

    Private Sub txtKunden_Gruppe_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKunden_Gruppe.Validated
        'Einstellung schreiben
        My.Settings.Kunden_Gruppe = txtKunden_Gruppe.Text
        My.Settings.Save()

    End Sub

    Private Sub txtKunden_PL_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKunden_PL.Validated
        'Einstellung schreiben
        txtKunden_PL.Text = txtKunden_PL.Text.ToUpper

        My.Settings.Kunden_PL = txtKunden_PL.Text
        My.Settings.Save()

    End Sub

#End Region

#Region "Einstellungen"
    Private Sub btnEinstellungen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEinstellungen.Click
        If grpEinstellungen.Visible Then
            grpEinstellungen.Visible = False
        Else
            grpEinstellungen.Visible = True
        End If

    End Sub

    Private Sub txtServer_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServer.Validated
        'Einstellung schreiben
        My.Settings.Server = txtServer.Text
        My.Settings.Save()

    End Sub

    Private Sub txtBenutzer_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBenutzer.Validated
        'Einstellung schreiben
        My.Settings.Benutzer = txtBenutzer.Text
        My.Settings.Save()

    End Sub

    Private Sub txtKennwort_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKennwort.Validated
        'Einstellung schreiben
        My.Settings.Kennwort = txtKennwort.Text
        My.Settings.Save()

    End Sub

    Private Sub btnVerbinden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerbinden.Click
        Verbinden()

    End Sub

#End Region
  

End Class
