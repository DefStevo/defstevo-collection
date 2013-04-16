Public Class Channel

    Public Sub New(ByVal number As Integer, ByVal rate As Integer, ByVal file As String)
        Me.Number = number
        Me.RefreshRate = rate
        Me.Image = System.Drawing.Image.FromFile(file)
    End Sub

    Private numberValue As Integer
    Public Property Number() As Integer
        Get
            Return numberValue
        End Get
        Set(ByVal value As Integer)
            numberValue = value
        End Set
    End Property

    Private rateValue As Integer
    Public Property RefreshRate() As Integer
        Get
            Return rateValue
        End Get
        Set(ByVal value As Integer)
            rateValue = value
        End Set
    End Property

    Private imageValue As Image
    Public Property Image() As Image
        Get
            Return imageValue
        End Get
        Set(ByVal value As Image)
            imageValue = value
        End Set
    End Property

    Public ReadOnly Property FrameCount() As Integer
        Get
            Dim frameDim As New System.Drawing.Imaging.FrameDimension(imageValue.FrameDimensionsList(0))
            Return imageValue.GetFrameCount(frameDim)
        End Get
    End Property

    Private currentFrameValue As Integer = 0
    Public Property CurrentFrame() As Integer
        Get
            Return currentFrameValue
        End Get
        Set(ByVal value As Integer)
            currentFrameValue = value
        End Set
    End Property
End Class
