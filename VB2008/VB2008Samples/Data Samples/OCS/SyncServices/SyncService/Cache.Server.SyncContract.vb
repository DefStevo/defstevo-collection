Imports System
Imports System.Data
Imports System.Collections.ObjectModel
Imports System.ServiceModel
Imports Microsoft.Synchronization.Data

'
'<Instructions>
'
'The class CacheSyncService is a WCF Service that implements the ICacheSyncContract interface.
'This interface must be implemented by any web service that needs to participate in data synchronization.
'
'*** TODO: ***
'To expose this service as an endpoint add the following to the services section of the app.config file
'
'      <service name="SyncService.CacheSyncService" behaviorConfiguration="SyncService.CacheSyncServiceBehavior">
'        <host>
'          <baseAddresses>
'            <add baseAddress ="http://localhost:8080/CacheSyncService/"/>
'          </baseAddresses>
'        </host>
'        <endpoint address ="" binding="wsHttpBinding" contract="SyncService.ICacheSyncContract"/>
'        <endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange" />
'      </service>
'
'and the following to the serviceBehaviors section
'
'       <behavior name="SyncService.CacheSyncServiceBehavior">
'         <serviceMetadata httpGetEnabled="True" />
'         <serviceDebug includeExceptionDetailInFaults="False" />
'       </behavior>
'
'</Instructions>
'

Partial Public Class CacheSyncService
    Inherits Object
    Implements ICacheSyncContract
    
    Private _serverSyncProvider As CacheServerSyncProvider
    
    Public Sub New()
        MyBase.New
        Me._serverSyncProvider = New CacheServerSyncProvider
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overridable Function ApplyChanges(ByVal groupMetadata As SyncGroupMetadata, ByVal dataSet As DataSet, ByVal syncSession As SyncSession) As SyncContext Implements ICacheSyncContract.ApplyChanges
        Return Me._serverSyncProvider.ApplyChanges(groupMetadata, dataSet, syncSession)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overridable Function GetChanges(ByVal groupMetadata As SyncGroupMetadata, ByVal syncSession As SyncSession) As SyncContext Implements ICacheSyncContract.GetChanges
        Return Me._serverSyncProvider.GetChanges(groupMetadata, syncSession)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overridable Function GetSchema(ByVal tableNames As Collection(Of String), ByVal syncSession As SyncSession) As SyncSchema Implements ICacheSyncContract.GetSchema
        Return Me._serverSyncProvider.GetSchema(tableNames, syncSession)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overridable Function GetServerInfo(ByVal syncSession As SyncSession) As SyncServerInfo Implements ICacheSyncContract.GetServerInfo
        Return Me._serverSyncProvider.GetServerInfo(syncSession)
    End Function
End Class

<ServiceContractAttribute()>  _
Public Interface ICacheSyncContract
    
    <OperationContract()>  _
    Function ApplyChanges(ByVal groupMetadata As SyncGroupMetadata, ByVal dataSet As DataSet, ByVal syncSession As SyncSession) As SyncContext
    
    <OperationContract()>  _
    Function GetChanges(ByVal groupMetadata As SyncGroupMetadata, ByVal syncSession As SyncSession) As SyncContext
    
    <OperationContract()>  _
    Function GetSchema(ByVal tableNames As Collection(Of String), ByVal syncSession As SyncSession) As SyncSchema
    
    <OperationContract()>  _
    Function GetServerInfo(ByVal syncSession As SyncSession) As SyncServerInfo
End Interface
