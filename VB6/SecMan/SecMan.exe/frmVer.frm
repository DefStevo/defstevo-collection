VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmVer 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Security Manager - Veranstaltung"
   ClientHeight    =   4065
   ClientLeft      =   45
   ClientTop       =   315
   ClientWidth     =   9090
   Icon            =   "frmVer.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4065
   ScaleWidth      =   9090
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin VB.Frame grpZeit 
      Caption         =   "Zeiten"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2295
      Left            =   120
      TabIndex        =   25
      Top             =   1200
      Width           =   4335
      Begin sevListBox.roListBox lstZeit 
         Height          =   1455
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   4125
         _ExtentX        =   7276
         _ExtentY        =   2566
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
         HideColumnHeaders=   -1  'True
         ColumnCount     =   4
         ColWidth1       =   1000
         ColType1        =   1
         ColWidth2       =   1000
         ColType2        =   2
         ColWidth3       =   1000
         ColType3        =   1
         ColWidth4       =   1020
         ColType4        =   2
         MustUpdate      =   -1  'True
      End
      Begin sevCommand3.Command cmdHinz 
         Height          =   255
         Left            =   3960
         TabIndex        =   10
         Top             =   480
         Width           =   255
         _ExtentX        =   450
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
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16053492
         BackColorFrom   =   15461355
         BackColorTo     =   14145495
         BackColorCheckedFrom=   14145495
         BackColorCheckedTo=   15461355
         BackColorDownFrom=   14145495
         BackColorDownTo =   15461355
         BackColorHoverFrom=   16577247
         BackColorHoverTo=   16309675
         BorderColor     =   9408398
         BorderColorDisabled=   11907757
         BorderColorFocus=   16698372
         BorderColorHover=   11632444
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
         Caption         =   ""
         Image           =   6606
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   0
         Left            =   2040
         TabIndex        =   26
         Top             =   240
         Width           =   1935
         _ExtentX        =   3413
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
         ForeColor       =   0
         Caption         =   "Ende:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText BegDat 
         Height          =   285
         Left            =   120
         TabIndex        =   6
         Top             =   480
         Width           =   1215
         _ExtentX        =   2143
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
            Name            =   "Century Gothic"
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
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   2
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         ShowButton      =   -1  'True
         Text            =   "01.01.2007"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText EndDat 
         Height          =   285
         Left            =   2040
         TabIndex        =   8
         Top             =   480
         Width           =   1215
         _ExtentX        =   2143
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
            Name            =   "Century Gothic"
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
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   2
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         ShowButton      =   -1  'True
         Text            =   "01.01.2007"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   7
         Left            =   120
         TabIndex        =   27
         Top             =   240
         Width           =   1935
         _ExtentX        =   3413
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
         ForeColor       =   0
         Caption         =   "Beginn:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText BegZeit 
         Height          =   285
         Left            =   1320
         TabIndex        =   7
         Top             =   480
         Width           =   735
         _ExtentX        =   1296
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
            Name            =   "Century Gothic"
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
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   6
         MaxLength       =   5
         PopUpFloskel    =   0   'False
         Text            =   "00:00"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText EndZeit 
         Height          =   285
         Left            =   3240
         TabIndex        =   9
         Top             =   480
         Width           =   735
         _ExtentX        =   1296
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
            Name            =   "Century Gothic"
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
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   6
         MaxLength       =   5
         PopUpFloskel    =   0   'False
         Text            =   "00:00"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin VB.Frame grpAnm 
      Caption         =   "Anmerkung"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2055
      Left            =   4680
      TabIndex        =   24
      Top             =   1440
      Width           =   4335
      Begin sevTextBox.sevText Anm 
         Height          =   1725
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   3043
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
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CaptionAlignment=   0
         CheckMarkColor  =   2203937
         MultiLine       =   -1  'True
         PopUpFloskel    =   0   'False
         ScrollBars      =   2
         Text            =   "Anm"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin VB.Frame grpName 
      Caption         =   "Name"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      TabIndex        =   18
      Top             =   0
      Width           =   4335
      Begin sevTextBox.sevText VName 
         Height          =   285
         Left            =   1200
         TabIndex        =   0
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
            Name            =   "Century Gothic"
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
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "VName"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   11
         Left            =   120
         TabIndex        =   19
         Top             =   240
         Width           =   1335
         _ExtentX        =   2355
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
         ForeColor       =   0
         Caption         =   "Name:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.Command cmdKd 
         Height          =   255
         Left            =   3960
         TabIndex        =   1
         Top             =   720
         Width           =   255
         _ExtentX        =   450
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
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16053492
         BackColorFrom   =   15461355
         BackColorTo     =   14145495
         BackColorCheckedFrom=   14145495
         BackColorCheckedTo=   15461355
         BackColorDownFrom=   14145495
         BackColorDownTo =   15461355
         BackColorHoverFrom=   16577247
         BackColorHoverTo=   16309675
         BorderColor     =   9408398
         BorderColorDisabled=   11907757
         BorderColorFocus=   16698372
         BorderColorHover=   11632444
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
         Caption         =   ""
         Image           =   6419
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText Kunde 
         Height          =   285
         Left            =   1200
         TabIndex        =   20
         TabStop         =   0   'False
         Top             =   720
         Width           =   2775
         _ExtentX        =   4895
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
            Name            =   "Century Gothic"
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
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckBoxEnabled =   0   'False
         CheckMarkColor  =   32768
         Enabled         =   0   'False
         ForeColor       =   4210752
         ForeColorDisabled=   4210752
         ForeColorFocus  =   4210752
         PopUpFloskel    =   0   'False
         Text            =   "Kunde"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   8
         Left            =   120
         TabIndex        =   21
         Top             =   720
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
         ForeColor       =   0
         Caption         =   "Kunde:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText KdId 
         Height          =   285
         Left            =   960
         TabIndex        =   22
         TabStop         =   0   'False
         Top             =   720
         Visible         =   0   'False
         Width           =   255
         _ExtentX        =   450
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
         Text            =   "0"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin VB.Frame grpAdr 
      Caption         =   "Anschrift"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Left            =   4680
      TabIndex        =   15
      Top             =   0
      Width           =   4335
      Begin sevTextBox.sevText Adr 
         Height          =   285
         Left            =   1200
         TabIndex        =   2
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
            Name            =   "Century Gothic"
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
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "Adr"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText PLZ 
         Height          =   285
         Left            =   1200
         TabIndex        =   3
         Top             =   600
         Width           =   720
         _ExtentX        =   1270
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
            Name            =   "Century Gothic"
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
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "PLZ"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Ort 
         Height          =   285
         Left            =   2040
         TabIndex        =   4
         Top             =   600
         Width           =   2175
         _ExtentX        =   3836
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
            Name            =   "Century Gothic"
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
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "Ort"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   6
         Left            =   120
         TabIndex        =   16
         Top             =   600
         Width           =   1095
         _ExtentX        =   1931
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
         ForeColor       =   0
         Caption         =   "PLZ/Ort:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   2
         Left            =   120
         TabIndex        =   17
         Top             =   240
         Width           =   1095
         _ExtentX        =   1931
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
         ForeColor       =   0
         Caption         =   "Anschrift:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText SP 
         Height          =   285
         Left            =   1200
         TabIndex        =   5
         Top             =   960
         Width           =   3015
         _ExtentX        =   5318
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
            Name            =   "Century Gothic"
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
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "SP"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   23
         Top             =   960
         Width           =   1095
         _ExtentX        =   1931
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
         ForeColor       =   0
         Caption         =   "Schauplatz:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   13
      Top             =   3600
      Width           =   1995
      _ExtentX        =   3519
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
      BackColorFrom   =   15461355
      BackColorTo     =   14145495
      BackColorCheckedFrom=   14145495
      BackColorCheckedTo=   15461355
      BackColorDownFrom=   14145495
      BackColorDownTo =   15461355
      BackColorHoverFrom=   16577247
      BackColorHoverTo=   16309675
      BorderColor     =   9408398
      BorderColorDisabled=   11907757
      BorderColorFocus=   16698372
      BorderColorHover=   11632444
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
      Caption         =   "&Speichern"
      Filename        =   "Z:\DEV\SecMan\Icons\UserAdd.ico"
      Image           =   6122
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   6960
      TabIndex        =   14
      Top             =   3600
      Width           =   1995
      _ExtentX        =   3519
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
      BackColorFrom   =   15461355
      BackColorTo     =   14145495
      BackColorCheckedFrom=   14145495
      BackColorCheckedTo=   15461355
      BackColorDownFrom=   14145495
      BackColorDownTo =   15461355
      BackColorHoverFrom=   16577247
      BackColorHoverTo=   16309675
      BorderColor     =   9408398
      BorderColorDisabled=   11907757
      BorderColorFocus=   16698372
      BorderColorHover=   11632444
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
Attribute VB_Name = "frmVer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Dim RsKd As Recordset
Dim RSZeit As Recordset
Dim i As Integer

'Alle Felder leeren
VName.Text = ""
Adr.Text = ""
PLZ.Text = ""
Ort.Text = ""
SP.Text = ""
BegDat.Text = Date 'heutiges Datum
BegZeit.Text = FormatDateTime(Time, vbShortTime) 'Zeit jetzt
EndDat.Text = Date 'heutiges Datum
EndZeit.Text = FormatDateTime(Time, vbShortTime) 'Zeit jetzt
Anm.Text = ""
KdId.Text = ""
Kunde.Text = ""

'Aufruf Prüfen ob Aufruf 2 bestehender Datensatz
If Aufruf = 2 Then
    'Felder mit den Werten aus der Tabelle füllen
    VName.Text = RS("VName").Value
    Adr.Text = RS("Adr").Value
    PLZ.Text = RS("PLZ").Value
    Ort.Text = RS("Ort").Value
    SP.Text = RS("SP").Value
    Anm.Text = RS("Anm").Value
    KdId.Text = RS("KdId").Value
    
    'Sql Select wird in den strSQL geschrieben
    strSQL = "select VName, NName from KD where KdId=" & KdId.Text
  
  'Tabelle KD wird mit den oa. Kriterien geöffnet
  Set RsKd = DBSecMan.OpenRecordset(strSQL)
  
    'Feld Kunde wird befüllt
    Kunde.Text = RsKd("VName").Value & " " & RsKd("NName").Value
   
    'Sql Select wird in den strSQL geschrieben
    strSQL = "select * from VERZeit where VerId=" & RS("VerId").Value

  'Tabelle VERZeit wird mit den oa. Kriterien geöffnet
  Set RSZeit = DBSecMan.OpenRecordset(strSQL)

  'Prüfen ob Datensätze in VERZeit vorhanden sind
  If Not RSZeit.BOF And Not RSZeit.EOF Then
      'Wird verwendet um die Datensätze zählen zu lassen und die Funktion RecordCount verwenden zu können
      RSZeit.MoveLast
      RSZeit.MoveFirst
    
    'Schleife zum befüllen der lstZeit
    For i = 1 To RSZeit.RecordCount
        'Befehl zum hinzufügen von Datensätzen
        lstZeit.AddItem i, RSZeit("BegDat").Value & vbTab & _
                           RSZeit("BegZeit").Value & vbTab & _
                           RSZeit("EndDat").Value & vbTab & _
                           RSZeit("EndZeit").Value
        'Nächster Datensatz
        RSZeit.MoveNext
        'Liste aktualisieren
        lstZeit.Refresh
    Next i
  End If
