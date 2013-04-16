VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmArtStamm 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Security Manager - Artikelstamm"
   ClientHeight    =   4815
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7290
   Icon            =   "frmArtStamm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4815
   ScaleWidth      =   7290
   StartUpPosition =   1  'Fenstermitte
   Begin sevListBox.roListBox lstArt 
      Height          =   4095
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   7035
      _ExtentX        =   12409
      _ExtentY        =   7223
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
      ColumnCount     =   4
      ColText1        =   "Nr"
      ColWidth1       =   485
      ColText2        =   "Bezeichnung"
      ColWidth2       =   3185
      ColText3        =   "Einheit"
      ColWidth3       =   2490
      ColText4        =   "Preis"
      ColWidth4       =   790
      ColAlignment4   =   1
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdNeu 
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   4320
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
      Caption         =   "&Neu"
      Filename        =   "Z:\DEV\SecMan\Icons\PriorityHigh.ico"
      Image           =   6606
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEdit 
      Height          =   375
      Left            =   1920
      TabIndex        =   2
      Top             =   4320
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
      Caption         =   "&Bearbeiten"
      Enabled         =   0   'False
      Filename        =   "Z:\DEV\SecMan\Icons\PriorityAuto.ico"
      Image           =   6608
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdDelete 
      Height          =   375
      Left            =   3720
      TabIndex        =   3
      Top             =   4320
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
      Caption         =   "&Löschen"
      Enabled         =   0   'False
      Filename        =   "Z:\DEV\SecMan\Icons\PriorityLow.ico"
      Image           =   6607
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   5520
      TabIndex        =   4
      Top             =   4320
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
End
Attribute VB_Name = "frmArtStamm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Sub ZeigeArt ausführen
ZeigeArt

End Sub

Public Sub ZeigeArt()
Dim i As Integer
'Wird zur Umwandlung des Einheitscodes benötigt 0=Stunde, 1=Pauschal, 2=Stück
Dim strEinh As String
'lstArt leeren
lstArt.Clear

'Tabelle Art öffnen
Set RS = DBSecMan.OpenRecordset("Art")

'Prüfen ob Datensätze vorhanden sind
If Not RS.EOF And Not RS.BOF Then
    'Wenn Ja werden die Buttons cmdEdit und cmdDelete aktiviert
    cmdEdit.Enabled = True
    cmdDelete.Enabled = True
    'Wird verwendet um die Datensätze zählen zu lassen und die Funktion RecordCount verwenden zu können
    RS.MoveLast
    RS.MoveFirst
Else
    'Wenn keine Datensätze vorhanden sind werden die Buttons deaktiviert
    cmdEdit.Enabled = False
    cmdDelete.Enabled = False
End If

'Schleife zum Befüllen der Liste
For i = 1 To RS.RecordCount
  'Umwandlung des Einheitscodes in einen Text
  Select Case RS("Einh").Value
    Case "0"
        strEinh = "Stunde"
    Case "1"
        strEinh = "Pauschal"
    Case "2"
        strEinh = "Stück"
  End Select
  
  'Befehl zum hinzufügen von Datensätzen
    lstArt.AddItem RS("ArtId").Value, _
                   RS("ArtId").Value & vbTab & _
                   RS("Bez").Value & vbTab & _
                   strEinh & vbTab & _
                   FormatCurrency(RS("Preis").Value, 2, vbTrue, vbFalse, vbTrue)
    'Nächster Datensatz
    RS.MoveNext
    'Liste aktualisieren
    lstArt.Refresh
Next i

RS.Close
End Sub

Private Sub lstArt_DblClick()
'Funktion ArtEdit wird aufgefrufen dabei wird der Wert in Spalte 1 der Tabelle als Artikelnummer übergeben
ARTEdit (lstArt.SubItems(lstArt.ListIndex, 1))

End Sub

Private Sub cmdNeu_Click()
'Aufruf wird auf 1(Neuer Datensatz) gestellt
Aufruf = 1
frmArt.Show

End Sub

Private Sub cmdEdit_Click()
'Funktion ArtEdit wird aufgefrufen dabei wird der Wert in Spalte 1 der Tabelle als Artikelnummer übergeben
ARTEdit (lstArt.SubItems(lstArt.ListIndex, 1))

End Sub

Private Sub cmdDelete_Click()
strSQL = "select * from Z where ArtId=" & lstArt.SubItems(lstArt.ListIndex, 1)

Set RS = DBSecMan.OpenRecordset(strSQL)

If RS.BOF And RS.EOF Then
    'Sql Select wird in den strSQL geschrieben
    strSQL = "select * from ART where ArtId =" & lstArt.SubItems(lstArt.ListIndex, 1)

    'Tabelle Art wird mit den oa. Kriterien geöffnet
    Set RS = DBSecMan.OpenRecordset(strSQL)

    'Abfrage ob der Mitarbeiter gelöscht werden soll
    If MsgBox("Wollen Sie den Artikel : " & RS("ArtId").Value & " - " & RS("Bez").Value & " wirklich löschen?", vbYesNo, "Artikel löschen") = vbYes Then
        'Wenn JA Delete ausführen
        DBSecMan.Execute ("delete from ART where ArtId=" & RS("ArtId").Value)
    End If

    'Liste neu laden
    ZeigeArt
Else
    MsgBox "Diser Artikel wird bereits in Angebot, Auftrag bzw. Rechnung verwendet.", vbCritical + vbOKOnly, "Löschen nicht möglich"
End If

End Sub

Private Sub ARTEdit(ArtId As Integer)
'Sql Select wird in den strSQL geschrieben
strSQL = "select * from ART where ArtID =" & ArtId
'Tabelle Art wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)
'Aufruf wird auf 2(bestehender Datensatz) gestellt
Aufruf = 2
frmArt.Show
End Sub

Private Sub cmdEnde_Click()
Unload frmArt
Unload Me

End Sub

Private Sub Form_Unload(Cancel As Integer)
'frmMenu wird wieder angezeigt
frmMenu.WindowState = 0

End Sub




