VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Object = "{89CA3B53-D36C-483D-950E-C068E02FB78E}#2.41#0"; "sevEin20.ocx"
Begin VB.Form frmPrüfung 
   Caption         =   "Prüfungen"
   ClientHeight    =   5220
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7200
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
   ScaleHeight     =   5220
   ScaleWidth      =   7200
   StartUpPosition =   2  'Bildschirmmitte
   Begin sevListBox.roListBox lstKorr 
      Height          =   3135
      Left            =   120
      TabIndex        =   18
      Top             =   2040
      Width           =   6975
      _ExtentX        =   12303
      _ExtentY        =   5530
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
      ColumnCount     =   4
      ColText1        =   "ID"
      ColWidth1       =   1000
      ColText2        =   "Feld"
      ColWidth2       =   2600
      ColText3        =   "lt. DB"
      ColWidth3       =   1500
      ColAlignment3   =   1
      ColText4        =   "Berechnet"
      ColWidth4       =   1500
      ColAlignment4   =   1
      MustUpdate      =   -1  'True
   End
   Begin VB.Frame frmKriterien 
      Caption         =   "Buchungen"
      BeginProperty Font 
         Name            =   "Century Gothic"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1935
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   5295
      Begin VB.CheckBox chkKorr 
         Caption         =   "inkl. Korrektur"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   1560
         Width           =   2175
      End
      Begin VB.OptionButton optPrüf 
         Caption         =   "Adressen"
         Height          =   240
         Index           =   2
         Left            =   120
         TabIndex        =   3
         Top             =   1080
         Width           =   1335
      End
      Begin VB.OptionButton optPrüf 
         Caption         =   "Konten"
         Height          =   240
         Index           =   1
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   1335
      End
      Begin VB.OptionButton optPrüf 
         Caption         =   "Buchungen"
         Enabled         =   0   'False
         Height          =   240
         Index           =   0
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   1335
      End
      Begin sevTextBox.sevText txtVon 
         Height          =   285
         Index           =   0
         Left            =   3000
         TabIndex        =   4
         Top             =   360
         Visible         =   0   'False
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
         BackColorDisabled=   16633531
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
      Begin sevCommand3.roLabel lblBeschr 
         Height          =   255
         Index           =   0
         Left            =   1560
         TabIndex        =   5
         Top             =   360
         Visible         =   0   'False
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
         Caption         =   "BuchID (von-bis)"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtBis 
         Height          =   285
         Index           =   0
         Left            =   4200
         TabIndex        =   6
         Top             =   360
         Visible         =   0   'False
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
         BackColorDisabled=   16633531
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
      Begin sevTextBox.sevText txtVon 
         Height          =   285
         Index           =   1
         Left            =   3000
         TabIndex        =   7
         Top             =   720
         Visible         =   0   'False
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
         BackColorDisabled=   16633531
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
      Begin sevCommand3.roLabel lblBeschr 
         Height          =   255
         Index           =   1
         Left            =   1560
         TabIndex        =   8
         Top             =   720
         Visible         =   0   'False
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
         Caption         =   "KtoNr (von-bis)"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtBis 
         Height          =   285
         Index           =   1
         Left            =   4200
         TabIndex        =   9
         Top             =   720
         Visible         =   0   'False
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
         BackColorDisabled=   16633531
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
      Begin sevTextBox.sevText txtVon 
         Height          =   285
         Index           =   2
         Left            =   3000
         TabIndex        =   10
         Top             =   1080
         Visible         =   0   'False
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
         BackColorDisabled=   16633531
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
      Begin sevCommand3.roLabel lblBeschr 
         Height          =   255
         Index           =   2
         Left            =   1560
         TabIndex        =   11
         Top             =   1080
         Visible         =   0   'False
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
         Caption         =   "AdrNr (von-bis)"
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevTextBox.sevText txtBis 
         Height          =   285
         Index           =   2
         Left            =   4200
         TabIndex        =   12
         Top             =   1080
         Visible         =   0   'False
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
         BackColorDisabled=   16633531
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
      Begin sevCommand3.roLabel lblBis 
         Height          =   255
         Index           =   0
         Left            =   3960
         TabIndex        =   13
         Top             =   360
         Visible         =   0   'False
         Width           =   255
         _ExtentX        =   450
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
         Caption         =   "-"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lblBis 
         Height          =   255
         Index           =   1
         Left            =   3960
         TabIndex        =   14
         Top             =   720
         Visible         =   0   'False
         Width           =   255
         _ExtentX        =   450
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
         Caption         =   "-"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.roLabel lblBis 
         Height          =   255
         Index           =   2
         Left            =   3960
         TabIndex        =   15
         Top             =   1080
         Visible         =   0   'False
         Width           =   255
         _ExtentX        =   450
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
         Caption         =   "-"
         Alignment       =   2
         GradiantStyle   =   0
         ForeColorOnMouseMove=   0
         Version3        =   -1  'True
      End
      Begin sevCommand3.Command cmdStart 
         Height          =   405
         Left            =   3600
         TabIndex        =   17
         Top             =   1440
         Width           =   1515
         _ExtentX        =   2672
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
         Caption         =   "&Starten"
         Image           =   6608
         UseDefaultMaskColor=   -1  'True
         Version3        =   -1  'True
      End
   End
End
Attribute VB_Name = "frmPrüfung"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdStart_Click()
lstKorr.Clear
If optPrüf(0).Value = True Then
  If Buch(txtVon(0), txtBis(0)) = True Then

  End If
