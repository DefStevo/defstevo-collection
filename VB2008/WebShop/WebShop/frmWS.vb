Public Class frmWS
    Private Sub btnDatei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatei.Click
        BrowseDialog.ShowDialog()
        txtDatei.Text = BrowseDialog.FileName.ToString
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim sPage As String = ""

        If Not txtDatei.Text = "" And Not txtPage.Text = "" Then
            Select Case txtPage.Text
                Case "Währungen"
                    sPage = "a_shop_currency"
                Case "Artikel Detail"
                    sPage = "a_shop_item_DT"
                Case "Kunden"
                    sPage = "a_customer"
                Case "Artikel Großhandel"
                    sPage = "a_shop_item_GH"
                Case "Preislisten"
                    sPage = "a_shop_pricelist"
                Case "Regionen"
                    sPage = "a_shop_region"
            End Select

            If txtWiederholung.Text = "" Then
                txtWiederholung.Text = "0"
            End If

            MsgBox(UploadWS(txtDatei.Text, sPage, Val(txtWiederholung.Text)))

            If mdlMain.nError = 1 Then
                SentMail()
            End If

            Me.Close()
        End If

    End Sub

    Private Sub frmWS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub
End Class

