Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Windows.Forms
Imports System.Transactions

Module mdlUsingTransaction

    'Connection string to connect to Database
    Private ConnString As String = "Data Source=WINXP\SQLEXPRESS;Initial Catalog=LinqTest;User ID=LinqTest;Password=sa"

    '###Declare Database "LinqTest###"
    Public Class DBLinq
        Inherits DataContext

        Public Emp As Table(Of Emp)

        Public Sub New(ByVal Connection As String)
            MyBase.New(Connection)
        End Sub
    End Class

    <Table(Name:="emp")> _
    Public Class Emp
        Private _Id As Integer
        Private _Name As String

        <Column(Storage:="_Id", IsPrimaryKey:=True, IsDBGenerated:=True)> _
       Public ReadOnly Property Id() As Integer
            Get
                Return Me._Id
            End Get
        End Property
        <Column(Storage:="_Name")> _
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(ByVal value As String)
                Me._Name = value
            End Set
        End Property

    End Class

    Sub UsingTrans()

        Dim Db As New DBLinq(ConnString)

        Db.Log = Console.Out

        Using TS As New TransactionScope()

            Dim Query = Db.Emp.First()

            Console.WriteLine("ID= " + Query.Id.ToString + ", Name= " + Query.Name)

            If Query.Name = "VB 6" Then
                Query.Name = "XXX"
            Else
                Query.Name = "VB 6"
            End If

            Console.WriteLine("Ready to edit. Press any key..")
            Console.Read()
            Try
                Db.SubmitChanges()

                Console.WriteLine("ID= " + Query.Id.ToString + ", Name= " + Query.Name)

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.Read()
            End Try
        End Using

        Console.WriteLine("Ready to exit. Press any key..")

        Console.Read()

        MsgBox("Fertig")

    End Sub

End Module
