'Needs System.IO because we are loading in the channel images.
Imports System.IO

'Needs Imaging to manually cycle through the frames of an animated .gif
Imports System.Drawing.Imaging

''' <summary>
''' Main form for the VCR sample
''' application. Emulates a video cassette
''' recorder using Visual Basic objects.
''' </summary>
''' <remarks></remarks>
Public Class VCRScreen

    Private Enum PlayState
        Record
        Play
        FastForward
        Rewind
        Pause
        Stopped
        TV
    End Enum

    ' Track when we're recording or the channel has changed, so we can redraw 
    ' info in the PictureBox after the form loses and regains focus.
    Private playingState As PlayState = PlayState.TV
    Private isChannelChanged As Boolean = True
    Private channels As New System.Collections.Generic.Dictionary(Of Integer, Channel)

    Dim channelBitmap As Image
    Dim currentFrame As New Hashtable()
    Dim currentFrameCount As Integer
    Dim lastChannelLoaded As Integer
    Dim tvChannel As Channel

    Dim recorder As New Recorder
    'You can control the frame rate on animated gif images.
    'channelRate is milliseconds between frames for each channel.
    Dim channelRate() As Integer = {0, 0, 1400, 1400, 1400, 1400}

    'Tape class records what's on the screen.
    Dim tape As New Tape()

    'Dim currentChannel As Integer = 3

#Region "Channel Up and Down"
    Private Sub cmdDown_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDown.Click
        ' Valid range is 2 through 5.
        If tvChannel.Number = 2 Then
            tvChannel = channels(5)
        Else
            tvChannel = channels(tvChannel.Number - 1)
        End If

        ' assign the channel variable to the display
        lblChannel.Text = CStr(tvChannel.Number)
        channelBitmap = tvChannel.Image

        ' Set the channel-changed flag.
        isChannelChanged = True

    End Sub

    Private Sub cmdUp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUp.Click
        ' Valid range is 2 through 5.
        If tvChannel.Number = 5 Then
            tvChannel = channels(2)
        Else
            tvChannel = channels(tvChannel.Number + 1)
        End If

        ' assign the channel variable to the display
        lblChannel.Text = CStr(tvChannel.Number)
        channelBitmap = tvChannel.Image

        ' Set the channel-changed flag.
        isChannelChanged = True
    End Sub
#End Region

