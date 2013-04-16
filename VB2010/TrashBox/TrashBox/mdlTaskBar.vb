Public Module mdlTaskBar
    Private Declare Function _SHAppBarMessage Lib "shell32.dll" Alias "SHAppBarMessage" _
     (ByVal dwMessage As Int32, _
      ByRef pData As _TaskBarData) As Int32

    Private Structure _Size
        Dim Left As Int32
        Dim Top As Int32
        Dim Right As Int32
        Dim Bottom As Int32
    End Structure

    Private Structure _TaskBarData
        Dim cbSize As Int32
        Dim hwnd As IntPtr
        Dim uCallbackMessage As [Delegate]
        Dim uEdge As Int32
        Dim Size As _Size
        Dim lParam As Int32
    End Structure

    Private Const _ABM_GETTASKBARPOS As Int32 = &H5
    Private Const _ABM_GETSTATE As Int32 = &H4
    Private Const _ABS_AUTOHIDE As Int32 = &H1
    Private Const _ABS_ALWAYSONTOP As Int32 = &H2

    Public Sub GetTaskbarState(ByRef iTop As Int32, _
            ByRef iBottom As Int32, _
            ByRef iLeft As Int32, _
            ByRef iRight As Int32, _
            ByRef iHeight As Int32, _
            ByRef iWidth As Int32, _
            ByRef bAutoHide As Boolean)

        Dim _Result As Int32
        Dim _TaskBar As _TaskBarData = Nothing

        Call _SHAppBarMessage(_ABM_GETTASKBARPOS, _TaskBar)
        _Result = _SHAppBarMessage(_ABM_GETSTATE, _TaskBar)
        If (_Result And _ABS_AUTOHIDE) Then
            bAutoHide = True
        End If

        With _TaskBar.Size
            iLeft = .Left
            iTop = .Top
            iRight = .Right
            iBottom = .Bottom
            If .Bottom < Screen.PrimaryScreen.WorkingArea.Height Then
                iHeight = Screen.PrimaryScreen.WorkingArea.Height
            Else
                iHeight = .Bottom
            End If

            If .Right < Screen.PrimaryScreen.WorkingArea.Width Then
                iWidth = Screen.PrimaryScreen.WorkingArea.Width
            Else
                iWidth = .Right
            End If
        End With

    End Sub


End Module
