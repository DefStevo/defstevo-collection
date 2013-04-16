VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmOptionen 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "E-Mail Tools - Optionen"
   ClientHeight    =   4755
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9735
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmOptionen.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4755
   ScaleWidth      =   9735
   StartUpPosition =   1  'Fenstermitte
   Begin VB.Frame grpSonst 
      BackColor       =   &H00C0F1FF&
      Caption         =   "Sonstiges"
      ForeColor       =   &H00404040&
      Height          =   2055
      Left            =   4920
      TabIndex        =   15
      Top             =   2160
      Width           =   4695
      Begin VB.CheckBox chkLog 
         BackColor       =   &H00C0F1FF&
         Caption         =   "Protokollierung aktivieren (KdMails + Batchlauf)"
         ForeColor       =   &H00404040&
         Height          =   255
         Left            =   240
         TabIndex        =   28
         Top             =   1200
         Width           =   4335
      End
      Begin sevCommand3.roLabel roLabel5 
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   240
         Width           =   4455
         _ExtentX        =   7858
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
         BackColor       =   12644863
         ForeColor       =   4210752
         Caption         =   "Bitte Tragen Sie den Aufrufparamter ein, den Sie für den"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel7 
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   480
         Width           =   4335
         _ExtentX        =   7646
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
         BackColor       =   12644863
         ForeColor       =   4210752
         Caption         =   "Batchlauf verwenden wollen."
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtParKdMails 
         Height          =   285
         Left            =   1200
         TabIndex        =   18
         Top             =   840
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
         BackColor       =   12644863
         BackColorDisabled=   12644863
         BackColorFocus  =   12644863
         BorderColor     =   4773631
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         ForeColor       =   4210752
         ForeColorDisabled=   4210752
         ForeColorFocus  =   4210752
         PopUpFloskel    =   0   'False
         Text            =   "txtParKdMails"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel8 
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   840
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
         BackColor       =   12644863
         ForeColor       =   4210752
         Caption         =   "KdMails:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   4210752
         Version3        =   -1  'True
      End
      Begin sevCommand3.Command cmdLOG 
         Height          =   285
         Left            =   4200
         TabIndex        =   27
         Top             =   840
         Width           =   330
         _ExtentX        =   582
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
         Caption         =   ""
         Enabled         =   0   'False
         Image           =   6937
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame grpKdMails 
      BackColor       =   &H00C0F1FF&
      Caption         =   "Kd Mails"
      ForeColor       =   &H00404040&
      Height          =   2055
      Left            =   120
      TabIndex        =   3
      Top             =   2160
      Width           =   4695
      Begin VB.OptionButton optKdMailsDB 
         BackColor       =   &H00C0F1FF&
         Caption         =   "Datenbank"
         Enabled         =   0   'False
         ForeColor       =   &H00404040&
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   25
         Top             =   720
         Value           =   -1  'True
         Width           =   2167
      End
      Begin VB.OptionButton optKdMailsDB 
         BackColor       =   &H00C0F1FF&
         Caption         =   "ohne Datenbank"
         Enabled         =   0   'False
         ForeColor       =   &H00404040&
         Height          =   255
         Index           =   1
         Left            =   2280
         TabIndex        =   24
         Top             =   720
         Width           =   2167
      End
      Begin sevTextBox.sevText txtTage 
         Height          =   285
         Left            =   3000
         TabIndex        =   20
         Top             =   240
         Width           =   495
         _ExtentX        =   873
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
         BackColor       =   12644863
         BackColorDisabled=   12644863
         BackColorFocus  =   12644863
         BorderColor     =   4773631
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Format          =   4
         ForeColor       =   4210752
         ForeColorDisabled=   4210752
         ForeColorFocus  =   4210752
         MaxLength       =   3
         PopUpFloskel    =   0   'False
         Text            =   "0"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel9 
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   240
         Width           =   2895
         _ExtentX        =   5106
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
         BackColor       =   12644863
         ForeColor       =   4210752
         Caption         =   "Standardzeitraum für Archivierung"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel roLabel10 
         Height          =   255
         Left            =   3600
         TabIndex        =   22
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
         BackColor       =   12644863
         ForeColor       =   4210752
         Caption         =   "Tage"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.Command cmdFoldDb 
         Height          =   375
         Left            =   120
         TabIndex        =   23
         Top             =   1080
         Width           =   4455
         _ExtentX        =   7858
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
         Caption         =   "&Datenbank aufbauen/aktualisieren"
         Image           =   6600
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
      Begin sevCommand3.Command cmdDBEdit 
         Height          =   375
         Left            =   120
         TabIndex        =   26
         Top             =   1560
         Width           =   4455
         _ExtentX        =   7858
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
         Caption         =   "Datenbank &Editieren"
         Enabled         =   0   'False
         Image           =   6600
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
   End
   Begin VB.Frame grpSupSniff 
      BackColor       =   &H00C0F1FF&
      Caption         =   "Support Sniffer"
      ForeColor       =   &H00404040&
      Height          =   2055
      Left            =   120
      TabIndex        =   2
      Top             =   0
      Width           =   9495
      Begin VB.Frame Frame1 
         BackColor       =   &H00C0F1FF&
         Caption         =   "Ordner"
         ForeColor       =   &H00404040&
         Height          =   1695
         Left            =   120
         TabIndex        =   8
         Top             =   240
         Width           =   4575
         Begin sevTextBox.sevText txtFold 
            Height          =   285
            Left            =   960
            TabIndex        =   9
            Top             =   600
            Width           =   3135
            _ExtentX        =   5530
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
            BackColor       =   12644863
            BackColorDisabled=   12644863
            BackColorFocus  =   12644863
            BorderColor     =   4773631
            BorderStyle     =   3
            BtnBackColor    =   16633531
            BtnBackColorDown=   15968390
            CheckMarkColor  =   2203937
            Enabled         =   0   'False
            ForeColor       =   4210752
            ForeColorDisabled=   4210752
            ForeColorFocus  =   4210752
            PopUpFloskel    =   0   'False
            Text            =   "txtFold"
            WheelMouse      =   0   'False
            Show            =   -1  'True
         End
         Begin sevTextBox.sevText txtFoldId 
            Height          =   645
            Left            =   960
            TabIndex        =   10
            Top             =   960
            Width           =   3495
            _ExtentX        =   6165
            _ExtentY        =   1138
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
            BorderStyle     =   3
            BtnBackColor    =   16633531
            BtnBackColorDown=   15968390
            CheckMarkColor  =   2203937
            Enabled         =   0   'False
            ForeColor       =   4210752
            ForeColorDisabled=   4210752
            ForeColorFocus  =   4210752
            MultiLine       =   -1  'True
            PopUpFloskel    =   0   'False
            Text            =   "txtFoldId"
            WheelMouse      =   0   'False
            Show            =   -1  'True
         End
         Begin sevCommand3.roLabel roLabel2 
            Height          =   255
            Left            =   120
            TabIndex        =   11
            Top             =   600
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
            BackColor       =   12644863
            ForeColor       =   4210752
            Caption         =   "Ordner:"
            GradiantStyle   =   0
            ForeColorOnMouseMove=   4210752
            Version3        =   -1  'True
         End
         Begin sevCommand3.roLabel roLabel3 
            Height          =   255
            Left            =   120
            TabIndex        =   12
            Top             =   960
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
            BackColor       =   12644863
            ForeColor       =   4210752
            Caption         =   "OrdnerId:"
            GradiantStyle   =   0
            ForeColorOnMouseMove=   0
            Version3        =   -1  'True
         End
         Begin sevCommand3.roLabel roLabel1 
            Height          =   255
            Left            =   120
            TabIndex        =   13
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
            BackColor       =   12644863
            ForeColor       =   4210752
            Caption         =   "Bitte Ordner zur Überwachung auswählen."
            GradiantStyle   =   0
            ForeColorOnMouseMove=   0
            Version3        =   -1  'True
         End
         Begin sevCommand3.Command cmdFold 
            Height          =   285
            Left            =   4080
            TabIndex        =   14
            Top             =   600
            Width           =   330
            _ExtentX        =   582
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
            Caption         =   ""
            Image           =   6109
            UseDefaultMaskColor=   -1  'True
            Version3        =   -1  'True
         End
      End
      Begin VB.Frame grpInfo 
         BackColor       =   &H00C0F1FF&
         Caption         =   "Benachrichtigung"
         ForeColor       =   &H00404040&
         Height          =   1095
         Left            =   4800
         TabIndex        =   4
         Top             =   240
         Width           =   4575
         Begin VB.OptionButton optInfo 
            BackColor       =   &H00C0F1FF&
            Caption         =   "Tabelle"
            ForeColor       =   &H00404040&
            Height          =   255
            Index           =   1
            Left            =   2280
            TabIndex        =   6
            Top             =   600
            Width           =   2167
         End
         Begin VB.OptionButton optInfo 
            BackColor       =   &H00C0F1FF&
            Caption         =   "Tooltip"
            ForeColor       =   &H00404040&
            Height          =   255
            Index           =   0
            Left            =   120
            TabIndex        =   5
            Top             =   600
            Value           =   -1  'True
            Width           =   2167
         End
         Begin sevCommand3.roLabel roLabel4 
            Height          =   255
            Left            =   120
            TabIndex        =   7
            Top             =   240
            Width           =   3495
            _ExtentX        =   6165
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
            BackColor       =   12644863
            ForeColor       =   4210752
            Caption         =   "Wählen Sie die Form der Benachrichtigung"
            GradiantStyle   =   0
            ForeColorOnMouseMove=   0
            Version3        =   -1  'True
         End
      End
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   4320
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
      Caption         =   "&Speichern"
      Image           =   6936
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   7080
      TabIndex        =   1
      Top             =   4320
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
Attribute VB_Name = "frmOptionen"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmHilfe.Hilfe Me.Name
End Sub

