VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmBuch 
   Caption         =   "Buchen"
   ClientHeight    =   5775
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5595
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   5775
   ScaleWidth      =   5595
   StartUpPosition =   2  'Bildschirmmitte
   Begin VB.Frame frmAusgang 
      Caption         =   "Bestandskonto Ausgang"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   43
      Top             =   960
      Visible         =   0   'False
      Width           =   5295
      Begin sevTextBox.sevText txtKtoAusName 
         Height          =   285
         Left            =   1080
         TabIndex        =   44
         Top             =   480
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         MaxLength       =   25
         PopUpFloskel    =   0   'False
         Text            =   ""
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtKtoAusSaldo 
         Height          =   285
         Left            =   4080
         TabIndex        =   45
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
         Alignment       =   1
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         ForeColorDisabled=   -2147483640
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 €"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchKtoAus 
         Height          =   285
         Left            =   120
         TabIndex        =   46
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   4
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   6
         Left            =   4080
         TabIndex        =   47
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
         Caption         =   "Saldo"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   8
         Left            =   120
         TabIndex        =   48
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
         Caption         =   "Kontonr:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   16
         Left            =   1080
         TabIndex        =   49
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
         Caption         =   "Name"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame frmEingang 
      Caption         =   "Bestandskonto Eingang"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   36
      Top             =   1800
      Visible         =   0   'False
      Width           =   5295
      Begin sevTextBox.sevText txtKtoEinName 
         Height          =   285
         Left            =   1080
         TabIndex        =   37
         Top             =   480
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         MaxLength       =   25
         PopUpFloskel    =   0   'False
         Text            =   ""
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtKtoEinSaldo 
         Height          =   285
         Left            =   4080
         TabIndex        =   38
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
         Alignment       =   1
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         ForeColorDisabled=   -2147483640
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 €"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchKtoEin 
         Height          =   285
         Left            =   120
         TabIndex        =   39
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   4
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   3
         Left            =   4080
         TabIndex        =   40
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
         Caption         =   "Saldo"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   4
         Left            =   120
         TabIndex        =   41
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
         Caption         =   "Kontonr:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   5
         Left            =   1080
         TabIndex        =   42
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
         Caption         =   "Name"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame frmSonst 
      Caption         =   "Sonstiges"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2655
      Left            =   120
      TabIndex        =   26
      Top             =   2640
      Width           =   5295
      Begin sevTextBox.sevText txtAdrName 
         Height          =   285
         Left            =   1080
         TabIndex        =   27
         Top             =   480
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         MaxLength       =   25
         PopUpFloskel    =   0   'False
         Text            =   ""
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtAdrSaldo 
         Height          =   285
         Left            =   4080
         TabIndex        =   28
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
         Alignment       =   1
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         ForeColorDisabled=   -2147483640
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 €"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchAdr 
         Height          =   285
         Left            =   120
         TabIndex        =   5
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   4
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchMemo 
         Height          =   1125
         Left            =   1080
         TabIndex        =   8
         Top             =   1440
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   1984
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   255
         MultiLine       =   -1  'True
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchKtoBetrag 
         Height          =   285
         Left            =   120
         TabIndex        =   7
         Top             =   1440
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   1
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         Text            =   "0,00 €"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   13
         Left            =   120
         TabIndex        =   29
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
         Caption         =   "AdrNr:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   14
         Left            =   1080
         TabIndex        =   30
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
         Caption         =   "Name"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   15
         Left            =   4080
         TabIndex        =   31
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
         Caption         =   "Saldo"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchText 
         Height          =   285
         Left            =   120
         TabIndex        =   6
         Top             =   960
         Width           =   5055
         _ExtentX        =   8916
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         ForeColorDisabled=   -2147483640
         MaxLength       =   55
         PopUpFloskel    =   0   'False
         Text            =   ""
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   17
         Left            =   120
         TabIndex        =   32
         Top             =   720
         Width           =   5055
         _ExtentX        =   8916
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
         Caption         =   "Buchungstext"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   9
         Left            =   120
         TabIndex        =   33
         Top             =   1200
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
         Caption         =   "Betrag:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   7
         Left            =   1080
         TabIndex        =   34
         Top             =   1200
         Width           =   4095
         _ExtentX        =   7223
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
         Caption         =   "Anmerkung:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame frmBestand 
      Caption         =   "Bestandskonto"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   20
      Top             =   960
      Width           =   5295
      Begin sevTextBox.sevText txtKtoBestandName 
         Height          =   285
         Left            =   1080
         TabIndex        =   21
         Top             =   480
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         MaxLength       =   25
         PopUpFloskel    =   0   'False
         Text            =   ""
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtKtoBestandSaldo 
         Height          =   285
         Left            =   4080
         TabIndex        =   22
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
         Alignment       =   1
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         ForeColorDisabled=   -2147483640
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 €"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchKtoBestand 
         Height          =   285
         Left            =   120
         TabIndex        =   3
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   4
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   20
         Left            =   4080
         TabIndex        =   23
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
         Caption         =   "Saldo"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   24
         Left            =   120
         TabIndex        =   24
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
         Caption         =   "Kontonr:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   25
         Left            =   1080
         TabIndex        =   25
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
         Caption         =   "Name"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame frmAufErtr 
      Caption         =   "Aufwand/Ertrag"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   14
      Top             =   1800
      Width           =   5295
      Begin sevTextBox.sevText txtKtoName 
         Height          =   285
         Left            =   1080
         TabIndex        =   16
         Top             =   480
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
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         MaxLength       =   25
         PopUpFloskel    =   0   'False
         Text            =   ""
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtKtoSaldo 
         Height          =   285
         Left            =   4080
         TabIndex        =   17
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
         Alignment       =   1
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         Format          =   1
         ForeColorDisabled=   -2147483640
         MaxLength       =   15
         PopUpFloskel    =   0   'False
         Text            =   "0,00 €"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchKto 
         Height          =   285
         Left            =   120
         TabIndex        =   4
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   4
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   10
         Left            =   120
         TabIndex        =   15
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
         Caption         =   "Kontonr:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   11
         Left            =   1080
         TabIndex        =   18
         Top             =   240
         Width           =   3015
         _ExtentX        =   5318
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
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   12
         Left            =   4080
         TabIndex        =   19
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
         Caption         =   "Saldo"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame frmEinst 
      Caption         =   "Einstellungen"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   10
      Top             =   0
      Width           =   5295
      Begin sevTextBox.sevText txtBuchID 
         Height          =   285
         Left            =   120
         TabIndex        =   9
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         Text            =   "0"
         Währung         =   "€"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchDat 
         Height          =   285
         Left            =   1200
         TabIndex        =   0
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
         Alignment       =   2
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   2
         MaxLength       =   10
         PopUpFloskel    =   0   'False
         Text            =   "01.01.2007"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   1
         Left            =   1200
         TabIndex        =   11
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
         Caption         =   "Buch. Dat:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtBuchArt 
         Height          =   285
         Left            =   2400
         TabIndex        =   1
         Top             =   480
         Width           =   1455
         _ExtentX        =   2566
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MaxLength       =   25
         PopUpFloskel    =   0   'False
         Style           =   2
         ShowButton      =   -1  'True
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   2
         Left            =   2400
         TabIndex        =   12
         Top             =   240
         Width           =   1455
         _ExtentX        =   2566
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
         Caption         =   "Buch. Art:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   13
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
         Caption         =   "Buch. ID:"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.Command cmdEinstOK 
         Height          =   285
         Left            =   3960
         TabIndex        =   2
         Top             =   480
         Width           =   1245
         _ExtentX        =   2196
         _ExtentY        =   503
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
         Caption         =   "&OK"
         Image           =   6936
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdFertig 
      Height          =   405
      Left            =   120
      TabIndex        =   35
      Top             =   5280
      Width           =   5325
      _ExtentX        =   9393
      _ExtentY        =   714
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
      Caption         =   "&Fertig"
      Enabled         =   0   'False
      Image           =   6923
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmBuch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private bolF4 As Boolean