End If

End Sub

Private Sub cmdHinz_Click()
'Prüfen ob Beginndatum befüllt ist
If BegDat.Value = "" Then
    BegDat.SetFocus
'Prüfen ob Beginnzeit befüllt ist
ElseIf BegZeit.Value = "" Then
    BegZeit.SetFocus
'Prüfen ob Enddatum befüllt ist
ElseIf EndDat.Value = "" Then
    EndDat.SetFocus
'Prüfen ob Endzeit befüllt ist
ElseIf EndZeit.Value = "" Then
    EndZeit.SetFocus
'Prüfen ob Enddatum größer Beginndatum
ElseIf EndDat.Value < BegDat.Value Then
    EndDat.Value = BegDat.Value
    EndDat.SetFocus
'Prüfen ob Endzeit größer Beginnzeit wenn Beginndatum = Enddatum
ElseIf EndDat.Value = BegDat.Value And EndZeit.Value < BegZeit.Value Then
    EndZeit.Value = BegZeit.Value
    EndZeit.SetFocus
Else
    'Liste befüllen
    lstZeit.AddItem lstZeit.ListCount + 1, BegDat.Value & vbTab & _
                                           BegZeit.Value & vbTab & _
                                           EndDat.Value & vbTab & _
                                            EndZeit.Value
    'Liste aktualisieren
    lstZeit.Refresh
End If
BegDat.SetFocus

End Sub

Private Sub lstZeit_DblClick()
'Datensatz wird aus der lstZeit gelöscht
lstZeit.RemoveItem (lstZeit.ListIndex)

End Sub

Private Sub cmdKd_Click()
frmVerKdListe.Show

End Sub

