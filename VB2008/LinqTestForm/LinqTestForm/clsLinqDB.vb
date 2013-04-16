Imports System.Data.Linq
Imports System.Data.Linq.Mapping

'### Declaration of Base Class for Database connection
Public Class clsDBLinqTest
    'Inherits System.Data.Linq.Mapping.DataContext for connection
    Inherits DataContext

    'Declaration of Tables Classes see below
    Public Items As Table(Of clsItems)
    Public Customers As Table(Of clsCustomers)
    Public Orders As Table(Of clsOrders)
    Public Orders_detail As Table(Of clsOrders_detail)

    'Connection to Database with ConnectionString
    'example: "Data Source=WINXP\SQLEXPRESS;Initial Catalog=LinqTest;User ID=xxx;Password=xxx"
    Public Sub New(ByVal sConnection As String)
        MyBase.New(sConnection)
    End Sub

End Class


'### Declaration of Class/Table "items" ###
<Table(Name:="items")> _
Public Class clsItems
    'Declaration of Colmumns and Properties
#Region "Variables/Columns"
    Private _Id As Integer
    <Column(Storage:="_Id", IsPrimaryKey:=True, IsDBGenerated:=True)> _
Public ReadOnly Property Id() As Integer
        Get
            Return Me._Id
        End Get
    End Property

    Private _Number As String
    <Column(Storage:="_Number")> _
    Public Property Number() As String
        Get
            Return Me._Number
        End Get
        Set(ByVal value As String)
            Me._Number = value
        End Set
    End Property

    Private _Description1 As String
    <Column(Storage:="_Description1")> _
    Public Property Description1() As String
        Get
            Return Me._Description1
        End Get
        Set(ByVal value As String)
            Me._Description1 = value
        End Set
    End Property

    Private _Description2 As String
    <Column(Storage:="_Description2")> _
    Public Property Description2() As String
        Get
            Return Me._Description2
        End Get
        Set(ByVal value As String)
            Me._Description2 = value
        End Set
    End Property

    Private _Short_description As String
    <Column(Storage:="_Short_description")> _
    Public Property Short_description() As String
        Get
            Return Me._Short_description
        End Get
        Set(ByVal value As String)
            Me._Short_description = value
        End Set
    End Property

    Private _Type As String
    <Column(Storage:="_Type")> _
    Public Property Type() As String
        Get
            Return Me._Type
        End Get
        Set(ByVal value As String)
            Me._Type = value
        End Set
    End Property

#End Region

    'Declaration of References
#Region "References"
    Private _Orders_detail As EntitySet(Of clsOrders_detail)
    <Association(Storage:="_Orders_detail", OtherKey:="Items_id")> _
    Public Property Orders_detail() As EntitySet(Of clsOrders_detail)
        Get
            Return Me._Orders_detail
        End Get
        Set(ByVal value As EntitySet(Of clsOrders_detail))
            Me._Orders_detail.Assign(value)
        End Set
    End Property

#End Region

    'Declaration of Subs/Functions
#Region "Sub"
    Public Sub New()
        'Me._Orders_detail = New EntitySet(Of clsOrders_detail)()
    End Sub

#End Region

End Class


'### Declaration of Class/Table "customers" ###
<Table(Name:="customers")> _
Public Class clsCustomers
    'Declaration of Colmumns and Properties
#Region "Variables/Columns"
    Private _Id As Integer
    <Column(Storage:="_Id", IsPrimaryKey:=True, IsDBGenerated:=True)> _
    Public ReadOnly Property Id() As Integer
        Get
            Return Me._Id
        End Get
    End Property

    Private _Number As String
    <Column(Storage:="_Number")> _
        Public Property Number() As String
        Get
            Return Me._Number
        End Get
        Set(ByVal value As String)
            Me._Number = value
        End Set
    End Property

    Private _Name1 As String
    <Column(Storage:="_Name1")> _
    Public Property Name1() As String
        Get
            Return Me._Name1
        End Get
        Set(ByVal value As String)
            Me._Name1 = value
        End Set
    End Property

    Private _Name2 As String
    <Column(Storage:="_Name2")> _
    Public Property Name2() As String
        Get
            Return Me._Name2
        End Get
        Set(ByVal value As String)
            Me._Name2 = value
        End Set
    End Property

    Private _Adress As String
    <Column(Storage:="_Adress")> _
    Public Property Adress() As String
        Get
            Return Me._Adress
        End Get
        Set(ByVal value As String)
            Me._Adress = value
        End Set
    End Property

    Private _Zip As String
    <Column(Storage:="_Zip")> _
    Public Property Zip() As String
        Get
            Return Me._Zip
        End Get
        Set(ByVal value As String)
            Me._Zip = value
        End Set
    End Property

    Private _City As String
    <Column(Storage:="_City")> _
    Public Property City() As String
        Get
            Return Me._City
        End Get
        Set(ByVal value As String)
            Me._City = value
        End Set
    End Property

    Private _Country As String
    <Column(Storage:="_Country")> _
    Public Property Country() As String
        Get
            Return Me._Country
        End Get
        Set(ByVal value As String)
            Me._Country = value
        End Set
    End Property

    Private _Country_ISO As String
    <Column(Storage:="_Country_ISO")> _
    Public Property Country_ISO() As String
        Get
            Return Me._Country_ISO
        End Get
        Set(ByVal value As String)
            Me._Country_ISO = value
        End Set
    End Property