Private Sub cmdFertig_Click()
If Prüfung = True Then
  If Speichern = True Then
      Unload frmBuch
      frmBuch.Show
  End If
Else
  'Fehler gefunden
  MsgBox FehlerText
End If
End Sub

Public Function Prüfung() As Boolean
Prüfung = True
FehlerText = "Folgende Fehler wurden festgestellt:"
'Prüfung ob Buchungstext eingetragen ist
If txtBuchText = "" Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Kein Buchungstext hinterlegt"
End If
'Prüfung ob Betrag eingetrage ist
If txtBuchKtoBetrag = "" Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Keine Betrag hinterlegt"
Else
  'Prüfunb ob Betrag ungleich 0
  If txtBuchKtoBetrag = 0 Then
    Prüfung = False
    FehlerText = FehlerText & vbCrLf & "- Betrag darf nicht EUR 0,00 sein"
  End If
  'Prüfung ob Betrag bei Einnahmen positiv
  If Left(txtBuchArt, 1) = "E" And txtBuchKtoBetrag < 0 Then
    Prüfung = False
    FehlerText = FehlerText & vbCrLf & "- Bei Einnahmen muss Betrag positiv sein (Betrag wird korrigiert)"
    txtBuchKtoBetrag = txtBuchKtoBetrag * -1
  End If
  'Prüfung ob Betrag bei Ausgaben negativ
  If Left(txtBuchArt, 1) = "A" And txtBuchKtoBetrag > 0 Then
    Prüfung = False
    FehlerText = FehlerText & vbCrLf & "- Bei Ausgaben muss Betrag negativ sein (Betrag wird korrigiert)"
    txtBuchKtoBetrag = txtBuchKtoBetrag * -1
  End If
