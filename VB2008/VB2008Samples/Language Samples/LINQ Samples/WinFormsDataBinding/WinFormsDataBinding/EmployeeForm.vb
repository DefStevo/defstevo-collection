Public Class EmployeeForm
    Private db As NorthwindDataContext
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        db = New NorthwindDataContext
        Dim employeeQuery = From employee In db.Employees _
                                Order By employee.LastName _
                                Select employee
        Dim managerQuery = From manager In db.Employees _
                            Order By manager.LastName _
                            Select manager
        'ToBindingList method converts query into a structure that supports IBindingList.
        'The Table<T> is required to convert to a binding list so that the addition and
        'deletion of entities are tracked correctly.
        employeeBindingSource.DataSource = employeeQuery
        managerBindingSource.DataSource = managerQuery.ToList()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click, btnSave.Click
        Me.Validate()
        db.SubmitChanges()
    End Sub

    Private Sub employeeDataGridView_CellParsing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles employeeDataGridView.CellParsing
        Dim s As String = e.Value.ToString()

        'OfType is needed because the employeeBindingSource returns instances of type object.
        Dim emp As Employee = (From employee In managerBindingSource.OfType(Of Employee)() _
                              Where employee.ToString() = s _
                              Select employee).FirstOrDefault()

        e.Value = emp
        e.ParsingApplied = True
    End Sub

    Private Sub btnLaunchMasterDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunchMasterDetail.Click
        Dim Form As WinFormsDataBinding.EmployeeManagerGrids = New EmployeeManagerGrids()
        Form.Visible = True
    End Sub

End Class
