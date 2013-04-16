Public Class frmHaupt

    Private Sub btnAbrechnung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrechnung.Click
        'Init Felder TextBox-Array
        Dim Brutto() As TextBox = {txtBrutto1, txtBrutto2, txtBrutto3, txtBrutto4, txtBrutto5, txtBrutto6, txtBrutto7, txtBrutto8, txtBrutto9, txtBrutto10, txtBrutto11, txtBrutto12}
        Dim SZ() As TextBox = {txtSZ1, txtSZ2, txtSZ3, txtSZ4, txtSZ5, txtSZ6, txtSZ7, txtSZ8, txtSZ9, txtSZ10, txtSZ11, txtSZ12}
        Dim J6() As TextBox = {txtJ61, txtJ62, txtJ63, txtJ64, txtJ65, txtJ66, txtJ67, txtJ68, txtJ69, txtJ610, txtJ611, txtJ612}
        Dim WertUJ6() As TextBox = {txtWertUJ61, txtWertUJ62, txtWertUJ63, txtWertUJ64, txtWertUJ65, txtWertUJ66, txtWertUJ67, txtWertUJ68, txtWertUJ69, txtWertUJ610, txtWertUJ611, txtWertUJ612}
        Dim Freibetrag() As TextBox = {txtFreibetrag1, txtFreibetrag2, txtFreibetrag3, txtFreibetrag4, txtFreibetrag5, txtFreibetrag6, txtFreibetrag7, txtFreibetrag8, txtFreibetrag9, txtFreibetrag10, txtFreibetrag11, txtFreibetrag12}
        Dim SVLfd() As TextBox = {txtSVLfd1, txtSVLfd2, txtSVLfd3, txtSVLfd4, txtSVLfd5, txtSVLfd6, txtSVLfd7, txtSVLfd8, txtSVLfd9, txtSVLfd10, txtSVLfd11, txtSVLfd12}
        Dim SVSZ() As TextBox = {txtSVSZ1, txtSVSZ2, txtSVSZ3, txtSVSZ4, txtSVSZ5, txtSVSZ6, txtSVSZ7, txtSVSZ8, txtSVSZ9, txtSVSZ10, txtSVSZ11, txtSVSZ12}
        Dim LstBem() As TextBox = {txtLstBem1, txtLstBem2, txtLstBem3, txtLstBem4, txtLstBem5, txtLstBem6, txtLstBem7, txtLstBem8, txtLstBem9, txtLstBem10, txtLstBem11, txtLstBem12}
        Dim LstBemSZ() As TextBox = {txtLstBemSZ1, txtLstBemSZ2, txtLstBemSZ3, txtLstBemSZ4, txtLstBemSZ5, txtLstBemSZ6, txtLstBemSZ7, txtLstBemSZ8, txtLstBemSZ9, txtLstBemSZ10, txtLstBemSZ11, txtLstBemSZ12}
        Dim Lstlfd() As TextBox = {txtLstLfd1, txtLstLfd2, txtLstLfd3, txtLstLfd4, txtLstLfd5, txtLstLfd6, txtLstLfd7, txtLstLfd8, txtLstLfd9, txtLstLfd10, txtLstLfd11, txtLstLfd12}
        Dim LstSZ() As TextBox = {txtLstSZ1, txtLstSZ2, txtLstSZ3, txtLstSZ4, txtLstSZ5, txtLstSZ6, txtLstSZ7, txtLstSZ8, txtLstSZ9, txtLstSZ10, txtLstSZ11, txtLstSZ12}
        Dim Netto() As TextBox = {txtNetto1, txtNetto2, txtNetto3, txtNetto4, txtNetto5, txtNetto6, txtNetto7, txtNetto8, txtNetto9, txtNetto10, txtNetto11, txtNetto12}

        Dim BruttoGes As Decimal = 0
        Dim SZGes As Decimal = 0
        Dim NettoGes As Decimal = 0
        Dim SVGes As Decimal = 0
        Dim SVSZGes As Decimal = 0
        Dim LstGes As Decimal = 0
        Dim LstSZGes As Decimal = 0
        Dim WertUJ6Ges As Decimal = 0

        If False Then 'Code zum Testen der Feldnamen (False muss auf True gestellt werden)
            For i As Integer = 0 To 11 'Schleife für die einzelnen Monate
                Brutto(i).Text = Brutto(i).Name
                SZ(i).Text = SZ(i).Name
                J6(i).Text = J6(i).Name
                WertUJ6(i).Text = WertUJ6(i).Name
                Freibetrag(i).Text = Freibetrag(i).Name
                SVLfd(i).Text = SVLfd(i).Name
                SVSZ(i).Text = SVSZ(i).Name
                LstBem(i).Text = LstBem(i).Name
                LstBemSZ(i).Text = LstBemSZ(i).Name
                Lstlfd(i).Text = Lstlfd(i).Name
                LstSZ(i).Text = LstSZ(i).Name
                Netto(i).Text = Netto(i).Name
            Next
        End If


        For i As Integer = 0 To 11 'Schleife für die einzelnen Monate
            'Berechnung Jahressechstel
            Netto(i).Text = 0
            Brutto(i).Text = Math.Round(Convert.ToDecimal(Brutto(i).Text), 2).ToString
            BruttoGes = BruttoGes + Convert.ToDecimal(Brutto(i).Text)
            J6(i).Text = (BruttoGes + WertUJ6Ges) / (i + 1) * 2 - (SZGes - WertUJ6Ges)

            'Wenn Jahressechsel überschritten auf 0 setzen
            If Convert.ToDecimal(J6(i).Text) < 0 Then
                J6(i).Text = 0
            End If

            J6(i).Text = Math.Round(Convert.ToDecimal(J6(i).Text), 2).ToString

            If i = 0 Then 'Wenn 1 Monat Freibetrag berücksichtigen
                Freibetrag(i).Text = txtSZLstFreibetrag.Text
            Else
                Freibetrag(i).Text = Freibetrag(i - 1).Text
            End If

            Freibetrag(i).Text = Math.Round(Convert.ToDecimal(Freibetrag(i).Text), 2).ToString

            'Berechnung SZ
            If Not SZ(i).Text = "" Then
                SZ(i).Text = Math.Round(Convert.ToDecimal(SZ(i).Text), 2).ToString
                SZGes = SZGes + SZ(i).Text

                'Berechnung Sozialversicherung
                If Convert.ToDecimal(SZ(i).Text) > Convert.ToDecimal(txtSZSVHoechst.Text) Then  'SZ größer Höchstbemessung
                    SVSZ(i).Text = txtSZSVHoechst.Text / 100 * txtSZSVProz.Text
                Else
                    SVSZ(i).Text = SZ(i).Text / 100 * txtSZSVProz.Text
                End If

                SVSZ(i).Text = Math.Round(Convert.ToDecimal(SVSZ(i).Text), 2).ToString

                SVSZGes = SVSZGes + SVSZ(i).Text

                'Ermitteln des Wert über Jahressechsel
                If Convert.ToDecimal(SZ(i).Text) > Convert.ToDecimal(J6(i).Text) Then 'SZ größer Jahressechstel
                    WertUJ6(i).Text = SZ(i).Text - J6(i).Text
                Else
                    WertUJ6(i).Text = 0
                End If

                WertUJ6(i).Text = Math.Round(Convert.ToDecimal(WertUJ6(i).Text), 2).ToString

                WertUJ6Ges = WertUJ6Ges + WertUJ6(i).Text

                'Ermittlung Lohnsteuerbemessung für Sonderzahlung
                LstBemSZ(i).Text = SZ(i).Text - SVSZ(i).Text - WertUJ6(i).Text

                'Freibetrag für SZ berücksichtigen
                If Convert.ToDecimal(Freibetrag(i).Text) > 0 Then
                    If Freibetrag(i).Text < LstBemSZ(i).Text Then
                        Freibetrag(i).Text = Freibetrag(i).Text - LstBemSZ(i).Text
                        LstBemSZ(i).Text = 0
                    Else
                        LstBemSZ(i).Text = LstBemSZ(i).Text - Freibetrag(i).Text
                        Freibetrag(i).Text = 0
                    End If
                End If

                Freibetrag(i).Text = Math.Round(Convert.ToDecimal(Freibetrag(i).Text), 2).ToString
                LstBemSZ(i).Text = Math.Round(Convert.ToDecimal(LstBemSZ(i).Text), 2).ToString

                LstSZ(i).Text = LstBemSZ(i).Text / 100 * txtSZLstProz.Text

                LstSZ(i).Text = Math.Round(Convert.ToDecimal(LstSZ(i).Text), 2).ToString

                LstSZGes = LstSZGes + LstSZ(i).Text

                'Netto errechnen (lfd wird unten berücksichtigt)
                Netto(i).Text = SZ(i).Text - SVSZ(i).Text - LstSZ(i).Text

                Netto(i).Text = Math.Round(Convert.ToDecimal(Netto(i).Text), 2).ToString
            End If

            'Berechnung lfd. Bezüge
            If True Then
                'Berechnung Sozialversicherung
                If Convert.ToDecimal(Brutto(i).Text) > Convert.ToDecimal(txtSVHoechst.Text) Then  'Brutto größer Höchstbemessung
                    SVLfd(i).Text = txtSVHoechst.Text / 100 * txtSVProz.Text
                Else
                    SVLfd(i).Text = Brutto(i).Text / 100 * txtSVProz.Text
                End If

                SVLfd(i).Text = Math.Round(Convert.ToDecimal(SVLfd(i).Text), 2).ToString

                SVGes = SVGes + SVLfd(i).Text

                'Ermittlung Lohnsteuer Bemessung
                LstBem(i).Text = Brutto(i).Text - SVLfd(i).Text

                If Not WertUJ6(i).Text = "" Then
                    LstBem(i).Text = Convert.ToDecimal(LstBem(i).Text) + Convert.ToDecimal(WertUJ6(i).Text)
                End If

                LstBem(i).Text = Math.Round(Convert.ToDecimal(LstBem(i).Text), 2).ToString

                If Convert.ToDecimal(LstBem(i).Text) >= Convert.ToDecimal(txtLstWert3.Text) Then
                    Lstlfd(i).Text = LstBem(i).Text / 100 * txtLstProz3.Text - txtLstAbzug3.Text
                ElseIf Convert.ToDecimal(LstBem(i).Text) >= Convert.ToDecimal(txtLstWert2.Text) Then
                    Lstlfd(i).Text = LstBem(i).Text / 100 * txtLstProz2.Text - txtLstAbzug2.Text
                ElseIf Convert.ToDecimal(LstBem(i).Text) >= Convert.ToDecimal(txtLstWert1.Text) Then
                    Lstlfd(i).Text = LstBem(i).Text / 100 * txtLstProz1.Text - txtLstAbzug1.Text
                Else
                    Lstlfd(i).Text = 0
                End If

                Lstlfd(i).Text = Math.Round(Convert.ToDecimal(Lstlfd(i).Text), 2).ToString

                LstGes = LstGes + Lstlfd(i).Text

            End If

            'Netto errechnen (SZ wird oben berücksichtigt)
            Netto(i).Text = Convert.ToDecimal(Netto(i).Text) + Convert.ToDecimal(Brutto(i).Text) - SVLfd(i).Text - Lstlfd(i).Text
            NettoGes = NettoGes + Netto(i).Text
            Netto(i).Text = Math.Round(Convert.ToDecimal(Netto(i).Text), 2).ToString
        Next

        txtBruttoGes.Text = BruttoGes
        txtSZGes.Text = SZGes
        txtNettoGes.Text = NettoGes
        txtSVLfdGes.Text = SVGes
        txtSVSZGes.Text = SVSZGes
        txtLstLfdGes.Text = LstGes
        txtLstSZGes.Text = LstSZGes
    End Sub

End Class
