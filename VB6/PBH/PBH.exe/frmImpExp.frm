VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmImpExp 
   Caption         =   "Import/Export"
   ClientHeight    =   4575
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
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
   ScaleHeight     =   4575
   ScaleWidth      =   4680
   StartUpPosition =   2  'Bildschirmmitte
   Begin VB.Frame frmExp 
      Caption         =   "Vorlage exportieren"
      Height          =   3015
      Left            =   0
      TabIndex        =   6
      Top             =   1560
      Width           =   4695
      Begin VB.CheckBox chkExcel 
         Caption         =   "PBH Quick Editor sofort Starten"
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   2160
         Width           =   4455
      End
      Begin sevCommand3.Command cmdExpPfad 
         Height          =   285
         Left            =   4320
         TabIndex        =   7
         Top             =   360
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
         Image           =   6111
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtExpDatei 
         Height          =   285
         Left            =   720
         TabIndex        =   8
         Top             =   360
         Width           =   3615
         _ExtentX        =   6376
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   9
         Top             =   360
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
         Caption         =   "Pfad:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin MSComDlg.CommonDialog dlgExpPfad 
         Left            =   4200
         Top             =   120
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin sevCommand3.Command cmdStartExp 
         Height          =   405
         Left            =   120
         TabIndex        =   10
         Top             =   2520
         Width           =   4485
         _ExtentX        =   7911
         _ExtentY        =   714
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
         Caption         =   "&Export starten"
         Image           =   6606
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
      Begin VB.Frame frmInh 
         Caption         =   "Inhalte"
         Enabled         =   0   'False
         Height          =   1335
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   4455
         Begin VB.CheckBox chkBuchMemo 
            Caption         =   "Memo"
            Height          =   255
            Left            =   2160
            TabIndex        =   19
            Top             =   960
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchText 
            Caption         =   "Buchungstext"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2160
            TabIndex        =   18
            Top             =   480
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchKtoBetrag 
            Caption         =   "Betrag"
            Enabled         =   0   'False
            Height          =   255
            Left            =   2160
            TabIndex        =   17
            Top             =   240
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchAdr 
            Caption         =   "Adresse"
            Height          =   255
            Left            =   2160
            TabIndex        =   16
            Top             =   720
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchKto 
            Caption         =   "Gegenkonto"
            Enabled         =   0   'False
            Height          =   255
            Left            =   120
            TabIndex        =   15
            Top             =   960
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchKtoBestand 
            Caption         =   "Bestandskonto"
            Enabled         =   0   'False
            Height          =   255
            Left            =   120
            TabIndex        =   14
            Top             =   720
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchArt 
            Caption         =   "Buchungsart"
            Enabled         =   0   'False
            Height          =   255
            Left            =   120
            TabIndex        =   13
            Top             =   480
            Value           =   1  'Aktiviert
            Width           =   1575
         End
         Begin VB.CheckBox chkBuchDat 
            Caption         =   "Buchungsdatum"
            Enabled         =   0   'False
            Height          =   255
            Left            =   120
            TabIndex        =   12
            Top             =   240
            Value           =   1  'Aktiviert
            Width           =   1815
         End
      End
   End
   Begin VB.Frame frmImp 
      Caption         =   "Importieren"
      Height          =   1575
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   4695
      Begin VB.CheckBox chkLösche 
         Caption         =   "Datei nach Import löschen"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   720
         Width           =   4455
      End
      Begin sevCommand3.Command cmdImpPfad 
         Height          =   285
         Left            =   4320
         TabIndex        =   3
         Top             =   360
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
         Image           =   6111
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtImpDatei 
         Height          =   285
         Left            =   720
         TabIndex        =   1
         Top             =   360
         Width           =   3615
         _ExtentX        =   6376
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
         BackColorDisabled=   16633531
         BorderColor     =   12164479
         BtnBackColor    =   16633531
         BtnBackColorDown=   15968390
         CheckMarkColor  =   2203937
         Enabled         =   0   'False
         ForeColorDisabled=   -2147483640
         PopUpFloskel    =   0   'False
         Text            =   ""
         WheelMouse      =   0   'False
         Show            =   -1  'True
      End
      Begin sevCommand3.roLabel lbl 
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   2
         Top             =   360
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
         Caption         =   "Pfad:"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin MSComDlg.CommonDialog dlgImpPfad 
         Left            =   4200
         Top             =   120
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin sevCommand3.Command cmdStartImp 
         Height          =   405
         Left            =   120
         TabIndex        =   5
         Top             =   1080
         Width           =   4485
         _ExtentX        =   7911
         _ExtentY        =   714
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
         Caption         =   "&Import starten"
         Image           =   6602
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
   End
End
Attribute VB_Name = "frmImpExp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdExpPfad_Click()
With dlgImpPfad
  .Filter = "PBH Import Datei|Import*.csv|" & _
            "Alle Dateien|*.*"
  .FileName = txtImpDatei
  .ShowSave
  
  If .FileName <> "" Then
    txtExpDatei = .FileName
  End If
End With
End Sub

