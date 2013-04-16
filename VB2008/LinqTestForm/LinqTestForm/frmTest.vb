Public Class frmTest

    Private DataSource As New LinqTestDataContext

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CustomersBindingSource.DataSource = DataSource.customers

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Try
            DataSource.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Dim custQuery = _
            From cust In DataSource.customers _
            Where cust.name1 = txtName.Text _
            Select cust

        If txtName.Text = "" Then
            CustomersBindingSource.DataSource = DataSource.customers
        Else
            CustomersBindingSource.DataSource = custQuery
        End If


    End Sub
End Class