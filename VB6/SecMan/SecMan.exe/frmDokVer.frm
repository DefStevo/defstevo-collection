VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmDokVer 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Veranstaltungen"
   ClientHeight    =   2625
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   3720
   Icon            =   "frmDokVer.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2625
   ScaleWidth      =   3720
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'Fenstermitte
   Begin sevListBox.roListBox lstVer 
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
Attribute VB_Name = "frmDokVer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Sub ZeigeVER ausführen
ZeigeVer

End Sub

Public Sub ZeigeVer()
Dim i As Integer
'lstVER leeren
lstVer.Clear

'Aufruf Prüfen über welches Fenster geöffnet wurde
If Aufruf = 11 Then
  'VER öffnen um alle Veranstaltungen anzuzeigen für welche weder Anbot, Auftrag noch Rechnung erstellt wurde
  Set RS = DBSecMan.OpenRecordset("Select * from VER where Stat=0")
  
ElseIf Aufruf = 21 Then
  'VER öffnen um alle Veranstaltungen anzuzeigen für welche weder Auftrag noch Rechnung erstellt wurde
  Set RS = DBSecMan.OpenRecordset("Select * from VER where Stat <= 1")
  
ElseIf Aufruf = 31 Then
  'VER öffnen um alle Veranstaltungen anzuzeigen für welche noch keine Rechnung erstellt wurde
  Set RS = DBSecMan.OpenRecordset("Select * from VER where Stat <= 2")
  
End If

'Prüfen ob Datensatz vorhanden
If Not RS.EOF And Not RS.BOF Then
    'Wird verwendet um die Datensätze zählen zu lassen und die Funktion RecordCount verwenden zu können
    RS.MoveLast
    RS.MoveFirst
  
  'Schleife zum Befüllen der Liste
  For i = 1 To RS.RecordCount
      'Befehl zum hinzufügen von Datensätzen
      lstVer.AddItem RS("VerId").Value, _
                     RS("VerID").Value & vbTab & RS("VName").Value
        
      'Nächster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      lstVer.Refresh
  Next i
  
RS.Close
End If

End Sub

Private Sub lstVer_DblClick()
'Aufruf Prüfen über welches Fenster geöffnet wurde
If Aufruf = 11 Then
    'Angebot befüllen
    InAnbot
ElseIf Aufruf = 21 Then
    'Auftrag befüllen
    InAuftrag
ElseIf Aufruf = 31 Then
    'Rechnung befüllen
    InRechnung
End If
Unload Me

End Sub

Private Sub cmdAusw_Click()
'Aufruf Prüfen über welches Fenster geöffnet wurde
If Aufruf = 11 Then
    'Angebot befüllen
    InAnbot
ElseIf Aufruf = 21 Then
    'Auftrag befüllen
    InAuftrag
ElseIf Aufruf = 31 Then
    'Rechnung befüllen
    InRechnung
End If
Unload Me

End Sub

Public Sub InAnbot()
'Recordset um Zeiten zu ermitteln
Dim i As Integer

'Sql Select wird in den strSQL geschrieben mit Join auf KD Tabelle
strSQL = "select * from VER INNER JOIN KD on VER.KdId = KD.KdId where VerId=" & lstVer.SubItems(lstVer.ListIndex, 1)

'Tabelle VER und KD wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)

'VerId in vordefiniertes Feld schreiben (In Maske visible = False)
frmAnbot.VerId.Text = RS("VerId").Value
frmAnbot.Ver.Text = RS("VerId").Value & " - " & RS("VER.VName").Value
frmAnbot.SP.Text = RS("SP").Value
frmAnbot.VerAnm.Text = RS("VER.Anm").Value

'Kunden Informationen schreiben
frmAnbot.Kd.Text = RS("KD.VName").Value & " " & RS("NName").Value
frmAnbot.kdAnsch.Text = RS("KD.Adr").Value
frmAnbot.PLZOrt.Text = RS("KD.PLZ").Value & " " & RS("KD.Ort").Value
frmAnbot.KdAnm.Text = RS("KD.Anm").Value

'Tabelle VERZeit öffnen um die Veranstaltungszeiten einzulesen
Set RS = DBSecMan.OpenRecordset("Select * from VERZeit where VerId=" & frmAnbot.VerId.Text)

'Prüfen ob Datensatz vorhanden
If Not RS.BOF And Not RS.EOF Then
    'lstZeit leeren
    frmAnbot.lstZeit.Clear
    'Wird verwendet um die Datensätze zählen zu lassen und die Funktion RecordCount verwenden zu können
    RS.MoveLast
    RS.MoveFirst
  'Schleife zum Befüllen der Liste
  For i = 1 To RS.RecordCount
      'Befehl zum hinzufügen von Datensätzen
      frmAnbot.lstZeit.AddItem i, RS("Begdat").Value & " " & RS("Begzeit").Value & " - " & RS("Enddat").Value & " " & RS("endzeit").Value
      'Nächster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      frmAnbot.lstZeit.Refresh
  Next i
  frmAnbot.lstZeit.DeSelectAll