Private Sub cmdSpeichern_Click()
Dim Fehler As Integer
Dim EinMeld As String
'Auf Anfangswert 0 setzen
Fehler = 0
EinMeld = "Bitte Fehlerhafte Eingabe korrigieren" & vbCrLf & vbCrLf

'Alle Feldhintergründe auf Weiß stellen
VName.BackColor = vbWhite
Adr.BackColor = vbWhite
PLZ.BackColor = vbWhite
Ort.BackColor = vbWhite
SP.BackColor = vbWhite
Kunde.BackColor = vbWhite

'Prüfen ob der Vorname hinterlegt ist
If VName.Text = "" Then
    VName.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Veranstaltungsname muss befüllt sein" & vbCrLf
End If

'Prüfen ob die Anschrift befüllt ist
If Adr.Text = "" Then
    Adr.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Anschrift muss befüllt sein" & vbCrLf
End If

'Prüfung ob PLZ befüllt ist
If PLZ.Text = "" Then
    PLZ.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - PLZ muss befüllt sein" & vbCrLf
'Prüfung ob PLZ nummerisch ist
ElseIf IsNumeric(PLZ.Text) = False Then
    PLZ.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - PLZ muss nummerisch sein" & vbCrLf
End If

'Prüfung ob Ort befüllt ist
If Ort.Text = "" Then
    Ort.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Ort muss befüllt sein" & vbCrLf
End If

'Prüfung ob Schauplatz angegeben ist
If SP.Text = "" Then
    SP.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Schauplatz muss hinterlegt sein" & vbCrLf
End If

'Prüfung ob Kunde hinterlegt ist
If Kunde.Text = "" Then
    Kunde.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Kein Veranstalter hinterlegt" & vbCrLf
End If

If Fehler = 0 Then
    SpeicherVer
Else
    MsgBox EinMeld, vbInformation + vbOKOnly, "Fehlerhafte Eingabe"
End If

End Sub

Private Sub SpeicherVer()
Dim strVerID As Integer
Dim i As Integer

If Aufruf = 1 Then
    'Tabelle Ver öffnen
    Set RS = DBSecMan.OpenRecordset("VER")
    'Neuen leeren Datensatz anfügen
    RS.AddNew
Else
    'Recordset in den Editmode stellen
    RS.Edit
End If

'Tabelle mit den Feldwerten befüllen
RS("VName").Value = VName.Text
RS("Adr").Value = Adr.Text
RS("PLZ").Value = PLZ.Text
RS("Ort").Value = Ort.Text
RS("SP").Value = SP.Text
RS("Anm").Value = Anm.Text
RS("KdId").Value = KdId.Text
RS("Stat").Value = 0

RS.Update
RS.MoveLast

'VerID in Variable schreiben
strVerID = RS("VerId").Value

'Alle Datensätze mit derselben VerId aus der Tabelle VERZeit löschen
DBSecMan.Execute "delete from VERZeit where VerId=" & strVerID
    
'Tabelle VERZeit öffnen
Set RS = DBSecMan.OpenRecordset("VERZeit")

'Zeiten in Tabelle VerZeit mittels Schleife eintragen
For i = 1 To lstZeit.ListCount
    'Neuen leeren Datensatz anfügen
    RS.AddNew
    RS("VerId").Value = strVerID
    RS("BegDat").Value = lstZeit.SubItems(i, 1)
    RS("BegZeit").Value = lstZeit.SubItems(i, 2)
    RS("EndDat").Value = lstZeit.SubItems(i, 3)
    RS("EndZeit").Value = lstZeit.SubItems(i, 4)
    'Recordset aktualisieren
    RS.Update
Next i

'Recordset schließen
RS.Close

Unload Me

End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub

Private Sub Form_Unload(Cancel As Integer)
'Aufruf auf 0 Stellen
Aufruf = 0

'Im VerStamm die Liste neu laden
frmVerStamm.ZeigeVer

End Sub

Private Sub PLZ_LostFocus()
Dim RsPLZ As Recordset

If IsNumeric(PLZ.Text) = True Then
  strSQL = "Select * from PLZ where PLZ=" & PLZ.Text
  Set RsPLZ = DBSecMan.OpenRecordset(strSQL)
  
  If RsPLZ.BOF = False And RsPLZ.EOF = False Then
    Ort.Text = RsPLZ("Ort").Value
  Else
    Ort.Text = ""
  End If
Else
  Ort.Text = ""
End If
End Sub
