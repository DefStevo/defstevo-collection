Imports LinqTestForm.clsDBLinqTest

Public Class frmMain
    'Private Const
    Const sNull As String = Nothing
    Const nNull As String = Nothing

    'Connectiion String
    Private sConnString As String = "Data Source=WINXP\SQLEXPRESS;Initial Catalog=LinqTest;User ID=LinqTest;Password=sa"

    'Local Variable for Database connection
    Private dbLinq As New clsDBLinqTest(sConnString)

    'Local Variable Boolean (EditMode)
    Private bEditCustomer As Boolean


#Region "Customers"
    Private Sub TabFrmMain_Customers_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabFrmMain_Customers.Enter
        'Tab get Focus

        'Select Customers from database
        Dim qCustomers = _
            From cust In dbLinq.Customers _
            Select cust.Id, cust.Number, cust.Name1, cust.Name2, cust.Adress, cust.Zip, cust.City, cust.Country

        'Fill Datagrid-View
        dgCustomers.DataSource = qCustomers

    End Sub

    Private Sub dgCustomers_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgCustomers.RowHeaderMouseDoubleClick
        Dim qCustomers = _
            (From cust In dbLinq.Customers _
            Where cust.Id = dgCustomers.SelectedRows.Item(0).Cells(0).Value.ToString _
            Select cust).First()

        txtID.Text = qCustomers.Id
        txtNumber.Text = qCustomers.Number
        txtName1.Text = qCustomers.Name1
        txtName2.Text = qCustomers.Name2
        txtAdress.Text = qCustomers.Adress
        txtZip.Text = qCustomers.Zip
        txtCity.Text = qCustomers.City
        txtCountry.Text = qCustomers.Country
        txtCountry_ISO.Text = qCustomers.Country_ISO

    End Sub

#End Region

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtID.Text = sNull
        txtNumber.Text = sNull
        txtName1.Text = sNull
        txtName2.Text = sNull
        txtAdress.Text = sNull
        txtZip.Text = sNull
        txtCity.Text = sNull
        txtCountry.Text = sNull
        txtCountry_ISO.Text = sNull
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtID.Text = sNull Then
            'Insert
            Dim newCustomer As New clsCustomers

            With newCustomer
                .Number = txtNumber.Text
                .Name1 = txtName1.Text
                .Name2 = txtName2.Text
                .Adress = txtAdress.Text
                .Zip = txtZip.Text
                .City = txtCity.Text
                .Country = txtCountry.Text
                .Country_ISO = txtCountry_ISO.Text
            End With

            dbLinq.Customers.InsertOnSubmit(newCustomer)

            dbLinq.SubmitChanges()

            TabFrmMain_Customers_Enter(sender, e)
            btnNew_Click(sender, e)

        Else
            'Update
            Dim custQuery = _
                From cust In dbLinq.Customers _
                Where cust.Id = txtID.Text _
                Select cust

            For Each custObj In custQuery
                With custObj
                    .Number = txtNumber.Text
                    .Name1 = txtName1.Text
                    .Name2 = txtName2.Text
                    .Adress = txtAdress.Text
                    .Zip = txtZip.Text
                    .City = txtCity.Text
                    .Country = txtCountry.Text
                    .Country_ISO = txtCountry_ISO.Text
                End With
            Next

        End If

        dbLinq.SubmitChanges()

        TabFrmMain_Customers_Enter(sender, e)
        btnNew_Click(sender, e)

    End Sub
End Class
