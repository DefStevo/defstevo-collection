VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmAuft 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Security Manager - Auftrag"
   ClientHeight    =   8265
   ClientLeft      =   45
   ClientTop       =   315
   ClientWidth     =   9855
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8265
   ScaleWidth      =   9855
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin VB.Frame grpZahl 
      Caption         =   "Zahlungsbedingung"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   39
      Top             =   3840
      Width           =   9615
      Begin sevTextBox.sevText Zahl 
         Height          =   285
         Left            =   120
         TabIndex        =   40
         Top             =   240
         Width           =   9015
         _ExtentX        =   15901
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         Text            =   "Zahl"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText cmdZahl 
         Height          =   285
         Left            =   9120
         TabIndex        =   41
         Top             =   240
         Width           =   315
         _ExtentX        =   556
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
            Name            =   "Century Gothic"
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
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         ShowButton      =   -1  'True
         Text            =   "Ver"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText ZahlId 
         Height          =   285
         Left            =   120
         TabIndex        =   42
         TabStop         =   0   'False
         Top             =   240
         Visible         =   0   'False
         Width           =   615
         _ExtentX        =   1085
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   4
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin VB.Frame grpKopf 
      Caption         =   "Kopf"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3735
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   9615
      Begin sevListBox.roListBox lstZeit 
         Height          =   975
         Left            =   120
         TabIndex        =   7
         TabStop         =   0   'False
         Top             =   1440
         Width           =   6135
         _ExtentX        =   10821
         _ExtentY        =   1720
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
         HideColumnHeaders=   -1  'True
         ColumnCount     =   1
         ColText1        =   "Zeit"
         ColWidth1       =   6080
         MustUpdate      =   -1  'True
      End
      Begin sevTextBox.sevText Ver 
         Height          =   285
         Left            =   1440
         TabIndex        =   8
         Top             =   720
         Width           =   3495
         _ExtentX        =   6165
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         Text            =   "Ver"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Kd 
         Height          =   285
         Left            =   1920
         TabIndex        =   9
         TabStop         =   0   'False
         Top             =   2640
         Width           =   3255
         _ExtentX        =   5741
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         Text            =   "Kd"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText VerAnm 
         Height          =   1725
         Left            =   6360
         TabIndex        =   10
         TabStop         =   0   'False
         Top             =   720
         Width           =   3135
         _ExtentX        =   5530
         _ExtentY        =   3043
         VBA             =   -1  'True
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
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
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         MultiLine       =   -1  'True
         PopUpFloskel    =   0   'False
         Text            =   "VerAnm"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   3
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   1215
         _ExtentX        =   2143
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
         Caption         =   "Veranstaltung:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   5
         Left            =   120
         TabIndex        =   12
         Top             =   2640
         Width           =   1815
         _ExtentX        =   3201
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
         Caption         =   "Veranstalter/Kunde:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   6
         Left            =   5280
         TabIndex        =   13
         Top             =   720
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   450
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   0
         Caption         =   "Anmerkung:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText kdAnsch 
         Height          =   285
         Left            =   1920
         TabIndex        =   14
         TabStop         =   0   'False
         Top             =   3000
         Width           =   4335
         _ExtentX        =   7646
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         Text            =   "KdAnsch"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   4
         Left            =   120
         TabIndex        =   15
         Top             =   3000
         Width           =   1815
         _ExtentX        =   3201
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
         Left            =   1440
         TabIndex        =   16
         TabStop         =   0   'False
         Top             =   1080
         Width           =   4815
         _ExtentX        =   8493
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         Text            =   "SP"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   7
         Left            =   120
         TabIndex        =   17
         Top             =   1080
         Width           =   1815
         _ExtentX        =   3201
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
      Begin sevTextBox.sevText KdAnm 
         Height          =   1005
         Left            =   6360
         TabIndex        =   18
         TabStop         =   0   'False
         Top             =   2640
         Width           =   3135
         _ExtentX        =   5530
         _ExtentY        =   1773
         VBA             =   -1  'True
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
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
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         MultiLine       =   -1  'True
         PopUpFloskel    =   0   'False
         Text            =   "KdAnm"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   8
         Left            =   5280
         TabIndex        =   19
         Top             =   2640
         Width           =   1095
         _ExtentX        =   1931
         _ExtentY        =   450
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   0
         Caption         =   "Anmerkung:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText PLZOrt 
         Height          =   285
         Left            =   1920
         TabIndex        =   20
         TabStop         =   0   'False
         Top             =   3360
         Width           =   4335
         _ExtentX        =   7646
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         Text            =   "PLZOrt"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   9
         Left            =   120
         TabIndex        =   21
         Top             =   3360
         Width           =   1815
         _ExtentX        =   3201
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
      Begin sevTextBox.sevText VerId 
         Height          =   285
         Left            =   1440
         TabIndex        =   22
         TabStop         =   0   'False
         Top             =   720
         Visible         =   0   'False
         Width           =   615
         _ExtentX        =   1085
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   4
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText cmdVer 
         Height          =   285
         Left            =   4920
         TabIndex        =   0
         Top             =   720
         Width           =   320
         _ExtentX        =   556
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
            Name            =   "Century Gothic"
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
         MaxLength       =   255
         PopUpFloskel    =   0   'False
         ShowButton      =   -1  'True
         Text            =   "Ver"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText ANNr 
         Height          =   285
         Left            =   1200
         TabIndex        =   23
         TabStop         =   0   'False
         Top             =   240
         Visible         =   0   'False
         Width           =   375
         _ExtentX        =   661
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   2
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         PopUpFloskel    =   0   'False
         Text            =   "AUNR"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Stat 
         Height          =   285
         Left            =   4920
         TabIndex        =   43
         TabStop         =   0   'False
         Top             =   240
         Width           =   1335
         _ExtentX        =   2355
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   2
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         PopUpFloskel    =   0   'False
         Text            =   "Stat"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   16
         Left            =   4320
         TabIndex        =   44
         Top             =   240
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
         Caption         =   "Status:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText sum 
         Height          =   285
         Left            =   7080
         TabIndex        =   45
         TabStop         =   0   'False
         Top             =   240
         Width           =   975
         _ExtentX        =   1720
         _ExtentY        =   503
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
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 �"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   17
         Left            =   6360
         TabIndex        =   46
         Top             =   240
         Width           =   735
         _ExtentX        =   1296
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
         ForeColor       =   0
         Caption         =   "Netto:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText Ust 
         Height          =   285
         Left            =   8520
         TabIndex        =   47
         TabStop         =   0   'False
         Top             =   240
         Width           =   975
         _ExtentX        =   1720
         _ExtentY        =   503
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
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 �"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   19
         Left            =   8160
         TabIndex        =   48
         Top             =   240
         Width           =   375
         _ExtentX        =   661
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
         ForeColor       =   0
         Caption         =   "Ust:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   49
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
         Caption         =   "Angebotsnr:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText AUNR 
         Height          =   285
         Left            =   1200
         TabIndex        =   50
         TabStop         =   0   'False
         Top             =   240
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   2
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         PopUpFloskel    =   0   'False
         Text            =   "ANNR"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText AuDat 
         Height          =   285
         Left            =   3240
         TabIndex        =   51
         TabStop         =   0   'False
         Top             =   240
         Width           =   975
         _ExtentX        =   1720
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   2
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   2
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   1
         Left            =   2520
         TabIndex        =   52
         Top             =   240
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
         Caption         =   "Datum:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin VB.Line Line1 
         Index           =   0
         X1              =   120
         X2              =   9480
         Y1              =   600
         Y2              =   600
      End
      Begin VB.Line Line1 
         Index           =   1
         X1              =   120
         X2              =   9480
         Y1              =   2520
         Y2              =   2520
      End
   End
   Begin VB.Frame grpZeile 
      Caption         =   "Zeilen"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3135
      Left            =   120
      TabIndex        =   5
      Top             =   4560
      Width           =   9615
      Begin sevCommand3.Command cmdHinz 
         Height          =   255
         Left            =   9120
         TabIndex        =   1
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
      Begin sevListBox.roListBox lstArt 
         Height          =   2175
         Left            =   120
         TabIndex        =   24
         Top             =   840
         Width           =   9015
         _ExtentX        =   15901
         _ExtentY        =   3836
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
         ColumnCount     =   7
         ColText1        =   "ArtNr"
         ColWidth1       =   600
         ColText2        =   "Bezeichnung"
         ColWidth2       =   3500
         ColText3        =   "Einheit"
         ColWidth3       =   1100
         ColText4        =   "Einzelpreis"
         ColWidth4       =   1000
         ColAlignment4   =   1
         ColText5        =   "Anzahl"
         ColWidth5       =   800
         ColText6        =   "Gesamt"
         ColWidth6       =   1000
         ColAlignment6   =   1
         ColText7        =   "Ust"
         ColWidth7       =   900
         MustUpdate      =   -1  'True
      End
      Begin sevTextBox.sevText ArtId 
         Height          =   285
         Left            =   135
         TabIndex        =   25
         Top             =   480
         Width           =   615
         _ExtentX        =   1085
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
            Name            =   "Century Gothic"
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
         Text            =   "ArtId"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Bez 
         Height          =   285
         Left            =   735
         TabIndex        =   26
         Top             =   480
         Width           =   3600
         _ExtentX        =   6350
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
            Name            =   "Century Gothic"
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
         Text            =   "Bez"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Einh 
         Height          =   285
         Left            =   4320
         TabIndex        =   27
         TabStop         =   0   'False
         Top             =   480
         Width           =   1095
         _ExtentX        =   1931
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
            Name            =   "Century Gothic"
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
         Enabled         =   0   'False
         PopUpFloskel    =   0   'False
         Text            =   "Einh"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText EPreis 
         Height          =   285
         Left            =   5400
         TabIndex        =   28
         Top             =   480
         Width           =   975
         _ExtentX        =   1720
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 �"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText Anzahl 
         Height          =   285
         Left            =   6360
         TabIndex        =   29
         Top             =   480
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "1,00"
         W�hrung         =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText GPreis 
         Height          =   285
         Left            =   7200
         TabIndex        =   30
         Top             =   480
         Width           =   975
         _ExtentX        =   1720
         _ExtentY        =   503
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
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 �"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   10
         Left            =   120
         TabIndex        =   31
         Top             =   240
         Width           =   615
         _ExtentX        =   1085
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
         Caption         =   "ArtNr"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   11
         Left            =   720
         TabIndex        =   32
         Top             =   240
         Width           =   3615
         _ExtentX        =   6376
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
         Caption         =   "Bezeichnung"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   13
         Left            =   4320
         TabIndex        =   33
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
         Caption         =   "Einheit"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   12
         Left            =   5400
         TabIndex        =   34
         Top             =   240
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
         Caption         =   "Einzelpreis"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   14
         Left            =   6360
         TabIndex        =   35
         Top             =   240
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
         ForeColor       =   0
         Caption         =   "Anzahl"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   15
         Left            =   7200
         TabIndex        =   36
         Top             =   240
         Width           =   975
         _ExtentX        =   1720
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
         ForeColor       =   0
         Caption         =   "Gesamt"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText UstBetrag 
         Height          =   285
         Left            =   8160
         TabIndex        =   37
         Top             =   480
         Width           =   975
         _ExtentX        =   1720
         _ExtentY        =   503
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
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 �"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel1 
         Height          =   255
         Index           =   18
         Left            =   8160
         TabIndex        =   38
         Top             =   240
         Width           =   975
         _ExtentX        =   1720
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
         ForeColor       =   0
         Caption         =   "Ust"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText UstSatz 
         Height          =   285
         Left            =   8160
         TabIndex        =   53
         Top             =   480
         Visible         =   0   'False
         Width           =   975
         _ExtentX        =   1720
         _ExtentY        =   503
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
         Alignment       =   1
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 �"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   7800
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
      Left            =   7680
      TabIndex        =   4
      Top             =   7800
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
   Begin sevCommand3.Command cmdDruck 
      Height          =   375
      Left            =   2280
      TabIndex        =   3
      Top             =   7800
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
      Caption         =   "&Drucken"
      Filename        =   "Z:\DEV\SecMan\Icons\UserAdd.ico"
      Image           =   6506
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmAuft"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cmdZahl_ButtonClick(bCancel As Boolean)
frmDokZahl.Show
End Sub

