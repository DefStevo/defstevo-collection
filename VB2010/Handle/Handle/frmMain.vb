Option Explicit On

Public Class frmMain

    Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure

    ' zunächst die benötigten API-Deklarationen
    Private Declare Function GetCursorPos Lib "user32" ( _
      ByRef lpPoint As POINTAPI) As Boolean

    Private Declare Function WindowFromPoint Lib "user32" ( _
      ByVal xPoint As Integer, _
      ByVal yPoint As Integer) As Integer

    Private Declare Function SendMessage Lib "user32" _
      Alias "SendMessageA" ( _
      ByVal hWnd As Integer, _
      ByRef wMsg As Integer, _
      ByRef wParam As Integer, _
      lParam As Int32) As Integer

    Private Const WM_GETTEXT = &HD
    Private Sub Form_Load() Handles Me.Load
        ' Timer initialisieren
        tmrTimer.Interval = 10
        tmrTimer.Enabled = False
    End Sub
    Private Sub cmdStart_Click() Handles cmdStart.Click
        tmrTimer.Enabled = Not tmrTimer.Enabled
        cmdStart.Text = IIf(tmrTimer.Enabled, "Stop", "Start")
    End Sub
    Private Sub tmrTimer_Timer() Handles tmrTimer.Tick
        Dim oPoint As POINTAPI
        Dim bResult As Boolean
        Dim hWnd As Integer
        Dim lLength As Long
        Dim sWindowText As String

        bResult = GetCursorPos(oPoint)

        ' Mausposition ermitteln
        If GetCursorPos(oPoint) <> 0 Then
            ' Fensterhandle des Controls, auf dem sich
            ' der Mauszeiger befindet
            hWnd = WindowFromPoint(oPoint.x, oPoint.y)

            ' Fenstertext des Controls ermitteln
            lLength = SendMessage(hWnd, WM_GETTEXT, _
            Len(sWindowText) + 1, sWindowText)

            ' Handle anzeigen
            lblHandle.Text = hWnd

            ' Mausposition anzeigen
            lblPos.Text = "x " & oPoint.x & " y " & oPoint.y

            ' Fenstertext anzeigen
            If Not sWindowText Is Nothing Then
                lblWindowText.Text = sWindowText.Substring(1, lLength)
            Else
                lblWindowText.Text = ""
            End If

        End If
    End Sub

End Class
