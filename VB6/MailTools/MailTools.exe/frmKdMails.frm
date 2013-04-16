VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmKdMails 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "E-Mail Tools - KdMails"
   ClientHeight    =   3705
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9225
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmKdMails.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3705
   ScaleWidth      =   9225
   StartUpPosition =   1  'Fenstermitte
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   500
      Left            =   5400
      Top             =   3240
   End
   Begin VB.TextBox txtMail 
      BackColor       =   &H00C0F1FF&
      BorderStyle     =   0  'Kein
      Enabled         =   0   'False
      ForeColor       =   &H00404040&
      Height          =   615
      Left            =   0
      MultiLine       =   -1  'True
      TabIndex        =   0
      Top             =   0
      Width           =   9255
   End
   Begin sevListBox.roListBox lstMail 
      Height          =   2535
      Left            =   0
      TabIndex        =   1
      Top             =   600
      Width           =   9240
      _ExtentX        =   16298
      _ExtentY        =   4471
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   12644863
      ForeColor       =   -2147483640
      GridLines       =   -1  'True
      Sorted          =   -1  'True
      SortKey         =   1
      SortOrder       =   1
      ColumnCount     =   6
      ColText1        =   "Betreff"
      ColWidth1       =   5900
      ColText2        =   "Kunde"
      ColWidth2       =   1000
      ColText3        =   "Gesendet"
      ColWidth3       =   2000
      ColText4        =   "EntryID - EMail"
      ColText5        =   "EntryID- Ordner"
      ColText6        =   "Ordnername"
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdMove 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   3240
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty MenuFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColorDisabled=   16053492
      BackColorDisabledFrom=   15461355
      BackColorDisabledTo=   15461355
      BackColorFrom   =   12644863
      BackColorTo     =   10086655
      BackColorCheckedFrom=   10086655
      BackColorCheckedTo=   4773631
      BackColorDownFrom=   10086655
      BackColorDownTo =   4773631
      BackColorHoverFrom=   16777215
      BackColorHoverTo=   12644863
      BorderColor     =   4773631
      BorderColorDisabled=   4773631
      BorderColorFocus=   4773631
      BorderColorHover=   4773631
      MenuBackColor   =   16119285
      MenuBackColorChecked=   16380124
      MenuBackColorHover=   16380124
      MenuBorderColor =   14472646
      MenuCheckMarkColorFrom=   15856113
      MenuCheckMarkColorTo=   15856113
      MenuForeColor   =   -2147483640
      MenuForeColorHover=   -2147483640
      MenuStyle       =   5
      BorderStyle     =   2
      ButtonStyle     =   5
      Caption         =   "&Verschieben"
      Enabled         =   0   'False
      Image           =   6942
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdMoveAll 
      Height          =   375
      Left            =   2760
      TabIndex        =   3
      Top             =   3240
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty MenuFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColorDisabled=   16053492
      BackColorDisabledFrom=   15461355
      BackColorDisabledTo=   15461355
      BackColorFrom   =   12644863
      BackColorTo     =   10086655
      BackColorCheckedFrom=   10086655
      BackColorCheckedTo=   4773631
      BackColorDownFrom=   10086655
      BackColorDownTo =   4773631
      BackColorHoverFrom=   16777215
      BackColorHoverTo=   12644863
      BorderColor     =   4773631
      BorderColorDisabled=   4773631
      BorderColorFocus=   4773631
      BorderColorHover=   4773631
      MenuBackColor   =   16119285
      MenuBackColorChecked=   16380124
      MenuBackColorHover=   16380124
      MenuBorderColor =   14472646
      MenuCheckMarkColorFrom=   15856113
      MenuCheckMarkColorTo=   15856113
      MenuForeColor   =   -2147483640
      MenuForeColorHover=   -2147483640
      MenuStyle       =   5
      BorderStyle     =   2
      ButtonStyle     =   5
      Caption         =   "&Alle Verschieben"
      Enabled         =   0   'False
      Image           =   6943
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   6600
      TabIndex        =   4
      Top             =   3240
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty MenuFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColorDisabled=   16053492
      BackColorDisabledFrom=   15461355
      BackColorDisabledTo=   15461355
      BackColorFrom   =   12644863
      BackColorTo     =   10086655
      BackColorCheckedFrom=   10086655
      BackColorCheckedTo=   4773631
      BackColorDownFrom=   10086655
      BackColorDownTo =   4773631
      BackColorHoverFrom=   16777215
      BackColorHoverTo=   12644863
      BorderColor     =   4773631
      BorderColorDisabled=   4773631
      BorderColorFocus=   4773631
      BorderColorHover=   4773631
      MenuBackColor   =   16119285
      MenuBackColorChecked=   16380124
      MenuBackColorHover=   16380124
      MenuBorderColor =   14472646
      MenuCheckMarkColorFrom=   15856113
      MenuCheckMarkColorTo=   15856113
      MenuForeColor   =   -2147483640
      MenuForeColorHover=   -2147483640
      MenuStyle       =   5
      BorderStyle     =   2
      ButtonStyle     =   5
      Caption         =   "B&eenden"
      Image           =   6953
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmKdMails"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmHilfe.Hilfe Me.Name
End Sub

Private Sub Form_Load()
txtMail.Text = "E-Mails werden analysiert bitte warten ..."
lstMail.Enabled = False
lstMail.BackColor = &H8000000F
Timer1.Enabled = True
End Sub

Private Sub Timer1_Timer()
GetParameter
SucheMails
Timer1.Enabled = False
End Sub

Private Sub lstMail_DblClick()
MoveMail lstMail.ListIndex
End Sub

Private Sub cmdMove_Click()
MoveMail lstMail.ListIndex
End Sub

Private Sub cmdMoveAll_Click()
For i = 1 To lstMail.ListCount
  MoveMail 1
Next i
End Sub

Private Sub cmdEnde_Click()
Unload Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
If frmMain.Visible = False Then
  Unload frmMain
End If
End Sub


