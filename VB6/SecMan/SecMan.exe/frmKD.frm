VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmKD 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Security Manager - Kunden"
   ClientHeight    =   6345
   ClientLeft      =   45
   ClientTop       =   315
   ClientWidth     =   9120
   Icon            =   "frmKD.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6345
   ScaleMode       =   0  'Benutzerdefiniert
   ScaleWidth      =   6170.553
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin VB.Frame grpVer 
      Caption         =   "Veranstaltungen"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2775
      Left            =   120
      TabIndex        =   25
      Top             =   3000
      Width           =   8895
      Begin sevListBox.roListBox lstVer 
         Height          =   2415
         Left            =   120
         TabIndex        =   26
         TabStop         =   0   'False
         Top             =   240
         Width           =   8655
         _ExtentX        =   15266
         _ExtentY        =   4260
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
         Enabled         =   0   'False
         GridLines       =   -1  'True
         Sorted          =   -1  'True
         ColumnCount     =   5
         ColText1        =   "Nr"
         ColWidth1       =   485
         ColText2        =   "Name"
         ColWidth2       =   2970
         ColText3        =   "Schauplatz"
         ColWidth3       =   2145
         ColText4        =   "PLZ"
         ColWidth4       =   645
         ColText5        =   "Ort"
         ColWidth5       =   2325
         MustUpdate      =   -1  'True
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
      Height          =   1815
      Left            =   4680
      TabIndex        =   24
      Top             =   1080
      Width           =   4335
      Begin sevTextBox.sevText Anm 
         Height          =   1485
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   2619
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
   Begin VB.Frame grpKontakt 
      Caption         =   "Kontakt"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1815
      Left            =   120
      TabIndex        =   18
      Top             =   1080
      Width           =   4335
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   19
         Top             =   720
         Width           =   975
         _ExtentX        =   1720
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
         Caption         =   "Handy:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
         Begin sevCommand3.roLabel roLabel1 
            Height          =   255
            Index           =   5
            Left            =   0
            TabIndex        =   20
            Top             =   -960
            Width           =   1335
            _ExtentX        =   2355
            _ExtentY        =   450
            BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
               Name            =   "Century Gothic"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            BackColor       =   0
            ForeColor       =   0
            Caption         =   "Anschrift:"
            GradiantStyle   =   0
            ForeColorOnMouseMove=   0
            Version3        =   -1  'True
         End
      End
      Begin sevTextBox.sevText Tel 
         Height          =   285
         Left            =   1200
         TabIndex        =   5
         Top             =   360
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
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "Tel"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Handy 
         Height          =   285
         Left            =   1200
         TabIndex        =   6
         Top             =   720
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
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "Handy"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText EMail 
         Height          =   285
         Left            =   1200
         TabIndex        =   8
         Top             =   1440
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
         CheckBoxEnabled =   0   'False
         CheckMarkColor  =   32768
         PopUpFloskel    =   0   'False
         Text            =   "EMail"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   7
         Left            =   120
         TabIndex        =   21
         Top             =   360
         Width           =   975
         _ExtentX        =   1720
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
         Caption         =   "Telefon:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   8
         Left            =   120
         TabIndex        =   22
         Top             =   1440
         Width           =   975
         _ExtentX        =   1720
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
         Caption         =   "E-Mail:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText Fax 
         Height          =   285
         Left            =   1200
         TabIndex        =   7
         Top             =   1080
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
         Text            =   "Fax"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   12
         Left            =   120
         TabIndex        =   23
         Top             =   1080
         Width           =   975
         _ExtentX        =   1720
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
         Caption         =   "Fax:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
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
      Height          =   975
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
      Height          =   975
      Left            =   120
      TabIndex        =   12
      Top             =   0
      Width           =   4335
      Begin sevTextBox.sevText VName 
         Height          =   285
         Left            =   2040
         TabIndex        =   0
         Top             =   240
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
         Text            =   "VName"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText NName 
         Height          =   285
         Left            =   1200
         TabIndex        =   1
         Top             =   600
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
         BackColor       =   16777215
         BackColorDisabled=   16777215
         BackColorFocus  =   16777215
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         PopUpFloskel    =   0   'False
         Text            =   "NName"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   13
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
         Caption         =   "Nachname:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   11
         Left            =   120
         TabIndex        =   14
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
         Caption         =   "Vorname:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText Anr 
         Height          =   285
         Left            =   1200
         TabIndex        =   27
         Top             =   240
         Width           =   855
         _ExtentX        =   1508
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
         Style           =   0
         ShowButton      =   -1  'True
         Text            =   "Anr"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   10
      Top             =   5880
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
      TabIndex        =   11
      Top             =   5880
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
Attribute VB_Name = "frmKD"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Alle Felder leeren
With Anr
  .AddItem "Firma"
  .AddItem "Frau"
  .AddItem "Herr"
