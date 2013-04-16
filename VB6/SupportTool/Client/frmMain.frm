VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Supporttool"
   ClientHeight    =   825
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   825
   ScaleWidth      =   4680
   StartUpPosition =   2  'Bildschirmmitte
   Begin VB.CommandButton cmdHilfe 
      Caption         =   "Hilfe Anfordern"
      Height          =   615
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4455
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdHile_Click()
If cmdHilfe.Caption = "Beenden" Then
  Unload frmMain
  Unload frmWSock
Else
  If Hilfe = True Then
    cmdHilfe.Caption = "Beenden"
  End If
End If
End Sub
