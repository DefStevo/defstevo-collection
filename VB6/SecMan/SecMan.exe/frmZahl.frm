VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmZahl 
   Caption         =   "Security Manager - Zahlungsbedingung"
   ClientHeight    =   2460
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6210
   LinkTopic       =   "Form1"
   ScaleHeight     =   2460
   ScaleWidth      =   6210
   StartUpPosition =   3  'Windows-Standard
   Begin VB.Frame grpText 
      Caption         =   "Text"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1455
      Left            =   120
      TabIndex        =   4
      Top             =   480
      Width           =   6015
      Begin sevTextBox.sevText Text 
         Height          =   1125
         Left            =   120
         TabIndex        =   5
         Top             =   240
         Width           =   5775
         _ExtentX        =   10186
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
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColor       =   16633531
         BackColorDisabled=   16633531
         BackColorFocus  =   16633531
         BorderColor     =   12164479
         BorderStyle     =   3
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         MultiLine       =   -1  'True
         PopUpFloskel    =   0   'False
         Text            =   "Text"
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   2040
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
      Filename        =   "Z:\DEV\SecMan\Icons\PriorityHigh.ico"
      Image           =   6122
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   4080
      TabIndex        =   1
      Top             =   2040
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
   Begin sevTextBox.sevText Bez 
      Height          =   285
      Left            =   1560
      TabIndex        =   2
      Top             =   120
      Width           =   4575
      _ExtentX        =   8070
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
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BackColor       =   16633531
      BackColorDisabled=   16633531
      BackColorFocus  =   16633531
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
   Begin sevCommand3.roLabel roLabel1 
      Height          =   255
      Index           =   11
      Left            =   120
      TabIndex        =   3
      Top             =   120
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
      ForeColor       =   0
      Caption         =   "Bezeichnung:"
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmZahl"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Aufruf Prüfen Wenn 2 bestehender Datensatz
If Aufruf = 2 Then
    'Felder mit den Werten aus der Tabelle füllen
    Bez.Text = RS("Bez").Value
    Text.Text = RS("Text").Value
'Wenn 1 neuer Datensatz
ElseIf Aufruf = 1 Then
    'Alle Felder leeren
    Bez.Text = ""
    Text.Text = ""
End If

End Sub

Private Sub cmdSpeichern_Click()
Dim Fehler As Integer
Dim EinMeld As String
'Auf Anfangswert 0 setzen
Fehler = 0
EinMeld = "Bitte Fehlerhafte Eingabe korrigieren" & vbCrLf & vbCrLf

'Alle Feldhintergründe auf Weiß stellen
Bez.BackColor = vbWhite

'Prüfen ob Bezeichnugn angelegt ist
If Bez.Text = "" Then
    Bez.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Bezeichnung muss befüllt sein" & vbCrLf
End If

If Text.Text = "" Then
    Text.BackColor = vbRed
    Fehler = 1
    EinMeld = EinMeld & "  - Zahlungsbedinguns-Text muss befüllt sein" & vbCrLf
End If

If Fehler = 0 Then
    SpeicherZahl
Else
    MsgBox EinMeld, vbInformation + vbOKOnly, "Fehlerhafte Eingabe"
End If

End Sub

Private Sub SpeicherZahl()

If Aufruf = 1 Then
    'Tabelle Zahl öffnen
    Set RS = DBSecMan.OpenRecordset("Zahl")
    'Neuen leeren Datensatz anfügen
    RS.AddNew
Else
    RS.Edit
End If

RS("Bez").Value = Bez.Text
RS("Text").Value = Text.Text

'Recordset aktualisieren
RS.Update

'Recordset schließen
RS.Close

'Fenster schließen
Unload Me

End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub

Private Sub Form_Unload(Cancel As Integer)
'Aufruf auf 0 Stellen
Aufruf = 0

'Im ZahlStamm die Liste neu laden
frmZahlStamm.ZeigeZahl

End Sub

