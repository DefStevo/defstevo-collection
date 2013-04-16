Imports System.Data.Common
Imports System.Data.SqlClient

Public Class cls_S_ARLG

    Private _dbConn = New SqlConnection(My.Settings.ConnString)
    Private _LAG_NR As cls_L_LAG
    Private _ART_NR As cls_S_ART
    Private _ARLG_BESTAND As Decimal
    Private _ARLG_BEDARF As Decimal


#Region "Properties"
    Public Property LAG_NR()
        Get
            Return _LAG_NR
        End Get
        Set(ByVal value)
            _LAG_NR = value
        End Set
    End Property

    Public Property ART_NR()
        Get
            Return _ART_NR
        End Get
        Set(ByVal value)
            _ART_NR = value
        End Set
    End Property

    Public Property ARLG_BESTAND()
        Get
            Return _ARLG_BESTAND
        End Get
        Set(ByVal value)
            _ARLG_BESTAND = value
        End Set
    End Property

    Public Property ARLG_BEDARF()
        Get
            Return _ARLG_BEDARF
        End Get
        Set(ByVal value)
            _ARLG_BEDARF = value
        End Set
    End Property

#End Region

    Function Get_by_ID() As cls_S_ARLG

        Return Nothing
    End Function

    Function Get_Next() As cls_S_ARLG

        Return Nothing
    End Function




End Class
