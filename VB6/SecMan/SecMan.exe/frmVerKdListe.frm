VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmVerKdListe 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Kunden"
   ClientHeight    =   2670
   ClientLeft      =   45
   ClientTop       =   315
   ClientWidth     =   3720
   Icon            =   "frmVerKdListe.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2670
   ScaleWidth      =   3720
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin sevListBox.roListBox lstKd 
      Height          =   2295
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   3720
      _ExtentX        =   6562
      _ExtentY        =   4048
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
      ColumnCount     =   2
      ColText1        =   "Nr"
      ColWidth1       =   485
      ColText2        =   "Name"
      ColWidth2       =   3185
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdAusw 
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   2280
      Width           =   1815
      _ExtentX        =   3201
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
      Caption         =   "&Auswählen"
      Enabled         =   0   'False
      Filename        =   "Z:\DEV\SecMan\Icons\UserDetails.ico"
      Image           =   6936
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   1920
      TabIndex        =   2
      Top             =   2280
      Width           =   1815
      _ExtentX        =   3201
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
Attribute VB_Name = "frmVerKdListe"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Sub ZeigeVER ausführen
ZeigeKD

End Sub

Public Sub ZeigeKD()
Dim RsKd As Recordset
Dim i As Integer

'Tabelle KD öffnen
Set RsKd = DBSecMan.OpenRecordset("Kd")
'lstKd leeren
lstKd.Clear

'Prüfen ob Datensatz vorhanden
If Not RsKd.EOF And Not RsKd.BOF Then
    'Wenn Ja werden die Buttons cmdAusw
    cmdAusw.Enabled = True
    RsKd.MoveLast
    RsKd.MoveFirst

  'Schleife zum Befüllen der Liste
  For i = 1 To RsKd.RecordCount
      lstKd.AddItem RsKd("KdId").Value, _
      RsKd("KDID").Value & vbTab & _
      RsKd("VName").Value & " " & RsKd("NName").Value
      RsKd.MoveNext
      lstKd.Refresh
  Next i
        
    'Recordset schließen
    RsKd.Close
Else
MsgBox "Bitte Zuerst Kunde anlegen.", vbOKOnly & vbInformation, "Kein Kunde vorhanden"

End If

End Sub

Private Sub lstKd_DblClick()
'Sub InVer ausführen und KdId und Name übergeben
InVer lstKd.SubItems(lstKd.ListIndex, 1), lstKd.SubItems(lstKd.ListIndex, 2)
Unload Me

End Sub

Private Sub cmdAusw_Click()
'Sub InVer ausführen und KdId und Name übergeben
InVer lstKd.SubItems(lstKd.ListIndex, 1), lstKd.SubItems(lstKd.ListIndex, 2)
Unload Me

End Sub

Private Sub InVer(KdId As Integer, KdName As String)
frmVer.KdId.Text = KdId
frmVer.Kunde.Text = KdName

End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub





