VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmDokZahl 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Zahlungsbedingung"
   ClientHeight    =   2670
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   5550
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2670
   ScaleWidth      =   5550
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin sevListBox.roListBox lstZahl 
      Height          =   2295
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   5640
      _ExtentX        =   9948
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
      ColText2        =   "Bezeichnung"
      ColWidth2       =   5000
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
      Filename        =   "Z:\DEV\SecMan\Icons\UserDetails.ico"
      Image           =   6936
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   3720
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
Attribute VB_Name = "frmDokZahl"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Sub ZeigeZahl ausführen
ZeigeZahl

End Sub

Public Sub ZeigeZahl()
Dim i As Integer
'lstZahl leeren
lstZahl.Clear

'Tabelle Zahl öffnen
Set RS = DBSecMan.OpenRecordset("ZAHL")

'Prüfen ob Datensatz vorhanden
If Not RS.EOF And Not RS.BOF Then
    'Wird Zahlwendet um die Datensätze zählen zu lassen und die Funktion RecordCount Zahlwenden zu können
    RS.MoveLast
    RS.MoveFirst
  
  'Schleife zum Befüllen der Liste
  For i = 1 To RS.RecordCount
      'Befehl zum hinzufügen von Datensätzen
      lstZahl.AddItem RS("ZahlId").Value, _
                     RS("ZahlID").Value & vbTab & RS("Bez").Value
        
      'Nächster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      lstZahl.Refresh
  Next i
  
RS.Close
End If

End Sub

Private Sub lstZahl_DblClick()
'Aufruf Prüfen über welches Fenster geöffnet wurde
If Aufruf = 11 Or Aufruf = 13 Then
    'Angebot befüllen
    InAnbot
ElseIf Aufruf = 21 Or Aufruf = 23 Then
    'Auftrag befüllen
    InAuftrag
ElseIf Aufruf = 31 Or Aufruf = 33 Then
    'Rechnung befüllen
    InRechnung
End If
Unload Me

End Sub

Private Sub cmdAusw_Click()
'Aufruf Prüfen über welches Fenster geöffnet wurde
If Aufruf = 11 Or Aufruf = 13 Then
    'Angebot befüllen
    InAnbot
ElseIf Aufruf = 21 Or Aufruf = 23 Then
    'Auftrag befüllen
    InAuftrag
ElseIf Aufruf = 31 Or Aufruf = 33 Then
    'Rechnung befüllen
    InRechnung
End If
Unload Me

End Sub

Public Sub InAnbot()
'Zahlungsbedingung in Angebot schreiben
frmAnbot.ZahlId = lstZahl.SubItems(lstZahl.ListIndex, 1)
frmAnbot.Zahl = lstZahl.SubItems(lstZahl.ListIndex, 1) & " - " & lstZahl.SubItems(lstZahl.ListIndex, 2)

End Sub

Public Sub InAuftrag()
'Zahlungsbedingung in Auftrag schreiben
frmAuft.ZahlId = lstZahl.SubItems(lstZahl.ListIndex, 1)
frmAuft.Zahl = lstZahl.SubItems(lstZahl.ListIndex, 1) & " - " & lstZahl.SubItems(lstZahl.ListIndex, 2)

End Sub

Public Sub InRechnung()
'Zahlungsbedingung in Rechnung schreiben
frmRech.ZahlId = lstZahl.SubItems(lstZahl.ListIndex, 1)
frmRech.Zahl = lstZahl.SubItems(lstZahl.ListIndex, 1) & " - " & lstZahl.SubItems(lstZahl.ListIndex, 2)
End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub







