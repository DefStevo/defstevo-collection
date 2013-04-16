Imports System.Data.Common
Imports System.Data.SqlClient

Public Class cls_S_ART

    Private _dbConn As SqlConnection
    Private _ART_NR As String
    Private _ART_KBEZ As String
    Private _ART_BEZ As String
    Private _ART_STATUS As Integer
    Private _ART_KZLAGER As Integer
    Private _ART_KZVK As Integer
    Private _ART_KZEK As Integer

    Private _ConnStatus As Boolean

#Region "Properties"
    Public Property ART_NR()
        Get
            Return _ART_NR
        End Get
        Set(ByVal value)
            _ART_NR = value
        End Set
    End Property

    Public Property ART_KBEZ()
        Get
            Return _ART_KBEZ
        End Get
        Set(ByVal value)
            _ART_KBEZ = value
        End Set
    End Property

    Public Property ART_BEZ()
        Get
            Return _ART_BEZ
        End Get
        Set(ByVal value)
            _ART_BEZ = value
        End Set
    End Property

    Public Property ART_STATUS()
        Get
            Return _ART_STATUS
        End Get
        Set(ByVal value)
            _ART_STATUS = value
        End Set
    End Property

    Public Property ART_KZLAGER()
        Get
            Return _ART_KZLAGER
        End Get
        Set(ByVal value)
            _ART_KZLAGER = value
        End Set
    End Property

    Public Property ART_KZVK()
        Get
            Return _ART_KZVK
        End Get
        Set(ByVal value)
            _ART_KZVK = value
        End Set
    End Property

    Public Property ART_KZEK()
        Get
            Return _ART_KZEK
        End Get
        Set(ByVal value)
            _ART_KZEK = value
        End Set
    End Property

#End Region

    Private Function ConnectDB() As Boolean
        Dim _dbState As ConnectionState
        _dbConn = New SqlConnection(My.Settings.ConnString)
        _dbConn.Open()

        _dbState = _dbConn.State

        If _dbState = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Get_by_ID(ByVal ID As String) As cls_S_ART

        If _ConnStatus = False Then
            ConnectDB()
        End If



        Return Nothing
    End Function

    Public Function Get_Next() As cls_S_ART

        Return Nothing
    End Function




End Class
