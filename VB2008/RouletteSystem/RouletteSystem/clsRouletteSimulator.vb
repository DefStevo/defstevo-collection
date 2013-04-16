Imports ZedGraph


Public Class clsRouletteSimulator

    'Todo Statistiken einbauen
    ' - Durchschnittliche Runden bis Gewinn
    ' - Durchschnittlicher Geweinn pro Runde
    ' - Längste Verlustserie
    ' - Zahlenanalysen X% nie, X% 1x etc.
    ' - Ergebniss in eigenes Form ausgeben (DataGrid 1 für Spiel 1 für Statistiken)

    ' - Threaths mit Serien 100 Spiele mit 100 Runden
    ' - LiveTime Statistiken
    ' - Andere Systeme

    Structure nZahlen
        Dim nZahl As Integer

        Sub New(ByVal Zahl As Integer)
            nZahl = Zahl
        End Sub

        Public Sub ToList()

        End Sub
    End Structure

    Private _nKapital As Integer            'Vorhandenes Kapital
    Private _nEinsatz As Integer            'Aktueller Einsatz
    Private _nRunden As Integer             'Anahl der Runden
    Private _nSystem As Integer             'Spielsystem
    Private _nRundenGewinn As Integer       'Counter für die Rundenanzahl bis zum Sieg (Wird nach jedem Sieg auf 0 gesetzt)

    Private _nZahlen As List(Of nZahlen)    'Liste mit den aktuellen Zahlen
    Private _nZahl As nZahlen               'Wird benötigt um die Liste zu befüllen

    Private _nMaxRunden As Integer          'Runden bis Ende

    Private _nRoulette As Integer           'Gezogene Zahl

    Private r As New System.Random()        'Zufallsgenerator

    Public Sub Start()
        _nKapital = frmHaupt.nKapital.Text
        _nEinsatz = frmHaupt.nEinsatz.Text
        _nRunden = frmHaupt.nRunden.Text

        frmStatistik.nRunden.Text = 0
        frmStatistik.nGewinnVerlust.Text = 0
        frmStatistik.nGewinnVerlustDurchschnitt.Text = 0
        frmStatistik.nRundenBisSiegDurchschnitt.Text = 0
        frmStatistik.nRundenBisSiegMax.Text = 0
        frmStatistik.nSiegNachRunde1.Text = 0
        frmStatistik.nSiegNachRunde2.Text = 0
        frmStatistik.nSiegNachRunde3.Text = 0
        frmStatistik.nSiegNachRunde4.Text = 0
        frmStatistik.nSiegNachRunde5.Text = 0
        frmStatistik.nSiegNachRunde6.Text = 0
        frmStatistik.nSiegNachRunde7.Text = 0
        frmStatistik.nSiegNachRunde8.Text = 0
        frmStatistik.nSiegNachRunde9.Text = 0

        _nZahlen = New List(Of nZahlen)

        If frmHaupt.rd8er.Checked Then
            '1 Zahl deklarieren
            _nZahl = New nZahlen(r.Next(0, 36))
            _nZahlen.Add(_nZahl)

            'Systemspiel Starten
            System8er()
        End If

        If frmHaupt.rdMarch.Checked Then
            _nSystem = 1
        End If

        If frmHaupt.rdMartingale.Checked Then
            _nSystem = 2
        End If
    End Sub

    Private Sub System8er()

        _nRundenGewinn = 0

        For i As Integer = 1 To _nRunden
            SchreibeStatistik(True) 'Statistik: NEUE ZEILE

            _nRundenGewinn += 1

            If _nKapital <= _nEinsatz Then 'Prüfen ob noch Kapital größer benötigten Einsatz ist
                _nEinsatz = _nKapital

                LeereZahlen(_nEinsatz)

            End If

            _nKapital -= _nEinsatz



            SchreibeStatistik(False, i.ToString, _nKapital.ToString, _nEinsatz.ToString, , ListeZahlen()) 'Statistik: Rundennr, Kaptial, Einsatz, Gesetzte Zahlen

            _nMaxRunden = i


            _nRoulette = r.Next(0, 36) 'Kugel werfen

            SchreibeStatistik(False, , , , _nRoulette.ToString) 'Statistik: Gezogene Zahl

            'Prüfen ob Gewonnen wurde
            If Gewinn() Then
                LeereZahlen() 'Zahlen leeren

                _nEinsatz = 1
                _nKapital += 36

                SchreibeStatistik(False, , _nKapital.ToString, , , , _nRundenGewinn.ToString) 'Statistik: Benötigte Runden bis Sieg

                _nRundenGewinn = 0

            Else
                _nEinsatz += 1

            End If

            _nZahl = New nZahlen(_nRoulette)
            _nZahlen.Add(_nZahl)

            If Not NochKapital() Then 'Prüfen ob noch Kapital vorhanden
                GoTo Ende
            End If
        Next

        'Einsprungpunkt für Statistik
