VERSION 5.00
Begin VB.Form frmVista 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   0  'Kein
   Caption         =   "Windows Vista - Window Demo"
   ClientHeight    =   4200
   ClientLeft      =   6405
   ClientTop       =   4050
   ClientWidth     =   7320
   Icon            =   "frmVista.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4200
   ScaleWidth      =   7320
   Begin VB.Image picClose 
      Height          =   225
      Left            =   6840
      Top             =   120
      Width           =   420
   End
   Begin VB.Image picMax 
      Height          =   225
      Left            =   6360
      Top             =   120
      Width           =   420
   End
   Begin VB.Image picMin 
      Height          =   225
      Left            =   5880
      Top             =   120
      Width           =   420
   End
   Begin VB.Image picTitel 
      Height          =   420
      Left            =   0
      Top             =   0
      Width           =   7335
   End
   Begin VB.Image Image1 
      Height          =   240
      Left            =   120
      Picture         =   "frmVista.frx":279E7
      Top             =   120
      Width           =   240
   End
   Begin VB.Label lblTitel 
      BackColor       =   &H00D6B69C&
      Caption         =   " Windows Vista - Window Demo"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   120
      Width           =   5415
   End
   Begin VB.Image picClose_aktiv 
      Height          =   225
      Left            =   6840
      Picture         =   "frmVista.frx":27DEB
      Top             =   120
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.Image picClose_inaktiv 
      Height          =   225
      Left            =   6840
      Picture         =   "frmVista.frx":28319
      Top             =   120
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.Image picMax_aktiv 
      Height          =   225
      Left            =   6360
      Picture         =   "frmVista.frx":28847
      Top             =   120
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.Image picMax_inaktiv 
      Height          =   225
      Left            =   6360
      Picture         =   "frmVista.frx":28D75
      Top             =   120
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.Image picMin_aktiv 
      Height          =   225
      Left            =   5880
      Picture         =   "frmVista.frx":292A3
      Top             =   120
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.Image picMin_inaktiv 
      Height          =   225
      Left            =   5880
      Picture         =   "frmVista.frx":297D1
      Top             =   120
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.Image picRU 
      Height          =   120
      Left            =   7200
      MousePointer    =   8  'Größenänderung NW SO
      Picture         =   "frmVista.frx":29CFF
      Top             =   4080
      Width           =   120
   End
   Begin VB.Image picR 
      Height          =   3765
      Left            =   7200
      Picture         =   "frmVista.frx":29E01
      Stretch         =   -1  'True
      Top             =   360
      Width           =   120
   End
   Begin VB.Image picU 
      Height          =   120
      Left            =   120
      Picture         =   "frmVista.frx":29E8B
      Stretch         =   -1  'True
      Top             =   4080
      Width           =   7080
   End
   Begin VB.Image picLU 
      Height          =   120
      Left            =   0
      Picture         =   "frmVista.frx":29F4D
      Top             =   4080
      Width           =   120
   End
   Begin VB.Image picL 
      Height          =   3780
      Left            =   0
      Picture         =   "frmVista.frx":2A04F
      Stretch         =   -1  'True
      Top             =   360
      Width           =   120
   End
   Begin VB.Image picRO 
      Height          =   420
      Left            =   7200
      Picture         =   "frmVista.frx":2A0F1
      Top             =   0
      Width           =   120
   End
   Begin VB.Image picLO 
      Height          =   420
      Left            =   0
      Picture         =   "frmVista.frx":2A3D3
      Top             =   0
      Width           =   120
   End
   Begin VB.Image picO 
      Height          =   420
      Left            =   120
      Picture         =   "frmVista.frx":2A6B5
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7080
   End
End
Attribute VB_Name = "frmVista"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public iHigh As Integer
Public iWide As Integer
Public iTop As Integer
Public iLeft As Integer
Public MinHeight As Integer
Public MinWidth As Integer

Private Sub DrawWindow()
picLO.Top = 0
picLO.Left = 0

picO.Top = 0
picO.Left = picLO.Width
picO.Width = Me.Width - picLO.Width - picRO.Width

picRO.Top = 0
picRO.Left = picLO.Width + picO.Width

picL.Top = picLO.Height
picL.Left = 0
picL.Height = Me.Height - picLO.Height - picLU.Height

picR.Top = picRO.Height
picR.Left = Me.Width - picR.Width
picR.Height = Me.Height - picRO.Height - picRU.Height

picLU.Top = picLO.Height + picR.Height
picLU.Left = 0

picU.Top = Me.Height - picU.Height
picU.Left = picLU.Width
picU.Width = Me.Width - picLU.Width - picRU.Width

picRU.Top = picRO.Height + picR.Height
picRU.Left = picLU.Width + picU.Width

lblTitel.Width = Me.Width - lblTitel.Left - picR.Width

picTitel.Top = 0
picTitel.Height = picO.Height
picTitel.Width = Me.Width

picClose.Top = 110
picMax.Top = 110
picMin.Top = 110
picClose.Left = Me.Width - picClose.Width - 140
picMax.Left = picClose.Left - picMax.Width - 65
picMin.Left = picMax.Left - picMin.Width - 65

picMin.Picture = picMin_inaktiv.Picture
picMax.Picture = picMax_inaktiv.Picture
picClose.Picture = picClose_inaktiv.Picture
End Sub

Private Sub Form_Load()
DrawWindow
End Sub

Private Sub picMin_Click()
Me.WindowState = vbMinimized
End Sub

Private Sub picMax_Click()
If Not Me.WindowState = vbMaximized Then
  iHigh = Me.Height
  iWide = Me.Width
  iTop = Me.Top
  iLeft = Me.Left
  Me.WindowState = vbMaximized
  picRU.MousePointer = 0
Else
  Me.WindowState = vbNormal
  picRU.MousePointer = 8
End If

If Me.WindowState = vbNormal Then
  Me.Height = iHigh
  Me.Width = iWide
  Me.Top = iTop
  Me.Left = iLeft
End If
DrawWindow
End Sub

Private Sub picClose_Click()
Unload Me
End Sub

Private Sub picTitel_MouseMove(Button As Integer, Shift As Integer, _
  X As Single, Y As Single)

  ' Verschieben der rahmenlosen Form
  If Not Me.WindowState = vbMaximized Then
    Call MoveControl(Me, Button, Shift, X, Y)
  End If
  ' Inaktiv Picture setzen
  picMin.Picture = picMin_inaktiv.Picture
  picMax.Picture = picMax_inaktiv.Picture
  picClose.Picture = picClose_inaktiv.Picture
End Sub

Public Sub MoveControl(ctrControl As Object, Button As Integer, _
  Shift As Integer, X As Single, Y As Single)
  Static OldX As Single
  Static OldY As Single
    
  If Not Button = 1 Then
    OldX = X
    OldY = Y
  Else
    ' Wenn rechte Maus-Taste gedrückt, dann Elemente verschieben.
    ctrControl.Left = ctrControl.Left + (X - OldX)
    ctrControl.Top = ctrControl.Top + (Y - OldY)
  End If
End Sub

Private Sub picRU_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
  If Not Me.WindowState = vbMaximized Then
    Call ResizeControl(Me, Button, Shift, X, Y)
  End If
End Sub

Public Sub ResizeControl(ctrControl As Object, Button As Integer, _
  Shift As Integer, X As Single, Y As Single)
  MinHeight = picO.Height + picU.Height + 15
  MinWidth = picL.Width + picMin.Width + 65 + picMax.Width + 65 + picClose.Width + picR.Width
 
  Static OldX As Single
  Static OldY As Single
    
  If Not Button = 1 Then
    OldX = X
    OldY = Y
  Else
    ' Wenn rechte Maus-Taste gedrückt, dann Elemente verschieben.
    If ctrControl.Width + (X - OldX) > MinWidth Then
      ctrControl.Width = ctrControl.Width + (X - OldX)
    Else
      ctrControl.Width = MinWidth
    End If
    If ctrControl.Height + (Y - OldY) > MinHeight Then
      ctrControl.Height = ctrControl.Height + (Y - OldY)
    Else
      ctrControl.Height = MinHeight
    End If
  End If
  DrawWindow
End Sub

Private Sub picMin_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
picMin.Picture = picMin_aktiv.Picture
End Sub

Private Sub picMax_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
picMax.Picture = picMax_aktiv.Picture
End Sub

Private Sub picClose_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
picClose.Picture = picClose_aktiv.Picture
End Sub

