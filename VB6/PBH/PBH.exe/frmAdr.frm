VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmAdr 
   Caption         =   "Adressverwaltung"
   ClientHeight    =   3180
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4155
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
   ScaleHeight     =   3180
   ScaleWidth      =   4155
   StartUpPosition =   2  'Bildschirmmitte
   Begin sevCommand3.Command cmdBuchung 
      Height          =   285
      Left            =   3840
      TabIndex        =   16
      Top             =   1200
      Width           =   285
      _ExtentX        =   503
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
      Caption         =   ""
      Enabled         =   0   'False
      Image           =   6419
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   2760
      TabIndex        =   9
      Top             =   2760
      Width           =   1335
      _ExtentX        =   2355
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
      Caption         =   "&Ende"
      Image           =   6954
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdSpeichern 
      Height          =   375
      Left            =   1440
      TabIndex        =   7
      Top             =   2760
      Width           =   1335
      _ExtentX        =   2355
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
      Caption         =   "&Speichern"
      Image           =   6122
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.roLabel lbl 
      Height          =   255
      Index           =   0
      Left            =   120
      TabIndex        =   8
      Top             =   120
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
      ForeColor       =   0
      Caption         =   "Adr-Nr."
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtAdrNr 
      Height          =   285
      Left            =   840
      TabIndex        =   0
      Top             =   120
      Width           =   1215
      _ExtentX        =   2143
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
      MaxLength       =   4
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevTextBox.sevText txtAdrName 
      Height          =   285
      Left            =   840
      TabIndex        =   2
      Top             =   600
      Width           =   3255
      _ExtentX        =   5741
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
      MaxLength       =   25
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.roLabel lbl 
      Height          =   255
      Index           =   1
      Left            =   120
      TabIndex        =   10
      Top             =   600
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
      ForeColor       =   0
      Caption         =   "Name"
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtAdrTyp 
      Height          =   285
      Left            =   120
      TabIndex        =   3
      Top             =   1200
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
      Left            =   120
      TabIndex        =   11
      Top             =   960
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
      Caption         =   "Typ"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtAdrStatus 
      Height          =   285
      Left            =   1560
      TabIndex        =   4
      Top             =   1200
      Width           =   1215
      _ExtentX        =   2143
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
      Index           =   3
      Left            =   1560
      TabIndex        =   12
      Top             =   960
      Width           =   1215
      _ExtentX        =   2143
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
      Caption         =   "Status"
      Alignment       =   2
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtAdrSaldo 
      Height          =   285
      Left            =   2880
      TabIndex        =   13
      Top             =   1200
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
   Begin sevCommand3.roLabel lbl 
      Height          =   255
      Index           =   4
      Left            =   2880
      TabIndex        =   14
      Top             =   960
      Width           =   1215
      _ExtentX        =   2143
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
   Begin sevCommand3.Command cmdListe 
      Height          =   285
      Left            =   2880
      TabIndex        =   1
      Top             =   120
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
      Caption         =   "S&uchen"
      Image           =   6419
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdNeu 
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   2760
      Width           =   1335
      _ExtentX        =   2355
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
      Caption         =   "&Neu"
      Image           =   6101
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevTextBox.sevText txtAdrMemo 
      Height          =   1125
      Left            =   840
      TabIndex        =   5
      Top             =   1560
      Width           =   3255
      _ExtentX        =   5741
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
      BorderColor     =   12164479
      BtnBackColor    =   16633531
      BtnBackColorDown=   15968390
      CheckMarkColor  =   2203937
      MultiLine       =   -1  'True
      PopUpFloskel    =   0   'False
      Text            =   ""
      WheelMouse      =   0   'False
      Show            =   -1  'True
   End
   Begin sevCommand3.roLabel lbl 
      Height          =   255
      Index           =   5
      Left            =   120
      TabIndex        =   15
      Top             =   1560
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
      ForeColor       =   0
      Caption         =   "Memo"
      GradiantStyle   =   0
      ForeColorOnMouseMove=   0
      Version3        =   -1  'True
   End
   Begin VB.Line Line1 
      X1              =   120
      X2              =   4080
      Y1              =   480
      Y2              =   480
   End
End
Attribute VB_Name = "frmAdr"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private bolNeu As Boolean

Private Sub Form_Load()
Me.Caption = "Adressverwaltung [" & strUser & "]"
txtAdrTyp.AddItem Kürzel("E"), "E"
txtAdrTyp.AddItem Kürzel("A"), "A"
txtAdrTyp.AddItem Kürzel("U"), "U"
txtAdrStatus.AddItem Kürzel(1), "A"
txtAdrStatus.AddItem Kürzel(0), "I"
End Sub

Private Sub cmdBuchung_Click()
If Buchungen(txtAdrNr, "P") = True Then
  frmBuchungen.Caption = "Buchungen" & txtAdrNr
  frmBuchungen.Show vbModal
Else
  MsgBox FehlerText 'Fehlermeldung
End If
End Sub

Private Sub cmdEnde_Click()
Unload Me
End Sub

