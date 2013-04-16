''' <summary>
''' Acts as the logic module for the VCR to store
''' data and track recording activity.
''' </summary>
''' <remarks></remarks>
Public Class Recorder

    ''' <summary>
    ''' Channel to record.
    ''' </summary>
    ''' <remarks></remarks>
    Public Channel As Integer = 3

    ''' <summary>
    ''' Start time.
    ''' </summary>
    ''' <remarks></remarks>
    Public StartTime As Date = Date.MinValue

    ''' <summary>
    ''' End time.
    ''' </summary>
    ''' <remarks></remarks>
    Public StopTime As Date = Date.MinValue

    ''' <summary>
    ''' Recording mode.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enabled As Boolean = True

    ''' <summary>
    ''' True if StartTime and EndTime are valid.
    ''' </summary>
    ''' <remarks></remarks>
    Public IsSet As Boolean = False

    Public Sub New()
        MyBase.New()

    End Sub
End Class
