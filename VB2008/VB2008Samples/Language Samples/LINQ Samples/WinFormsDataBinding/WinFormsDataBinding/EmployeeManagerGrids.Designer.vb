<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeManagerGrids
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified imports the Windows Form Designer.  
    'Do not modify it imports the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeManagerGrids))
        Me.employeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.employeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeeDataGridView1 = New System.Windows.Forms.DataGridView
        Me.EmployeeID1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstName1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastName1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Extension = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Region = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.managerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employeeDataGridView = New System.Windows.Forms.DataGridView
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReportsToEmployee = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.btnSubmitChanges = New System.Windows.Forms.Button
        CType(Me.employeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.employeeBindingNavigator.SuspendLayout()
        CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.managerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employeeBindingNavigator
        '
        Me.employeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.employeeBindingNavigator.BindingSource = Me.employeeBindingSource
        Me.employeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.employeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.employeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.employeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.employeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.employeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.employeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.employeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.employeeBindingNavigator.Name = "employeeBindingNavigator"
        Me.employeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.employeeBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.employeeBindingNavigator.TabIndex = 0
        Me.employeeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'employeesBindingSource
        '
        Me.employeesBindingSource.DataSource = Me.employeeBindingSource
        '
        'employeeDataGridView1
        '
        Me.employeeDataGridView1.AllowUserToAddRows = False
        Me.employeeDataGridView1.AllowUserToDeleteRows = False
        Me.employeeDataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeeDataGridView1.AutoGenerateColumns = False
        Me.employeeDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID1, Me.FirstName1, Me.LastName1, Me.Extension, Me.Address, Me.City, Me.Region})
        Me.employeeDataGridView1.DataSource = Me.employeesBindingSource
        Me.employeeDataGridView1.Location = New System.Drawing.Point(0, 315)
        Me.employeeDataGridView1.Name = "employeeDataGridView1"
        Me.employeeDataGridView1.ReadOnly = True
        Me.employeeDataGridView1.Size = New System.Drawing.Size(804, 168)
        Me.employeeDataGridView1.TabIndex = 2
        '
        'EmployeeID1
        '
        Me.EmployeeID1.DataPropertyName = "EmployeeID"
        Me.EmployeeID1.HeaderText = "EmployeeID"
        Me.EmployeeID1.Name = "EmployeeID1"
        Me.EmployeeID1.ReadOnly = True
        '
        'FirstName1
        '
        Me.FirstName1.DataPropertyName = "FirstName"
        Me.FirstName1.HeaderText = "First Name"
        Me.FirstName1.Name = "FirstName1"
        Me.FirstName1.ReadOnly = True
        '
        'LastName1
        '
        Me.LastName1.DataPropertyName = "LastName"
        Me.LastName1.HeaderText = "Last Name"
        Me.LastName1.Name = "LastName1"
        Me.LastName1.ReadOnly = True
        '
        'Extension
        '
        Me.Extension.DataPropertyName = "Extension"
        Me.Extension.HeaderText = "Extension"
        Me.Extension.Name = "Extension"
        Me.Extension.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'City
        '
        Me.City.DataPropertyName = "City"
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        Me.City.ReadOnly = True
        '
        'Region
        '
        Me.Region.DataPropertyName = "Region"
        Me.Region.HeaderText = "Region"
        Me.Region.Name = "Region"
        Me.Region.ReadOnly = True
        '
        'employeeDataGridView
        '
        Me.employeeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeeDataGridView.AutoGenerateColumns = False
        Me.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.FirstName, Me.LastName, Me.ReportsToEmployee})
        Me.employeeDataGridView.DataSource = Me.employeeBindingSource
        Me.employeeDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.employeeDataGridView.Name = "employeeDataGridView"
        Me.employeeDataGridView.Size = New System.Drawing.Size(804, 269)
        Me.employeeDataGridView.TabIndex = 3
        '
        'EmployeeID
        '
        Me.EmployeeID.DataPropertyName = "EmployeeID"
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        '
        'ReportsToEmployee
        '
        Me.ReportsToEmployee.DataPropertyName = "ReportsToEmployee"
        Me.ReportsToEmployee.DataSource = Me.managerBindingSource
        Me.ReportsToEmployee.HeaderText = "Manager"
        Me.ReportsToEmployee.Name = "ReportsToEmployee"
        Me.ReportsToEmployee.Width = 200
        '
        'btnSubmitChanges
        '
        Me.btnSubmitChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSubmitChanges.Location = New System.Drawing.Point(317, 498)
        Me.btnSubmitChanges.Name = "btnSubmitChanges"
        Me.btnSubmitChanges.Size = New System.Drawing.Size(171, 23)
        Me.btnSubmitChanges.TabIndex = 4
        Me.btnSubmitChanges.Text = "Submit Changes"
        Me.btnSubmitChanges.UseVisualStyleBackColor = True
        '
        'EmployeeManagerGrids
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 533)
        Me.Controls.Add(Me.btnSubmitChanges)
        Me.Controls.Add(Me.employeeDataGridView)
        Me.Controls.Add(Me.employeeDataGridView1)
        Me.Controls.Add(Me.employeeBindingNavigator)
        Me.Name = "EmployeeManagerGrids"
        Me.Text = "EmployeeManagerGrids"
        CType(Me.employeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.employeeBindingNavigator.ResumeLayout(False)
        Me.employeeBindingNavigator.PerformLayout()
        CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.managerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents employeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents employeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents employeeDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents managerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Extension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Region As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportsToEmployee As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents btnSubmitChanges As System.Windows.Forms.Button
End Class