#Region "Load and Exit"
    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmVCR_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' Load the channels.
        Dim fullpath As String = Path.GetFullPath(Application.StartupPath & "\..\..\images\")
        Dim imageFile As String = ""
        Dim newChannel As Channel
        For index As Integer = 2 To 5
            imageFile = fullpath & "Channel_" & index & ".gif"
            newChannel = New Channel(index, channelRate(index), imageFile)
            channels.Add(index, newChannel)
        Next

        tvChannel = channels(2)
        channelBitmap = tvChannel.Image

        ' Show the current time
        lblTime.Text = Format(Now, "h:mm tt")
        lblChannel.Text = CStr(tvChannel.Number)

        Me.ButtonManager(PlayState.TV)
    End Sub
#End Region

#Region "VCR - Play, Rewind, FastForward, Record, Pause, Stop"
    Private Sub cmdForward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdForward.Click
        ' must be on channel 3 to play a tape
        tvChannel = channels(3)
        isChannelChanged = True

        lblChannel.Text = CStr(tvChannel.Number)

        ButtonManager(PlayState.FastForward)
        isChannelChanged = False
        playingState = PlayState.FastForward
    End Sub


    Private Sub cmdPause_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPause.Click
        ' Call the function to update the controls
        ButtonManager(PlayState.Pause)
        isChannelChanged = False
        playingState = PlayState.Pause
    End Sub

    Private Sub cmdPlay_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlay.Click
        ' must be on channel 3 to play a tape
        tvChannel = channels(3)
        lblChannel.Text = CStr(tvChannel.Number)

        ' Call the function to update the controls
        ButtonManager(PlayState.Play)
        isChannelChanged = False
        playingState = PlayState.Play
    End Sub

    Private Sub cmdRec_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRec.Click
        ' Call the function to update the controls
        ButtonManager(PlayState.Record)

        ' Set the recording and channel-changed flags. Display the recording status.
        playingState = PlayState.Record
    End Sub

    Private Sub cmdRewind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRewind.Click
        ' must be on channel 3 to play a tape
        tvChannel = channels(3)

        lblChannel.Text = CStr(tvChannel.Number)

        ' Call the function to update the controls
        ButtonManager(PlayState.Rewind)
        isChannelChanged = False
        playingState = PlayState.Rewind
    End Sub

    Private Sub cmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStop.Click
        ' Call the function to update the controls
        ButtonManager(PlayState.Stopped)

        lblChannel.Text = CStr(tvChannel.Number)

        If playingState = PlayState.Record Then
            If MessageBox.Show("Would you like to rewind the tape at this time?", _
                "Rewind?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                tape.Rewind()
            End If
        End If

        ' Set the recording flag.
        isChannelChanged = True
        playingState = PlayState.TV
    End Sub

#End Region

#Region "Set Recording Times"
    Private Sub cmdSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSet.Click
        ' show the user entry form modally
        Dim frm As New SetRecording()
        frm.ShowDialog()
    End Sub
#End Region

#Region "Display Animated Channels"
    Private Sub tmr1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmr1.Tick
        ' Update the time display
        lblTime.Text = Format(Now, "h:mm tt")

        ' If the Recorder property is turned on
        If recorder.Enabled = True Then
            ' If it's time to record
            If recorder.StartTime.Hour = Now.Hour And recorder.StartTime.Minute = Now.Minute Then
                ' Start "recording"
                tvChannel = channels(recorder.Channel)
                isChannelChanged = True

                lblChannel.Text = CStr(tvChannel.Number)

                ' Activate the Record button
                cmdRec_Click(cmdRec, New System.EventArgs())
            End If
        Else
            ' If it's time to stop recording
            If recorder.StopTime.Hour = Now.Hour And recorder.StopTime.Minute = Now.Minute Then
                ' Activate the Stop button
                playingState = PlayState.Stopped
                cmdStop_Click(cmdStop, New System.EventArgs())

                ' clear the property in the Recorder class
                recorder.IsSet = False
            End If
        End If
    End Sub

    Private Sub DisplayInfo()
        Static tf As TapeFrame

        'If the channel has changed, change the timer interval.
        If isChannelChanged Then
            frameTimer.Interval = tvChannel.RefreshRate
            isChannelChanged = False
        End If

        'If playing or fast forward, then the data is coming from the tape class.
        Select Case playingState
            Case PlayState.FastForward
                tf = tape.GetNextFrame()
                frameTimer.Interval = channels(tf.ChannelNumber).RefreshRate
                'Fast forwarding - go through the tape 10x as fast.
                frameTimer.Interval = frameTimer.Interval \ 10
                DrawChannel(tf.ChannelNumber, tf.Frame)

            Case PlayState.Pause
                frameTimer.Interval = channels(tf.ChannelNumber).RefreshRate
                DrawChannel(tf.ChannelNumber, tf.Frame)

            Case PlayState.Play
                tf = tape.GetNextFrame()
                frameTimer.Interval = channels(tf.ChannelNumber).RefreshRate
                DrawChannel(tf.ChannelNumber, tf.Frame)

            Case PlayState.Record
                ' Loop the images and record them.
                If tvChannel.CurrentFrame = tvChannel.FrameCount - 1 Then
                    tvChannel.CurrentFrame = 0
                Else
                    tvChannel.CurrentFrame += 1
                End If
                DrawChannel(tvChannel.Number, tvChannel.CurrentFrame)
                tape.SaveFrame(tvChannel.Number, tvChannel.CurrentFrame)

            Case PlayState.Rewind
                'Rewind works similar to play and fast forward.
                tf = tape.GetPreviousFrame()
                frameTimer.Interval = channels(tf.ChannelNumber).RefreshRate \ 10
                DrawChannel(tf.ChannelNumber, tf.Frame)

            Case PlayState.Stopped
            Case PlayState.TV
                ' Loop the images.
                If tvChannel.CurrentFrame = tvChannel.FrameCount - 1 Then
                    tvChannel.CurrentFrame = 0
                Else
                    tvChannel.CurrentFrame += 1
                End If
                DrawChannel(tvChannel.Number, tvChannel.CurrentFrame)

        End Select
    End Sub

    ''' <summary>
    ''' frameTimer controls what is displayed on the TV.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameTimer.Tick
        DisplayInfo()
    End Sub


    ''' <summary>
    ''' Draw the actual image frame.
    ''' </summary>
    ''' <param name="frame"></param>
    ''' <remarks></remarks>
    Private Sub DrawChannel(ByVal channelnumber As Integer, ByVal frame As Integer)
        channelBitmap = channels(channelnumber).Image
        Dim frameDim As New FrameDimension(channels(channelnumber).Image.FrameDimensionsList(0))
        channelBitmap.SelectActiveFrame(frameDim, frame)
        'Dim fd As New FrameDimension(channelBitmap.FrameDimensionsList(0))
        'channelBitmap.SelectActiveFrame(fd, frame)

        Dim g As Graphics = picTV.CreateGraphics
        g.DrawImage(channelBitmap, New Point(0, 0))

        Dim sans18 As New Font("Microsoft Sans Serif", 18)
        'If recording, write the recording message in the top
        'left. Write in black and white offset so that the text will
        'be visible regardless of the background.
        If playingState = PlayState.Record Then
            g.DrawString("Recording: Channel " & channelnumber, sans18, Brushes.Black, 0, 0)
            g.DrawString(lblTime.Text, sans18, Brushes.Black, 0, 25)
            g.DrawString("Recording: Channel " & channelnumber, sans18, Brushes.White, 1, 1)
            g.DrawString(lblTime.Text, sans18, Brushes.White, 1, 26)
            If playingState <> PlayState.Pause Then
                tape.SaveFrame(channelnumber, CInt(currentFrame(channelnumber)))
            End If
            g.Dispose()
        End If
    End Sub
#End Region

#Region "UI Updates"
    ''' <summary>
    ''' Enables or disables buttons on the VCR form based on the current mode.
    ''' </summary>
    ''' <param name="playingState">Action to take.</param>
    ''' <remarks></remarks>
    Private Sub ButtonManager(ByVal playingState As PlayState)
        ' Determine which function button was pushed
        ' and update all buttons and Recorder class.
        Me.cmdPause.Enabled = False
        Me.cmdStop.Enabled = False
        Me.cmdPlay.Enabled = False
        Me.cmdForward.Enabled = False
        Me.cmdRewind.Enabled = False
        Me.cmdDown.Enabled = False
        Me.cmdUp.Enabled = False

        Select Case playingState
            Case PlayState.Play, PlayState.FastForward, PlayState.Rewind
                Me.cmdPause.Enabled = True
                Me.cmdStop.Enabled = True

            Case PlayState.Record
                'Me.cmdPause.Enabled = True
                Me.cmdStop.Enabled = True

            Case PlayState.Pause
                Me.cmdPlay.Enabled = True

            Case PlayState.Stopped
                Me.cmdRec.Enabled = True
                Me.cmdPlay.Enabled = True
                Me.cmdForward.Enabled = True
                Me.cmdRewind.Enabled = True
                Me.cmdDown.Enabled = True
                Me.cmdUp.Enabled = True
                recorder.Enabled = True

            Case PlayState.TV
                Me.cmdUp.Enabled = True
                Me.cmdDown.Enabled = True

        End Select
    End Sub
#End Region

End Class