End With

VName.Text = ""
NName.Text = ""
Adr.Text = ""
PLZ.Text = ""
Ort.Text = ""
Tel.Text = ""
Handy.Text = ""
Fax.Text = ""
EMail.Text = ""
Anm.Text = ""
Anr.ListIndex = 0

'Aufruf Prüfen Wenn 2 bestehender Datensatz
If Aufruf = 2 Then
    Dim RsVer As Recordset
    Dim i As Integer
    Set RsVer = DBSecMan.OpenRecordset("select VerId, VName, SP, PLZ, Ort from VER where KdId=" & RS("KdId").Value)
    If Not RsVer.BOF And Not RsVer.EOF Then
      RsVer.MoveLast
      RsVer.MoveFirst
      For i = 1 To RsVer.RecordCount
          lstVer.AddItem RsVer("VerId").Value, RsVer("VerId").Value & vbTab & _
                                               RsVer("VName").Value & vbTab & _
                                               RsVer("SP").Value & vbTab & _
                                               RsVer("PLZ").Value & vbTab & _
                                               RsVer("Ort").Value
          RsVer.MoveNext
      Next i
      lstVer.DeSelectAll
    End If
    
       
    'Felder mit den Werten aus der Tabelle füllen
    VName.Text = RS("VName").Value
    NName.Text = RS("NName").Value
    Adr.Text = RS("Adr").Value
    PLZ.Text = RS("PLZ").Value
    Ort.Text = RS("Ort").Value
    Tel.Text = RS("Tel").Value
    Handy.Text = RS("Handy").Value
    Fax.Text = RS("Fax").Value
    EMail.Text = RS("EMail").Value
    Anm.Text = RS("Anm").Value
    If RS("Anr").Value = "Firma" Then
        Anr.ListIndex = 0
    ElseIf RS("Anr").Value = "Frau" Then
        Anr.ListIndex = 1
    Else
        Anr.ListIndex = 2
    End If
End If

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
Fax.BackColor = vbWhite
EMail.BackColor = vbWhite

'Prüfen ob der Vorname/Firmenname hinterlegt ist
If VName.Text = "" Then
    VName.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- Vorname/Firmenname muss befüllt sein" & vbCrLf
End If

'Prüfen ob die Anschrift befüllt ist
If Adr.Text = "" Then
    Adr.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- Anschrift muss befüllt sein" & vbCrLf
End If

'Prüfung ob PLZ befüllt ist
If PLZ.Text = "" Then
    PLZ.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- PLZ muss befüllt sein" & vbCrLf
'Prüfung ob PLZ nummerisch ist
ElseIf IsNumeric(PLZ.Text) = False Then
    PLZ.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- PLZ muss nummerisch sein" & vbCrLf
End If

'Prüfung ob Ort befüllt ist
If Ort.Text = "" Then
    Ort.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- Ort muss befüllt sein" & vbCrLf
End If

'Prüfung ob Handy bzw. Telefon befüllt ist
If Fax.Text = "" And EMail.Text = "" Then
    Fax.BackColor = vbRed
    EMail.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- Es muss zumindest die Faxnummer und/oder die E-Mail Adresse hinterlegt werden" & vbCrLf
End If

If Anr.Text = "" Then
    Anr.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "- Es muss eine Anrede hinterlegt werden"
End If

If Fehler = 0 Then
    SpeicherKD
Else
    MsgBox EinMeld, vbInformation + vbOKOnly, "Fehlerhafte Eingabe"
End If

End Sub

Private Sub SpeicherKD()

If Aufruf = 1 Then
    'Tabelle MA öffnen
    Set RS = DBSecMan.OpenRecordset("Kd")
    'Neuen leeren Datensatz anfügen
    RS.AddNew
Else
    'Recordset in den Editmode stellen
    RS.Edit
End If

'Tabelle mit den Feldwerten befüllen
RS("VName").Value = VName.Text
RS("NName").Value = NName.Text
RS("Adr").Value = Adr.Text
RS("PLZ").Value = PLZ.Text
RS("Ort").Value = Ort.Text
RS("Tel").Value = Tel.Text
RS("Handy").Value = Handy.Text
RS("Fax").Value = Fax.Text
RS("EMail").Value = EMail.Text
RS("Anm").Value = Anm.Text
RS("Anr").Value = Anr.LineText

'Recordset aktualisieren
RS.Update

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

'Im KdStamm die Liste neu laden
frmKdStamm.ZeigeKD

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
