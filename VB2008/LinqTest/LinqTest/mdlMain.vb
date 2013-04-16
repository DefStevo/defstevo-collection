Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Windows.Forms


Module mdlMain
    'Connection string to connect to Database
    Private ConnString As String = "Data Source=WINXP\SQLEXPRESS;Initial Catalog=LinqTest;User ID=LinqTest;Password=sa"

    'Connect to Database Northwind using a connection string
    Private DbNw As New DataContext(ConnString)

    '###Declare Database "LinqTest###"
    Public Class Northwind
        Inherits DataContext

        Public Customers As Table(Of Customer)
        Public Orders As Table(Of Orders)

        Public Sub New(ByVal Connection As String)
            MyBase.New(Connection)
        End Sub
    End Class

    '###Declare Table "customers###"
    <Table(Name:="customers")> _
    Public Class Customer
        'Declare Variables and Entity
#Region "Declaration"
#Region "Variables"
        Private _Id As Integer
        Private _Number As String
        Private _Name1 As String
        Private _Name2 As String
        Private _Adress As String
        Private _Zip As String
        Private _City As String
        Private _Country As String
        Private _Country_ISO As String
#End Region

#Region "Entity"
        Private _Orders As EntitySet(Of Orders)
#End Region
#End Region

#Region "Column and Property"
        <Column(Storage:="_Id", IsPrimaryKey:=True, IsDBGenerated:=True)> _
        Public ReadOnly Property Id() As Integer
            Get
                Return Me._Id
            End Get
        End Property
        <Column(Storage:="_Number")> _
        Public Property Number() As String
            Get
                Return Me._Number
            End Get
            Set(ByVal value As String)
                Me._Number = value
            End Set
        End Property
        <Column(Storage:="_Name1")> _
        Public Property Name1() As String
            Get
                Return Me._Name1
            End Get
            Set(ByVal value As String)
                Me._Name1 = value
            End Set
        End Property
        <Column(Storage:="_Name2")> _
        Public Property Name2() As String
            Get
                Return Me._Name2
            End Get
            Set(ByVal value As String)
                Me._Name2 = value
            End Set
        End Property
        <Column(Storage:="_Adress")> _
        Public Property Adress() As String
            Get
                Return Me._Adress
            End Get
            Set(ByVal value As String)
                Me._Adress = value
            End Set
        End Property
        <Column(Storage:="_Zip")> _
        Public Property Zip() As String
            Get
                Return Me._Zip
            End Get
            Set(ByVal value As String)
                Me._Zip = value
            End Set
        End Property
        <Column(Storage:="_City")> _
        Public Property City() As String
            Get
                Return Me._City
            End Get
            Set(ByVal value As String)
                Me._City = value
            End Set
        End Property
        <Column(Storage:="_Country")> _
        Public Property Country() As String
            Get
                Return Me._Country
            End Get
            Set(ByVal value As String)
                Me._Country = value
            End Set
        End Property
        <Column(Storage:="_Country_ISO")> _
        Public Property Country_ISO() As String
            Get
                Return Me._Country_ISO
            End Get
            Set(ByVal value As String)
                Me._Country_ISO = value
            End Set
        End Property
        'Reference to Order
        <Association(Storage:="_Orders", OtherKey:="Customer_id")> _
        Public Property Orders() As EntitySet(Of Orders)
            Get
                Return Me._Orders
            End Get
            Set(ByVal value As EntitySet(Of Orders))
                Me._Orders.Assign(value)
            End Set
        End Property
#End Region

#Region "Sub"
        Public Sub New()
            Me._Orders = New EntitySet(Of Orders)()
        End Sub
#End Region
    End Class

    '###Declare Tabel "orders###"
    <Table(Name:="orders")> _
    Public Class Orders
        'Declare variables and Entity
#Region "Declaration"
#Region "Variables"
        Private _Id As Integer
        Private _Number As String
        Private _oDate As Date
        Private _Customer_id As Integer
#End Region

#Region "Entity"
        Private _Customers As EntityRef(Of Customer)
#End Region
#End Region

#Region "Column and Property"
        <Column(Storage:="_Id", IsPrimaryKey:=True, IsDBGenerated:=True)> _
      Public ReadOnly Property Id() As Integer
            Get
                Return Me._Id
            End Get
        End Property
        <Column(Storage:="_Number")> _
        Public Property Number() As String
            Get
                Return Me._Number
            End Get
            Set(ByVal value As String)
                Me._Number = value
            End Set
        End Property
        <Column(Storage:="_oDate")> _
        Public Property oDate() As Date
            Get
                Return Me._oDate
            End Get
            Set(ByVal value As Date)
                Me._oDate = value
            End Set
        End Property
        <Column(Storage:="_Customer_id")> _
        Public Property Customer_id() As Integer
            Get
                Return Me._Customer_id
            End Get
            Set(ByVal value As Integer)
                Me._Customer_id = value
            End Set
        End Property
        'Reference to Customer
        <Association(Storage:="_Customers", ThisKey:="Customer_id")> _
        Public Property Customers() As Customer
            Get
                Return Me._Customers.Entity
            End Get
            Set(ByVal value As Customer)
                Me._Customers.Entity = value
            End Set
        End Property
#End Region

#Region "Sub"
        Public Sub New()
            Me._Customers = New EntityRef(Of Customer)()
        End Sub
