

Partial Public Class CacheSyncAgent
    
    Private Sub OnInitialized()
        Dim proxy As New SyncServiceReference.CacheSyncContractClient
        Dim remoteProvider As New Microsoft.Synchronization.Data.ServerSyncProviderProxy(proxy)

        Me.RemoteProvider = remoteProvider
    End Sub
End Class
