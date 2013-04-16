VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmMenu 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Security Manager - Hauptmenu"
   ClientHeight    =   4380
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   8610
   BeginProperty Font 
      Name            =   "Century Gothic"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMenu.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   4380
   ScaleWidth      =   8610
   StartUpPosition =   2  'Bildschirmmitte
   Begin VB.Frame grpDok 
      Caption         =   "Dokumente"
      Height          =   4335
      Left            =   3360
      TabIndex        =   6
      Top             =   0
      Visible         =   0   'False
      Width           =   6255
      Begin sevListBox.roListBox lstDok 
         Height          =   4000
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   6020
         _ExtentX        =   10610
         _ExtentY        =   7064
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         FlatHeaders     =   -1  'True
         ColumnCount     =   2
         ColText1        =   "Programm"
         ColWidth1       =   1980
         ColText2        =   "Beschreibung"
         ColWidth2       =   3980
         MustUpdate      =   -1  'True
      End
   End
   Begin VB.Frame grpStamm 
      Caption         =   "Stammdaten"
      Height          =   4335
      Left            =   2280
      TabIndex        =   4
      Top             =   0
      Width           =   6255
      Begin sevListBox.roListBox lstStamm 
         Height          =   4000
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   6020
         _ExtentX        =   10610
         _ExtentY        =   7064
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Century Gothic"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BackColor       =   -2147483643
         ForeColor       =   -2147483640
         FlatHeaders     =   -1  'True
         ColumnCount     =   2
         ColText1        =   "Programm"
         ColWidth1       =   1980
         ColText2        =   "Beschreibung"
         ColWidth2       =   3980
         MustUpdate      =   -1  'True
      End
   End
   Begin sevCommand3.Command cmdStamm 
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
      Caption         =   "&Stammdaten"
      Image           =   6604
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdDok 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   600
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
      Caption         =   "&Dokumente"
      Image           =   6104
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdEnde 
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   3960
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
      Caption         =   "B&eenden"
      Image           =   6953
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
End
Attribute VB_Name = "frmMenu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdEnde_Click()
Unload Me

End Sub

Private Sub cmdstamm_Click()
grpDok.Visible = False
grpStamm.Visible = True
grpStamm.Left = 2280

End Sub

Private Sub cmdDok_Click()
grpStamm.Visible = False
grpDok.Visible = True
grpDok.Left = 2280

End Sub

Private Sub Form_Load()

With lstStamm 'lststamm mit Werte befüllen
    .AddItem "MaStamm", "MaStamm" & vbTab & "Mitarbeiterstamm"
    .AddItem "KdStamm", "KdStamm" & vbTab & "Kundenstamm"
    .AddItem "VerStamm", "VerStamm" & vbTab & "Veranstaltungsstamm"
    .AddItem "ArtStamm", "ArtStamm" & vbTab & "Artikelstamm"
    .AddItem "ZahlStamm", "ZahlStamm" & vbTab & "Zahlungsbedingungsstamm"
    .AddItem "L1" 'Leerzeile1
    .AddItem "MaList", "MaList" & vbTab & "Mitarbeiterliste"
    .AddItem "KdList", "KdList" & vbTab & "Kundenliste"
    .AddItem "VerList", "VerList" & vbTab & "Veranstalterliste"
    .AddItem "ArtList", "ArtList" & vbTab & "Artikelliste"
End With

With lstDok 'lstDok mit Werte befüllen
    .AddItem "AnbotNeu", "AnbotNeu" & vbTab & "Neues Angebot anlegen"
    .AddItem "AuftNeu", "AuftNeu" & vbTab & "Neuen Auftrag anlegen"
    .AddItem "RechNeu", "RechNeu" & vbTab & "Neue Rechnung anlegen"
    .AddItem "L1" 'Leerzeile
    .AddItem "DokStat", "DokStat" & vbTab & "Dokumentenstatus"
    .AddItem "Kal", "Kal" & vbTab & "Kalender"
End With

End Sub

Private Sub Form_Unload(Cancel As Integer)
'Abfrage ob das Programm wirklich geschlossen werden soll
If MsgBox("Wollen Sie das Programm wirklich beenden?", vbQuestion + vbYesNo, "Beenden") = vbNo Then
    Cancel = 1
    Exit Sub
Else 'Wenn JA geklickt wird werden alle Formulare geschlossen
    Unload frmKD
    Unload frmKdStamm
    Unload frmMA
    Unload frmMaStamm
    Unload frmVer
    Unload frmVerKdListe
    Unload frmVerStamm
    Unload frmDok
    Unload frmDokVer
    Unload frmAnbot
    'Report Engine Beenden
    DREngine.Quit
End If

'!!!Backup Routine einbauen

End Sub

Private Sub lststamm_DblClick()
ProgrammÖffnen (lstStamm.SubItems(lstStamm.ListIndex, 1))

End Sub

Private Sub ProgrammÖffnen(Name As String)
Select Case Name
  Case "MaStamm"
    Me.WindowState = 1
    frmMaStamm.Show
    
  Case "MaList"
    frmDruck.Show
    frmDruck.Refresh
    Druck.MADruck

  Case "KdStamm"
    Me.WindowState = 1
    frmKdStamm.Show
    
  Case "KdList"
    frmDruck.Show
    frmDruck.Refresh
    Druck.KDDruck

  Case "VerStamm"
    Me.WindowState = 1
    frmVerStamm.Show
    
  Case "VerList"
    frmDruck.Show
    frmDruck.Refresh
    Druck.VERDruck
    
  Case "ArtStamm"
    Me.WindowState = 1
    frmArtStamm.Show
    
  Case "ArtList"
    frmDruck.Show
    frmDruck.Refresh
    Druck.ARTDruck
    
  Case "ZahlStamm"
    Me.WindowState = 1
    frmZahlStamm.Show
            
  Case "AnbotNeu"
    'Aufruf auf 11 für neues Angebot stellen
    Aufruf = 11
    Me.WindowState = 1
    frmAnbot.Show
    
  Case "AuftNeu"
    'Aufruf auf 21 für neuen Auftrag stellen
    Aufruf = 21
    Me.WindowState = 1
    frmAuft.Show
    
  Case "RechNeu"
    'Aufruf auf 31 für neue Rechnung stellen
    Aufruf = 31
    Me.WindowState = 1
    frmRech.Show
    
  Case "DokStat"
    Me.WindowState = 1
    frmDok.Show
    
  Case "Kal"
    Me.WindowState = 1
    frmKal.Show


End Select

End Sub

Private Sub lstDok_DblClick()
ProgrammÖffnen (lstDok.SubItems(lstDok.ListIndex, 1))

End Sub
