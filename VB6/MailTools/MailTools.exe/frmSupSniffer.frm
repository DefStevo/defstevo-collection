VERSION 5.00
Object = "{2E7D099B-10DF-4D08-AC5A-B42F7800B5E6}#2.4#0"; "sevtrayicon.ocx"
Begin VB.Form frmSupSniffer 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "E-Mail Tools - Support Sniffer"
   ClientHeight    =   510
   ClientLeft      =   -1410
   ClientTop       =   -1005
   ClientWidth     =   1500
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmSupSniffer.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   510
   ScaleWidth      =   1500
   ShowInTaskbar   =   0   'False
   Visible         =   0   'False
   Begin VB.Timer Timer 
      Interval        =   5000
      Left            =   960
      Top             =   0
   End
   Begin sevTrayIcon.sevTray sevTray 
      Left            =   0
      Top             =   0
      _ExtentX        =   1720
      _ExtentY        =   873
      Icon            =   "frmSupSniffer.frx":1601A
      MustUpdate      =   -1  'True
   End
End
Attribute VB_Name = "frmSupSniffer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
frmMain.Hide
sevTray.ShowInTray
Me.Visible = False
Me.Hide
Timer.Enabled = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
frmMain.Show
End Sub

Private Sub sevTray_Click(Button As Integer)
If Button = vbRightButton Then
  With sevTray
    .AddMenuItem "Support Sniffer beenden", "Ende"
    .AddMenuItem "Mails gelesen", "Lese"
    .PopupMenu
    End With
End If
End Sub

Private Sub sevTray_DblClick(Button As Integer)
sevTray.IconStyle = sevSingleIcon
i = 0
If iTyp = 0 Then
  Gelesen
  OpenFolder
Else
  frmSupSnifferTab.Show
End If
End Sub

Private Sub sevTray_MenuClick(ByVal Index As Long, ByVal Key As String)
Select Case Key
  Case "Ende"
    Unload frmSupSniffer
    Unload frmSupSnifferTab
  Case "Lese"
    sevTray.IconStyle = sevSingleIcon
    i = 0
    Gelesen
End Select
End Sub

Private Sub Timer_Timer()
If GetSettings = True Then
  If OpenRs = True Then
    Sniff
  End If
End If
End Sub