End If
FehlerText = FehlerText & vbCrLf & vbCrLf & "Bitte korrigieren Sie die eingaben"
End Function

Public Function Speichern() As Boolean
Speichern = True
Set RS = DB.OpenRecordset("Buch")
RS.AddNew
RS("BuchId").Value = txtBuchID
RS("BuchDat").Value = txtBuchDat
RS("BuchArt").Value = Left(txtBuchArt, 1)
RS("BuchStatus").Value = "N"
RS("BuchAdr").Value = txtBuchAdr
RS("BuchKtoBetrag").Value = txtBuchKtoBetrag
RS("BuchText").Value = txtBuchText
RS("BuchMemo").Value = txtBuchMemo
If Left(txtBuchArt, 1) = "U" Then
  RS("BuchKtoBestand").Value = txtBuchKtoAus
  RS("BuchKto").Value = txtBuchKtoEin
  'Saldo Update
  DB.Execute ("Update Kto set KtoSaldo = '" & ((CCur(txtBuchKtoBetrag) * -1) + CCur(txtKtoAusSaldo)) & "' where KtoNr='" & txtBuchKtoAus & "'")
  DB.Execute ("Update Kto set KtoSaldo = '" & (CCur(txtBuchKtoBetrag) + CCur(txtKtoEinSaldo)) & "' where KtoNr='" & txtBuchKtoEin & "'")
Else
  RS("BuchKtoBestand").Value = txtBuchKtoBestand
  RS("BuchKto").Value = txtBuchKto
  'Saldo Update
  DB.Execute ("Update Kto set KtoSaldo = '" & (CCur(txtBuchKtoBetrag) + CCur(txtKtoBestandSaldo)) & "' where KtoNr='" & txtBuchKtoBestand & "'")
  DB.Execute ("Update Kto set KtoSaldo = '" & (CCur(txtBuchKtoBetrag) + CCur(txtKtoSaldo)) & "' where KtoNr='" & txtBuchKto & "'")