Private Sub Form_Load()
Set RS = DB.OpenRecordset("Settings")
RS.MoveFirst
Do Until RS.EOF = True
  Select Case RS("SetName").Value
    Case "SupSnifffold"
      txtFold.Text = RS("SetValue").Value
    Case "SupSnifffoldEntryId"
      txtFoldId.Text = RS("SetValue").Value
    Case "SupSniffNotific"
      optInfo(RS("SetValue").Value).Value = True
    Case "KdMailsDays"
      txtTage.Text = RS("SetValue").Value
    Case "KdMailsDB"
      optKdMailsDB(RS("SetValue").Value).Value = True
      If RS("SetValue").Value = 0 Then
        cmdDBEdit.Enabled = True
      End If
    Case "KdMailsBatch"
      txtParKdMails.Text = RS("SetValue").Value
    Case "KdMailsLOG"
      chkLog.Value = RS("SetValue").Value
      If RS("SetValue").Value = 1 Then
        cmdLOG.Enabled = True
      End If
  End Select
  RS.MoveNext
Loop
End Sub

Private Sub cmdFold_Click()
Set OUTNS = Application.GetNamespace("MAPI")
Set OUTFOLD = OUTNS.PickFolder
txtFold.Text = OUTFOLD.Name
txtFoldId.Text = OUTFOLD.EntryID
End Sub

