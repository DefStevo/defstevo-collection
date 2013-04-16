VERSION 5.00
Object = "{7D622DE6-0ABC-471E-9234-97DEC5E0A708}#3.2#0"; "sevCmd3.ocx"
Object = "{12E1BFF7-4980-11D3-98DA-00E0292B2A47}#4.10#0"; "sevList32.ocx"
Begin VB.Form frmImpTabelle 
   Caption         =   "Datensätze"
   ClientHeight    =   5805
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   13920
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
   ScaleHeight     =   5805
   ScaleWidth      =   13920
   StartUpPosition =   2  'Bildschirmmitte
   Begin sevCommand3.Command cmdBuch 
      Height          =   405
      Left            =   0
      TabIndex        =   1
      Top             =   5400
      Width           =   4645
      _ExtentX        =   8202
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
      Caption         =   "Markierte Buchung &Verbuchen"
      Enabled         =   0   'False
      Image           =   6608
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdBuchAlle 
      Height          =   405
      Left            =   4645
      TabIndex        =   2
      Top             =   5400
      Width           =   4650
      _ExtentX        =   8202
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
      Caption         =   "&Alle Buchungen Verbuchen"
      Image           =   6608
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevCommand3.Command cmdLösche 
      Height          =   405
      Left            =   9290
      TabIndex        =   3
      Top             =   5400
      Width           =   4650
      _ExtentX        =   8202
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
      Caption         =   "Alle Buchungen &Löschen"
      Image           =   6607
      UseDefaultMaskColor=   -1  'True
      Version3        =   -1  'True
   End
   Begin sevListBox.roListBox lstData 
      Height          =   5415
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13935
      _ExtentX        =   24580
      _ExtentY        =   9551
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
      ColumnCount     =   11
      ColText1        =   "Datum"
      ColWidth1       =   1000
      ColText2        =   "Buchart"
      ColWidth2       =   1000
      ColText3        =   "Bst"
      ColWidth3       =   500
      ColText4        =   "Name"
      ColWidth4       =   1500
      ColText5        =   "GK"
      ColWidth5       =   500
      ColText6        =   "Name"
      ColWidth6       =   1500
      ColText7        =   "Betrag"
      ColWidth7       =   1000
      ColAlignment7   =   1
      ColText8        =   "Buchungstext"
      ColWidth8       =   2000
      ColText9        =   "Adr"
      ColWidth9       =   500
      ColText10       =   "Name"
      ColWidth10      =   1500
      ColText11       =   "Memo"
      ColWidth11      =   2500
      MustUpdate      =   -1  'True
   End
End
Attribute VB_Name = "frmImpTabelle"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdBuch_Click()
Dim i As Integer
Dim iBuchId As Integer
Set RS = DB.OpenRecordset("Select max(BuchId) as maxBuchId from Buch")
If IsNull(RS("maxBuchId").Value) Then
  iBuchId = 1
Else
  iBuchId = RS("maxBuchId").Value + 1
End If
Set RS = DB.OpenRecordset("Buch")
RS.AddNew
RS("BuchId").Value = iBuchId
RS("BuchDat").Value = lstData.SubItems(lstData.ListIndex, 1)
RS("BuchArt").Value = lstData.SubItems(lstData.ListIndex, 2)
RS("BuchStatus").Value = "I"
RS("BuchAdr").Value = lstData.SubItems(lstData.ListIndex, 9)
RS("BuchKtoBestand").Value = lstData.SubItems(lstData.ListIndex, 3)
RS("BuchKto").Value = lstData.SubItems(lstData.ListIndex, 5)
RS("BuchKtoBetrag").Value = lstData.SubItems(lstData.ListIndex, 7)
RS("BuchText").Value = lstData.SubItems(lstData.ListIndex, 8)
RS("BuchMemo").Value = lstData.SubItems(lstData.ListIndex, 11)
RS.Update
DB.Execute ("Update Kto set KtoSaldo = KtoSaldo + '" & CCur(lstData.SubItems(lstData.ListIndex, 7)) & "' where KtoNr='" & lstData.SubItems(lstData.ListIndex, 3) & "'")
DB.Execute ("Update Kto set KtoSaldo = KtoSaldo + '" & CCur(lstData.SubItems(lstData.ListIndex, 7)) & "' where KtoNr='" & lstData.SubItems(lstData.ListIndex, 5) & "'")
If Not lstData.SubItems(i, 9) = "" Then
  DB.Execute ("Update Adr set AdrSaldo = AdrSaldo + '" & CCur(lstData.SubItems(lstData.ListIndex, 7)) & "' where AdrNr='" & lstData.SubItems(lstData.ListIndex, 9) & "'")
End If
lstData.RemoveItem (lstData.ListIndex)
cmdBuch.Enabled = False
End Sub

Private Sub cmdBuchAlle_Click()
Dim i As Integer
Dim iBuchId As Integer
Set RS = DB.OpenRecordset("Select max(BuchId) as maxBuchId from Buch")
  If IsNull(RS("maxBuchId").Value) Then
    iBuchId = 1
  Else
    iBuchId = RS("maxBuchId").Value + 1
  End If
Set RS = DB.OpenRecordset("Buch")
For i = 1 To lstData.ListCount
  RS.AddNew
  RS("BuchId").Value = iBuchId
  RS("BuchDat").Value = lstData.SubItems(1, 1)
  RS("BuchArt").Value = lstData.SubItems(1, 2)
  RS("BuchStatus").Value = "I"
  RS("BuchAdr").Value = lstData.SubItems(1, 9)
  RS("BuchKtoBestand").Value = lstData.SubItems(1, 3)
  RS("BuchKto").Value = lstData.SubItems(1, 5)
  RS("BuchKtoBetrag").Value = lstData.SubItems(1, 7)
  RS("BuchText").Value = lstData.SubItems(1, 8)
  RS("BuchMemo").Value = lstData.SubItems(1, 11)
  RS.Update
  DB.Execute ("Update Kto set KtoSaldo = KtoSaldo + '" & CCur(lstData.SubItems(1, 7)) & "' where KtoNr='" & lstData.SubItems(1, 3) & "'")
  DB.Execute ("Update Kto set KtoSaldo = KtoSaldo + '" & CCur(lstData.SubItems(1, 7)) & "' where KtoNr='" & lstData.SubItems(1, 5) & "'")
  If Not lstData.SubItems(1, 9) = "" Then
    DB.Execute ("Update Adr set AdrSaldo = AdrSaldo + '" & CCur(lstData.SubItems(1, 7)) & "' where AdrNr='" & lstData.SubItems(1, 9) & "'")
  End If
  lstData.RemoveItem (1)
  lstData.Refresh
  frmImpTabelle.Refresh
  iBuchId = iBuchId + 1
Next i
End Sub

Private Sub cmdLösche_Click()
Dim i As Integer
For i = 1 To lstData.ListCount
  lstData.RemoveItem (1)
Next i
End Sub

Private Sub lstData_Click(Index As Integer, Key As String)
cmdBuch.Enabled = True
End Sub
