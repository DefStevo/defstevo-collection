<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabFrmMain = New System.Windows.Forms.TabControl
        Me.TabFrmMain_Customers = New System.Windows.Forms.TabPage
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupCustomers = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCountry_ISO = New System.Windows.Forms.TextBox
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtAdress = New System.Windows.Forms.TextBox
        Me.txtName2 = New System.Windows.Forms.TextBox
        Me.txtName1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgCustomers = New System.Windows.Forms.DataGridView
        Me.TabFrmMain_Items = New System.Windows.Forms.TabPage
        Me.TabFrmMain.SuspendLayout()
        Me.TabFrmMain_Customers.SuspendLayout()
        Me.GroupCustomers.SuspendLayout()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabFrmMain
        '
        Me.TabFrmMain.Controls.Add(Me.TabFrmMain_Customers)
        Me.TabFrmMain.Controls.Add(Me.TabFrmMain_Items)
        Me.TabFrmMain.Location = New System.Drawing.Point(2, 3)
        Me.TabFrmMain.Name = "TabFrmMain"
        Me.TabFrmMain.SelectedIndex = 0
        Me.TabFrmMain.Size = New System.Drawing.Size(780, 384)
        Me.TabFrmMain.TabIndex = 1
        '
        'TabFrmMain_Customers
        '
        Me.TabFrmMain_Customers.Controls.Add(Me.btnDelete)
        Me.TabFrmMain_Customers.Controls.Add(Me.btnSave)
        Me.TabFrmMain_Customers.Controls.Add(Me.btnNew)
        Me.TabFrmMain_Customers.Controls.Add(Me.GroupCustomers)
        Me.TabFrmMain_Customers.Controls.Add(Me.dgCustomers)
        Me.TabFrmMain_Customers.Location = New System.Drawing.Point(4, 22)
        Me.TabFrmMain_Customers.Name = "TabFrmMain_Customers"
        Me.TabFrmMain_Customers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFrmMain_Customers.Size = New System.Drawing.Size(772, 358)
        Me.TabFrmMain_Customers.TabIndex = 0
        Me.TabFrmMain_Customers.Text = "Customers"
        Me.TabFrmMain_Customers.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(606, 83)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(157, 30)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(606, 47)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 30)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(606, 11)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(157, 30)
        Me.btnNew.TabIndex = 21
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupCustomers
        '
        Me.GroupCustomers.Controls.Add(Me.Label9)
        Me.GroupCustomers.Controls.Add(Me.Label8)
        Me.GroupCustomers.Controls.Add(Me.Label7)
        Me.GroupCustomers.Controls.Add(Me.Label6)
        Me.GroupCustomers.Controls.Add(Me.Label5)
        Me.GroupCustomers.Controls.Add(Me.Label4)
        Me.GroupCustomers.Controls.Add(Me.Label3)
        Me.GroupCustomers.Controls.Add(Me.txtCountry_ISO)
        Me.GroupCustomers.Controls.Add(Me.txtCountry)
        Me.GroupCustomers.Controls.Add(Me.txtCity)
        Me.GroupCustomers.Controls.Add(Me.txtZip)
        Me.GroupCustomers.Controls.Add(Me.txtAdress)
        Me.GroupCustomers.Controls.Add(Me.txtName2)
        Me.GroupCustomers.Controls.Add(Me.txtName1)
        Me.GroupCustomers.Controls.Add(Me.Label2)
        Me.GroupCustomers.Controls.Add(Me.txtNumber)
        Me.GroupCustomers.Controls.Add(Me.txtID)
        Me.GroupCustomers.Controls.Add(Me.Label1)
        Me.GroupCustomers.Location = New System.Drawing.Point(6, 6)
        Me.GroupCustomers.Name = "GroupCustomers"
        Me.GroupCustomers.Size = New System.Drawing.Size(594, 163)
        Me.GroupCustomers.TabIndex = 20
        Me.GroupCustomers.TabStop = False
        Me.GroupCustomers.Text = "Main Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(513, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "ISO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Country"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Zip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Name2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Name1"
        '
        'txtCountry_ISO
        '
        Me.txtCountry_ISO.Location = New System.Drawing.Point(544, 123)
        Me.txtCountry_ISO.Name = "txtCountry_ISO"
        Me.txtCountry_ISO.Size = New System.Drawing.Size(34, 20)
        Me.txtCountry_ISO.TabIndex = 22
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(398, 123)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(109, 20)
        Me.txtCountry.TabIndex = 21
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(159, 123)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(184, 20)
        Me.txtCity.TabIndex = 20
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(56, 123)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(67, 20)
        Me.txtZip.TabIndex = 19
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(56, 97)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(522, 20)
        Me.txtAdress.TabIndex = 18
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(56, 71)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(522, 20)
        Me.txtName2.TabIndex = 17
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(56, 45)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(522, 20)
        Me.txtName1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Number"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(56, 19)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(96, 20)
        Me.txtNumber.TabIndex = 13
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(478, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(456, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Id"
        '
        'dgCustomers
        '
        Me.dgCustomers.AllowUserToAddRows = False
        Me.dgCustomers.AllowUserToDeleteRows = False
        Me.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomers.Location = New System.Drawing.Point(3, 175)
        Me.dgCustomers.Name = "dgCustomers"
        Me.dgCustomers.ReadOnly = True
        Me.dgCustomers.Size = New System.Drawing.Size(760, 175)
        Me.dgCustomers.TabIndex = 1
        '
        'TabFrmMain_Items
        '
        Me.TabFrmMain_Items.Location = New System.Drawing.Point(4, 22)
        Me.TabFrmMain_Items.Name = "TabFrmMain_Items"
        Me.TabFrmMain_Items.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFrmMain_Items.Size = New System.Drawing.Size(772, 358)
        Me.TabFrmMain_Items.TabIndex = 1
        Me.TabFrmMain_Items.Text = "Items"
        Me.TabFrmMain_Items.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 389)
        Me.Controls.Add(Me.TabFrmMain)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.TabFrmMain.ResumeLayout(False)
        Me.TabFrmMain_Customers.ResumeLayout(False)
        Me.GroupCustomers.ResumeLayout(False)
        Me.GroupCustomers.PerformLayout()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabFrmMain As System.Windows.Forms.TabControl
    Friend WithEvents TabFrmMain_Customers As System.Windows.Forms.TabPage
    Friend WithEvents TabFrmMain_Items As System.Windows.Forms.TabPage
    Friend WithEvents dgCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents GroupCustomers As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCountry_ISO As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button

End Class