#End Region

    End Class

    Sub Main()
        'OnlyCustomer()
        'CustomerWithNoOrder()
        'DBConnection()
        'CreateCustomer()
        'ChangeCustomer()
        'DeleteCustomer()
        mdlUsingTransaction.UsingTrans()
    End Sub

    Sub OnlyCustomer()
        'Wrtie "Hello World" in Console
        Console.WriteLine("Hello World - Only Customer")

        'Get a typed table to run queries.
        Dim Customers As Table(Of Customer) = _
            DbNw.GetTable(Of Customer)()

        'Attach the log to show generated SQL in a console window
        DbNw.Log = Console.Out

        'Define query to select customer "20002" from Database
        Dim custQuery = _
                From cust In Customers _
                Where cust.Number = "20002" _
                Select cust.Id, cust.Number, cust.Name1

        'Format a Message box
        Dim msg As String = ""
        Dim title As String = "Customers:"
        Dim response As MsgBoxResult
        Dim style As MsgBoxStyle = MsgBoxStyle.Information

        'Execute the query
        For Each custObj In custQuery
            msg &= String.Format(custObj.Id & "|" & custObj.Number & "|" & custObj.Name1 & vbCrLf)
        Next

        'Display the result as Message box
        response = MsgBox(msg, style, title)

    End Sub

    Sub CustomerWithNoOrder()
        'Wrtie "Hello World" in Console
        Console.WriteLine("Hello World - Customer with no order")

        'Get a typed table "Cusomter" to run query
        Dim Customers As Table(Of Customer) = _
            DbNw.GetTable(Of Customer)()

        'Get a typed table "Orders" to run query
        Dim Orders As Table(Of Orders) = _
            DbNw.GetTable(Of Orders)()

        'Attach the log to show generated SQL in a console window
        DbNw.Log = Console.Out

        'Define query to select customer with no order from Database
        Dim custQuery = _
                From cust In Customers _
                Where Not cust.Orders.Any() _
                Select cust.Id, cust.Number, cust.Name1

        'Format a Message box
        Dim msg As String = ""
        Dim title As String = "Customers:"
        Dim response As MsgBoxResult
        Dim style As MsgBoxStyle = MsgBoxStyle.Information

        'Execute the query
        For Each custObj In custQuery
            msg &= String.Format(custObj.Id & "|" & custObj.Number & "|" & custObj.Name1 & vbCrLf)
        Next

        'Display the result as Message box
        response = MsgBox(msg, style, title)

    End Sub

    Sub DBConnection()
        'Wrtie "Hello World" in Console
        Console.WriteLine("Hello World - DB Connection")

        'Database Connection
        Dim db As New Northwind(ConnString)

        'Define query to select customer with specified adress from Database
        Dim custQuery = _
            From cust In db.Customers _
            Where cust.Adress = "Erzherzog Eugenstraße 23" _
            Select cust

        'Write Id and Name in Console
        For Each custObj In custQuery
            Console.WriteLine("ID=" & custObj.Id & "; Name=" & custObj.Name1)
        Next

        'Freeze the console window
        Console.ReadLine()

    End Sub

    Sub CreateCustomer()
        'Wrtie "Hello World" in Console
        Console.WriteLine("Hello World - Create Customer")

        'Database Connection
        Dim db As New Northwind(ConnString)

        'Attach the log to show generated SQL in a console window
        db.Log = Console.Out

        Console.WriteLine("All customers before insert:")

        'Define query to select all customer from Database
        Dim custQuery = _
            From cust In db.Customers _
            Select cust

        For Each custObj In custQuery
            Console.WriteLine("ID=" & custObj.Id & "; Name=" & custObj.Name1 & "; Adress=" & custObj.Adress)
        Next

        'Create New Customer
        Dim newCust As New Customer()
        With newCust
            .Number = "20004"
            .Name1 = "Inge Dehner"
            .Adress = "Karl Heinrich Waggerlstraße 15"
            .Zip = "5020"
            .City = "Salzburg"
            .Country = "Austria"
            .Country_ISO = "AT"
        End With

        Console.WriteLine("!Add Adress")

        'Add the customer to Database
        db.Customers.InsertOnSubmit(newCust)

        'Submit Changes to Database
        db.SubmitChanges()

        'Freeze the console window
        Console.ReadLine()

    End Sub

    Sub ChangeCustomer()
        'Write "Hello World" in Console
        Console.WriteLine("Hello World - Change Customer Adress")

        'Database Connection
        Dim db As New Northwind(ConnString)

        'Attach the log to show generated SQL in a console window
        db.Log = Console.Out

        'Define query to select all customer from Database
        Dim custQuery = _
            From cust In db.Customers _
            Select cust

        For Each custObj In custQuery
            Console.WriteLine("ID=" & custObj.Id & "; Name=" & custObj.Name1 & "; Adress=" & custObj.Adress)
            If custObj.Name1 = "Inge Dehner" Then
                Console.WriteLine("!Change Adress")
                custObj.Adress = "K.H.Waggerlstraße 15"
            End If
        Next

        'Submit Changes to Database
        db.SubmitChanges()

        'Freeze the console window
        Console.ReadLine()

    End Sub

    Sub DeleteCustomer()
        'Write "Hello World" in Console
        Console.WriteLine("Hello World - Delete Customer")

        'Database Connection
        Dim db As New Northwind(ConnString)

        'Attach the log to show generated SQL in a console window
        db.Log = Console.Out

        'Define query to select all customer from Database
        Dim custQuery = _
            From cust In db.Customers _
            Select cust

        For Each custObj In custQuery
            Console.WriteLine("ID=" & custObj.Id & "; Name=" & custObj.Name1 & "; Adress=" & custObj.Adress)
            If custObj.Name1 = "Inge Dehner" Then
                Console.WriteLine("!Delete Adress")
                db.Customers.DeleteOnSubmit(custObj)
            End If
        Next

        'Submit Changes to Database
        db.SubmitChanges()

        'Freeze the console window
        Console.ReadLine()

    End Sub

End Module
