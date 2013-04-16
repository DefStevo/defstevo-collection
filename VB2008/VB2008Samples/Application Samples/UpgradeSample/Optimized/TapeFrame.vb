''' <summary>
''' Storew information about each recorded frame.
''' </summary>
''' <remarks></remarks>
Public Class TapeFrame

    Public ChannelNumber As Integer
    Public Frame As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal channel As Integer, ByVal frame As Integer)
        Me.ChannelNumber = channel
        Me.Frame = frame
    End Sub
End Class