#End Region

    'Declaration of References
#Region "References"
    Private _Orders As EntitySet(Of clsOrders)
    <Association(Storage:="_Orders", OtherKey:="Customer_id")> _
    Public Property Orders() As EntitySet(Of clsOrders)
        Get
            Return Me._Orders
        End Get
        Set(ByVal value As EntitySet(Of clsOrders))
            Me._Orders.Assign(value)
        End Set
    End Property

#End Region

    'Declaration of Subs/Functions
#Region "Sub"
    Public Sub New()
        Me._Orders = New EntitySet(Of clsOrders)()
    End Sub

#End Region

End Class


'### Declaration of Class/Table "orders" ###
<Table(Name:="orders")> _
Public Class clsOrders
    'Declaration of Colmumns and Properties
#Region "Variables/Columns"
    Private _Id As Integer
    <Column(Storage:="_Id", IsPrimaryKey:=True, IsDBGenerated:=True)> _
    Public ReadOnly Property Id() As Integer
        Get
            Return Me._Id
        End Get
    End Property

    Private _Number As String
    <Column(Storage:="_Number")> _
    Public Property Number() As String
        Get
            Return Me._Number
        End Get
        Set(ByVal value As String)
            Me._Number = value
        End Set
    End Property

    Private _oDate As Date
    <Column(Storage:="_oDate")> _
    Public Property oDate() As Date
        Get
            Return Me._oDate
        End Get
        Set(ByVal value As Date)
            Me._oDate = value
        End Set
    End Property

    Private _Customer_id As Integer
    <Column(Storage:="_Customer_id")> _
    Public Property Customer_id() As Integer
        Get
            Return Me._Customer_id
        End Get
        Set(ByVal value As Integer)
            Me._Customer_id = value
        End Set
    End Property

#End Region

    'Declaration of References
#Region "References"
    Private _Customers As EntityRef(Of clsCustomers)
    <Association(Storage:="_Customers", ThisKey:="Customer_id")> _
    Public Property Customers() As clsCustomers
        Get
            Return Me._Customers.Entity
        End Get
        Set(ByVal value As clsCustomers)
            Me._Customers.Entity = value
        End Set
    End Property

    Private _Orders_detail As EntitySet(Of clsOrders_detail)
    <Association(Storage:="_Orders_detail", OtherKey:="Orders_id")> _
    Public Property Orders_detail() As EntitySet(Of clsOrders_detail)
        Get
            Return Me._Orders_detail
        End Get
        Set(ByVal value As EntitySet(Of clsOrders_detail))
            Me._Orders_detail.Assign(value)
        End Set
    End Property

#End Region

    'Declaration of Subs/Functions
#Region "Sub"
    Public Sub New()
        Me._Customers = New EntityRef(Of clsCustomers)()
    End Sub

#End Region

End Class


    '### Declaration of Class/Table "orders_detail" ###
<Table(Name:="orders_detail")> _
Public Class clsOrders_detail
    'Declaration of Colmumns and Properties
#Region "Variables/Columns"
    Private _Orders_id As Integer
    <Column(Storage:="_Orders_id", IsPrimaryKey:=True)> _
    Public Property Orders_id() As Integer
        Get
            Return Me._Orders_id
        End Get
        Set(ByVal value As Integer)
            Me._Orders_id = value
        End Set



    End Property

    Private _Id As Integer
    <Column(Storage:="_Id", IsPrimaryKey:=True)> _
    Public Property Id() As Integer
        Get
            Return Me._Id
        End Get
        Set(ByVal value As Integer)
            Me._Id = value
        End Set
    End Property

    Private _Items_id As Integer
    <Column(Storage:="_Items_id")> _
    Public Property Items_id() As Integer
        Get
            Return Me._Items_id
        End Get
        Set(ByVal value As Integer)
            Me._Items_id = value
        End Set
    End Property

    Private _Amount As Decimal
    <Column(Storage:="_Amount")> _
    Public Property Amount() As Decimal
        Get
            Return Me._Amount
        End Get
        Set(ByVal value As Decimal)
            Me._Amount = value
        End Set
    End Property

    Private _Price As Decimal
    <Column(Storage:="_Price")> _
    Public Property Price() As Decimal
        Get
            Return Me._Price
        End Get
        Set(ByVal value As Decimal)
            Me._Price = value
        End Set
    End Property

#End Region

    'Declaration of References
#Region "References"
    Private _Items As EntityRef(Of clsItems)
    <Association(Storage:="_Items", ThisKey:="Items_id")> _
    Public Property Items() As clsItems
        Get
            Return Me._Items.Entity
        End Get
        Set(ByVal value As clsItems)
            Me._Items.Entity = value
        End Set
    End Property

    Private _Orders As EntityRef(Of clsOrders)
    <Association(Storage:="_Orders", ThisKey:="Orders_id")> _
    Public Property Orders() As clsOrders
        Get
            Return Me._Orders.Entity
        End Get
        Set(ByVal value As clsOrders)
            Me._Orders.Entity = value
        End Set
    End Property

#End Region

    'Declaration of Subs/Functions
#Region "Sub"
    Public Sub New()
        Me._Orders = New EntityRef(Of clsOrders)()
        Me._Items = New EntityRef(Of clsItems)()
    End Sub

#End Region

End Class


