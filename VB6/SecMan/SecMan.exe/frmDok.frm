VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmDok 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Security Manager - Dokumente"
   ClientHeight    =   6240
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9825
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmDok.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6240
   ScaleWidth      =   9825
   StartUpPosition =   1  'Fenstermitte
   Begin VB.Frame grpRech 
      Caption         =   "Rechnung"
      Height          =   5055
      Left            =   1800
      TabIndex        =   12
      Top             =   600
      Visible         =   0   'False
      Width           =   9495
      Begin sevListBox.roListBox lstRech 
         Height          =   4695
         Left            =   120
         TabIndex        =   5
         Top             =   240
         Width           =   9255
         _ExtentX        =   16325
         _ExtentY        =   8281
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
         ColumnCount     =   5
         ColText1        =   "RENr"
         ColWidth1       =   1100
         ColText2        =   "Veranstaltung"
         ColWidth2       =   4180
         ColText3        =   "Datum"
         ColWidth3       =   1200
         ColText4        =   "Wert-Nto"
         ColWidth4       =   1200
         ColAlignment4   =   1
         ColText5        =   "Status"
         ColWidth5       =   1500
         MustUpdate      =   -1  'True
      End
   End
   Begin VB.Frame grpAuft 
      Caption         =   "Auftrag"
      Height          =   5055
      Left            =   960
      TabIndex        =   11
      Top             =   600
      Visible         =   0   'False
      Width           =   9495
      Begin sevListBox.roListBox lstAuft 
         Height          =   4695
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   9255
         _ExtentX        =   16325
         _ExtentY        =   8281
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
         ColumnCount     =   5
         ColText1        =   "AUNr"
         ColWidth1       =   1100
         ColText2        =   "Veranstaltung"
         ColWidth2       =   4180
         ColText3        =   "Datum"
         ColWidth3       =   1200
         ColText4        =   "Wert-Nto"
         ColWidth4       =   1200
         ColAlignment4   =   1
         ColText5        =   "Status"
         ColWidth5       =   1500
         MustUpdate      =   -1  'True
      End
   End
   Begin VB.Frame grpAnbot 
      Caption         =   "Angebot"
      Height          =   5055
      Left            =   120
      TabIndex        =   10
      Top             =   600
      Visible         =   0   'False
      Width           =   9495
      Begin sevListBox.roListBox lstAnbot 
         Height          =   4695
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   9255
         _ExtentX        =   16325
         _ExtentY        =   8281
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
         ColumnCount     =   5
         ColText1        =   "ANNr"
         ColWidth1       =   1100
         ColText2        =   "Veranstaltung"
         ColWidth2       =   4180
         ColText3        =   "Datum"
         ColWidth3       =   1200
         ColText4        =   "Wert-Nto"
         ColWidth4       =   1200
         ColAlignment4   =   1
         ColText5        =   "Status"
         ColWidth5       =   1500
         MustUpdate      =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdAnbot 
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2055
      _ExtentX        =   3625
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   9.75
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
      ToolTipIcon     =   1
      BorderStyle     =   2
      ButtonStyle     =   5
      Caption         =   "&Angebot"
      CheckButton     =   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdAuft 
      Height          =   375
      Left            =   3840
      TabIndex        =   2
      Top             =   120
      Width           =   2055
      _ExtentX        =   3625
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   9.75
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
      ToolTipIcon     =   1
      BorderStyle     =   2
      ButtonStyle     =   5
      Caption         =   "A&uftrag"
      CheckButton     =   -1  'True
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdRech 
      Height          =   375
      Left            =   7560
      TabIndex        =   4
      Top             =   120
      Width           =   2055
      _ExtentX        =   3625
      _ExtentY        =   661
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Century Gothic"
         Size            =   9.75
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
      ToolTipIcon     =   1
      BorderStyle     =   2
      ButtonStyle     =   5
      Caption         =   "&Rechnung"
      CheckButton     =   -1  'True
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdNeu 
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   5760
      Width           =   1875
      _ExtentX        =   3307
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
      Caption         =   "&Neu"
      Enabled         =   0   'False
      Filename        =   "C:\DEV\Icons\emuleCollAdd.ico"
      Image           =   6606
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEdit 
      Height          =   375
      Left            =   2640
      TabIndex        =   7
      Top             =   5760
      Width           =   1875
      _ExtentX        =   3307
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
      Caption         =   "&Bearbeiten"
      Enabled         =   0   'False
      Filename        =   "C:\DEV\Icons\emuleCollEdit.ico"
      Image           =   6608
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   7800
      TabIndex        =   9
      Top             =   5760
      Width           =   1875
      _ExtentX        =   3307
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
   Begin sevCommand3.Command cmdUeber 
      Height          =   375
      Left            =   5280
      TabIndex        =   8
      Top             =   5760
      Width           =   1875
      _ExtentX        =   3307
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
      Caption         =   "&Überleitung"
      Enabled         =   0   'False
      Filename        =   "Z:\DEV\SecMan\Icons\ConnectedNotNot.ico"
      Image           =   6603
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmDok"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAnbot_Click()
cmdAnbot.Checked = True
cmdAuft.Checked = False
cmdRech.Checked = False
cmdNeu.Enabled = True

