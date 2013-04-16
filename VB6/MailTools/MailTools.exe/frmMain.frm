VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmMain 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "E-Mail Tools - Outlook 2000, Outlook XP und Outlook 2003"
   ClientHeight    =   4170
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8520
   Icon            =   "frmMain.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4170
   ScaleWidth      =   8520
   StartUpPosition =   1  'Fenstermitte
   Begin sevTextBox.sevText txt 
      Height          =   255
      Index           =   1
      Left            =   3960
      TabIndex        =   0
      Top             =   1680
      Width           =   4455
      _ExtentX        =   7858
      _ExtentY        =   450
      VBA             =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty CaptionFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   12644863
      BackColorDisabled=   12644863
      BackColorFocus  =   12644863
      BorderColor     =   4773631
      BorderStyle     =   0
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      ForeColor       =   4210752
      ForeColorDisabled=   4210752
      ForeColorFocus  =   4210752
      MultiLine       =   -1  'True
      PopUpFloskel    =   0   'False
      Text            =   "Prüft den Supportordner auf neue E-Mail Nachrichten."
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevTextBox.sevText txt 
      Height          =   495
      Index           =   0
      Left            =   3960
      TabIndex        =   1
      Top             =   360
      Width           =   4455
      _ExtentX        =   7858
      _ExtentY        =   873
      VBA             =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty CaptionFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   12644863
      BackColorDisabled=   12644863
      BackColorFocus  =   12644863
      BorderColor     =   4773631
      BorderStyle     =   0
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      ForeColor       =   4210752
      ForeColorDisabled=   4210752
      ForeColorFocus  =   4210752
      MultiLine       =   -1  'True
      PopUpFloskel    =   0   'False
      Text            =   "Willkommen bei den E-Mail Tools welches Programm wollen Sie starten."
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevTextBox.sevText txt 
      Height          =   495
      Index           =   2
      Left            =   3960
      TabIndex        =   2
      Top             =   2640
      Width           =   4455
      _ExtentX        =   7858
      _ExtentY        =   873
      VBA             =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty CaptionFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   12644863
      BackColorDisabled=   12644863
      BackColorFocus  =   12644863
      BorderColor     =   4773631
      BorderStyle     =   0
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      ForeColor       =   4210752
      ForeColorDisabled=   4210752
      ForeColorFocus  =   4210752
      MultiLine       =   -1  'True
      PopUpFloskel    =   0   'False
      Text            =   "Verschiebt alle gesendeten Kundenmails in den dazugehörigen Ordner."
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.Command cmdKdMails 
      Height          =   375
      Left            =   4920
      TabIndex        =   3
      Top             =   2160
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
      Caption         =   "&Kd Mails"
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txt 
      Height          =   255
      Index           =   3
      Left            =   3960
      TabIndex        =   4
      Top             =   3840
      Width           =   4455
      _ExtentX        =   7858
      _ExtentY        =   450
      VBA             =   -1  'True
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty CaptionFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   12644863
      BackColorDisabled=   12644863
      BackColorFocus  =   12644863
      BorderColor     =   4773631
      BorderStyle     =   0
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      ForeColor       =   4210752
      ForeColorDisabled=   4210752
      ForeColorFocus  =   4210752
      MultiLine       =   -1  'True
      PopUpFloskel    =   0   'False
      Text            =   "Einstellungen für Support Sniffer und Kd Mails."
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.Command cmdOptionen 
      Height          =   375
      Left            =   4920
      TabIndex        =   5
      Top             =   3360
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
      Caption         =   "&Optionen"
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdSupSniff 
      Height          =   375
      Left            =   4920
      TabIndex        =   6
      Top             =   1200
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
      Caption         =   "&Support Sniffer"
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command mnuDatei 
      Height          =   255
      Left            =   0
      TabIndex        =   7
      Top             =   0
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   450
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
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColorDisabledFrom=   12644863
      BackColorDisabledTo=   12644863
      BackColorFrom   =   12644863
      BackColorTo     =   12644863
      BackColorCheckedFrom=   10086655
      BackColorCheckedTo=   10086655
      BackColorDownFrom=   10086655
      BackColorDownTo =   10086655
      BackColorHoverFrom=   10086655
      BackColorHoverTo=   10086655
      BorderColor     =   12644863
      BorderColorDisabled=   12644863
      BorderColorFocus=   12644863
      BorderColorHover=   12644863
      MenuBackColor   =   12644863
      MenuBackColorChecked=   12644863
      MenuBackColorHover=   4773631
      MenuBorderColor =   4773631
      MenuCheckMarkColorFrom=   10086655
      MenuCheckMarkColorTo=   4773631
      MenuForeColor   =   -2147483640
      MenuForeColorHover=   -2147483640
      MenuStyle       =   4
      BorderStyle     =   0
      ButtonStyle     =   4
      Caption         =   "&Datei"
      DropDownButton  =   -1  'True
      Version3        =   -1  'True
      MenuButtonCount =   5
      Menu1_Caption   =   "&Support Sniffer"
      Menu1_Filename  =   "C:\Dokumente und Einstellungen\SDehner\Desktop\vb6\Favorites.ico"
      Menu1_Picture   =   "frmMain.frx":1601A
      Menu1_Key       =   "SupSniff"
      Menu1_Picture   =   "frmMain.frx":1636C
      Menu1_UseDefaultMaskColor=   -1  'True
      Menu2_Caption   =   "&Kd Mails"
      Menu2_Filename  =   "C:\Dokumente und Einstellungen\SDehner\Desktop\vb6\Favorites.ico"
      Menu2_Picture   =   "frmMain.frx":166BE
      Menu2_Key       =   "KdMail"
      Menu2_Picture   =   "frmMain.frx":16A10
      Menu2_UseDefaultMaskColor=   -1  'True
      Menu3_Caption   =   "&Optionen"
      Menu3_Filename  =   "C:\Dokumente und Einstellungen\SDehner\Desktop\vb6\Favorites.ico"
      Menu3_Picture   =   "frmMain.frx":16D62
      Menu3_Key       =   "Optionen"
      Menu3_Picture   =   "frmMain.frx":170B4
      Menu3_UseDefaultMaskColor=   -1  'True
      Menu4_Caption   =   "-"
      Menu5_Caption   =   "B&eenden"
      Menu5_Image     =   6953
      Menu5_Key       =   "Ende"
      Menu5_Picture   =   "frmMain.frx":17406
      Menu5_UseDefaultMaskColor=   -1  'True
   End
   Begin sevCommand3.Command mnuHilfe 
      Height          =   255
      Left            =   840
      TabIndex        =   8
      Top             =   0
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   450
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
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColorDisabledFrom=   12644863
      BackColorDisabledTo=   12644863
      BackColorFrom   =   12644863
      BackColorTo     =   12644863
      BackColorCheckedFrom=   10086655
      BackColorCheckedTo=   10086655
      BackColorDownFrom=   10086655
      BackColorDownTo =   10086655
      BackColorHoverFrom=   10086655
      BackColorHoverTo=   10086655
      BorderColor     =   12644863
      BorderColorDisabled=   12644863
      BorderColorFocus=   12644863
      BorderColorHover=   12644863
      MenuBackColor   =   12644863
      MenuBackColorChecked=   12644863
      MenuBackColorHover=   4773631
      MenuBorderColor =   4773631
      MenuCheckMarkColorFrom=   10086655
      MenuCheckMarkColorTo=   4773631
      MenuForeColor   =   -2147483640
      MenuForeColorHover=   -2147483640
      MenuStyle       =   4
      BorderStyle     =   0
      ButtonStyle     =   4
      Caption         =   "&Hilfe"
      DropDownButton  =   -1  'True
      Version3        =   -1  'True
      MenuButtonCount =   2
      Menu1_Caption   =   "&Hilfe"
      Menu1_Filename  =   "C:\Dokumente und Einstellungen\SDehner\Desktop\vb6\MailTools\Hilfe.ico"
      Menu1_Picture   =   "frmMain.frx":1783A
      Menu1_Key       =   "Hilfe"
      Menu1_Picture   =   "frmMain.frx":17B8C
      Menu1_UseDefaultMaskColor=   -1  'True
      Menu2_Caption   =   "&Info"
      Menu2_Filename  =   "C:\Dokumente und Einstellungen\SDehner\Desktop\vb6\MailTools\Info.ico"
      Menu2_Picture   =   "frmMain.frx":17EDE
      Menu2_Key       =   "Info"
      Menu2_Picture   =   "frmMain.frx":18230
      Menu2_UseDefaultMaskColor=   -1  'True
   End
   Begin VB.Image Image1 
      Height          =   3675
      Left            =   120
      Picture         =   "frmMain.frx":18582
      Top             =   360
      Width           =   3645
   End
   Begin VB.Line Line1 
      BorderColor     =   &H0048D6FF&
      X1              =   0
      X2              =   8520
      Y1              =   255
      Y2              =   255
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmHilfe.Hilfe Me.Name
End Sub

