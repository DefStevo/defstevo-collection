Imports System.Data.SqlServerCe

Public Class MainForm

    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CustomersTableAdapter.Fill(Me.NorthwindDataSet.Customers)
        Me.CustomersTableAdapter1.Fill(Me.CacheDataSet.Customers)
    End Sub

    Private Sub btnSynchronize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSynchronize.Click
        ' Instantiate the cache sync agent and call Synchronize()
        ' The Synchoronize method returns a SyncStatistics object
        Dim cacheAgent As New CacheSyncAgent

        Dim syncStats = cacheAgent.Synchronize()

        ' Display sync start and end times
        Me.txtBoxStartTime.Text = syncStats.SyncStartTime.ToString
        Me.txtBoxEndTime.Text = syncStats.SyncCompleteTime.ToString

        Me.txtBoxDLoaded.Text = syncStats.TotalChangesDownloaded
        Me.txtBoxApplied.Text = syncStats.DownloadChangesApplied

        Me.CustomersTableAdapter1.Fill(Me.CacheDataSet.Customers)
    End Sub
End Class
