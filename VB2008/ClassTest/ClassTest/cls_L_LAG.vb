Imports System.Data.Common
Imports System.Data.SqlClient

Public Class cls_L_LAG

    Private _dbConn = New SqlConnection(My.Settings.ConnString)
    Private _LAG_NR As String
    Private _LAG_BEZ As String

#Region "Properties"
    Public Property LAG_NR()
        Get
            Return _LAG_NR
        End Get
        Set(ByVal value)
            _LAG_NR = value
        End Set
    End Property

    Public Property LAG_BEZ()
        Get
            Return _LAG_BEZ
        End Get
        Set(ByVal value)
            _LAG_BEZ = value
        End Set
    End Property

#End Region

    Function Get_by_ID() As cls_L_LAG

        Return Nothing
    End Function

    Function Get_Next() As cls_L_LAG

        Return Nothing
    End Function




End Class
