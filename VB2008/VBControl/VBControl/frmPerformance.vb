Imports System.Management 'TODO (3) Implement Performance Monitor Using WMI (System.Management)

Public Class frmPerformance

#Region "Declaration"

    Private _iHeight As Integer = 0
    Private _iWidth As Integer = 350

    Private _sPerformance(7, 2) As String
    Private _sMetrics As String = "Guest/CPU/Load/User,Guest/CPU/Load/Kernel,Guest/CPU/Load/Idle,Guest/RAM/Usage/Total,Guest/RAM/Usage/Free,Guest/RAM/Usage/Balloon,Guest/RAM/Usage/Shared,Guest/RAM/Usage/Cache"

    'CPU Variables
    Private _sCPU_Unit As String = "%"
    Private _iCPU_Usage_User As Integer = 0
    Private _iCPU_Usage_Kernel As Integer = 0

    'Variables for Drawing
    Private _iCPU_User(25) As Integer
    Private _iCPU_Kernel(25) As Integer
    Private _LineCPU_Total(24) As Microsoft.VisualBasic.PowerPacks.LineShape
    Private _LineCPU_User(24) As Microsoft.VisualBasic.PowerPacks.LineShape
    Private _LineCPU_Kernel(24) As Microsoft.VisualBasic.PowerPacks.LineShape
    Private _ContainerCPU As Microsoft.VisualBasic.PowerPacks.ShapeContainer

    'RAM Variables
    Private _sRAM_Unit As String = "MB"
    Private _iRAM_Usage As Integer = 0
    Private _iRAM_Usage_perc As Integer = 0
    Private _iRAM_Total As Integer = 0
    Private _iRAM_Free As Integer = 0
    Private _iRAM_Balloon As Integer = 0
    Private _iRAM_Shared As Integer = 0
    Private _iRAM_Cache As Integer = 0

    'Variables for Drawing
    Private _iRAM(10) As Integer
    Private _LineRAM(9) As Microsoft.VisualBasic.PowerPacks.LineShape
    Private _ContainerRAM As Microsoft.VisualBasic.PowerPacks.ShapeContainer


#End Region

