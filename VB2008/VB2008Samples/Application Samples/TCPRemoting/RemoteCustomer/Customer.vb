Public Class Customer : Inherits MarshalByRefObject

    'Private fields for storage of property values of customer
    Private ageValue As Byte = 0
    Private nameValue As String = "<<Uninitialized>>"

    ' Private field to store time object instance was created.
    Private ReadOnly mdteCreationTime As DateTime = Date.Now

    'Default no argument constructor
    Public Sub New()
        MyBase.New()
    End Sub

    'Parameterized Constructor called only by Client Activated Objects
    Public Sub New(ByVal NewName As String, ByVal NewAge As Byte)
        Me.Name = NewName
        Me.Age = NewAge
    End Sub

    'Property implementation for Age
    Public Property Age() As Byte
        Get
            Return ageValue
        End Get

        Set(ByVal Value As Byte)
            If Value > 0 Then
                ageValue = Value
            Else
                ageValue = 0
            End If
        End Set
    End Property

    'Property implementation for Name
    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal Value As String)
            nameValue = Value
        End Set
    End Property

    'Return Customer Name and Age as a string
    Public Function GetCustomerInfo() As String
        Return String.Format("Customer Name is {0}. Customer Age is {1}", Me.Name, Me.Age)
    End Function

    ' Accept changes to the Name & Age and return the values as a string
    Public Function UpdateCustomerInfo(ByVal NewName As String, ByVal NewAge As Byte) As String
        ' Update local properties
        Me.Name = NewName
        Me.Age = NewAge

        ' Do some work here like update a database (an exercise for the reader).

        Return String.Format("Customer Name is {0}. Customer Age is {1}", Me.Name, Me.Age)
    End Function

    ' The following properties are for getting information about the component
    ' for testing purposes only. Some information is retrieved using the
    ' AssemblyInfo class (defined in the AssemblyInfo.vb file).
    ' All the members are decorated with the Debug keyword to designate their
    ' testing status and to make them easy to find in IntelliSense.

    ' The CodeBase will return the physical path from which the 
    ' component is running.
    Public ReadOnly Property DebugCodeBase() As String
        Get
            Dim myType As Type = GetType(Customer)
            Return myType.Assembly.CodeBase
        End Get
    End Property

    ' Returns the assembly's fully qualified name
    Public ReadOnly Property DebugFQName() As String
        Get
            Dim myType As Type = GetType(Customer)
            Return myType.Assembly.GetName.FullName.ToString()
        End Get
    End Property

    ' Returns the date & time the current object instance was created.
    Public ReadOnly Property DebugCreationTime() As DateTime
        Get
            Return mdteCreationTime
        End Get
    End Property

    ' Returns the name of the machine that the object is running on.
    Public ReadOnly Property DebugHostName() As String
        Get
            Return System.Environment.MachineName
        End Get
    End Property
End Class