Private Sub cmdImpPfad_Click()
With dlgImpPfad
  .Filter = "PBH Import Datei|Import*.csv|" & _
            "Alle Dateien|*.*"
  .FileName = txtImpDatei
  .ShowOpen
  
  If .FileName <> "" Then
    txtImpDatei = .FileName
  End If
End With
End Sub

Private Sub cmdStartExp_Click()
Dim F As Integer
Dim strDatei As String
strDatei = "BuchDate;BuchArt;BuchKtoBestand;BuchKto;BuchKtoBetrag;BuchText"
If chkBuchAdr.Value = 1 Then
  strDatei = strDatei & ";BuchAdr"
End If
If chkBuchMemo.Value = 1 Then
  strDatei = strDatei & ";BuchMemo"
End If
F = FreeFile
Open txtExpDatei For Output As #F
  Print #F, strDatei
Close #F
If chkExcel.Value = 1 Then
  Shell App.Path & "\PBHQE.exe " & txtExpDatei, vbNormalFocus
End If
End Sub

Private Sub cmdStartImp_Click()
On Error GoTo Err:
Dim F As Integer
Dim iLine As Integer
Dim strZeile As String
Dim aText() As String
'On Error GoTo Err
F = FreeFile
iLine = 1
Open txtImpDatei For Input As #F
' Zeilen aus Textdatei einlesen und in Variable AllText speichern
Do Until EOF(F)
  Line Input #F, strZeile
  If Not iLine = 1 Then
    aText = Split(strZeile, ";", -1)
    If Not ImpBuchung(aText(0), aText(1), aText(2), aText(3), aText(4), aText(5), aText(6), aText(7)) = True Then
      MsgBox FehlerText & vbCrLf & "in Zeile " & iLine
    End If
  End If
  iLine = iLine + 1
Loop
Close #F
If Not frmImpTabelle.lstData.ListCount = 0 Then
  frmImpTabelle.Show vbModal
Else
  MsgBox "Keine Daten zum Verbuchen vorhanden"
End If
If chkLösche.Value = 1 Then
  Kill txtImpDatei
End If
Exit Sub
Err:
MsgBox "Fehler " & Err.Number & " - " & Err.Description, vbOKOnly, "Folgender Fehler ist aufgetreten"
End Sub

Private Sub Form_Load()
Me.Caption = "Import/Export [" & strUser & "]"
txtImpDatei = App.Path & "\Import" & Format(Now, "dd") & Format(Now, "MM") & Format(Now, "YY") & ".csv"
txtExpDatei = App.Path & "\Import" & Format(Now, "DD") & Format(Now, "MM") & Format(Now, "YY") & ".csv"
End Sub

Function ImpBuchung(BuchDat As String, BuchArt As String, BuchKtoBestand As String, BuchKto As String, BuchKtoBetrag As String, BuchText As String, BuchAdr As String, BuchMemo As String) As Boolean
Dim BuchKtoBestandName As String
Dim BuchKtoName As String
Dim BuchAdrName As String
ImpBuchung = True
On Error GoTo Err
Set RS = DB.OpenRecordset("Select KtoName from Kto where KtoNr='" & BuchKtoBestand & "'")
If Not RS.BOF And Not RS.EOF Then
  BuchKtoBestandName = RS("KtoName").Value
Else
  BuchKtoBestandName = "Bestandskonto '" & BuchKtoBestand & "' nicht vorhanden"
  BuchKtoBestand = ""
End If
Set RS = DB.OpenRecordset("Select KtoName from Kto where KtoNr='" & BuchKto & "'")
If Not RS.BOF And Not RS.EOF Then
  BuchKtoName = RS("KtoName").Value
Else
  BuchKtoName = "Gegenkonto '" & BuchKto & "' nicht vorhanden"
  BuchKto = ""
End If
If Not BuchAdr = "" Then
  Set RS = DB.OpenRecordset("Select AdrName from Adr where AdrNr='" & BuchAdr & "'")
  If Not RS.BOF And Not RS.EOF Then
    BuchAdrName = RS("AdrName").Value
  Else
    BuchAdrName = "Adresse '" & BuchAdr & "' nicht vorhanden"
    BuchAdr = ""
  End If
End If
frmImpTabelle.lstData.AddItem , Format(BuchDat, "DD.MM.YYYY") & vbTab & _
                                BuchArt & vbTab & _
                                BuchKtoBestand & vbTab & _
                                BuchKtoBestandName & vbTab & _
                                BuchKto & vbTab & _
                                BuchKtoName & vbTab & _
                                Format(BuchKtoBetrag, "#,##0.00 €") & vbTab & _
                                BuchText & vbTab & _
                                BuchAdr & vbTab & _
                                BuchAdrName & vbTab & _
                                BuchMemo
frmImpTabelle.lstData.DeSelectAll
Exit Function
Err:
ImpBuchung = False
FehlerText = "Fehler" & Err.Number & " " & Err.Description & vbCrLf & _
             BuchDat & ", " & BuchArt & ", " & BuchKtoBestand & ", " & BuchKto & ", " & BuchKtoBetrag & ", " & BuchText & ", " & BuchAdr & ", " & BuchMemo
End Function
