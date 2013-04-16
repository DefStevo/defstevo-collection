''' <summary>
''' Tape class encapsulates the concept of a VCR tape.  It
''' has the ability to record frames, and return the previous and
''' next frames.
''' </summary>
''' <remarks></remarks>
Public Class Tape
    Protected frameArray As New ArrayList()
    Private frames As New System.Collections.Generic.List(Of TapeFrame)
    ' tapePosition holds the value of the last frame fetched or added.
    Protected tapePosition As Integer = 0

    Public Sub New()
        'Start with a blank tape.
    End Sub

    Public Sub Clear()
        frames.Clear()
    End Sub

    ''' <summary>
    ''' When recording, this method is called to store frames.
    ''' </summary>
    ''' <param name="channel"></param>
    ''' <param name="frame"></param>
    ''' <remarks></remarks>
    Public Sub SaveFrame(ByVal channel As Integer, ByVal frame As Integer)
        Dim tf As New TapeFrame(channel, frame)
        If tapePosition < frameArray.Count Then
            frames(tapePosition) = tf
            tapePosition += 1
        Else
            frames.Add(tf)
            tapePosition = frames.Count - 1
        End If
    End Sub

    ''' <summary>
    ''' When playing or fast forward, this method is called to
    ''' get the next frame. Stick on the last frame.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNextFrame() As TapeFrame
        If tapePosition < frames.Count - 1 Then
            tapePosition += 1
        End If
        Return frames(tapePosition)
    End Function

    ''' <summary>
    ''' When rewinding, this method is called to get the previous frame.
    ''' Stick on 0.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPreviousFrame() As TapeFrame
        If tapePosition > 0 Then
            tapePosition -= 1
        End If
        Return frames(tapePosition)
    End Function

    ''' <summary>
    ''' Instant rewind method.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Rewind()
        tapePosition = 0
    End Sub
End Class