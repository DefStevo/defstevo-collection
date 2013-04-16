VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmKdStamm 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Security Manager - Kundenstamm"
   ClientHeight    =   5505
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9210
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmKdStamm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5505
   ScaleWidth      =   9210
   StartUpPosition =   1  'Fenstermitte
   Begin sevListBox.roListBox lstKd 
      Height          =   4815
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   9000
      _ExtentX        =   15875
      _ExtentY        =   8493
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
      ColumnCount     =   5
      ColText1        =   "Nr"
      ColWidth1       =   485
      ColText2        =   "Name"
      ColWidth2       =   3185
      ColText3        =   "Straße"
      ColWidth3       =   2490
      ColText4        =   "PLZ"
      ColWidth4       =   790
      ColText5        =   "Ort"
      ColWidth5       =   1990
      MustUpdate      =   -1  'True
   End
   Begin sevCommand3.Command cmdNeu 
      Height          =   375
      Left            =   150
      TabIndex        =   1
      Top             =   5040
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
      Caption         =   "&Neu"
      Filename        =   "Z:\DEV\SecMan\Icons\UserAdd.ico"
      Image           =   6606
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEdit 
      Height          =   375
      Left            =   2490
      TabIndex        =   2
      Top             =   5040
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
      Caption         =   "&Bearbeiten"
      Enabled         =   0   'False
      Filename        =   "Z:\DEV\SecMan\Icons\UserDetails.ico"
      Image           =   6608
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdDelete 
      Height          =   375
      Left            =   4815
      TabIndex        =   3
      Top             =   5040
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
      Caption         =   "&Löschen"
      Enabled         =   0   'False
      Filename        =   "Z:\DEV\SecMan\Icons\UserDelete.ico"
      Image           =   6607
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   7080
      TabIndex        =   4
      Top             =   5040
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
End
Attribute VB_Name = "frmKdStamm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
'Sub ZeigeKD ausführen
ZeigeKD

End Sub

Public Sub ZeigeKD()
Dim i As Integer
'lstKd leeren
lstKd.Clear

'Tabelle KD öffnen
Set RS = DBSecMan.OpenRecordset("KD")

'Prüfen ob Datensatz vorhanden
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
    'Befehl zum hinzufügen von Datensätzen
    lstKd.AddItem RS("KdId").Value, _
                  RS("KDID").Value & vbTab & _
                  RS("VName").Value & " " & RS("NName").Value & vbTab & _
                  RS("Adr").Value & vbTab & _
                  RS("PLZ").Value & vbTab & _
                  RS("Ort").Value
    'Nächster Datensatz
    RS.MoveNext
    'Liste aktualisieren
    lstKd.Refresh
Next i

RS.Close

End Sub

Private Sub lstKd_DblClick()
'Funktion KDEdit wird aufgefrufen dabei wird der Wert in Spalte 1 der Tabelle als Kundennummer übergeben
KDEdit (lstKd.SubItems(lstKd.ListIndex, 1))

End Sub

Private Sub cmdNeu_Click()
'Aufruf wird auf 1(Neuer Datensatz) gestellt
Aufruf = 1
frmKD.Show

End Sub

Private Sub cmdEdit_Click()
'Funktion KDEdit wird aufgefrufen dabei wird der Wert in Spalte 1 der Tabelle als Kundennummer übergeben
KDEdit (lstKd.SubItems(lstKd.ListIndex, 1))

End Sub

Private Sub cmdDelete_Click()
Dim i As Integer
Dim strmsg As String
'Select zur Abfrag ob Veranstaltung für den Kunden vorhanden ist
strSQL = "select * from VER where KdId = " & lstKd.SubItems(lstKd.ListIndex, 1)

Set RS = DBSecMan.OpenRecordset(strSQL)

'keine Veranstaltungen vorhanden
If RS.BOF And RS.EOF Then
    'Sql Select wird in den strSQL geschrieben
    strSQL = "select * from KD where KdID =" & lstKd.SubItems(lstKd.ListIndex, 1)

    'Tabelle KD wird mit den oa. Kriterien geöffnet
    Set RS = DBSecMan.OpenRecordset(strSQL)

    'Abfrage ob der Kunden gelöscht werden soll
    If MsgBox("Wollen Sie den Kunden: " & RS("Kdid").Value & " - " & RS("VName").Value & " " & RS("NName").Value & " wirklich löschen?", vbYesNo, "Kunden löschen") = vbYes Then
        'Wenn JA Delete ausführen
        DBSecMan.Execute ("delete from KD where Kdid=" & RS("KDID").Value)
    End If
    'Liste neu laden
    ZeigeKD
'Veranstaltungen sind vorhanden
Else
    RS.MoveLast
    RS.MoveFirst
    'MsgBox Text wird erstellt
    strmsg = "Bitte zuerst Veranstaltungen löschen:"
    For i = 1 To RS.RecordCount
    'VerId und Name in MsgBox Text einfügen
    strmsg = strmsg & vbCrLf & RS("VerId").Value & " - " & RS("VName").Value
    RS.MoveNext
    Next i
    
    'MsgBox anzeigen
    MsgBox strmsg, vbCritical + vbOKOnly, "Kunde kann nicht gelöscht werden"
End If


End Sub

Private Sub KDEdit(KdId As String)
'Sql Select wird in den strSQL geschrieben
strSQL = "select * from KD where KdID =" & KdId
'Tabelle KD wird mit den oa. Kriterien geöffnet
Set RS = DBSecMan.OpenRecordset(strSQL)
'Aufruf wird auf 2(bestehender Datensatz) gestellt
Aufruf = 2
frmKD.Show

End Sub

Private Sub cmdEnde_Click()
Unload frmKD
Unload Me

End Sub

Private Sub Form_Unload(Cancel As Integer)
'frmMenu wird wieder angezeigt
frmMenu.WindowState = 0

End Sub