#Region "Form Activities"

    Private Sub frmPerformance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.clsVBox.StartPerformance(1, 1, frmMain.GetUUID)
        grpCPU.Visible = False
        grpRAM.Visible = False
        Timer1.Enabled = False

        cbCPU.Checked = False
        cbRAM.Checked = False

        Me.Text = "Performance Monitor: " & frmMain.clsVBox.Machine_Name(frmMain.GetUUID)
        lblCPU.Text = ""
        lblRAM.Text = ""

        'Initialize Array CPU User
        For i As Integer = 0 To _iCPU_User.Length - 1
            _iCPU_User(i) = 100
        Next

        'Initialize Array CPU Kernel
        For i As Integer = 0 To _iCPU_Kernel.Length - 1
            _iCPU_Kernel(i) = 100
        Next

        'Initialize Lines CPU Total
        For i As Integer = 0 To _LineCPU_Total.Length - 1
            _LineCPU_Total(i) = New Microsoft.VisualBasic.PowerPacks.LineShape
            With _LineCPU_Total(i)
                .BorderColor = Color.Lime
                .Y1 = 60
                .Y2 = 60
                .X1 = gCPU.Width / _LineCPU_Total.Count * (i)
                .X2 = gCPU.Width / _LineCPU_Total.Count * (i + 1)
            End With
        Next

        'Initialize Lines CPU User
        For i As Integer = 0 To _LineCPU_User.Length - 1
            _LineCPU_User(i) = New Microsoft.VisualBasic.PowerPacks.LineShape
            With _LineCPU_User(i)
                .BorderColor = Color.Yellow
                .Y1 = 60
                .Y2 = 60
                .X1 = gCPU.Width / _LineCPU_User.Count * (i)
                .X2 = gCPU.Width / _LineCPU_User.Count * (i + 1)
            End With
        Next

        'Initialize Lines CPU Kernel
        For i As Integer = 0 To _LineCPU_Kernel.Length - 1
            _LineCPU_Kernel(i) = New Microsoft.VisualBasic.PowerPacks.LineShape
            With _LineCPU_Kernel(i)
                .BorderColor = Color.Red
                .Y1 = 60
                .Y2 = 60

                .X1 = gCPU.Width / _LineCPU_Kernel.Count * (i)
                .X2 = gCPU.Width / _LineCPU_Kernel.Count * (i + 1)
            End With
        Next

        'Initialize Shape Container CPU
        _ContainerCPU = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        With _ContainerCPU
            .Location = New System.Drawing.Point(0, 0)
            .Margin = New System.Windows.Forms.Padding(0)
            .Size = New System.Drawing.Size(250, 60)
            .TabIndex = 0
            .TabStop = False

            'Add Controls Line CPU Total
            For i As Integer = 0 To _LineCPU_Total.Length - 1
                .Shapes.Add(_LineCPU_Total(i))
            Next

            'Add Controls Line CPU User
            For i As Integer = 0 To _LineCPU_User.Length - 1
                .Shapes.Add(_LineCPU_User(i))
            Next

            'Add Controls Line CPU Kernel
            For i As Integer = 0 To _LineCPU_Kernel.Length - 1
                .Shapes.Add(_LineCPU_Kernel(i))
            Next
        End With

        'Add Shape Container to gCPU
        gCPU.Controls.Add(_ContainerCPU)

        'Initialize Array RAM
        For i As Integer = 0 To _iRAM.Length - 1
            _iRAM(i) = 100
        Next

        'Initialize Lines RAM
        For i As Integer = 0 To _LineRAM.Length - 1
            _LineRAM(i) = New Microsoft.VisualBasic.PowerPacks.LineShape
            With _LineRAM(i)
                .BorderColor = Color.Lime
                .Y1 = 60
                .Y2 = 60
                .X1 = gRAM.Width / _LineRAM.Count * (i)
                .X2 = gRAM.Width / _LineRAM.Count * (i + 1)
            End With
        Next

        'Initialize Shape Container RAM
        _ContainerRAM = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        With _ContainerRAM
            .Location = New System.Drawing.Point(0, 0)
            .Margin = New System.Windows.Forms.Padding(0)
            For i As Integer = 0 To _LineRAM.Length - 1
                .Shapes.Add(_LineRAM(i))
            Next
            .Size = New System.Drawing.Size(250, 60)
            .TabIndex = 0
            .TabStop = False
        End With

        'Add Shape Container to gCPU
        gRAM.Controls.Add(_ContainerRAM)

        'Hide CPU Usage
        DrawCPU(0)

        'Hide RAM Usage
        DrawRAM(0)

        'Rezise Form
        FormResize()

    End Sub

    Private Sub FormResize()
        'Calculate Option Size for Form
        If grpCPU.Visible = True And grpRAM.Visible = True Then
            _iHeight = 220
            grpCPU.SetBounds(0, 30, grpCPU.Width, grpCPU.Height)
            grpRAM.SetBounds(0, 113, grpRAM.Width, grpRAM.Height)
        ElseIf grpCPU.Visible = False And grpRAM.Visible = False Then
            _iHeight = 57
        ElseIf grpCPU.Visible = True And grpRAM.Visible = False Then
            _iHeight = 137
            grpCPU.SetBounds(0, 30, grpCPU.Width, grpCPU.Height)
        ElseIf grpCPU.Visible = False And grpRAM.Visible = True Then
            _iHeight = 137
            grpRAM.SetBounds(0, 30, grpRAM.Width, grpRAM.Height)
        End If

        'Enable Timer
        If grpCPU.Visible = True Or grpRAM.Visible = True Then
            Timer1.Enabled = True
        End If

        Dim _iDif As Integer = 0

        If _iHeight < Me.Height Then
            _iDif = Me.Height - _iHeight
        Else
            _iDif = _iHeight - Me.Height
        End If

        For i As Integer = 0 To _iDif
            Me.Width = _iWidth

            If _iHeight < Me.Height Then
                Me.Height = Me.Height - 1
            Else
                Me.Height = Me.Height + 1
            End If
        Next

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        WritePerformance()
    End Sub