ElseIf optPrüf(1).Value = True Then
  Set RS = DB.OpenRecordset("Select Min(KtoNr) as minKtoNr, Max(KtoNr) as maxKtoNr from Kto")
  RS.MoveLast
  RS.MoveFirst
  If txtVon(1) = "" Then
    If IsNull(RS("minKtoNr").Value) Then
      GoTo Err
    Else
      txtVon(1) = RS("minKtoNr").Value
    End If
  End If
  If txtBis(1) = "" Then
    If IsNull(RS("maxKtoNr").Value) Then
      GoTo Err
    Else
      txtBis(1) = RS("maxKtoNr").Value
    End If
  End If
  Kto txtVon(1), txtBis(1)
ElseIf optPrüf(2).Value = True Then
  Set RS = DB.OpenRecordset("Select Min(AdrNr) as minAdrNr, Max(AdrNr) as maxAdrNr from Adr")
  RS.MoveLast
  RS.MoveFirst
  If txtVon(2) = "" Then
    If IsNull(RS("minAdrNr").Value) Then
      GoTo Err
    Else
      txtVon(2) = RS("minAdrNr").Value
    End If
  End If
  If txtBis(2) = "" Then
    If IsNull(RS("maxAdrNr").Value) Then
      GoTo Err
    Else
      txtBis(2) = RS("maxAdrNr").Value
    End If
  End If
  Adr txtVon(2), txtBis(2)
End If
Exit Sub
Err:
MsgBox "Keine Daten zum Prüfen vorhanden"
End Sub

Private Sub Form_Load()
Me.Caption = "Prüfungen [" & strUser & "]"
End Sub

Private Sub optPrüf_Click(Index As Integer)
'Alle Felder ausblenden
For i = 0 To 2
lblBeschr(i).Visible = False
txtVon(i).Visible = False
txtBis(i).Visible = False
lblBis(i).Visible = False
Next i
lblBeschr(Index).Visible = True
txtVon(Index).Visible = True
txtBis(Index).Visible = True
lblBis(Index).Visible = True
End Sub

Public Function Buch(BuchIdVon As String, BuchIdBis As String)

End Function

Public Function Kto(KtoNrVon As String, KtoNrBis As String)
Dim RsKto As Recordset
Dim i As Integer
Dim iSaldo As Currency
Dim iSaldoBer As Currency
Set RsKto = DB.OpenRecordset("Select * from Kto where KtoNr>='" & KtoNrVon & "' and KtoNr<='" & KtoNrBis & "'")
If Not RsKto.BOF And Not RsKto.EOF Then
  RsKto.MoveLast
  RsKto.MoveFirst
  For i = 1 To RsKto.RecordCount
    iSaldo = RsKto("KtoSaldo").Value
    If RsKto("KtoArt").Value = "B" Then
      Set RS = DB.OpenRecordset("Select sum(BuchKtoBetrag) as sumBuchKtoBetrag from Buch where BuchKtoBestand='" & RsKto("KtoNr").Value & "'")
    Else
      Set RS = DB.OpenRecordset("Select sum(BuchKtoBetrag) as sumBuchKtoBetrag from Buch where BuchKto='" & RsKto("KtoNr").Value & "'")
    End If
    If IsNull(RS("SumBuchKtoBetrag").Value) Then
      iSaldoBer = 0
    Else
      iSaldoBer = RS("sumbuchKtoBetrag").Value
    End If
    If Not iSaldo = iSaldoBer Then
      If IsNull(RS("sumBuchKtoBetrag").Value) Then
        iSaldoBer = 0
      Else
        iSaldoBer = RS("sumBuchKtoBetrag").Value
      End If
      lstKorr.AddItem , RsKto("KtoNr").Value & vbTab & _
                       "Saldo" & vbTab & _
                       Format(iSaldo, "#,##0.00 €") & vbTab & _
                       Format(iSaldoBer, "#,##0.00 €")
      If chkKorr.Value = 1 Then
        DB.Execute ("Update Kto set KtoSaldo='" & iSaldoBer & "' where KtoNr='" & RsKto("KtoNr").Value & "'")
      End If
    End If
    RsKto.MoveNext
  Next i
End If
End Function

Public Function Adr(AdrNrVon As String, AdrNrBis As String)
Dim RsAdr As Recordset
Dim i As Integer
Dim iSaldo As Currency
Dim iSaldoBer As Currency
Set RsAdr = DB.OpenRecordset("Select * from Adr where AdrNr>='" & AdrNrVon & "' and AdrNr<='" & AdrNrBis & "'")
If Not RsAdr.BOF And Not RsAdr.EOF Then
  RsAdr.MoveLast
  RsAdr.MoveFirst
  For i = 1 To RsAdr.RecordCount
    iSaldo = RsAdr("AdrSaldo").Value
    Set RS = DB.OpenRecordset("Select sum(BuchKtoBetrag) as sumBuchKtoBetrag from Buch where BuchAdr='" & RsAdr("AdrNr").Value & "'")
    If IsNull(RS("SumBuchKtoBetrag").Value) Then
      iSaldoBer = 0
    Else
      iSaldoBer = RS("sumbuchKtoBetrag").Value
    End If
    If Not iSaldo = iSaldoBer Then
      If IsNull(RS("sumBuchKtoBetrag").Value) Then
        iSaldoBer = 0
      Else
        iSaldoBer = RS("sumBuchKtoBetrag").Value
      End If
      lstKorr.AddItem , RsAdr("AdrNr").Value & vbTab & _
                        "Saldo" & vbTab & _
                        Format(iSaldo, "#,##0.00 €") & vbTab & _
                        Format(iSaldoBer, "#,##0.00 €")
      If chkKorr.Value = 1 Then
        DB.Execute ("Update Adr set AdrSaldo='" & iSaldoBer & "' where AdrNr='" & RsAdr("AdrNr").Value & "'")
      End If
    End If
    RsAdr.MoveNext
  Next i
End If
End Function