Ende:

        'Ermittlung der Maximalen/Durchschnittlichen Runden bis zum Sieg
        Dim _nCountSiege As Integer = 0
        Dim _nSummeRundenBisSieg As Integer = 0
        Dim _nMaxRundenBisSieg As Integer = 0
        Dim _nMinKapital As Integer = _nKapital
        Dim _nMaxKapital As Integer = _nKapital

        For i As Integer = 0 To frmStatistik.dgStatistik.Rows.Count - 1
            If frmStatistik.dgStatistik.Rows(i).Cells("colKapital").Value > _nMaxKapital Then
                _nMaxKapital = frmStatistik.dgStatistik.Rows(i).Cells("colKapital").Value
            End If

            If frmStatistik.dgStatistik.Rows(i).Cells("colKapital").Value < _nMinKapital Then
                _nMinKapital = frmStatistik.dgStatistik.Rows(i).Cells("colKapital").Value
            End If

            If Not frmStatistik.dgStatistik.Rows(i).Cells("colBenötigteRunden").Value = "" Then
                _nCountSiege = _nCountSiege + 1
                _nSummeRundenBisSieg = _nSummeRundenBisSieg + frmStatistik.dgStatistik.Rows(i).Cells("colBenötigteRunden").Value

                If _nMaxRundenBisSieg < frmStatistik.dgStatistik.Rows(i).Cells("colBenötigteRunden").Value Then
                    _nMaxRundenBisSieg = frmStatistik.dgStatistik.Rows(i).Cells("colBenötigteRunden").Value
                End If

                Select Case frmStatistik.dgStatistik.Rows(i).Cells("colBenötigteRunden").Value
                    Case 1
                        frmStatistik.nSiegNachRunde1.Text += 1
                    Case 2
                        frmStatistik.nSiegNachRunde2.Text += 1
                    Case 3
                        frmStatistik.nSiegNachRunde3.Text += 1
                    Case 4
                        frmStatistik.nSiegNachRunde4.Text += 1
                    Case 5
                        frmStatistik.nSiegNachRunde5.Text += 1
                    Case 6
                        frmStatistik.nSiegNachRunde6.Text += 1
                    Case 7
                        frmStatistik.nSiegNachRunde7.Text += 1
                    Case 8
                        frmStatistik.nSiegNachRunde8.Text += 1
                    Case Else
                        frmStatistik.nSiegNachRunde9.Text += 1
                End Select
            End If
        Next

        frmStatistik.nRunden.Text = _nMaxRunden
        frmStatistik.nGewinnVerlust.Text = _nKapital - frmHaupt.nKapital.Text
        frmStatistik.nGewinnVerlustDurchschnitt.Text = Math.Round((_nKapital - frmHaupt.nKapital.Text) / _nMaxRunden, 3)
        frmStatistik.nRundenBisSiegDurchschnitt.Text = Math.Round(_nSummeRundenBisSieg / _nCountSiege, 3)
        frmStatistik.nRundenBisSiegMax.Text = _nMaxRundenBisSieg
        frmStatistik.nKapital.Text = _nKapital
        frmStatistik.nKapitalMin.Text = _nMinKapital
        frmStatistik.nKapitalMax.Text = _nMaxKapital

        ZeichneDiagramm(frmStatistik.DiagStatistik)

        frmStatistik.ShowDialog()

    End Sub

    Private Function Gewinn() As Boolean
        For i As Integer = 0 To _nZahlen.Count - 1
            If _nZahlen(i).nZahl = _nRoulette Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function NochKapital() As Boolean
        If _nKapital <= 0 Then
            Return False
        End If

        Return True

    End Function

    Private Function ListeZahlen() As String
        Dim sHilfe As String = ""
        For i As Integer = 0 To _nZahlen.Count - 1
            sHilfe = sHilfe & _nZahlen(i).nZahl.ToString & ";"
        Next
        Return sHilfe
    End Function

    Private Function LeereZahlen(Optional ByVal Erhalten As Integer = -1) As Boolean
        If Erhalten = -1 Then
            _nZahlen.RemoveRange(0, _nZahlen.Count)
        Else
            _nZahlen.RemoveRange(0, _nZahlen.Count - Erhalten)
        End If


        Return True
    End Function

    Private Sub SchreibeStatistik(ByVal NeueZeile As Boolean, _
                                  Optional ByVal Runde As String = "", _
                                  Optional ByVal Kapital As String = "", _
                                  Optional ByVal Einsatz As String = "", _
                                  Optional ByVal Roulette As String = "", _
                                  Optional ByVal Zahlen As String = "", _
                                  Optional ByVal BenötigteRunden As String = "")

        'Neue Statistikzeile einfügen
        If NeueZeile Then
            frmStatistik.dgStatistik.Rows.Add()
        End If

        'Rundenanzahl schreiben
        If Not Runde = "" Then
            frmStatistik.dgStatistik.Rows(frmStatistik.dgStatistik.Rows.Count - 1).Cells("colRunde").Value = Runde
        End If

        'Kapital schreiben
        If Not Kapital = "" Then
            frmStatistik.dgStatistik.Rows(frmStatistik.dgStatistik.Rows.Count - 1).Cells("colKapital").Value = Kapital
        End If

        'Einsatz schreiben
        If Not Einsatz = "" Then
            frmStatistik.dgStatistik.Rows(frmStatistik.dgStatistik.Rows.Count - 1).Cells("colEinsatz").Value = Einsatz
        End If

        'Zahlen schreiben
        If Not Zahlen = "" Then
            frmStatistik.dgStatistik.Rows(frmStatistik.dgStatistik.Rows.Count - 1).Cells("colZahlen").Value = Zahlen
        End If

        'Gewinnzahl schreiben
        If Not Roulette = "" Then
            frmStatistik.dgStatistik.Rows(frmStatistik.dgStatistik.Rows.Count - 1).Cells("colRoulette").Value = Roulette
        End If

        'Benötigte Runden schreiben
        If Not BenötigteRunden = "" Then
            frmStatistik.dgStatistik.Rows(frmStatistik.dgStatistik.Rows.Count - 1).Cells("colBenötigteRunden").Value = BenötigteRunden
        End If

    End Sub

    Private Sub ZeichneDiagramm(ByVal zDiag As ZedGraphControl)
        Dim myPane As GraphPane = zDiag.GraphPane

        myPane.CurveList.RemoveRange(0, myPane.CurveList.Count)

        myPane.Title.Text = ""
        myPane.XAxis.Title.Text = "Runden"
        myPane.YAxis.Title.Text = "Kapital"

        Dim ListKapital = New PointPairList()
        Dim ListMinKapital = New PointPairList()
        Dim ListMaxKapital = New PointPairList()
        For x As Integer = 0 To frmStatistik.dgStatistik.Rows.Count - 1
            ListKapital.Add(x + 1, frmStatistik.dgStatistik.Rows(x).Cells("colKapital").Value)
            ListMinKapital.Add(x, frmStatistik.nKapitalMin.Text)
            ListMaxKapital.Add(x, frmStatistik.nKapitalMax.Text)
        Next x


        ' Generate a blue curve with circle symbols, and "My Curve 2" in the legend
        Dim CurveKapital As LineItem = myPane.AddCurve("Kapital", ListKapital, Color.Blue, SymbolType.Circle)
        Dim CurveKapitalMin As LineItem = myPane.AddCurve("", ListMinKapital, Color.Red, SymbolType.None)
        Dim CurveKapitalMax As LineItem = myPane.AddCurve("", ListMaxKapital, Color.Green, SymbolType.None)
        CurveKapital.Symbol.Fill = New Fill(Color.White)

        ' Fill the area under the curve with a white-red gradient at 45 degrees
        'CurveKapital.Line.Fill = New Fill(Color.White, Color.Red, 45.0F)
        ' Make the symbols opaque by filling them with white


        ' Fill the axis background with a color gradient
        myPane.Chart.Fill = New Fill(Color.White, Color.LightGoldenrodYellow, 45.0F)

        ' Fill the pane background with a color gradient
        myPane.Fill = New Fill(Color.White, Color.FromArgb(220, 220, 255), 45.0F)

        ' Calculate the Axis Scale Ranges
        zDiag.AxisChange()

        zDiag.Size = New Size(zDiag.ClientRectangle.Width - 20, zDiag.ClientRectangle.Height - 20)



    End Sub

End Class

