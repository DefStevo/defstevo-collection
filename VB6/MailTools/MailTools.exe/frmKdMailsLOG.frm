VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmKdMailsLOG 
   BackColor       =   &H00C0F1FF&
   Caption         =   "E-Mail Tools - KdMails LOG"
   ClientHeight    =   5295
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7575
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmKdMailsLOG.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   5295
   ScaleWidth      =   7575
   StartUpPosition =   1  'Fenstermitte
   Begin sevTextBox.sevText txtLOG 
      Height          =   4845
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   7575
      _ExtentX        =   13361
      _ExtentY        =   8546
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
      AutoComplete    =   0   'False
      AutoSelect      =   0   'False
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
      MultiLine       =   -1  'True
      PopUpFloskel    =   0   'False
      ScrollBars      =   2
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   4920
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
      Caption         =   "&Log Leeren"
      Image           =   6933
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   5040
      TabIndex        =   2
      Top             =   4920
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
Attribute VB_Name = "frmKdMailsLOG"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmHilfe.Hilfe Me.Name
End Sub

Private Sub cmdEnde_Click()
Unload Me
End Sub

Private Sub cmdSpeichern_Click()
DB.Execute ("Delete * from KdMailsLOG")
DB.Execute ("Update Settings set SetValue='FALSE' where SetName='KdMailsBatchLOG'")
frmOptionen.cmdLOG.Enabled = False
Unload Me
End Sub

Private Sub Form_Load()
Set RS = DB.OpenRecordset("select * from KdMailsLOG order by Date desc, Time")
RS.MoveLast
RS.MoveFirst
Do Until RS.EOF = True
txtLOG.Text = txtLOG.Text & RS("Date").Value & " " & _
                            RS("Time").Value & vbCrLf & _
                            "Betreff: " & RS("Subject").Value & vbCrLf & _
                            RS("SupKd").Value & ": " & _
                            RS("FoldNAme").Value & vbCrLf & vbCrLf
RS.MoveNext
Loop
End Sub
