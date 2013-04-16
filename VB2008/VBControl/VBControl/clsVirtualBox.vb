Imports VirtualBox

Public Class clsVirtualBox

#Region "Declaration"

    Private _VBoxPath As String 'Installation Path of Virtual Box (System Environment VBOX_INSTALL_PATH)

    Private _VBox As IVirtualBox
    Private _VBoxMachine As IMachine
    Private _VBoxConsole As IConsole
    Private _VBoxSession As New Session
    Private _VBoxProgress As IProgress
    Private _VBoxDisplay As IDisplay

    Private _VBoxPerformance As IPerformanceCollector
    Private _VBoxMetric() As IPerformanceMetric

    Private _VBoxMachineState As New MachineState

    Private _sUUID As String = "0"

    Private _sType_GUI As String = "gui"
    Private _sType_HEADLESS As String = "headless"
    Private _sType_SDL As String = "sdl"
    Private _sType_VRDP As String = "vrdp"
    Private _sType_NOGUI As String = "nogui"

#Region "Public"

    Public sMachine_Status_Running As MachineState = MachineState.MachineState_Running
    Public sMachine_Status_Paused As MachineState = MachineState.MachineState_Paused
    Public sMachine_Status_Saved As MachineState = MachineState.MachineState_Saved
    Public sMachine_Status_Stopped As MachineState = MachineState.MachineState_PoweredOff

#End Region

#End Region

#Region "Properties"

    Public ReadOnly Property VBox_Version() As String
        Get
            Return _VBox.Version
        End Get
    End Property

    Public ReadOnly Property VBox_Machines() As List(Of String())
        Get
            Dim saMachine As String() = {"0", "", ""}
            Dim saMachines As New List(Of String())

            'Add Array to List
            saMachines.Add(saMachine)

            For i As Integer = 0 To _VBox.Machines.Length - 1
                'ReDim to Clear Array (saMachine)
                ReDim saMachine(2)

                saMachine(0) = _VBox.Machines(i).Id
                saMachine(1) = _VBox.Machines(i).Name
                saMachine(2) = _VBox.Machines(i).GetGuestPropertyValue("/VirtualBox/GuestInfo/OS/Product")

                'Add Array to List
                saMachines.Add(saMachine)
            Next

            Return saMachines
        End Get
    End Property

    Public ReadOnly Property Machine_State(ByVal UUID As String) As MachineState
        Get
            If Not UUID = _sUUID Then
                InitMachine(UUID)
            End If

            If Not _VBoxMachine Is Nothing Then
                Return _VBoxMachine.State
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property Machine_Name(ByVal UUID As String) As String
        Get
            If Not UUID = _sUUID Then
                InitMachine(UUID)
            End If

            If _VBoxMachine Is Nothing Then
                Return Nothing
            End If

            Return _VBoxMachine.Name
        End Get
    End Property

    Public ReadOnly Property Machine_OS(ByVal UUID As String) As String
        Get
            If Not UUID = _sUUID Then
                InitMachine(UUID)
            End If

            If _VBoxMachine Is Nothing Then
                Return Nothing
            End If

            Dim sOS As String = ""

            'Gettin OS Information Product, SP (Windows Only), Version
            sOS = _VBoxMachine.GetGuestPropertyValue("/VirtualBox/GuestInfo/OS/Product")
            If Not _VBoxMachine.GetGuestPropertyValue("/VirtualBox/GuestInfo/OS/ServicePack") Is Nothing Then
                sOS = sOS + " SP" + _VBoxMachine.GetGuestPropertyValue("/VirtualBox/GuestInfo/OS/ServicePack")
            End If
            sOS = sOS + " (v." + _VBoxMachine.GetGuestPropertyValue("/VirtualBox/GuestInfo/OS/Release") + ")"


            Return sOS
        End Get
    End Property

    Public ReadOnly Property Machine_RAM(ByVal UUID As String) As String
        Get
            If Not UUID = _sUUID Then
                InitMachine(UUID)
            End If

            If _VBoxMachine Is Nothing Then
                Return Nothing
            End If

            Return _VBoxMachine.MemorySize.ToString + " MB"
        End Get
    End Property

    Public ReadOnly Property Machine_Resolution(ByVal UUID As String) As String
        Get
            If Not UUID = _sUUID Then
                InitMachine(UUID)
            End If

            If _VBoxMachine Is Nothing Then
                Return Nothing
            End If

            Dim iHeight As Integer = 0
            Dim iWidth As Integer = 0

            If Machine_State(UUID) = MachineState.MachineState_Running Then

                'Unlock Session to Set Console
                If _VBoxSession.State = SessionState.SessionState_Locked Then
                    _VBoxSession.UnlockMachine()
                End If

                _VBoxMachine.LockMachine(_VBoxSession, LockType.LockType_Shared)
                _VBoxDisplay = _VBoxSession.Console.Display

                _VBoxDisplay.GetScreenResolution(0, iWidth, iHeight, Nothing)
            End If

            Return iWidth.ToString + " x " + iHeight.ToString

        End Get
    End Property

    Public ReadOnly Property Machine_IP(ByVal UUID As String) As String
        Get
            If Not UUID = _sUUID Then
                InitMachine(UUID)
            End If

            If _VBoxMachine Is Nothing Then
                Return Nothing
            End If

            'Get IP an VRDE Port
            Return _VBoxMachine.GetGuestPropertyValue("/VirtualBox/GuestInfo/Net/0/V4/IP") + ":" + _VBoxMachine.VRDEServer.GetVRDEProperty("TCP/Ports")

        End Get
    End Property

#End Region

