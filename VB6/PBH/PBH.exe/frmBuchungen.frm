VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmBuchungen 
   Caption         =   "Buchungen"
   ClientHeight    =   5880
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   12825
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
   ScaleHeight     =   5880
   ScaleWidth      =   12825
   StartUpPosition =   2  'Bildschirmmitte
   Begin sevCommand3.Command cmdExcel 
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   5520
      Width           =   2295
      _ExtentX        =   4048
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
      Caption         =   "&Excel"
      Image           =   6800
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevListBox.roListBox lst 
      Height          =   5535
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   12855
      _ExtentX        =   22675
      _ExtentY        =   9763
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
      ColumnCount     =   11
      ColText1        =   "Id"
      ColWidth1       =   500
      ColText2        =   "Datum"
      ColWidth2       =   1000
      ColText3        =   "Status"
      ColWidth3       =   1000
      ColText4        =   "Bst."
      ColWidth4       =   500
      ColText5        =   "Name"
      ColWidth5       =   2000
      ColText6        =   "Kto"
      ColWidth6       =   500
      ColText7        =   "Name"
      ColWidth7       =   2000
      ColText8        =   "Adr"
      ColWidth8       =   500
      ColText9        =   "Name"
      ColWidth9       =   2000
      ColText10       =   "Betrag"
      ColWidth10      =   800
      ColAlignment10  =   1
      ColText11       =   "Text"
      ColWidth11      =   2000
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   10560
      TabIndex        =   2
      Top             =   5520
      Width           =   2295
      _ExtentX        =   4048
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
      Caption         =   "&Schlieﬂen"
      Image           =   6953
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmBuchungen"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdEnde_Click()
Unload Me
End Sub

Private Sub cmdExcel_Click()
Dim F As Integer
Dim i As Integer
Dim strDateiName As String
strDateiName = App.Path & "\" & frmBuchungen.Caption & ".csv"
Dim strDatei As String
strDatei = "Nr;Datum;Status;Bst.;Name;Kto;Name;Adr;Name;Betrag;Text" & vbCrLf
For i = 1 To lst.ListCount
strDatei = strDatei & lst.SubItems(i, 1) & ";" & _
                      lst.SubItems(i, 2) & ";" & _
                      lst.SubItems(i, 3) & ";" & _
                      lst.SubItems(i, 4) & ";" & _
                      lst.SubItems(i, 5) & ";" & _
                      lst.SubItems(i, 6) & ";" & _
                      lst.SubItems(i, 7) & ";" & _
                      lst.SubItems(i, 8) & ";" & _
                      lst.SubItems(i, 9) & ";" & _
                      lst.SubItems(i, 10) & ";" & _
                      lst.SubItems(i, 11)
If Not i = lst.ListCount Then
  strDatei = strDatei & vbCrLf
End If
Next i
F = FreeFile
Open strDateiName For Output As #F
  Print #F, strDatei
Close #F
Shell "C:\programme\Microsoft Office\office11\Excel.exe " & strDateiName, vbNormalFocus
End Sub
