Public Class frmTST

    Private Kunde As New clsKunde

    Private Sub btnSpeichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
        With Kunde
            .Vorname = txtVorname.Text
            .Nachname = txtNachname.Text
            .Strasse = txtStrasse.Text
            .Plz = txtPLZ.Text
            .Ort = txtOrt.Text
        End With

        Dim objDatei As New System.IO.FileStream("C:\test.xml", IO.FileMode.Create)
        Dim objSerializer As System.Xml.Serialization.XmlSerializer
        objSerializer = New System.Xml.Serialization.XmlSerializer(Kunde.GetType)
        objSerializer.Serialize(objDatei, Kunde)
        objSerializer.Serialize(objDatei, Kunde)
        objDatei.Close()
    End Sub
End Class