#Region "Init"
    Sub New()
        _VBox = CreateObject("VirtualBox.VirtualBox")
        _VBoxPath = Environment.GetEnvironmentVariable("VBOX_INSTALL_PATH")
    End Sub

    Public Function InitMachine(ByVal UUID As String) As Boolean
        _sUUID = "0"
        _VBoxMachine = Nothing

        If UUID = "" Or UUID = "0" Then
            Return Nothing
        End If

        'Check if UUID exist and set Machine and UUID
        _VBoxMachine = _VBox.FindMachine(UUID)

        'Return True/False
        If Not _VBoxMachine Is Nothing Then
            _sUUID = UUID
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "Machine Control"

    Public Function StartMachine(ByVal UUID As String, Optional ByVal iType As Integer = 0) As Boolean
        If Not UUID = _sUUID Then
            InitMachine(UUID)
        End If

        Dim sType As String = ""

        If iType > 4 Then
            iType = 0
        End If

        Select Case iType
            Case 0
                sType = _sType_GUI
            Case 1
                sType = _sType_HEADLESS
            Case 2
                sType = _sType_SDL
            Case 3
                sType = _sType_VRDP
            Case 4
                sType = _sType_NOGUI
        End Select

        If Not _VBoxMachine Is Nothing Then
            If Not Machine_State(UUID) = MachineState.MachineState_Running Then
                If _VBoxSession.State = SessionState.SessionState_Locked Then
                    _VBoxSession.UnlockMachine()
                End If

                If sType = _sType_NOGUI Then
                    'Start Windows Process without a GUI (Advanced headless)
                    Dim proc As New Process()
                    proc.StartInfo.FileName = _VBoxPath + "VBoxHeadless.exe"
                    proc.StartInfo.Arguments = "--startvm " + UUID
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    proc.StartInfo.UseShellExecute = False
                    proc.StartInfo.CreateNoWindow = True
                    proc.Start()
                Else
                    'Start VM with Mode GUI, HEADLESS, SDL, VRDP
                    _VBoxProgress = _VBoxMachine.LaunchVMProcess(_VBoxSession, sType, "")
                    _VBoxProgress.WaitForCompletion(5000)
                End If

            End If
        Else
            Return False
        End If

        Return True

    End Function

    Public Function StopMachine(ByVal UUID As String) As Boolean
        If Not UUID = _sUUID Then
            InitMachine(UUID)
        End If

        'Unlock Session to Set Console
        If _VBoxSession.State = VirtualBox.SessionState.SessionState_Locked Then
            _VBoxSession.UnlockMachine()
        End If

        _VBoxMachine.LockMachine(_VBoxSession, VirtualBox.LockType.LockType_Shared)

        'Stoping Machine SaveStat as Default
        _VBoxSession.Console.SaveState()


    End Function

#End Region

#Region "Performance"

    Public Sub StartPerformance(ByVal Interval As Integer, ByVal Count As Integer, ByVal UUID As String)
        Dim proc As New Process()
        proc.StartInfo.FileName = _VBoxPath + "VBoxManage.exe"
        proc.StartInfo.Arguments = "metrics setup --period " & Interval.ToString & " --samples " & Count.ToString & " " & UUID
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.CreateNoWindow = True
        proc.Start()
    End Sub

    Public Function GetMetrics(ByVal UUID As String, ByVal Metrics As String) As String(,)
        'Input
        Dim aMachine As System.Array = Nothing
        Dim aMetric As System.Array = Nothing

        'Output
        Dim sReturnMetricNames As System.Array = Nothing
        Dim oReturnObjects As System.Array = Nothing
        Dim sReturnUnits As System.Array = Nothing
        Dim lReturnScales As System.Array = Nothing
        Dim iReturnSequenceNumbers As System.Array = Nothing
        Dim iReturnDataIndices As System.Array = Nothing
        Dim iReturnDataLengths As System.Array = Nothing
        Dim lReturnData() As Int32 = Nothing

        Dim sOutput(7, 2) As String



        _VBoxPerformance = _VBox.PerformanceCollector

        'Create Array aMachine
        aMachine = System.Array.CreateInstance(GetType(IMachine), 1)
        aMachine(0) = _VBoxMachine

        'Create Array aMetric
        aMetric = System.Array.CreateInstance(GetType(String), 1)
        aMetric(0) = Metrics
        aMetric(0) = "Guest/CPU/Load/User," & _
                     "Guest/CPU/Load/Kernel," & _
                     "Guest/CPU/Load/Idle," & _
                     "Guest/RAM/Usage/Total," & _
                     "Guest/RAM/Usage/Free," & _
                     "Guest/RAM/Usage/Balloon," & _
                     "Guest/RAM/Usage/Shared," & _
                     "Guest/RAM/Usage/Cache,"

        lReturnData = _VBoxPerformance.QueryMetricsData(aMetric, aMachine, sReturnMetricNames, oReturnObjects, sReturnUnits, lReturnScales, iReturnSequenceNumbers, iReturnDataIndices, iReturnDataLengths)
        _VBoxMetric = _VBoxPerformance.GetMetrics(aMetric, aMachine)


        For i = 0 To (sOutput.Length / 3) - 1

            If Not lReturnData.Length = 0 Then
                sOutput(i, 0) = sReturnMetricNames(i)
                sOutput(i, 1) = (lReturnData(i) / lReturnScales(i)).ToString
                sOutput(i, 2) = sReturnUnits(i)
            Else
                sOutput(i, 0) = ""
                sOutput(i, 1) = 0
                sOutput(i, 2) = ""
            End If

        Next

        Return sOutput

    End Function

#End Region

End Class