#End Region

#Region "Checkboxes"

    Private Sub cbCPU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCPU.CheckedChanged
        grpCPU.Visible = cbCPU.Checked

        'Resize
        FormResize()

    End Sub

    Private Sub cbRAM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRAM.CheckedChanged
        grpRAM.Visible = cbRAM.Checked

        'Resize
        FormResize()

    End Sub

#End Region

#Region "Performance"

    Private Sub WritePerformance()
        _sPerformance = frmMain.clsVBox.GetMetrics(frmMain.GetUUID, _sMetrics)

        'CPU Usage User(0), Kernel(1)
        _iCPU_Usage_User = Val(_sPerformance(0, 1))
        _iCPU_Usage_Kernel = Val(_sPerformance(1, 1))

        DrawCPU(_iCPU_Usage_User + _iCPU_Usage_Kernel)
        DrawCPU_Graph(_iCPU_Usage_User, _iCPU_Usage_Kernel)
        lblCPU.Text = (_iCPU_Usage_User + _iCPU_Usage_Kernel).ToString & _sCPU_Unit

        'RAM Usage
        _iRAM_Usage = Val(_sPerformance(3, 1)) - Val(_sPerformance(4, 1))
        If Val(_sPerformance(3, 1)) = 0 Then
            _iRAM_Usage_perc = 0
        Else
            _iRAM_Usage_perc = _iRAM_Usage / Val(_sPerformance(3, 1)) * 100
        End If

        DrawRAM(_iRAM_Usage_perc)
        DrawRAM_Graph(_iRAM_Usage_perc)
        lblRAM.Text = Decimal.ToInt32(Decimal.Round(_iRAM_Usage / 1027)).ToString & " " & _sRAM_Unit

    End Sub

#End Region