End If
RS.Update
'Saldo updaten
'DB.Execute ("Update Kto set KtoSaldo = '" & (CCur(txtBuchKtoBetrag) + CCur(txtKtoBestandSaldo)) & "' where KtoNr='" & txtBuchKtoBestand & "'")
'DB.Execute ("Update Kto set KtoSaldo = '" & (CCur(txtBuchKtoBetrag) + CCur(txtKtoSaldo)) & "' where KtoNr='" & txtBuchKto & "'")
DB.Execute ("Update Adr set AdrSaldo = '" & (CCur(txtBuchKtoBetrag) + CCur(txtAdrSaldo)) & "' where AdrNr='" & txtBuchAdr & "'")
End Function

Private Sub Form_Load()
Me.Caption = "Buchen [" & strUser & "]"
txtBuchArt.AddItem "Einnahme", "E"
txtBuchArt.AddItem "Ausgabe", "A"
txtBuchArt.AddItem "Umbuchung", "U"
txtBuchDat = Date
End Sub

Private Sub cmdEinstOK_Click()
If PrüfeEinst = True Then
  'BuchungsId suchen
  Set RS = DB.OpenRecordset("Select max(BuchId) as maxBuchId from Buch")
  If IsNull(RS("maxBuchId").Value) Then
    txtBuchID = 1
  Else
    txtBuchID = RS("maxBuchId").Value + 1
  End If
  'Felder deaktivieren
  txtBuchDat.Enabled = False
  txtBuchArt.Enabled = False
  cmdEinstOK.Enabled = False
  frmEinst.Enabled = False
  'Prüfen ob Umbuchung erstellt wird
  If Left(txtBuchArt.Text, 1) = "U" Then
    frmAusgang.Visible = True
    txtBuchKtoAus.SetFocus
    frmEingang.Visible = True
  Else
    'Bestand aktivieren und Focus setzen
    frmBestand.Enabled = True
    txtBuchKtoBestand.SetFocus
  End If
  cmdFertig.Enabled = True
Else
  'Fehler gefunden
  MsgBox FehlerText
End If

End Sub

Public Function PrüfeEinst() As Boolean
PrüfeEinst = True
FehlerText = "Folgende Fehler wurden festgestellt:"
'Prüfung ob Datum eingetragen ist
If txtBuchDat = "" Or txtBuchDat = "  .  .    " Then
  PrüfeEinst = False
  FehlerText = FehlerText & vbCrLf & "- Kein Datum hinterlegt"
End If
'Prüfung ob Buchungsart eingetrage ist
If txtBuchArt = "" Then
  PrüfeEinst = False
  FehlerText = FehlerText & vbCrLf & "- Keine Buchungsart hinterlegt"
End If
FehlerText = FehlerText & vbCrLf & vbCrLf & "Bitte korrigieren Sie die eingaben"
End Function

Private Sub txtBuchAdr_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF4 Then
  bolF4 = True
  If mdlPBH.Liste("AdrNr", "AdrNr, AdrName", "Adr", "AdrTyp='" & Left(txtBuchArt, 1) & "'", "AdrNr") = True Then 'Wenn Liste erfolgreich befüllt wird, wird WAHR zurückgegeben
    frmListe.Show vbModal
    If Not strID = "" Then
      txtBuchAdr = strID
      bolF4 = False
      SendKeys vbTab
    Else
      txtBuchAdr = ""
      bolF4 = False
    End If
  Else
    MsgBox FehlerText 'Fehlermeldung
  End If
End If
End Sub