Private Sub Form_Load()
Dim strEinh As String
'Alle Felder leeren
AnDat = ""
AnStat = ""
AnWert = ""
Ver.Text = ""
SP.Text = ""
VerAnm.Text = ""
Kd.Text = ""
kdAnsch.Text = ""
PLZOrt.Text = ""
KdAnm.Text = ""
Zahl.Text = ""
ArtId.Text = ""
Bez.Text = ""
Einh.Text = ""
EPreis.Text = ""
Anzahl.Text = ""
GPreis.Text = ""

'Aufruf f�r neuen Auftrag
If Aufruf = 21 Then
  'Auftragsnummer initialisieren, Nummer wird jedoch erst beim Speichern erh�ht und in Tabelle AU eingetragen
  Set RS = DBSecMan.OpenRecordset("select * from NR where NrId='AU'")

    'Nummer aus NrId und Nummer zusamensetzen (Bsp. AU0001)
    AUNr.Text = RS("NrId").Value & RS("Nummer").Value

    RS.Close

    'aktuelles Datum verwenden
    AuDat.Text = Date
    Stat.Text = "Neu"

'Aufruf f�r bestehenden Auftrag
ElseIf Aufruf = 22 Then
    cmdVer.Visible = False
    cmdZahl.Visible = False
    'Eintragen der Kopfinformationen
    AUNr.Text = RS("AUNr").Value
    AuDat.Text = RS("Dat").Value
  'Eintragen des Status
  If RS("Stat").Value = 0 Then
      Stat.Text = "Gespeichert"
  ElseIf RS("Stat").Value = 1 Then
      Stat.Text = "Gedruck"
  Else
      Stat.Text = "Abgeschlossen"
  End If
  
    Sum.Text = RS("Wert").Value
    Ust.Text = RS("UstWert").Value
    ZahlId.Text = RS("ZahlId").Value
    VerId.Text = RS("VerId").Value
    
    'Abfrage nach VerAUstalter und Kunde
    strSQL = "SELECT VER.VName, VER.SP, VER.Anm, KD.Anr, KD.VName, KD.NName, KD.Adr, KD.PLZ, KD.Ort, KD.Anm FROM VER INNER JOIN KD ON VER.KdId = KD.KdId WHERE (((VER.VerId)=" & VerId.Text & "))"
  'Recordset �ffnen
  Set RS = DBSecMan.OpenRecordset(strSQL)
    
    'VerAUstalterdaten einf�gen
    Ver.Text = VerId.Text & " - " & RS("VER.VName").Value
    SP.Text = RS("SP").Value
    VerAnm.Text = RS("VER.Anm").Value
    
    'Kundendaten einf�gen
    Kd.Text = RS("Anr").Value & " " & RS("KD.VName").Value & " " & RS("NName").Value
    kdAnsch.Text = RS("Adr").Value
    PLZOrt.Text = RS("PLZ").Value & " " & RS("Ort").Value
    KdAnm.Text = RS("KD.Anm").Value
    
    'Zahlungsbedingung einf�gen
    strSQL = "Select * from Zahl where ZahlId=" & ZahlId.Text
    Set RS = DBSecMan.OpenRecordset(strSQL)
    Zahl.Text = RS("ZahlId").Value & " - " & RS("Bez").Value
    
    'Abfrage nach VerAUstaltungszeiten
    strSQL = "Select * from VERZeit where VerId=" & VerId.Text
  'Recordset �ffnen
  Set RS = DBSecMan.OpenRecordset(strSQL)
  
  'Abfrage ob Datens�tze vorhAnden sind
  If Not RS.BOF And Not RS.EOF Then
      'lstZeit leeren
      lstZeit.Clear
      'Wird verwendet um die Datens�tze z�hlen zu lassen und die Funktion RecordCount verwenden zu k�nnen
      RS.MoveLast
      RS.MoveFirst
  'Schleife zum Bef�llen der Liste
    For i = 1 To RS.RecordCount
      'Befehl zum hinzuf�gen von Datens�tzen
      lstZeit.AddItem i, RS("Begdat").Value & " " & RS("Begzeit").Value & " - " & RS("Enddat").Value & " " & RS("EndZeit").Value
      'N�chster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      lstZeit.Refresh
    Next i
    
  lstZeit.DeSelectAll
  End If
  
    strSQL = "SELECT Z.ArtId, Z.Bez, ART.Einh, Z.EPreis, Z.anzahl, Z.GPreis, Z.UstBetrag FROM ART INNER JOIN Z ON ART.ArtId = Z.ArtId WHERE (((Z.DokId)='" & AUNr.Text & "'))"
  Set RS = DBSecMan.OpenRecordset(strSQL)
  
  'Abfrage ob Datens�tze vorhAnden sind
  If Not RS.BOF And Not RS.EOF Then
      'lstArt leeren
      lstArt.Clear
      'Wird verwendet um die Datens�tze z�hlen zu lassen und die Funktion RecordCount verwenden zu k�nnen
      RS.MoveLast
      RS.MoveFirst
    'Schleife zum Bef�llen der Liste
    For i = 1 To RS.RecordCount
    
      'Ermitteln der Einheit
      Select Case RS("Einh").Value
       Case "0"
        strEinh = "Stunde"
       Case "1"
        strEinh = "Pauschal"
       Case "2"
        strEinh = "St�ck"
      End Select
      'Befehl zum hinzuf�gen von Datens�tzen
      lstArt.AddItem i, RS("ArtId").Value & vbTab & _
                        RS("Bez").Value & vbTab & _
                        strEinh & vbTab & _
                        FormatCurrency(RS("EPreis").Value, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                        RS("Anzahl").Value & vbTab & _
                        FormatCurrency(RS("GPreis").Value, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                        FormatCurrency(RS("UstBetrag").Value, 2, vbTrue, vbFalse, vbTrue)
      'N�chster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      lstArt.Refresh
    Next i
    
  lstArt.DeSelectAll
  End If

'Aufruf f�r �berleitung
ElseIf Aufruf = 23 Then
    cmdVer.Visible = False
    'Angebotsnummer einf�gen (Feld ANNr.visible = FALSE)
    ANNr.Text = RS("ANNr").Value
    
    'aktuelles Datum verwenden
    AuDat.Text = Date
    Stat.Text = "Neu"
    Sum.Text = RS("Wert").Value
    VerId.Text = RS("VerId").Value
    ZahlId.Text = RS("ZahlId").Value
    Ust.Text = RS("UstWert").Value

    'Abfrage nach VerAUstalter und Kunde
    strSQL = "SELECT VER.VName, VER.SP, VER.Anm, KD.Anr, KD.VName, KD.NName, KD.Adr, KD.PLZ, KD.Ort, KD.Anm FROM VER INNER JOIN KD ON VER.KdId = KD.KdId WHERE (((VER.VerId)=" & VerId.Text & "))"
  'Recordset �ffnen
  Set RS = DBSecMan.OpenRecordset(strSQL)
    
    'VerAUstalterdaten einf�gen
    Ver.Text = VerId.Text & " - " & RS("VER.VName").Value
    SP.Text = RS("SP").Value
    VerAnm.Text = RS("VER.Anm").Value
    
    'Kundendaten einf�gen
    Kd.Text = RS("Anr").Value & " " & RS("KD.VName").Value & " " & RS("NName").Value
    kdAnsch.Text = RS("Adr").Value
    PLZOrt.Text = RS("PLZ").Value & " " & RS("Ort").Value
    KdAnm.Text = RS("KD.Anm").Value
    
    'Zahlungsbedingung einf�gen
    strSQL = "Select * from Zahl where ZahlId=" & ZahlId.Text
    Set RS = DBSecMan.OpenRecordset(strSQL)
    Zahl.Text = RS("ZahlId").Value & " - " & RS("Bez").Value
        
    'Abfrage nach VerAUstaltungszeiten
    strSQL = "Select * from VERZeit where VerId=" & VerId.Text
  'Recordset �ffnen
  Set RS = DBSecMan.OpenRecordset(strSQL)
  
  'Abfrage ob Datens�tze vorhAnden sind
  If Not RS.BOF And Not RS.EOF Then
      'lstZeit leeren
      lstZeit.Clear
      'Wird verwendet um die Datens�tze z�hlen zu lassen und die Funktion RecordCount verwenden zu k�nnen
      RS.MoveLast
      RS.MoveFirst
  'Schleife zum Bef�llen der Liste
    For i = 1 To RS.RecordCount
      'Befehl zum hinzuf�gen von Datens�tzen
      lstZeit.AddItem i, RS("Begdat").Value & " " & RS("Begzeit").Value & " - " & RS("Enddat").Value & " " & RS("EndZeit").Value
      'N�chster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      lstZeit.Refresh
    Next i
    
  lstZeit.DeSelectAll
  End If
  
    strSQL = "SELECT Z.ArtId, Z.Bez, ART.Einh, Z.EPreis, Z.anzahl, Z.GPreis, Z.UstBetrag FROM ART INNER JOIN Z ON ART.ArtId = Z.ArtId WHERE (((Z.DokId)='" & ANNr.Text & "'))"
  Set RS = DBSecMan.OpenRecordset(strSQL)
  
  'Abfrage ob Datens�tze vorhAnden sind
  If Not RS.BOF And Not RS.EOF Then
      'lstArt leeren
      lstArt.Clear
      'Wird verwendet um die Datens�tze z�hlen zu lassen und die Funktion RecordCount verwenden zu k�nnen
      RS.MoveLast
      RS.MoveFirst
    'Schleife zum Bef�llen der Liste
    For i = 1 To RS.RecordCount
    
      'Ermitteln der Einheit
      Select Case RS("Einh").Value
       Case "0"
        strEinh = "Stunde"
       Case "1"
        strEinh = "Pauschal"
       Case "2"
        strEinh = "St�ck"
      End Select
      'Befehl zum hinzuf�gen von Datens�tzen
      lstArt.AddItem i, RS("ArtId").Value & vbTab & _
                        RS("Bez").Value & vbTab & _
                        strEinh & vbTab & _
                        FormatCurrency(RS("EPreis").Value, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                        RS("anzahl").Value & vbTab & _
                        FormatCurrency(RS("GPreis").Value, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                        FormatCurrency(RS("UstBetrag").Value, 2, vbTrue, vbFalse, vbTrue)
      'N�chster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      lstArt.Refresh
    Next i
    
  lstArt.DeSelectAll
  End If

'Auftragsnummer initialisieren, Nummer wird jedoch erst beim Speichern erh�ht und in Tabelle AU eingetragen
  Set RS = DBSecMan.OpenRecordset("select * from NR where NrId='AU'")

'Nummer aus NrId und Nummer zusamensetzen (Bsp. AU0001)
AUNr.Text = RS("NrId").Value & RS("Nummer").Value

RS.Close

End If

'Pr�fen ob Auftrag bereits in Rechnung�bergeleitet wurde
If Stat.Text = "Abgeschlossen" Then
    MsgBox "Aus diesem Auftrug wurde bereits eine Rechnung generiert," & vbCrLf & _
           "Nur noch Drucken m�glich", vbInformation + vbOKOnly, "Auftrag bereits abgeschlossen"
    cmdZahl.Visible = False
    ArtId.Enabled = False
    Bez.Enabled = False
    EPreis.Enabled = False
    Anzahl.Enabled = False
    cmdHinz.Enabled = False
    lstArt.Enabled = False
    cmdSpeichern.Enabled = False
End If

End Sub

Private Sub cmdVer_ButtonClick(bCancel As Boolean)
frmDokVer.Show

End Sub

Private Sub ArtId_LostFocus()
Dim strEinh As String
If Not ArtId.Text = "" Then
  'Tabelle ART �ffnen und eingegebenen Artikel zur�ckgeben
  Set RS = DBSecMan.OpenRecordset("select * from ART where ArtId=" & ArtId.Text)
    
    'Pr�fung ob Artikel vorhAnden
  If Not RS.BOF And Not RS.EOF Then
    'Select zum Einheit ermitteln
    Select Case RS("Einh").Value
      Case "0"
        strEinh = "Stunde"
      Case "1"
        strEinh = "Pauschal"
      Case "2"
        strEinh = "St�ck"
    End Select

        Bez.Text = RS("Bez").Value
        Einh.Text = strEinh
        EPreis.Text = RS("Preis").Value
        UstSatz.Text = RS("Ust").Value
        Bez.SetFocus
    Else
        'Wenn nicht vorhAnden Eingabe entfernen und Text �ndern
        ArtId = ""
        Bez.Text = "Artikel nicht vorhAnden"
        Bez.Text = ""
        Einh.Text = ""
        EPreis.Text = ""
        Anzahl.Text = ""
        GPreis.Text = ""
        Ust.Text = ""
        UstBetrag.Text = ""
        ArtId.SetFocus
    End If
Else
    Bez.Text = ""
    Einh.Text = ""
    EPreis.Text = ""
    Anzahl.Text = ""
    GPreis.Text = ""
End If

End Sub

Private Sub EPreis_LostFocus()
If Not Anzahl = "" Then
    'Gesamtpreis berechnen
    GPreis.Text = CCur(EPreis.Text) * CCur(Anzahl.Text)
    UstBetrag.Text = CCur(GPreis.Text) / 100 * UstSatz.Text
Else
    'Focus auf Feld anzahl setzen
    Anzahl.SetFocus
End If

End Sub

Private Sub anzahl_LostFocus()
If Not Anzahl = "" Then
    'Gesamtpreis berechnen
    GPreis.Text = CCur(EPreis.Text) * CCur(Anzahl.Text)
    UstBetrag.Text = CCur(GPreis.Text) / 100 * UstSatz.Text
End If

End Sub

Private Sub cmdHinz_Click()
'Error Handling
On Error GoTo ErrHinz

'Abfrage ob Werte zum Hinzuf�gen vorhanden sind
If Not ArtId.Text = "" And Not Einh.Text = "" And Not EPreis.Text = "" And Not Anzahl.Text = "" And Not GPreis.Text = "" Then
    'Falls Feld Bez leer ist wird die Standardbezeichnung des Artikels verwendet
    If Bez.Text = "" Then
        'Befehl zum Hinzuf�gen von Daten
        lstArt.AddItem , ArtId.Text & vbTab & _
                       RS("Bez").Value & vbTab & _
                       Einh.Text & vbTab & _
                       FormatCurrency(EPreis.Text, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                       Anzahl.Text & vbTab & _
                       FormatCurrency(GPreis.Text, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                       FormatCurrency(UstBetrag.Text, 2, vbTrue, vbFalse, vbTrue)
        'lstArt aktualisieren
        lstArt.Refresh
        
        'Gesamtsumme berechnen
        Sum.Text = CCur(Sum.Text) + CCur(GPreis.Text)
        Ust.Text = CCur(Ust.Text) + CCur(UstBetrag.Text)
    Else
        'Befehl zum Hinzuf�gen von Daten
        lstArt.AddItem , ArtId.Text & vbTab & _
                       Bez.Text & vbTab & _
                       Einh.Text & vbTab & _
                       FormatCurrency(EPreis.Text, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                       Anzahl.Text & vbTab & _
                       FormatCurrency(GPreis.Text, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                       FormatCurrency(UstBetrag.Text, 2, vbTrue, vbFalse, vbTrue)
        'lstArt aktualisieren
        lstArt.Refresh
        
        'Gesamtsumme berechnen
        Sum.Text = CCur(Sum.Text) + CCur(GPreis.Text)
        Ust.Text = CCur(Ust.Text) + CCur(UstBetrag.Text)
    End If
End If

ArtId = ""
Bez.Text = ""
Bez.Text = ""
Einh.Text = ""
EPreis.Text = ""
Anzahl.Text = ""
GPreis.Text = ""
UstBetrag.Text = ""
UstSatz.Text = ""
ArtId.SetFocus

Exit Sub

'Error Handling
ErrHinz:
'Artikel bereits vorhanden
If Err.Number = 35602 Then
    MsgBox "Artikel bereits vorhanden", vbOKOnly + vbInformation, "Hinweis"
    ArtId.Text = ""
    Bez.Text = ""
    Einh.Text = ""
    EPreis.Text = ""
    Anzahl.Text = ""
    GPreis.Text = ""
    UstBetrag.Text = ""
    UstSatz.Text = ""
    ArtId.SetFocus
Else
    MsgBox Err.Source & vbcrld & Err.Description, vbOKOnly + vbInformation, "Fehler: " & Err.Number
End If

End Sub

Private Sub lstArt_DblClick()
'Gesatmsumme berechnen
Sum.Text = CCur(Sum.Text) - CCur(lstArt.SubItems(lstArt.ListIndex, 6))
Ust.Text = CCur(Ust.Text) - CCur(lstArt.SubItems(lstArt.ListIndex, 7))
'Zeile aus Liste entfernen
lstArt.RemoveItem (lstArt.ListIndex)

End Sub

Private Sub cmdSpeichern_Click()
AUSpeichern (0)

End Sub

Private Sub cmdDruck_Click()
If Not Stat.Text = "Abgeschlossen" Then AUSpeichern (1)
frmDruck.Show
frmDruck.Refresh
Druck.DokDruck "AU", AUNr.Text
Unload Me

End Sub

Private Sub AUSpeichern(Status As Integer)

'Status im Angebot �ndern
If Aufruf = 23 Then
DBSecMan.Execute ("Update AN set Stat = 2 where ANNr ='" & ANNr.Text & "'")
End If

'Neues Auftrag
If Aufruf = 21 Or Aufruf = 23 Then
  Set RS = DBSecMan.OpenRecordset("AU")
    'Neuen Datensatz hinzuf�gen
    RS.AddNew
    RS("VerID").Value = VerId.Text
    RS("AUNr").Value = AUNr.Text
    RS("Dat").Value = AuDat.Text
    RS("Wert").Value = Sum.Text
    RS("Stat").Value = Status
    RS("ZahlId").Value = ZahlId.Text
    RS("UstWert").Value = Ust.Text
    'Recordset aktualisieren
    RS.Update
    
    'Auftragsnummer erh�hen
    'String(3 - Len(Left(Right(AUNr.Text, 8), 3) + 1), "0") & Left(Right(AUNr.Text, 8), 3) + 1 & "/2007"
    DBSecMan.Execute ("Update NR set Nummer='" & String(3 - Len(Left(Right(AUNr.Text, 8), 3) + 1), "0") & Left(Right(AUNr.Text, 8), 3) + 1 & "/2007" & "' where NrId='AU'")
    
  'Status aktualisieren
  If Status = 0 Then
      Stat.Text = "Gespeichert"
  ElseIf Status = 1 Then
      Stat.Text = "Gedruckt"
  End If
    
    Aufruf = 22
    
ElseIf Aufruf = 22 Then
  'Pr�fung ob Status ge�ndert wurde
  If Stat.Text = "Gespeichert" And Status = 1 Then
      'Status in Tabelle AU aktualisieren
      DBSecMan.Execute ("Update AU set Stat=" & Status & " where AUNr='" & AUNr.Text & "'")
      Stat.Text = "Gedruckt"
  End If
  
    'Auftragswert aktualisieren
    DBSecMan.Execute ("Update AU set Wert='" & CCur(Sum.Text) & "'where AuNr='" & AUNr.Text & "'")
    DBSecMan.Execute ("Update AU set UstWert='" & CCur(Ust.Text) & "'where AuNr='" & AUNr.Text & "'")
    
    'bestehnde Datens�tze aus Tabelle Z l�schen
    DBSecMan.Execute ("delete from Z where DokId='" & AUNr.Text & "'")
End If
  
'Tabelle Z �ffnen
Set RS = DBSecMan.OpenRecordset("Z")

For i = 1 To lstArt.ListCount
  'Neuen Datensatz hinzuf�gen
  RS.AddNew
 
  RS("DokId").Value = AUNr.Text
  RS("ArtID").Value = lstArt.SubItems(i, 1)
  RS("bez").Value = lstArt.SubItems(i, 2)
  RS("Epreis").Value = lstArt.SubItems(i, 4)
  RS("Anzahl").Value = lstArt.SubItems(i, 5)
  RS("GPreis").Value = lstArt.SubItems(i, 6)
  RS("UstBetrag").Value = lstArt.SubItems(i, 7)
  
  'Recordset aktualisieren
  RS.Update
Next i
 
'Status in VER auf 2 stellen
DBSecMan.Execute ("Update VER set Stat=2 where VerId=" & VerId.Text)

End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub

Private Sub Form_Unload(Cancel As Integer)
'Pr�fen ob �ber Menu oder �ber frmDok gestartet wurde
If frmDok.grpAuft.Visible = True Then
    frmDok.ZeigeDok "QrAU", frmDok.lstAuft
ElseIf frmDok.grpAnbot.Visible = True Then
    frmDok.ZeigeDok "QrAN", frmDok.lstAnbot
Else
    'frmMenu wird wieder Angezeigt
    frmMenu.WindowState = 0
End If
Aufruf = 0

End Sub
