Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Linq
Imports System.Data.Linq

Public Class EmployeeManagerGrids
    Private db As NorthwindDataContext

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New NorthwindDataContext()
        Dim employeeQuery = From employee In db.Employees _
                            Order By employee.LastName _
                            Select employee
        'ToBindingList method converts query into a structure that supports IBindingList.
        'The Table<T> is required to convert to a binding list so that the addition and
        'deletion of entities are tracked correctly.
        employeeBindingSource.DataSource = employeeQuery
        managerBindingSource.DataSource = employeeQuery.ToList
        employeesBindingSource.DataSource = employeeBindingSource
        employeesBindingSource.DataMember = "Employees"
    End Sub

    Private Sub employeeDataGridView_CellParsing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles employeeDataGridView.CellParsing
        Dim s As String = e.Value

        Dim emp As Employee = (From employee In managerBindingSource.OfType(Of Employee)() _
                                Where employee.ToString() = s _
                                Select employee).FirstOrDefault
        e.Value = emp
        e.ParsingApplied = True
    End Sub

    Private Sub btnSubmitChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitChanges.Click
        Validate()
        db.SubmitChanges()
    End Sub
End Class