Private Sub txtBuchAdr_LostFocus()
If Not txtBuchAdr = "" Then
  'Abfrage nach eingegebener KtoNr
  Set RS = DB.OpenRecordset("Select * from Adr where AdrNr='" & txtBuchAdr & "' and AdrTyp='" & Left(txtBuchArt, 1) & "'")
  'Prüfung ob KtoNr vorhanden ist
  If Not RS.BOF And Not RS.EOF Then
    txtAdrName = RS("AdrName").Value
    txtKtoSaldo = RS("AdrSaldo").Value
    If Not RS("AdrMemo").Value = "" Then
      MsgBox RS("AdrMemo").Value
    End If
    txtBuchText.SetFocus
  Else
    If Left(txtBuchArt, 1) = "A" Then
      MsgBox "Adresse nicht vorhanden oder nicht für Ausgaben bestimmt"
    Else
      MsgBox "Adresse nicht vorhanden oder nicht für Einnahmen bestimmt"
    End If
    txtBuchAdr = ""
    txtAdrName = ""
    txtAdrSaldo = 0
    txtBuchAdr.SetFocus
  End If
ElseIf bolF4 = True Then
  Exit Sub
Else
  txtAdrName = ""
  txtAdrSaldo = 0
  txtBuchText.SetFocus
End If
End Sub

Private Sub txtBuchKto_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF4 Then
  bolF4 = True
  If mdlPBH.Liste("KtoNr", "KtoNr, KtoName", "Kto", "KtoArt='" & Left(txtBuchArt, 1) & "'", "KtoNr") = True Then 'Wenn Liste erfolgreich befüllt wird, wird WAHR zurückgegeben
    frmListe.Show vbModal
    If Not strID = "" Then
      txtBuchKto = strID
      bolF4 = False
      SendKeys vbTab
    Else
      txtBuchKto = ""
      bolF4 = False
    End If
  Else
    MsgBox FehlerText 'Fehlermeldung
  End If
End If
End Sub

Private Sub txtBuchKto_lostfocus()
'Abfrage nach eingegebener KtoNr
Set RS = DB.OpenRecordset("Select * from Kto where KtoNr='" & txtBuchKto & "' and KtoArt='" & Left(txtBuchArt, 1) & "'")
'Prüfung ob KtoNr vorhanden ist
If Not RS.BOF And Not RS.EOF Then
  txtKtoName = RS("KtoName").Value
  txtKtoSaldo = RS("ktoSaldo").Value
  If Not RS("KtoMemo").Value = "" Then
    MsgBox RS("KtoMemo").Value
  End If
  txtBuchKto.Enabled = False
  frmAufErtr.Enabled = False
  frmSonst.Enabled = True
  txtBuchAdr.SetFocus
ElseIf bolF4 = True Then
  Exit Sub
Else
  If Left(txtBuchArt, 1) = "A" Then
    MsgBox "Konto nicht vorhanden oder kein Aufwandskonto"
  Else
    MsgBox "Konto nicht vorhanden oder kein Ertragskonto"
  End If
  txtBuchKto = ""
  txtKtoName = ""
  txtKtoSaldo = 0
  txtBuchKto.SetFocus
End If
End Sub

Private Sub txtBuchKtoBestand_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF4 Then
  bolF4 = True
  If mdlPBH.Liste("KtoNr", "KtoNr, KtoName", "Kto", "KtoArt='B'", "KtoNr") = True Then 'Wenn Liste erfolgreich befüllt wird, wird WAHR zurückgegeben
    frmListe.Show vbModal
    If Not strID = "" Then
      txtBuchKtoBestand = strID
      bolF4 = False
      SendKeys vbTab
    Else
      txtBuchKtoBestand = ""
      bolF4 = False
    End If
  Else
    MsgBox FehlerText 'Fehlermeldung
  End If
End If
End Sub

Private Sub txtBuchKtoBestand_LostFocus()
'Abfrage nach eingegebener KtoNr
Set RS = DB.OpenRecordset("Select * from Kto where KtoNr='" & txtBuchKtoBestand & "' and KtoArt='B'")
'Prüfung ob KtoNr vorhanden ist
If Not RS.BOF And Not RS.EOF Then
  txtKtoBestandName = RS("KtoName").Value
  txtKtoBestandSaldo = RS("KtoSaldo").Value
  If Not RS("KtoMemo").Value = "" Then
    MsgBox RS("KtoMemo").Value
  End If
  txtBuchKtoBestand.Enabled = False
  frmBestand.Enabled = False
  frmAufErtr.Enabled = True
  If txtBuchKtoBetrag = 0 Then
    txtBuchKto.SetFocus
  Else
    txtBuchText.SetFocus
  End If
