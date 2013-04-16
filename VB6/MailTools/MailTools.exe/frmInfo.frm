VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Begin VB.Form frmInfo 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   0  'Kein
   Caption         =   "Form1"
   ClientHeight    =   3330
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6360
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
   ScaleHeight     =   3330
   ScaleWidth      =   6360
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin sevCommand3.roLabel roLabel1 
      Height          =   3375
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   6375
      _ExtentX        =   11245
      _ExtentY        =   5953
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
      ForeColor       =   12644863
      Gradiant        =   -1  'True
      GradiantStyle   =   0
      FromColor       =   12644863
      ToColor         =   10086655
      ForeColorOnMouseMove=   12644863
      Version3        =   -1  'True
      Begin sevCommand3.roLabel lblInfo 
         Height          =   255
         Left            =   1200
         TabIndex        =   4
         Top             =   3000
         Width           =   5055
         _ExtentX        =   8916
         _ExtentY        =   450
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   6
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   4210752
         Caption         =   "ESC um den Dialog zu schlieﬂen."
         Alignment       =   1
         Gradiant        =   -1  'True
         GradiantStyle   =   0
         FromColor       =   12119807
         ToColor         =   10086655
         ForeColorOnMouseMove=   4210752
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lblCopyright 
         Height          =   255
         Left            =   1200
         TabIndex        =   3
         Top             =   2640
         Width           =   5055
         _ExtentX        =   8916
         _ExtentY        =   450
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   6
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   4210752
         Caption         =   "Detailbeschreibung"
         Alignment       =   1
         Gradiant        =   -1  'True
         GradiantStyle   =   0
         FromColor       =   12119807
         ToColor         =   10086655
         ForeColorOnMouseMove=   4210752
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lblDetail 
         Height          =   135
         Left            =   2160
         TabIndex        =   2
         Top             =   2400
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   238
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   4210752
         Caption         =   "Detailbeschreibung"
         Gradiant        =   -1  'True
         GradiantStyle   =   0
         FromColor       =   11726335
         ToColor         =   10086655
         ForeColorOnMouseMove=   4210752
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lblName 
         Height          =   375
         Left            =   2160
         TabIndex        =   1
         Top             =   2040
         Width           =   4095
         _ExtentX        =   7223
         _ExtentY        =   661
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   4210752
         Caption         =   "Name Version"
         Gradiant        =   -1  'True
         GradiantStyle   =   0
         FromColor       =   11726335
         ToColor         =   10086655
         ForeColorOnMouseMove=   4210752
         Version3        =   -1  'True
      End
      Begin VB.Image Image1 
         Height          =   3330
         Left            =   0
         Picture         =   "frmInfo.frx":0000
         Top             =   0
         Width           =   6360
      End
   End
End
Attribute VB_Name = "frmInfo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyPress(KeyAscii As Integer)
If KeyAscii = 27 Then
  Unload Me
End If
End Sub

Private Sub Form_Load()
lblName.Caption = App.EXEName & "   v." & App.Major & "." & App.Minor & "." & App.Revision
lblDetail.Caption = App.FileDescription
lblCopyright.Caption = App.LegalCopyright
End Sub