End If

RS.Close

'Alle Datensätze deselektieren
frmAnbot.lstZeit.DeSelectAll

End Sub

Public Sub InAuftrag()
'Recordset um Zeiten zu ermitteln
Dim i As Integer

'Sql Select wird in den strSQL geschrieben mit Join auf KD Tabelle
strSQL = "select * from VER INNER JOIN KD on VER.KdId = KD.KdId where VerId=" & lstVer.SubItems(lstVer.ListIndex, 1)

'Tabelle VER und KD wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)

'VerId in vordefiniertes Feld schreiben (In Maske visible = False)
frmAuft.VerId.Text = RS("VerId").Value
frmAuft.Ver.Text = RS("VerId").Value & " - " & RS("VER.VName").Value
frmAuft.SP.Text = RS("SP").Value
frmAuft.VerAnm.Text = RS("VER.Anm").Value

'Kunden Informationen schreiben
frmAuft.Kd.Text = RS("KD.VName").Value & " " & RS("NName").Value
frmAuft.kdAnsch.Text = RS("KD.Adr").Value
frmAuft.PLZOrt.Text = RS("KD.PLZ").Value & " " & RS("KD.Ort").Value
frmAuft.KdAnm.Text = RS("KD.Anm").Value

'Tabelle VERZeit öffnen um die Veranstaltungszeiten einzulesen
Set RS = DBSecMan.OpenRecordset("Select * from VERZeit where VerId=" & frmAuft.VerId.Text)

'Prüfen ob Datensatz vorhanden
If Not RS.BOF And Not RS.EOF Then
    'lstZeit leeren
    frmAuft.lstZeit.Clear
    'Wird verwendet um die Datensätze zählen zu lassen und die Funktion RecordCount verwenden zu können
    RS.MoveLast
    RS.MoveFirst
  'Schleife zum Befüllen der Liste
  For i = 1 To RS.RecordCount
      'Befehl zum hinzufügen von Datensätzen
      frmAuft.lstZeit.AddItem i, RS("Begdat").Value & " " & RS("Begzeit").Value & " - " & RS("Enddat").Value & " " & RS("endzeit").Value
      'Nächster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      frmAuft.lstZeit.Refresh
  Next i
  frmAuft.lstZeit.DeSelectAll
End If

RS.Close

'Alle Datensätze deselektieren
frmAuft.lstZeit.DeSelectAll

End Sub

Public Sub InRechnung()
'Recordset um Zeiten zu ermitteln
Dim i As Integer

'Sql Select wird in den strSQL geschrieben mit Join auf KD Tabelle
strSQL = "select * from VER INNER JOIN KD on VER.KdId = KD.KdId where VerId=" & lstVer.SubItems(lstVer.ListIndex, 1)

'Tabelle VER und KD wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)

'VerId in vordefiniertes Feld schreiben (In Maske visible = False)
frmRech.VerId.Text = RS("VerId").Value
frmRech.Ver.Text = RS("VerId").Value & " - " & RS("VER.VName").Value
frmRech.SP.Text = RS("SP").Value
frmRech.VerAnm.Text = RS("VER.Anm").Value

'Kunden Informationen schreiben
frmRech.Kd.Text = RS("KD.VName").Value & " " & RS("NName").Value
frmRech.kdAnsch.Text = RS("KD.Adr").Value
frmRech.PLZOrt.Text = RS("KD.PLZ").Value & " " & RS("KD.Ort").Value
frmRech.KdAnm.Text = RS("KD.Anm").Value

'Tabelle VERZeit öffnen um die Veranstaltungszeiten einzulesen
Set RS = DBSecMan.OpenRecordset("Select * from VERZeit where VerId=" & frmRech.VerId.Text)

'Prüfen ob Datensatz vorhanden
If Not RS.BOF And Not RS.EOF Then
    'lstZeit leeren
    frmRech.lstZeit.Clear
    'Wird verwendet um die Datensätze zählen zu lassen und die Funktion RecordCount verwenden zu können
    RS.MoveLast
    RS.MoveFirst
  'Schleife zum Befüllen der Liste
  For i = 1 To RS.RecordCount
      'Befehl zum hinzufügen von Datensätzen
      frmRech.lstZeit.AddItem i, RS("Begdat").Value & " " & RS("Begzeit").Value & " - " & RS("Enddat").Value & " " & RS("endzeit").Value
      'Nächster Datensatz
      RS.MoveNext
      'Liste aktualisieren
      frmRech.lstZeit.Refresh
  Next i
  frmRech.lstZeit.DeSelectAll
End If

RS.Close

'Alle Datensätze deselektieren
frmRech.lstZeit.DeSelectAll

End Sub

Private Sub cmdEnde_Click()
Unload Me

End Sub