#Region "Draw Graph"

    Private Sub DrawCPU(ByVal Usage As Integer)
        Select Case Usage
            Case 100
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Solid
                CPU6.FillStyle = PowerPacks.FillStyle.Solid
                CPU7.FillStyle = PowerPacks.FillStyle.Solid
                CPU8.FillStyle = PowerPacks.FillStyle.Solid
                CPU9.FillStyle = PowerPacks.FillStyle.Solid
                CPU10.FillStyle = PowerPacks.FillStyle.Solid
            Case Is >= 90
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Solid
                CPU6.FillStyle = PowerPacks.FillStyle.Solid
                CPU7.FillStyle = PowerPacks.FillStyle.Solid
                CPU8.FillStyle = PowerPacks.FillStyle.Solid
                CPU9.FillStyle = PowerPacks.FillStyle.Solid
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 80
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Solid
                CPU6.FillStyle = PowerPacks.FillStyle.Solid
                CPU7.FillStyle = PowerPacks.FillStyle.Solid
                CPU8.FillStyle = PowerPacks.FillStyle.Solid
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 70
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Solid
                CPU6.FillStyle = PowerPacks.FillStyle.Solid
                CPU7.FillStyle = PowerPacks.FillStyle.Solid
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 60
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Solid
                CPU6.FillStyle = PowerPacks.FillStyle.Solid
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 50
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Solid
                CPU6.FillStyle = PowerPacks.FillStyle.Transparent
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 40
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Solid
                CPU5.FillStyle = PowerPacks.FillStyle.Transparent
                CPU6.FillStyle = PowerPacks.FillStyle.Transparent
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 30
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Solid
                CPU4.FillStyle = PowerPacks.FillStyle.Transparent
                CPU5.FillStyle = PowerPacks.FillStyle.Transparent
                CPU6.FillStyle = PowerPacks.FillStyle.Transparent
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 20
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Solid
                CPU3.FillStyle = PowerPacks.FillStyle.Transparent
                CPU4.FillStyle = PowerPacks.FillStyle.Transparent
                CPU5.FillStyle = PowerPacks.FillStyle.Transparent
                CPU6.FillStyle = PowerPacks.FillStyle.Transparent
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 10
                CPU1.FillStyle = PowerPacks.FillStyle.Solid
                CPU2.FillStyle = PowerPacks.FillStyle.Transparent
                CPU3.FillStyle = PowerPacks.FillStyle.Transparent
                CPU4.FillStyle = PowerPacks.FillStyle.Transparent
                CPU5.FillStyle = PowerPacks.FillStyle.Transparent
                CPU6.FillStyle = PowerPacks.FillStyle.Transparent
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Else
                CPU1.FillStyle = PowerPacks.FillStyle.Transparent
                CPU2.FillStyle = PowerPacks.FillStyle.Transparent
                CPU3.FillStyle = PowerPacks.FillStyle.Transparent
                CPU4.FillStyle = PowerPacks.FillStyle.Transparent
                CPU5.FillStyle = PowerPacks.FillStyle.Transparent
                CPU6.FillStyle = PowerPacks.FillStyle.Transparent
                CPU7.FillStyle = PowerPacks.FillStyle.Transparent
                CPU8.FillStyle = PowerPacks.FillStyle.Transparent
                CPU9.FillStyle = PowerPacks.FillStyle.Transparent
                CPU10.FillStyle = PowerPacks.FillStyle.Transparent
        End Select
    End Sub

    Private Sub DrawCPU_Graph(ByVal User As Integer, ByVal Kernel As Integer)

        'Array CPU User
        For i As Integer = 0 To _iCPU_User.Length - 2
            _iCPU_User(i) = _iCPU_User(i + 1)
        Next

        'Add New Value
        _iCPU_User(_iCPU_User.Length - 1) = 100 - User

        'Array CPU Kernal
        For i As Integer = 0 To _iCPU_Kernel.Length - 2
            _iCPU_Kernel(i) = _iCPU_Kernel(i + 1)
        Next

        'Add New Value
        _iCPU_Kernel(_iCPU_Kernel.Length - 1) = 100 - Kernel

        'Draw Line1 Total
        With _LineCPU_Total(0)
            .Y1 = (100 - ((100 - _iCPU_User(0)) + (100 - _iCPU_Kernel(0)))) * 0.6
            .Y2 = (100 - ((100 - _iCPU_User(1)) + (100 - _iCPU_Kernel(1)))) * 0.6
        End With

        'Draw Line2 - n Total
        For i As Integer = 1 To _LineCPU_Total.Length - 1
            With _LineCPU_Total(i)
                .Y1 = _LineCPU_Total(i - 1).Y2
                .Y2 = (100 - ((100 - _iCPU_User(i + 1)) + (100 - _iCPU_Kernel(i + 1)))) * 0.6
            End With
        Next

        'Draw Line1 User
        With _LineCPU_User(0)
            .Y1 = _iCPU_User(0) * 0.6
            .Y2 = _iCPU_User(1) * 0.6
        End With

        'Draw Line2 - n User
        For i As Integer = 1 To _LineCPU_User.Length - 1
            With _LineCPU_User(i)
                .Y1 = _LineCPU_User(i - 1).Y2
                .Y2 = _iCPU_User(i + 1) * 0.6
            End With
        Next

        'Draw Line1 Kernel
        With _LineCPU_Kernel(0)
            .Y1 = _iCPU_Kernel(0) * 0.6
            .Y2 = _iCPU_Kernel(1) * 0.6
        End With

        'Draw Line2 - n Kernel
        For i As Integer = 1 To _LineCPU_Kernel.Length - 1
            With _LineCPU_Kernel(i)
                .Y1 = _LineCPU_Kernel(i - 1).Y2
                .Y2 = _iCPU_Kernel(i + 1) * 0.6
            End With
        Next
    End Sub

    Private Sub DrawRAM(ByVal Usage As Integer)
        Select Case Usage
            Case 100
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Solid
                RAM6.FillStyle = PowerPacks.FillStyle.Solid
                RAM7.FillStyle = PowerPacks.FillStyle.Solid
                RAM8.FillStyle = PowerPacks.FillStyle.Solid
                RAM9.FillStyle = PowerPacks.FillStyle.Solid
                RAM10.FillStyle = PowerPacks.FillStyle.Solid
            Case Is >= 90
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Solid
                RAM6.FillStyle = PowerPacks.FillStyle.Solid
                RAM7.FillStyle = PowerPacks.FillStyle.Solid
                RAM8.FillStyle = PowerPacks.FillStyle.Solid
                RAM9.FillStyle = PowerPacks.FillStyle.Solid
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 80
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Solid
                RAM6.FillStyle = PowerPacks.FillStyle.Solid
                RAM7.FillStyle = PowerPacks.FillStyle.Solid
                RAM8.FillStyle = PowerPacks.FillStyle.Solid
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 70
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Solid
                RAM6.FillStyle = PowerPacks.FillStyle.Solid
                RAM7.FillStyle = PowerPacks.FillStyle.Solid
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 60
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Solid
                RAM6.FillStyle = PowerPacks.FillStyle.Solid
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 50
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Solid
                RAM6.FillStyle = PowerPacks.FillStyle.Transparent
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 40
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Solid
                RAM5.FillStyle = PowerPacks.FillStyle.Transparent
                RAM6.FillStyle = PowerPacks.FillStyle.Transparent
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 30
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Solid
                RAM4.FillStyle = PowerPacks.FillStyle.Transparent
                RAM5.FillStyle = PowerPacks.FillStyle.Transparent
                RAM6.FillStyle = PowerPacks.FillStyle.Transparent
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 20
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Solid
                RAM3.FillStyle = PowerPacks.FillStyle.Transparent
                RAM4.FillStyle = PowerPacks.FillStyle.Transparent
                RAM5.FillStyle = PowerPacks.FillStyle.Transparent
                RAM6.FillStyle = PowerPacks.FillStyle.Transparent
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Is >= 10
                RAM1.FillStyle = PowerPacks.FillStyle.Solid
                RAM2.FillStyle = PowerPacks.FillStyle.Transparent
                RAM3.FillStyle = PowerPacks.FillStyle.Transparent
                RAM4.FillStyle = PowerPacks.FillStyle.Transparent
                RAM5.FillStyle = PowerPacks.FillStyle.Transparent
                RAM6.FillStyle = PowerPacks.FillStyle.Transparent
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
            Case Else
                RAM1.FillStyle = PowerPacks.FillStyle.Transparent
                RAM2.FillStyle = PowerPacks.FillStyle.Transparent
                RAM3.FillStyle = PowerPacks.FillStyle.Transparent
                RAM4.FillStyle = PowerPacks.FillStyle.Transparent
                RAM5.FillStyle = PowerPacks.FillStyle.Transparent
                RAM6.FillStyle = PowerPacks.FillStyle.Transparent
                RAM7.FillStyle = PowerPacks.FillStyle.Transparent
                RAM8.FillStyle = PowerPacks.FillStyle.Transparent
                RAM9.FillStyle = PowerPacks.FillStyle.Transparent
                RAM10.FillStyle = PowerPacks.FillStyle.Transparent
        End Select


    End Sub

    Private Sub DrawRAM_Graph(ByVal Usage As Integer)

        'Array RAM
        For i As Integer = 0 To _iRAM.Length - 2
            _iRAM(i) = _iRAM(i + 1)
        Next

        'Add New Value
        _iRAM(_iRAM.Length - 1) = 100 - Usage

        'Draw Line1 RAM
        With _LineRAM(0)
            .Y1 = _iRAM(0) * 0.6
            .Y2 = _iRAM(1) * 0.6
        End With

        'Draw Line2 - n RAM
        For i As Integer = 1 To _LineRAM.Length - 1
            With _LineRAM(i)
                .Y1 = _LineRAM(i - 1).Y2
                .Y2 = _iRAM(i + 1) * 0.6
            End With
        Next

    End Sub

#End Region

End Class