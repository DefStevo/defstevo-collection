VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmSupSnifferTab 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "E-Mail Tools - Support Sniffer Nachrichten"
   ClientHeight    =   3270
   ClientLeft      =   11880
   ClientTop       =   10815
   ClientWidth     =   7320
   Icon            =   "frmSupSnifferTab.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3270
   ScaleWidth      =   7320
   Begin sevListBox.roListBox lstMails 
      Height          =   2895
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   5106
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
      SortKey         =   2
      SortAuto        =   -1  'True
      ColumnCount     =   4
      ColText1        =   "Von"
      ColWidth1       =   1650
      ColText2        =   "Betreff"
      ColWidth2       =   3645
      ColText3        =   "Datum/Uhrzeit"
      ColWidth3       =   1710
      ColText4        =   "EntryID"
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   2880
      Width           =   7335
      _ExtentX        =   12938
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
      Caption         =   "&Schlieﬂen"
      Image           =   6953
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmSupSnifferTab"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmHilfe.Hilfe Me.Name
End Sub

Private Sub cmdEnde_Click()
lstMails.Clear
Gelesen
Unload Me
End Sub
