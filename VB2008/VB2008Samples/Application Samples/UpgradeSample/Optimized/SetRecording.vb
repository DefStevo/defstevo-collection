''' <summary>
''' Form for getting user input to set the time and channel for recording.
''' 
''' </summary>
''' <remarks></remarks>
Public Class SetRecording
    Private recorderValue As Recorder
    Public Property Recorder() As Recorder
        Get
            Return recorderValue
        End Get
        Set(ByVal value As Recorder)
            recorderValue = value
        End Set
    End Property

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        ' Unload the form, releasing the reference.
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Dim isOK As Boolean 'Return value
        Dim channel As Integer 'Channel number
        Dim message As String 'Message text

        ' Call the function to validate the entry
        isOK = ValidateTime(txtStart.Text, txtStart)
        ' If it wasn't valid, bail out here
        If isOK = False Then Exit Sub

        ' Call the function to validate the entry
        isOK = ValidateTime(txtEnd.Text, txtEnd)
        ' If it wasn't valid, bail out here
        If isOK = False Then Exit Sub

        ' Read the value of the channel display.
        channel = CInt(txtChannel.Text)

        ' If out of range, warn the user.
        If channel < 2 Or channel > 13 Then
            message = "Channel must be between 2 and 13!"
            MsgBox(message, MsgBoxStyle.OKOnly, "Invalid Channel")
            txtChannel.Focus()
            Exit Sub
        End If

        ' Set the properties of the Recorder class.
        ' Make the properties uppercase for ease of comparison later.
        Recorder.StartTime = CDate(txtStart.Text)
        Recorder.StopTime = CDate(txtEnd.Text)
        recorder.Channel = channel

        ' Unload the form, releasing the reference.
        Me.Close()
    End Sub

    Private Sub frmSetTime_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        txtStart.Text = CStr(Recorder.StartTime)
        txtEnd.Text = CStr(Recorder.StopTime)
        txtChannel.Text = CStr(Recorder.Channel)
    End Sub

    Private Sub txtChannel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChannel.Enter
        ' Select the existing text.
        txtChannel.SelectAll()
    End Sub

    Private Sub txtChannel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtChannel.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        ' Use the IsNumeric function to make sure
        ' only numbers can be entered.
        If Not IsNumeric(Chr(KeyAscii)) Then
            ' Not a number, so set it to null.
            KeyAscii = 0
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtEnd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEnd.Enter
        ' Select the existing text.
        txtEnd.SelectAll()
    End Sub

    Private Sub txtEnd_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEnd.Leave
        Dim isOK As Boolean 'Return value
        ' Call the function to validate the entry
        isOK = ValidateTime(txtEnd.Text, txtEnd)
    End Sub

    Private Sub txtStart_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStart.Enter
        ' Select the existing text
        txtStart.SelectAll()
    End Sub

    Private Sub txtStart_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStart.Leave
        Dim isOK As Boolean
        ' Call the function to validate the entry
        isOK = ValidateTime(txtStart.Text, txtStart)
    End Sub

    ''' <summary>
    ''' Validates the time string entered by 
    ''' the user. If correct, it formats the
    ''' string, if not, it displays a message.
    ''' </summary>
    ''' <param name="Time">The string passed from a text box.</param>
    ''' <param name="Field">The name of the text box control.</param>
    ''' <returns>True for a valid time, False if the
    ''' string isn't a valid time.</returns>
    ''' <remarks></remarks>
    Function ValidateTime(ByRef Time As String, ByRef Field As System.Windows.Forms.TextBox) As Boolean
        Dim message As String

        ' The IsDate function verifies a valid time
        If IsDate(Time) Then
            ' Format the string and return True
            Field.Text = String.Format(Time, "h:mm AM/PM")
            ValidateTime = True
        Else
            ' Notify the user of the error
            message = "Please enter a valid time! "
            message = message & "(Hour:Minute AM/PM)"
            MsgBox(message, MsgBoxStyle.OKOnly, "Invalid Time")

            ' Return focus to the textbox
            Field.Focus()

            ' Return a value of False
            ValidateTime = False
        End If
    End Function

End Class