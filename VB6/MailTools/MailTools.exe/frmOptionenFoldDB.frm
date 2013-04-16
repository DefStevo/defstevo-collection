VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmOptionenFoldDB 
   BackColor       =   &H00C0F1FF&
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "E-Mail Tolls - Ordnerdatenbank"
   ClientHeight    =   3945
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6105
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmOptionenFoldDB.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3945
   ScaleWidth      =   6105
   StartUpPosition =   1  'Fenstermitte
   Begin sevListBox.roListBox lstFold 
      Height          =   2655
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5895
      _ExtentX        =   10398
      _ExtentY        =   4683
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
      GridLines       =   -1  'True
      Sorted          =   -1  'True
      SortAuto        =   -1  'True
      SortSymbols     =   -1  'True
      ColumnCount     =   3
      ColText1        =   "Supportkunde"
      ColWidth1       =   2000
      ColIcon1        =   1
      ColText2        =   "Ordnername"
      ColWidth2       =   3550
      ColText3        =   "EntryID"
      MustUpdate      =   -1  'True
   End
   Begin sevTextBox.sevText txtName 
      Height          =   285
      Left            =   120
      TabIndex        =   1
      Top             =   3120
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
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   3480
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
      Left            =   3480
      TabIndex        =   3
      Top             =   3480
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
   Begin sevCommand3.roLabel roLabel1 
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   2880
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
      BackColor       =   12644863
      ForeColor       =   4210752
      Caption         =   "Supportkunde"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtEntryId 
      Height          =   285
      Left            =   2160
      TabIndex        =   5
      Top             =   3480
      Visible         =   0   'False
      Width           =   2535
      _ExtentX        =   4471
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
      Text            =   "visible = FALSE"
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevTextBox.sevText txtFoldName 
      Height          =   285
      Left            =   1560
      TabIndex        =   6
      Top             =   3120
      Width           =   4455
      _ExtentX        =   7858
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
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.roLabel roLabel2 
      Height          =   255
      Left            =   1560
      TabIndex        =   7
      Top             =   2880
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
      Caption         =   "Outlook - Ordnername"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmOptionenFoldDB"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Idx As Integer

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmHilfe.Hilfe Me.Name
End Sub

Private Sub Form_Load()
lstFold.Clear
Set RS = DB.OpenRecordset("OutFold")
RS.MoveLast
RS.MoveFirst
Do While RS.EOF = False
  lstFold.AddItem , RS("SupKD").Value & vbTab & RS("FoldName").Value & vbTab & RS("EntryId").Value
  lstFold.Refresh
  RS.MoveNext
Loop
End Sub

Private Sub lstFold_DblClick()
txtName.Text = lstFold.SubItems(lstFold.ListIndex, 1)
txtFoldName.Text = lstFold.SubItems(lstFold.ListIndex, 2)
txtEntryId.Text = lstFold.SubItems(lstFold.ListIndex, 3)
Idx = lstFold.ListIndex
End Sub

Private Sub cmdSpeichern_Click()
DB.Execute "Update OutFold set SupKd='" & txtName.Text & "' where EntryId='" & txtEntryId.Text & "'"
lstFold.List(Idx) = txtName.Text & vbTab & txtFoldName.Text & vbTab & txtEntryId.Text
lstFold.DeSelectAll
lstFold.ListIndex = lstFold.SearchItem(txtName.Text)
lstFold.View = Details
txtName.Text = ""
txtFoldName.Text = ""
txtEntryId.Text = ""
End Sub

Private Sub cmdEnde_Click()
Unload Me
End Sub
