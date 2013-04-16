VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmKal 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Security Manager - Kalender"
   ClientHeight    =   5235
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7545
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmKal.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5235
   ScaleWidth      =   7545
   StartUpPosition =   1  'Fenstermitte
   Begin sevCommand3.Command cmdVor 
      Height          =   285
      Left            =   1080
      TabIndex        =   2
      Top             =   120
      Width           =   1335
      _ExtentX        =   2355
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
      Caption         =   "&Vorherige"
      Image           =   6414
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtMon 
      Height          =   285
      Left            =   2520
      TabIndex        =   1
      Top             =   120
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
      Alignment       =   2
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevListBox.roListBox lstKal 
      Height          =   4215
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   7435
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
      ColumnCount     =   3
      ColText1        =   "Veranstaltung"
      ColWidth1       =   3400
      ColText2        =   "Beginn"
      ColWidth2       =   1900
      ColText3        =   "Ende"
      ColWidth3       =   1900
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdWeit 
      Height          =   285
      Left            =   5160
      TabIndex        =   3
      Top             =   120
      Width           =   1335
      _ExtentX        =   2355
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
      Caption         =   "&Nächste"
      Image           =   6413
      PictureAlign    =   1
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   5760
      TabIndex        =   4
      Top             =   4800
      Width           =   1635
      _ExtentX        =   2884
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
   Begin sevTextBox.sevText Mon 
      Height          =   285
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Visible         =   0   'False
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
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevTextBox.sevText Jahr 
      Height          =   285
      Left            =   6600
      TabIndex        =   6
      Top             =   120
      Visible         =   0   'False
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
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      Enabled         =   0   'False
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
End
Attribute VB_Name = "frmKal"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdEnde_Click()
Unload Me
End Sub

Private Sub cmdVor_Click()
If Not Mon.Text = 1 Then
  Mon.Text = Mon.Text - 1
Else
  Mon.Text = 12
  Jahr.Text = Jahr.Text - 1
End If
txtMon.Text = MonthName(Mon.Text) & " " & Jahr.Text
ZeigeVer Mon.Text, Jahr.Text

End Sub

Private Sub cmdWeit_Click()
If Not Mon.Text = 12 Then
  Mon.Text = Mon.Text + 1
Else
  Mon.Text = 1
  Jahr.Text = Jahr.Text + 1
End If
txtMon.Text = MonthName(Mon.Text) & " " & Jahr.Text
ZeigeVer Mon.Text, Jahr.Text

End Sub

Private Sub Form_Load()
Dim Monat As String
Mon.Text = Month(Date)
Jahr.Text = Year(Date)
txtMon.Text = MonthName(Mon.Text) & " " & Jahr.Text
ZeigeVer Mon.Text, Jahr.Text

End Sub

Private Sub ZeigeVer(Monat As Integer, Jahr As Integer)
Dim i As Integer
lstKal.Clear

strSQL = "SELECT VER.VName, Month([BegDat]) AS BegMon, Year([BegDat]) AS BegJahr, Month([EndDat]) AS EndMon, Year([EndDat]) AS EndJahr, VERZeit.BegDat, VERZeit.BegZeit, VERZeit.EndDat, VERZeit.EndZeit " & _
         "FROM VER INNER JOIN VERZeit ON VER.VerId = VERZeit.VerId " & _
         "WHERE (((Month([BegDat]))=" & Monat & ") AND ((Year([BegDat]))=" & Jahr & ")) OR (((Month([EndDat]))=" & Monat & ") AND ((Year([EndDat]))=" & Jahr & ")) OR (((Month([BegDat]))<" & Monat & ") AND ((Year([BegDat]))=" & Jahr & ") AND ((Month([EndDat]))>" & Monat & ") AND ((Year([EndDat]))=" & Jahr & ")) " & _
         "ORDER BY VERZeit.BegDat;"
                  
Set RS = DBSecMan.OpenRecordset(strSQL)
If RS.BOF = False And RS.EOF = False Then
  RS.MoveLast
  RS.MoveFirst
  For i = 1 To RS.RecordCount
    lstKal.AddItem i, RS("VName").Value & vbTab & _
                      RS("BegDat").Value & " - " & RS("BegZeit").Value & vbTab & _
                      RS("EndDat").Value & " - " & RS("EndZeit").Value
    RS.MoveNext
  Next i
End If

End Sub