Private Sub cmdFoldDb_Click()
If FoldIdDB = True Then
  cmdDBEdit.Enabled = True
  optKdMailsDB(0).Value = True
End If
End Sub

Private Sub cmdDBEdit_Click()
frmOptionenFoldDB.Show
End Sub

Private Sub cmdLOG_Click()
frmKdMailsLOG.Show
End Sub

Private Sub cmdSpeichern_Click()
Set RS = DB.OpenRecordset("Settings")
RS.MoveFirst
Do Until RS.EOF = True
  RS.Edit
  Select Case RS("SetName").Value
    Case "SupSnifffold"
      RS("SetValue").Value = txtFold.Text
    Case "SupSnifffoldEntryId"
      RS("SetValue").Value = txtFoldId.Text
    Case "SupSniffNotific"
      For i = optInfo.LBound To optInfo.UBound
        If optInfo(i).Value = True Then
          RS("SetValue").Value = i
          Exit For
        End If
      Next i
    Case "KdMailsDays"
      RS("SetValue").Value = txtTage.Text
    Case "KdMailsDB"
      For i = optKdMailsDB.LBound To optKdMailsDB.UBound
        If optKdMailsDB(i).Value = True Then
          RS("SetValue").Value = i
          Exit For
        End If
      Next i
    Case "SupSniffBatch"
      RS("SetValue").Value = txtParSupSniff.Text
    Case "KdMailsBatch"
      RS("SetValue").Value = txtParKdMails.Text
    Case "KdMailsLOG"
      RS("SetValue").Value = chkLog.Value
  End Select
  RS.Update
  RS.MoveNext
Loop
Unload Me
End Sub

Private Sub cmdEnde_Click()
Unload Me
End Sub
