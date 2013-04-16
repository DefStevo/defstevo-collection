VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmDiat 
   BackColor       =   &H80000005&
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Diätenstamm"
   ClientHeight    =   3960
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   3750
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3960
   ScaleWidth      =   3750
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows-Standard
   Begin sevCommand3.Command btnAbbrechen 
      Height          =   375
      Left            =   480
      TabIndex        =   10
      Top             =   3480
      Width           =   375
      _ExtentX        =   661
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
      BackColorDisabledFrom=   -2147483643
      BackColorDisabledTo=   -2147483643
      BackColorFrom   =   -2147483643
      BackColorTo     =   -2147483643
      BackColorCheckedFrom=   -2147483643
      BackColorCheckedTo=   -2147483643
      BackColorDownFrom=   -2147483643
      BackColorDownTo =   -2147483643
      BackColorHoverFrom=   -2147483643
      BackColorHoverTo=   -2147483643
      Caption         =   ""
      Image           =   6400
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText sevText1 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   800
      _ExtentX        =   1402
      _ExtentY        =   503
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
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.Command btnSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   3480
      Width           =   375
      _ExtentX        =   661
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
      BackColorDisabledFrom=   -2147483643
      BackColorDisabledTo=   -2147483643
      BackColorFrom   =   -2147483643
      BackColorTo     =   -2147483643
      BackColorCheckedFrom=   -2147483643
      BackColorCheckedTo=   -2147483643
      BackColorDownFrom=   -2147483643
      BackColorDownTo =   -2147483643
      BackColorHoverFrom=   -2147483643
      BackColorHoverTo=   -2147483643
      Caption         =   ""
      Image           =   6122
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.roLabel roLabel1 
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   735
      _ExtentX        =   1296
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
      BackColor       =   -2147483643
      ForeColor       =   0
      Caption         =   "Land"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevListBox.roListBox lstDiat 
      Height          =   2775
      Left            =   120
      TabIndex        =   5
      TabStop         =   0   'False
      Top             =   720
      Width           =   3500
      _ExtentX        =   6165
      _ExtentY        =   4895
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      GridLines       =   -1  'True
      Sorted          =   -1  'True
      ColumnCount     =   4
      ColText1        =   "Land"
      ColWidth1       =   800
      ColText2        =   "Tag"
      ColWidth2       =   800
      ColText3        =   "Nacht"
      ColWidth3       =   800
      ColText4        =   "Sonstiges"
      ColWidth4       =   800
      MustUpdate      =   -1  'True
   End
   Begin sevTextBox.sevText sevText2 
      Height          =   285
      Left            =   920
      TabIndex        =   1
      Top             =   360
      Width           =   800
      _ExtentX        =   1402
      _ExtentY        =   503
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
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Alignment       =   1
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Format          =   1
      MaxLength       =   2
      PopUpFloskel    =   0   'False
      Text            =   "0,00 €"
      Währung         =   "€"
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.roLabel roLabel2 
      Height          =   255
      Left            =   920
      TabIndex        =   7
      Top             =   120
      Width           =   735
      _ExtentX        =   1296
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
      BackColor       =   -2147483643
      ForeColor       =   0
      Caption         =   "Tag"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText sevText3 
      Height          =   285
      Left            =   1720
      TabIndex        =   2
      Top             =   360
      Width           =   800
      _ExtentX        =   1402
      _ExtentY        =   503
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
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Alignment       =   1
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Format          =   1
      MaxLength       =   2
      PopUpFloskel    =   0   'False
      Text            =   "0,00 €"
      Währung         =   "€"
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.roLabel roLabel3 
      Height          =   255
      Left            =   1720
      TabIndex        =   8
      Top             =   120
      Width           =   735
      _ExtentX        =   1296
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
      BackColor       =   -2147483643
      ForeColor       =   0
      Caption         =   "Nacht"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText sevText4 
      Height          =   285
      Left            =   2520
      TabIndex        =   3
      Top             =   360
      Width           =   800
      _ExtentX        =   1402
      _ExtentY        =   503
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
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty UnitDescrFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Alignment       =   1
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Format          =   1
      MaxLength       =   2
      PopUpFloskel    =   0   'False
      Text            =   "0,00 €"
      Währung         =   "€"
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.roLabel roLabel4 
      Height          =   255
      Left            =   2520
      TabIndex        =   9
      Top             =   120
      Width           =   735
      _ExtentX        =   1296
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
      BackColor       =   -2147483643
      ForeColor       =   0
      Caption         =   "Sonst"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmDiat"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private RSDiat As Recordset

Private Sub Form_Load()
Set RSDiat = DBA.OpenRecordset("Select * from Diat")
RSDiat.MoveLast
RSDiat.MoveFirst
MsgBox RSDiat.RecordCount
RSDiat.AddNew


End Sub