grpAnbot.Visible = True
grpAnbot.Left = 120
grpAuft.Visible = False
grpRech.Visible = False

ZeigeDok "QrAN", lstAnbot

End Sub

Private Sub cmdAuft_Click()
cmdAnbot.Checked = False
cmdAuft.Checked = True
cmdRech.Checked = False
cmdNeu.Enabled = True

grpAnbot.Visible = False
grpAuft.Visible = True
grpAuft.Left = 120
grpRech.Visible = False

ZeigeDok "QrAU", lstAuft

End Sub

Private Sub cmdRech_Click()
cmdAnbot.Checked = False
cmdAuft.Checked = False
cmdRech.Checked = True
cmdNeu.Enabled = True

grpAnbot.Visible = False
grpAuft.Visible = False
grpRech.Visible = True
grpRech.Left = 120

ZeigeDok "QrRE", lstRech

End Sub

Public Sub ZeigeDok(Querry As String, Liste As roListBox)
Dim i As Integer
Dim strStat As String
'Liste leeren
Liste.Clear
'Buttons Deaktivieren
cmdEdit.Enabled = False
cmdUeber.Enabled = False

'Querry öffnen
Set RS = DBSecMan.OpenRecordset(Querry)

'Prüfen ob Datensätze vorhanden sind
If Not RS.BOF And Not RS.EOF Then
    RS.MoveLast
    RS.MoveFirst
    cmdEdit.Enabled = True
    'Prüfen ob nicht die Rechnungen angezeigt werdne und die Überleitung aktivieren
    If Not cmdRech.Checked Then cmdUeber.Enabled = True
    
  'Schleife zum befüllen der Liste
  For i = 1 To RS.RecordCount
      'Status ermitteln
    If RS("Stat").Value = 0 Then
        strStat = "Gespeichert"
    ElseIf RS("Stat").Value = 1 Then
        strStat = "Gedruckt"
    ElseIf RS("Stat").Value = 2 Then
      If cmdAnbot.Checked = True Then
          strStat = "=> Auftrag"
      ElseIf cmdAuft.Checked = True Then
          strStat = "=> Rechnung"
      ElseIf cmdRech.Checked = True Then
          strStat = "bezahlt"
      End If
    Else
        Stat = "Bezahlt"
    End If
  
      'Liste befüllen
      Liste.AddItem RS("Nr").Value, RS("Nr").Value & vbTab & _
                                RS("VName").Value & vbTab & _
                                RS("Dat").Value & vbTab & _
                                FormatCurrency(RS("Wert").Value, 2, vbTrue, vbFalse, vbTrue) & vbTab & _
                                strStat
      'Liste aktualisieren
      Liste.Refresh
      RS.MoveNext
  Next i