Private Sub cmdListe_Click()
If mdlPBH.Liste("AdrNr", "AdrNr, AdrName, AdrSaldo", "Adr", "", "AdrNr") = True Then 'Wenn Liste erfolgreich befüllt wird, wird WAHR zurückgegeben
  frmListe.Show vbModal
  If Not strID = "" Then
    If mdlPBH.LadeDaten("Adr", "AdrNr = '" & strID & "'") = True Then 'Wenn Daten erfolgreich geladen werden, wird WAHR zurückgegeben
      'Werte ins Formular schreiben
      'Felder mit Werten befüllen
      txtAdrNr = RS("AdrNr").Value
      txtAdrName = RS("AdrName").Value
      txtAdrMemo = RS("AdrMemo").Value
      'Saldo eintragen
      If RS("AdrSaldo").Value = "" Then
        txtAdrSaldo = "0"
      Else
        txtAdrSaldo = RS("AdrSaldo").Value
      End If
      'Adresstyp eintragen
      Select Case RS("AdrTyp").Value
        Case "E"
          txtAdrTyp = "Einnahmen"
        Case "A"
          txtAdrTyp = "Ausgaben"
        Case "U"
          txtAdrTyp = "Umbuchung"
      End Select
      'Adresstatus eintragen
      Select Case RS("AdrStatus").Value
        Case "A"
          txtAdrStatus = "Aktiv"
        Case "I"
          txtAdrStatus = "Inaktiv"
      End Select
      bolNeu = False
      If txtAdrSaldo = "0,00 €" Then
        cmdBuchung.Enabled = False
      Else
        cmdBuchung.Enabled = True
      End If
      Exit Sub
    Else
      MsgBox FehlerText 'Fehlermeldung
    End If
  End If
Else
  MsgBox FehlerText 'Fehlermeldung
End If
End Sub

Private Sub cmdNeu_Click()
bolNeu = True
txtAdrNr = ""
txtAdrName = ""
txtAdrTyp.SetListIndex (-1)
txtAdrStatus.SetListIndex (-1)
txtAdrSaldo = "0,00"
txtAdrMemo = ""
cmdBuchung.Enabled = False
End Sub

Private Sub cmdSpeichern_Click()
If Prüfung = True Then
  'Prüfung ohne Fehler beendet
  Speichern
  'Felder entleeren
  txtAdrNr = ""
  txtAdrName = ""
  txtAdrTyp.SetListIndex (-1)
  txtAdrStatus.SetListIndex (-1)
  txtAdrSaldo = "0,00"
  txtAdrMemo = ""
  txtAdrNr.SetFocus
Else
  'Fehler gefunden
  MsgBox FehlerText
End If
End Sub

Private Sub txtAdrNr_LostFocus()
'Abfrage nach eingegebener KtoNr
Set RS = DB.OpenRecordset("Select * from Adr where AdrNr='" & txtAdrNr & "'")
'Prüfung ob AdrNr vorhanden ist
If Not RS.BOF And Not RS.EOF Then
  'Felder mit Werten befüllen
  txtAdrNr = RS("AdrNr").Value
  txtAdrName = RS("AdrName").Value
  txtAdrMemo = RS("AdrMemo").Value
  'Saldo eintragen
  If RS("AdrSaldo").Value = "" Then
    txtAdrSaldo = "0"
  Else
    txtAdrSaldo = RS("AdrSaldo").Value
  End If
  'Adresstyp eintragen
  Select Case RS("AdrTyp").Value
    Case "E"
      txtAdrTyp = "Einnahmen"
    Case "A"
      txtAdrTyp = "Ausgaben"
    Case "U"
      txtAdrTyp = "Umbuchung"
  End Select
  'Adresstatus eintragen
  Select Case RS("AdrStatus").Value
    Case "A"
      txtAdrStatus = "Aktiv"
    Case "I"
      txtAdrStatus = "Inaktiv"
  End Select
  bolNeu = False
  If txtAdrSaldo = "0,00 €" Then
    cmdBuchung.Enabled = False
  Else
    cmdBuchung.Enabled = True
  End If
Else
  txtAdrSaldo = 0
  cmdBuchung.Enabled = False
  bolNeu = True
End If
End Sub

Private Function Prüfung() As Boolean
Prüfung = True
FehlerText = "Folgende Fehler wurden festgestellt:"
'Prüfung ob Adressnummer befüllt ist
If txtAdrNr = "" Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Keine Adressnummer eingetragen"
'Prüfung ob Adressnummer nummerisch ist
ElseIf IsNumeric(txtAdrNr) = False Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Adressnummer muss numerisch sein"
End If
'Prüfung ob Adressname befüllt ist
If txtAdrName = "" Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Kein Adressname eingetragen"
End If
'Prüfung ob Adresstyp ausgewäht ist
If txtAdrTyp = "" Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Keine Adresstyp ausgewählt"
End If
'Prüfung ob Adresstatus ausgewählt ist
If txtAdrStatus = "" Then
  Prüfung = False
  FehlerText = FehlerText & vbCrLf & "- Kein Status ausgewählt"
End If
FehlerText = FehlerText & vbCrLf & vbCrLf & "Bitte korrigieren Sie die eingaben"
End Function

Private Sub Speichern()
If bolNeu = True Then
  'Tabelle Adr öffnen
  Set RS = DB.OpenRecordset("Adr")
  'Neuen Datensatz anlegen
  RS.AddNew
  'Werte Hinzufügen
  RS("AdrNr").Value = txtAdrNr
  RS("AdrAnlag").Value = Now
  RS("AdrUserAnlag").Value = strUser
Else
  RS.Edit
  RS("AdrAendg").Value = Now
  RS("AdrUserAendg").Value = strUser
End If
'Werte Hinzufügen/Update
RS("AdrName").Value = txtAdrName
RS("AdrMemo").Value = txtAdrMemo
RS("AdrTyp").Value = Left(txtAdrTyp, 1)
RS("AdrStatus").Value = Left(txtAdrStatus, 1)
RS("AdrSaldo").Value = txtAdrSaldo
RS.Update
End Sub

