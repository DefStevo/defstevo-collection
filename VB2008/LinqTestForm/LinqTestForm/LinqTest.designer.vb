﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:2.0.50727.4952
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="LinqTest")>  _
Partial Public Class LinqTestDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertcustomers(instance As customers)
    End Sub
  Partial Private Sub Deletecustomers(instance As customers)
    End Sub
  Partial Private Sub Insertorders(instance As orders)
    End Sub
  Partial Private Sub Updateorders(instance As orders)
    End Sub
  Partial Private Sub Deleteorders(instance As orders)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.LinqTestForm.My.MySettings.Default.LinqTestConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property customers() As System.Data.Linq.Table(Of customers)
		Get
			Return Me.GetTable(Of customers)
		End Get
	End Property
	
	Public ReadOnly Property orders() As System.Data.Linq.Table(Of orders)
		Get
			Return Me.GetTable(Of orders)
		End Get
	End Property
	
	Private Overloads Sub Updatecustomers(ByVal obj As customers)
		Dim original As customers = CType(customers.GetOriginalEntityState(obj),customers)
		Me.UpdateCustomers(obj.number, obj.name1, obj.name2, obj.adress, obj.zip, obj.city, obj.country, obj.country_ISO, CType(original.id,System.Nullable(Of Integer)))
	End Sub
	
	<FunctionAttribute(Name:="dbo.UpdateCustomers")>  _
	Public Overloads Function UpdateCustomers(<Parameter(Name:="Number", DbType:="NVarChar(50)")> ByVal number As String, <Parameter(Name:="Name1", DbType:="NVarChar(100)")> ByVal name1 As String, <Parameter(Name:="Name2", DbType:="NVarChar(100)")> ByVal name2 As String, <Parameter(Name:="Adress", DbType:="NVarChar(255)")> ByVal adress As String, <Parameter(DbType:="NVarChar(10)")> ByVal zip As String, <Parameter(DbType:="NVarChar(100)")> ByVal city As String, <Parameter(DbType:="NVarChar(50)")> ByVal country As String, <Parameter(DbType:="NVarChar(2)")> ByVal country_ISO As String, <Parameter(Name:="Original_ID", DbType:="Int")> ByVal original_ID As System.Nullable(Of Integer)) As ISingleResult(Of UpdateCustomers_Ergebnis)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), number, name1, name2, adress, zip, city, country, country_ISO, original_ID)
		Return CType(result.ReturnValue,ISingleResult(Of UpdateCustomers_Ergebnis))
	End Function
End Class