Private Sub mnuDatei_Click()
mnuDatei.ShowPopUpMenu
End Sub

Private Sub mnuDatei_MenuClick(ByVal Item As Long, ByVal Key As String)
Select Case Key
  Case "SupSniff"
    frmSupSniffer.Show
  Case "KdMail"
    frmKdMails.Show
  Case "Optionen"
    frmOptionen.Show
  Case "Ende"
    Unload frmMain
End Select
End Sub

Private Sub mnuHilfe_Click()
mnuHilfe.ShowPopUpMenu
End Sub

Private Sub mnuHilfe_MenuClick(ByVal Item As Long, ByVal Key As String)
Select Case Key
  Case "Hilfe"
    frmHilfe.Hilfe "index"
  Case "Info"
    frmInfo.Show
End Select
End Sub

Private Sub cmdSupSniff_Click()
frmSupSniffer.Show
End Sub

Private Sub cmdKdMails_Click()
frmKdMails.Show
End Sub

Private Sub cmdOptionen_Click()
frmOptionen.Show
End Sub

Private Sub Form_Unload(Cancel As Integer)
DB.Execute ("Delete * from Sniffer")
Unload frmHilfe
Unload frmInfo
Unload frmKdMails
Unload frmKdMailsLOG
Unload frmOptionen
Unload frmOptionenFoldDB
Unload frmSupSniffer
Unload frmSupSnifferTab
End Sub