End If

RS.Close

End Sub

Private Sub cmdUeber_Click()
If cmdAnbot.Checked = True Then
    InAuft
ElseIf cmdAuft.Checked = True Then
    InRech
End If
End Sub

Private Sub InAuft()
If lstAnbot.SubItems(lstAnbot.ListIndex, 5) = "=> Auftrag" Then
    MsgBox "Angebot wurde bereits übergeleitet," & vbCrLf & "kein Überleitung möglich", vbInformation + vbOKOnly, "Angebot bereits übergeleitet"
Else
    'Sql Select wird in den strSQL geschrieben
    strSQL = "select * from AN where ANNr='" & lstAnbot.SubItems(lstAnbot.ListIndex, 1) & "'"
    
    'Tabelle AN wird mit den oa. Kriterien geöffnet
    Set RS = DBSecMan.OpenRecordset(strSQL)

    Aufruf = 23
    frmAuft.Show
End If

End Sub

Private Sub InRech()
If lstAuft.SubItems(lstAuft.ListIndex, 5) = "=> Rechnung" Then
    MsgBox "Auftrag wurde bereits übergeleitet," & vbCrLf & "kein Überleitung möglich", vbInformation + vbOKOnly, "Auftrag bereits übergeleitet"
Else
    'Sql Select wird in den strSQL geschrieben
    strSQL = "select * from AU where AUNr='" & lstAuft.SubItems(lstAuft.ListIndex, 1) & "'"

    'Tabelle AN wird mit den oa. Kriterien geöffnet
    Set RS = DBSecMan.OpenRecordset(strSQL)

    Aufruf = 33
    frmRech.Show
End If


End Sub

Private Sub lstAnbot_DblClick()
Aufruf = 12
AnbotEdit

End Sub

Private Sub lstAuft_DblClick()
Aufruf = 22
AuftEdit

End Sub

Private Sub lstRech_DblClick()
Aufruf = 32
RechEdit

End Sub

Private Sub cmdNeu_Click()
If cmdAnbot.Checked = True Then
    'Aufruf auf 11 für neues Angebot stellen
    Aufruf = 11
    frmAnbot.Show
ElseIf cmdAuft.Checked = True Then
    'Aufruf auf 21 für neuer Auftrag stellen
    Aufruf = 21
    frmAuft.Show
ElseIf cmdRech.Checked = True Then
    'Aufruf auf 31 für neue Rechnung stellen
    Aufruf = 31
    frmRech.Show
End If
End Sub

Private Sub cmdEdit_Click()
If cmdAnbot.Checked = True Then
    'Aufruf auf 12 bestehendes Angebot stellen
    Aufruf = 12
    AnbotEdit
    
ElseIf cmdAuft.Checked = True Then
    'Aufruf auf 22 bestehender Auftrag stellen
    Aufruf = 22
    AuftEdit
ElseIf cmdRech.Checked = True Then
    'Aufruf auf 32 bestehende Rechnung stellen
    Aufruf = 32
    RechEdit
End If

End Sub

Private Sub AnbotEdit()
'Sql Select wird in den strSQL geschrieben
strSQL = "select * from AN where ANNr='" & lstAnbot.SubItems(lstAnbot.ListIndex, 1) & "'"

'Tabelle AN wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)

frmAnbot.Show

End Sub

Private Sub AuftEdit()
'Sql Select wird in den strSQL geschrieben
strSQL = "select * from AU where AUNr='" & lstAuft.SubItems(lstAuft.ListIndex, 1) & "'"

'Tabelle AU wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)

frmAuft.Show

End Sub

Private Sub RechEdit()
'Sql Select wird in den strSQL geschrieben
strSQL = "select * from RE where RENr='" & lstRech.SubItems(lstRech.ListIndex, 1) & "'"

'Tabelle RE wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)

frmRech.Show

End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub

Private Sub Form_Unload(Cancel As Integer)
frmMenu.WindowState = 0

End Sub