<Table(Name:="dbo.customers")>  _
Partial Public Class customers
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _number As String
	
	Private _name1 As String
	
	Private _name2 As String
	
	Private _adress As String
	
	Private _zip As String
	
	Private _city As String
	
	Private _country As String
	
	Private _country_ISO As String
	
	Private _orders As EntitySet(Of orders)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OnnumberChanging(value As String)
    End Sub
    Partial Private Sub OnnumberChanged()
    End Sub
    Partial Private Sub Onname1Changing(value As String)
    End Sub
    Partial Private Sub Onname1Changed()
    End Sub
    Partial Private Sub Onname2Changing(value As String)
    End Sub
    Partial Private Sub Onname2Changed()
    End Sub
    Partial Private Sub OnadressChanging(value As String)
    End Sub
    Partial Private Sub OnadressChanged()
    End Sub
    Partial Private Sub OnzipChanging(value As String)
    End Sub
    Partial Private Sub OnzipChanged()
    End Sub
    Partial Private Sub OncityChanging(value As String)
    End Sub
    Partial Private Sub OncityChanged()
    End Sub
    Partial Private Sub OncountryChanging(value As String)
    End Sub
    Partial Private Sub OncountryChanged()
    End Sub
    Partial Private Sub Oncountry_ISOChanging(value As String)
    End Sub
    Partial Private Sub Oncountry_ISOChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._orders = New EntitySet(Of orders)(AddressOf Me.attach_orders, AddressOf Me.detach_orders)
		OnCreated
	End Sub
	
	<Column(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_number", DbType:="NVarChar(50)")>  _
	Public Property number() As String
		Get
			Return Me._number
		End Get
		Set
			If (String.Equals(Me._number, value) = false) Then
				Me.OnnumberChanging(value)
				Me.SendPropertyChanging
				Me._number = value
				Me.SendPropertyChanged("number")
				Me.OnnumberChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_name1", DbType:="NVarChar(100)")>  _
	Public Property name1() As String
		Get
			Return Me._name1
		End Get
		Set
			If (String.Equals(Me._name1, value) = false) Then
				Me.Onname1Changing(value)
				Me.SendPropertyChanging
				Me._name1 = value
				Me.SendPropertyChanged("name1")
				Me.Onname1Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_name2", DbType:="NVarChar(100)")>  _
	Public Property name2() As String
		Get
			Return Me._name2
		End Get
		Set
			If (String.Equals(Me._name2, value) = false) Then
				Me.Onname2Changing(value)
				Me.SendPropertyChanging
				Me._name2 = value
				Me.SendPropertyChanged("name2")
				Me.Onname2Changed
			End If
		End Set
	End Property
	
	<Column(Storage:="_adress", DbType:="NVarChar(255)")>  _
	Public Property adress() As String
		Get
			Return Me._adress
		End Get
		Set
			If (String.Equals(Me._adress, value) = false) Then
				Me.OnadressChanging(value)
				Me.SendPropertyChanging
				Me._adress = value
				Me.SendPropertyChanged("adress")
				Me.OnadressChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_zip", DbType:="NVarChar(10)")>  _
	Public Property zip() As String
		Get
			Return Me._zip
		End Get
		Set
			If (String.Equals(Me._zip, value) = false) Then
				Me.OnzipChanging(value)
				Me.SendPropertyChanging
				Me._zip = value
				Me.SendPropertyChanged("zip")
				Me.OnzipChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_city", DbType:="NVarChar(100)")>  _
	Public Property city() As String
		Get
			Return Me._city
		End Get
		Set
			If (String.Equals(Me._city, value) = false) Then
				Me.OncityChanging(value)
				Me.SendPropertyChanging
				Me._city = value
				Me.SendPropertyChanged("city")
				Me.OncityChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_country", DbType:="NVarChar(50)")>  _
	Public Property country() As String
		Get
			Return Me._country
		End Get
		Set
			If (String.Equals(Me._country, value) = false) Then
				Me.OncountryChanging(value)
				Me.SendPropertyChanging
				Me._country = value
				Me.SendPropertyChanged("country")
				Me.OncountryChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_country_ISO", DbType:="NVarChar(2)")>  _
	Public Property country_ISO() As String
		Get
			Return Me._country_ISO
		End Get
		Set
			If (String.Equals(Me._country_ISO, value) = false) Then
				Me.Oncountry_ISOChanging(value)
				Me.SendPropertyChanging
				Me._country_ISO = value
				Me.SendPropertyChanged("country_ISO")
				Me.Oncountry_ISOChanged
			End If
		End Set
	End Property
	
	<Association(Name:="customers_orders", Storage:="_orders", ThisKey:="id", OtherKey:="customer_id")>  _
	Public Property orders() As EntitySet(Of orders)
		Get
			Return Me._orders
		End Get
		Set
			Me._orders.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_orders(ByVal entity As orders)
		Me.SendPropertyChanging
		entity.customers = Me
	End Sub
	
	Private Sub detach_orders(ByVal entity As orders)
		Me.SendPropertyChanging
		entity.customers = Nothing
	End Sub
End Class

<Table(Name:="dbo.orders")>  _
Partial Public Class orders
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _number As String
	
	Private _date As System.Nullable(Of Date)
	
	Private _customer_id As Integer
	
	Private _customers As EntityRef(Of customers)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OnnumberChanging(value As String)
    End Sub
    Partial Private Sub OnnumberChanged()
    End Sub
    Partial Private Sub OndateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OndateChanged()
    End Sub
    Partial Private Sub Oncustomer_idChanging(value As Integer)
    End Sub
    Partial Private Sub Oncustomer_idChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._customers = CType(Nothing, EntityRef(Of customers))
		OnCreated
	End Sub
	
	<Column(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_number", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property number() As String
		Get
			Return Me._number
		End Get
		Set
			If (String.Equals(Me._number, value) = false) Then
				Me.OnnumberChanging(value)
				Me.SendPropertyChanging
				Me._number = value
				Me.SendPropertyChanged("number")
				Me.OnnumberChanged
			End If
		End Set
	End Property
	
	<Column(Name:="date", Storage:="_date", DbType:="DateTime")>  _
	Public Property [date]() As System.Nullable(Of Date)
		Get
			Return Me._date
		End Get
		Set
			If (Me._date.Equals(value) = false) Then
				Me.OndateChanging(value)
				Me.SendPropertyChanging
				Me._date = value
				Me.SendPropertyChanged("[date]")
				Me.OndateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_customer_id", DbType:="Int NOT NULL")>  _
	Public Property customer_id() As Integer
		Get
			Return Me._customer_id
		End Get
		Set
			If ((Me._customer_id = value)  _
						= false) Then
				If Me._customers.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.Oncustomer_idChanging(value)
				Me.SendPropertyChanging
				Me._customer_id = value
				Me.SendPropertyChanged("customer_id")
				Me.Oncustomer_idChanged
			End If
		End Set
	End Property
	
	<Association(Name:="customers_orders", Storage:="_customers", ThisKey:="customer_id", OtherKey:="id", IsForeignKey:=true)>  _
	Public Property customers() As customers
		Get
			Return Me._customers.Entity
		End Get
		Set
			Dim previousValue As customers = Me._customers.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._customers.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._customers.Entity = Nothing
					previousValue.orders.Remove(Me)
				End If
				Me._customers.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.orders.Add(Me)
					Me._customer_id = value.id
				Else
					Me._customer_id = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("customers")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class UpdateCustomers_Ergebnis
	
	Private _id As Integer
	
	Private _number As String
	
	Private _name1 As String
	
	Private _name2 As String
	
	Private _adress As String
	
	Private _zip As String
	
	Private _city As String
	
	Private _country As String
	
	Private _country_ISO As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_id", DbType:="Int NOT NULL")>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me._id = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_number", DbType:="NVarChar(50)")>  _
	Public Property number() As String
		Get
			Return Me._number
		End Get
		Set
			If (String.Equals(Me._number, value) = false) Then
				Me._number = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_name1", DbType:="NVarChar(100)")>  _
	Public Property name1() As String
		Get
			Return Me._name1
		End Get
		Set
			If (String.Equals(Me._name1, value) = false) Then
				Me._name1 = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_name2", DbType:="NVarChar(100)")>  _
	Public Property name2() As String
		Get
			Return Me._name2
		End Get
		Set
			If (String.Equals(Me._name2, value) = false) Then
				Me._name2 = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_adress", DbType:="NVarChar(255)")>  _
	Public Property adress() As String
		Get
			Return Me._adress
		End Get
		Set
			If (String.Equals(Me._adress, value) = false) Then
				Me._adress = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_zip", DbType:="NVarChar(10)")>  _
	Public Property zip() As String
		Get
			Return Me._zip
		End Get
		Set
			If (String.Equals(Me._zip, value) = false) Then
				Me._zip = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_city", DbType:="NVarChar(100)")>  _
	Public Property city() As String
		Get
			Return Me._city
		End Get
		Set
			If (String.Equals(Me._city, value) = false) Then
				Me._city = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_country", DbType:="NVarChar(50)")>  _
	Public Property country() As String
		Get
			Return Me._country
		End Get
		Set
			If (String.Equals(Me._country, value) = false) Then
				Me._country = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_country_ISO", DbType:="NVarChar(2)")>  _
	Public Property country_ISO() As String
		Get
			Return Me._country_ISO
		End Get
		Set
			If (String.Equals(Me._country_ISO, value) = false) Then
				Me._country_ISO = value
			End If
		End Set
	End Property
End Class