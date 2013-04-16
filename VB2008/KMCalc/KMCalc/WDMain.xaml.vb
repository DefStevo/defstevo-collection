Imports System.Text.RegularExpressions

Class Window1

    Dim oFont As Windows.Media.FontFamily = New Windows.Media.FontFamily("WingDings")
    Dim oColorOK As Windows.Media.SolidColorBrush = New Windows.Media.SolidColorBrush(Color.FromRgb(0, 255, 0))
    Dim oColorNichtOK As Windows.Media.SolidColorBrush = New Windows.Media.SolidColorBrush(Color.FromRgb(255, 0, 0))
    Dim iSize As Integer = 40
    Dim sTextOK As String = Chr(252)
    Dim sTextNichtOK As String = Chr(251)

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnCalc.Click
        'Check Inputs (NOT NULL, IS NUMERIC)
        txtEffectVar.FontFamily = oFont
        txtEffectVar.Foreground = oColorOK
        txtEffectVar.FontSize = iSize
        txtEffectVar.Text = sTextOK
        Exit Sub

        If Not Check_Input() Then
            Exit Sub
        End If


        'Start Calculation (Output as MsgBox)
        Calculate()

    End Sub

    Private Function Check_Input() As Boolean
        Dim sMessage As String = "Es wurden folgende Fehler festgestellt, bitte korrigieren Sie die Eingaben" + vbNewLine + vbNewLine
        Dim bOK As Boolean = True

        'Check IF Duration is not NULL
        If txtDuration.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Kalkulationsdauer nicht eingetragen" + vbNewLine
        Else
            'Check IF Duration is numeric
            If Not IsNumeric(txtDuration.Text) Then
                bOK = False
                sMessage = sMessage + "  - Kalkulationsdauer ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If KM is not NULL
        If txtKM.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Jährliche Kilometerleistung nicht eingetragen" + vbNewLine
        Else
            'Check IF KM is numeric
            If Not IsNumeric(txtKM.Text) Then
                bOK = False
                sMessage = sMessage + "  - Jährliche Kilometerleistung ist nicht numerisch" + vbNewLine
            End If

            If txtKM.Text = 0 Then
                bOK = False
                sMessage = sMessage + "  - Kilomerterleistung darf nicht 0 sein" + vbNewLine
            End If
        End If

        'Check If ServiceCosts is not NULL
        If txtService.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Servicekosten nicht eingetragen" + vbNewLine
        Else
            'Check IF ServiceCosts is numeric
            If Not IsNumeric(txtService.Text) Then
                bOK = False
                sMessage = sMessage + "  - Servicekosten sind nicht numerisch" + vbNewLine
            End If
        End If

        'Check If ServiceCostsDuration is not NULL
        If txtServiceDuration.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Servicekosten(Dauer) nicht eingetragen" + vbNewLine
        Else
            'Check IF ServiceCostsDuration is numeric
            If Not IsNumeric(txtServiceDuration.Text) Then
                bOK = False
                sMessage = sMessage + "  - Servicekosten(Dauer) ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If Costs for Tires is not NULL
        If txtTires.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Reifenkosten nicht eingetragen" + vbNewLine
        Else
            'Check IF Costs for Tires is numeric
            If Not IsNumeric(txtTires.Text) Then
                bOK = False
                sMessage = sMessage + "  - Reifenkosten sind nicht numerisch" + vbNewLine
            End If
        End If

        'Check If Duration for Costs of Tires is not NULL
        If txtTiresDuration.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Reifenkosten(Dauer) nicht eingetragen" + vbNewLine
        Else
            'Check IF Duration for Costs of Tires is numeric
            If Not IsNumeric(txtTiresDuration.Text) Then
                bOK = False
                sMessage = sMessage + "  - Reifenkosten(Dauer) ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If RepairCosts is not NULL
        If txtRepair.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Reparaturkosen nicht eingetragen" + vbNewLine
        Else
            'Check IF RepairCosts is numeric
            If Not IsNumeric(txtRepair.Text) Then
                bOK = False
                sMessage = sMessage + "  - Reparaturkosten sind nicht numerisch" + vbNewLine
            End If
        End If

        'Check If RepairCostsDuration is not NULL
        If txtRepairDuration.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Reparaturkosten(Dauer) nicht eingetragen" + vbNewLine
        Else
            'Check IF RepairCostsDuration is numeric
            If Not IsNumeric(txtRepairDuration.Text) Then
                bOK = False
                sMessage = sMessage + "  - Reparaturkosten(Dauer) ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If Insurance is not NULL
        If txtInsur.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Versicherungskosten sind nicht eingetragen" + vbNewLine
        Else
            'Check IF Duration is numeric
            If Not IsNumeric(txtInsur.Text) Then
                bOK = False
                sMessage = sMessage + "  - Versicherkosten sind nicht numerisch" + vbNewLine
            End If
        End If

        'Check If LeasingCosts is not NULL
        'If txtLeasing.Text = "" Then
        '    bOK = False
        '    sMessage = sMessage + "  - Leasingkosten nicht eingetragen" + vbNewLine
        'Else
        '    'Check IF LeasingCosts is numeric
        '    If Not IsNumeric(txtLeasing.Text) Then
        '        bOK = False
        '        sMessage = sMessage + "  - Leasingkosten sind nicht numerisch" + vbNewLine
        '    End If
        'End If

        'Check If Usage in City is not NULL
        If txtUsageCity.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Stadtverbrauch nicht eingetragen" + vbNewLine
        Else
            'Check IF Usage in City is numeric
            If Not IsNumeric(txtUsageCity.Text) Then
                bOK = False
                sMessage = sMessage + "  - Stadtverbrauch ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If Usage in Country is not NULL
        If txtUsageCountry.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Überlandverbrauch nicht eingetragen" + vbNewLine
        Else
            'Check IF Usage in Country is numeric
            If Not IsNumeric(txtUsageCountry.Text) Then
                bOK = False
                sMessage = sMessage + "  - Überlandverbrauch ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If Usage on Highway is not NULL
        If txtUsageHighway.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Autobahnverbrauch nicht eingetragen" + vbNewLine
        Else
            'Check IF Usage on Highway is numeric
            If Not IsNumeric(txtUsageHighway.Text) Then
                bOK = False
                sMessage = sMessage + "  - Autobahnverbrauch ist nicht numerisch" + vbNewLine
            End If
        End If

        'Check If Costs for Gas is not NULL
        If txtGas.Text = "" Then
            bOK = False
            sMessage = sMessage + "  - Benzin/Dieselkosten nicht eingetragen" + vbNewLine
        Else
            'Check IF Costs for Gas is numeric
            If Not IsNumeric(txtGas.Text) Then
                bOK = False
                sMessage = sMessage + "  - Benzin/Dieselkosten sind nicht numerisch" + vbNewLine
            End If
        End If

        If bOK = False Then
            MsgBox(sMessage, MsgBoxStyle.OkOnly, "Fehler")
        End If

        Return bOK
    End Function

    Private Function IsNumeric(ByVal TextToCheck As String) As Boolean
        Return Regex.IsMatch(TextToCheck, "\b\d+(\.\d+)?\b")
    End Function

    Private Function Calculate() As Boolean
        Dim nCostYear As Decimal = 0
        Dim nCostMonth As Decimal = 0
        Dim nCostCar As Decimal = 0
        Dim nCostGasCity As Decimal = 0
        Dim nCostGasCountry As Decimal = 0
        Dim nCostGasHighway As Decimal = 0
        Dim nCostGasAverage As Decimal = 0

        Dim nCostCity As Decimal = 0
        Dim nCostCountry As Decimal = 0
        Dim nCostHighway As Decimal = 0
        Dim nCostAverage As Decimal = 0

        Dim sMessage As String = ""

        nCostYear = ((txtService.Text / txtServiceDuration.Text) + (txtTires.Text / txtTiresDuration.Text) + (txtRepair.Text / txtRepairDuration.Text)) / txtKM.Text
        nCostMonth = (txtInsur.Text) * 12 / txtKM.Text
        'nCostCar = (txtLeasing.Text) * 12 / txtKM.Text

        nCostGasCity = txtGas.Text * txtUsageCity.Text / 100
        nCostGasCountry = txtGas.Text * txtUsageCountry.Text / 100
        nCostGasHighway = txtGas.Text * txtUsageHighway.Text / 100
        nCostGasAverage = txtGas.Text * (((txtUsageCity.Text * 1) + (txtUsageCountry.Text * 1) + (txtUsageHighway.Text * 1)) / 3) / 100

        nCostCity = nCostYear + nCostMonth + nCostCar + nCostGasCity
        nCostCountry = nCostYear + nCostMonth + nCostCar + nCostGasCountry
        nCostHighway = nCostYear + nCostMonth + nCostCar + nCostGasHighway
        nCostAverage = nCostYear + nCostMonth + nCostCar + nCostGasAverage

        sMessage = "Ergebnis der Kalkulation:" + vbNewLine + vbNewLine + _
                   " - Kosten pro KM (Stadt): " + nCostCity.ToString("0.000") + vbNewLine + _
                   " - Kosten pro KM (Überland): " + nCostCountry.ToString("0.000") + vbNewLine + _
                   " - Kosten pro KM (Autobahn): " + nCostHighway.ToString("0.000") + vbNewLine + vbNewLine + _
                   " - Durchschnittliche Kosten pro KM: " + nCostAverage.ToString("0.000")

        MsgBox(sMessage, MsgBoxStyle.Information, "Ergebnis Ihrer Kalkulation")
        Return True
    End Function

    Private Function MinimizeAllFactoring() As Boolean
        grpFactLeasing.Height = 0
        grpFactLeasing.IsEnabled = False
        Stack_Effect_FactLeasing.Height = 0

        grpFactCredit.Height = 0
        grpFactCredit.IsEnabled = False
        Stack_Effect_FactCredit.Height = 0

        grpFactBar.Height = 0
        grpFactBar.IsEnabled = False
        Stack_Effect_FactBar.Height = 0

        Return True
    End Function

    Private Sub rdLeasing_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles rdLeasing.Click
        If rdLeasing.IsChecked Then
            If MinimizeAllFactoring() Then
                grpFactLeasing.Height = Stack_FactLeasing.Height + 20
                grpFactLeasing.IsEnabled = True
                Stack_Effect_FactLeasing.Height = grpFactLeasing.Height
            End If
        End If
    End Sub

    Private Sub rdCredit_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles rdCredit.Click
        If rdCredit.IsChecked Then
            If MinimizeAllFactoring() Then
                grpFactCredit.Height = Stack_FactCredit.Height + 20
                grpFactCredit.IsEnabled = True
                Stack_Effect_FactCredit.Height = grpFactCredit.Height
            End If
        End If
    End Sub

    Private Sub rdBar_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles rdBar.Click
        If rdBar.IsChecked Then
            If MinimizeAllFactoring() Then
                grpFactBar.Height = Stack_FactBar.Height + 20
                grpFactBar.IsEnabled = True
                Stack_Effect_FactBar.Height = grpFactBar.Height
            End If
        End If
    End Sub
End Class