ElseIf bolF4 = True Then
  Exit Sub
Else
  MsgBox "Konto nicht vorhanden oder kein Bestandskonto"
  txtBuchKtoBestand = ""
  txtKtoBestandName = ""
  txtKtoBestandSaldo = 0
  txtBuchKtoBestand.SetFocus
End If
End Sub

Private Sub txtBuchKtoAus_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF4 Then
  bolF4 = True
  If mdlPBH.Liste("KtoNr", "KtoNr, KtoName", "Kto", "KtoArt='B'", "KtoNr") = True Then 'Wenn Liste erfolgreich befüllt wird, wird WAHR zurückgegeben
    frmListe.Show vbModal
    If Not strID = "" Then
      txtBuchKtoAus = strID
      bolF4 = False
      SendKeys vbTab
    Else
      txtBuchKtoAus = ""
      bolF4 = False
    End If
  Else
    MsgBox FehlerText 'Fehlermeldung
  End If
End If
End Sub

Private Sub txtBuchKtoAus_LostFocus()
'Abfrage nach eingegebener KtoNr
Set RS = DB.OpenRecordset("Select * from Kto where KtoNr='" & txtBuchKtoAus & "' and KtoArt='B'")
'Prüfung ob KtoNr vorhanden ist
If Not RS.BOF And Not RS.EOF Then
  txtKtoAusName = RS("KtoName").Value
  txtKtoAusSaldo = RS("KtoSaldo").Value
  If Not RS("KtoMemo").Value = "" Then
    MsgBox RS("KtoMemo").Value
  End If
  txtBuchKtoEin.SetFocus
ElseIf bolF4 = True Then
  Exit Sub
Else
  MsgBox "Konto nicht vorhanden oder kein Bestandskonto"
  txtBuchKtoAus = ""
  txtKtoAusName = ""
  txtKtoAusSaldo = 0
  txtBuchKtoAus.SetFocus
End If
End Sub

Private Sub txtBuchKtoEin_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF4 Then
  bolF4 = True
  If mdlPBH.Liste("KtoNr", "KtoNr, KtoName", "Kto", "KtoArt='B'", "KtoNr") = True Then 'Wenn Liste erfolgreich befüllt wird, wird WAHR zurückgegeben
    frmListe.Show vbModal
    If Not strID = "" Then
      txtBuchKtoEin = strID
      bolF4 = False
      SendKeys vbTab
    Else
      txtBuchKtoEin = ""
      bolF4 = False
    End If
  Else
    MsgBox FehlerText 'Fehlermeldung
  End If
End If
End Sub

Private Sub txtBuchKtoEin_LostFocus()
'Abfrage nach eingegebener KtoNr
Set RS = DB.OpenRecordset("Select * from Kto where KtoNr='" & txtBuchKtoEin & "' and KtoArt='B'")
'Prüfung ob KtoNr vorhanden ist
If Not RS.BOF And Not RS.EOF Then
  txtKtoEinName = RS("KtoName").Value
  txtKtoEinSaldo = RS("KtoSaldo").Value
  If Not RS("KtoMemo").Value = "" Then
    MsgBox RS("KtoMemo").Value
  End If
  frmSonst.Enabled = True
  txtBuchAdr.Enabled = False
  txtBuchText.SetFocus
ElseIf bolF4 = True Then
  Exit Sub
Else
  MsgBox "Konto nicht vorhanden oder kein Bestandskonto"
  txtBuchKtoEin = ""
  txtKtoEinName = ""
  txtKtoEinSaldo = 0
  txtBuchKtoEin.SetFocus
End If
End Sub
