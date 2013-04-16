VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "mswinsck.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmWSock 
   BorderStyle     =   4  'Festes Werkzeugfenster
   Caption         =   "Supporttool-Server"
   ClientHeight    =   480
   ClientLeft      =   10260
   ClientTop       =   9600
   ClientWidth     =   4425
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   480
   ScaleWidth      =   4425
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'Bildschirmmitte
   Begin VB.TextBox txtStatus 
      Enabled         =   0   'False
      Height          =   285
      Left            =   960
      TabIndex        =   0
      Top             =   120
      Width           =   3375
   End
   Begin MSWinsockLib.Winsock WSock 
      Left            =   3360
      Top             =   0
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin MSComDlg.CommonDialog cdlgPfad 
      Left            =   3360
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label lblStat 
      Caption         =   "Status"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   735
   End
End
Attribute VB_Name = "frmWSock"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim nBytesTotal As Long
Dim nBytesRead As Long
Dim nBytesToRead As Long
Dim F As Integer

Function WSockStarte() As Boolean
WSock.LocalPort = Port
WSock.Listen
WSockStarte = True
End Function

Function WSockVerbinde() As Boolean
WSock.Connect IP, Port
WSockVerbinde = True
End Function

Function WSockSende(sCommand As String) As Boolean
WSock.SendData sCommand
WSockSende = True
End Function

Function WSockSendeDatei(sFile As String) As Boolean
Dim sBuffer As String

' Datei im Binary-Mode öffnen
F = FreeFile
Open sFile For Binary As #F
 
' Dateiname extrahieren
If InStr(sFile, "\") > 0 Then
  sFile = Mid$(sFile, InStrRev(sFile, "\") + 1)
End If

' Dateigröße
nBytesTotal = LOF(F)

' Sendevorgang starten
With WSock
  ' Empfänger mitteln, welche Datei und wieviele
  ' Daten gesendet werden
  .SendData "<begin size=" & CStr(nBytesTotal) & ";" & sFile & ">"
   
  ' Datei blockweise senden
  Do While nBytesRead < nBytesTotal
    nBytesToRead = BlockSize
    If nBytesRead + nBytesToRead > nBytesTotal Then
      nBytesToRead = nBytesTotal - nBytesRead
    End If
    
    ' Datenblock lesen
    sBuffer = Space$(nBytesToRead)
    Get #F, , sBuffer
    
    ' Datenblock senden
    .SendData sBuffer
    
    ' Fortschritt aktualisieren
    nBytesRead = nBytesRead + nBytesToRead
    txtStatus.Text = CStr(nBytesRead) + " von " + CStr(nBytesTotal) + " Bytes versandt"
    
    ' Wichtig!
    DoEvents
  Loop
End With
  
' Datei schließen (Sendevorgang beendet)
Close #F
WSockSendeDatei = True
End Function

Private Sub WSock_ConnectionRequest(ByVal requestID As Long)
WSock.Close
WSock.Accept requestID
End Sub

Private Sub WSock_DataArrival(ByVal bytesTotal As Long)
Dim sData As String
Dim sTemp As String
Static sFile As String
  
' Daten holen
WSock.GetData sData, vbString

'Prüfen ob Nachricht empfangen wird
Select Case Left$(sData, 4)
Case "/msg"
'Nachricht wird empfangen
  txtStatus = Mid(sData, 6)
  Exit Sub
Case "/cmd"
'Command wird empfangen
  If WSockCommand(Mid(sData, 6)) = True Then
    Exit Sub
  End If
Case "/sta"
'Statusmeldung wird empfangen
  txtStatus = "Status: " & Mid(sData, 6)
  Exit Sub
End Select
  
If Left$(sData, 12) = "<begin size=" Then
  ' Aha... eine neue Datei wird gesendet
  sData = Mid$(sData, 13)
  sTemp = Left$(sData, InStr(sData, ">") - 1)
  sData = Mid$(sData, InStr(sData, ">") + 1)
  
  ' Dateigröße und Dateiname ermitteln
  If InStr(sTemp, ";") > 0 Then
    nBytesTotal = Val(Left$(sTemp, InStr(sTemp, ";") - 1))
    sFile = Mid$(sTemp, InStr(sTemp, ";") + 1)
  Else
    nBytesTotal = Val(sTemp)
  End If
  
  ' Falls kein Dateiname angegeben wurde,
  ' Daten unter "temp.dat" speichern
  If Len(sFile) = 0 Then sFile = "temp.dat"
  
  ' ggf. Datei löschen, falls bereits existiert
  On Error Resume Next
  Kill App.Path & "\" & sFile
  On Error GoTo 0
  
  ' Datei im Binary-Mode öffnen
  F = FreeFile
  Open App.Path & "\" & sFile For Binary As #F
  
  ' bisher gelesene Bytes zurücksetzen
  nBytesRead = 0
End If
    
If Len(sData) > 0 And F > 0 Then
  ' bisher empfangene Daten...
  nBytesRead = nBytesRead + Len(sData)
  
  ' Daten in Datei speichern
  Put #F, , sData
  
  ' evtl. Fortschritt anzeigen
  txtStatus.Text = CStr(nBytesRead) & " von " & CStr(nBytesTotal) & " Bytes empfangen"
  
  ' Wenn alle Bytes empfangen wurden, Datei schließen
  If nBytesRead = nBytesTotal Then
    nFileComplete = True
    Close #F
    F = 0
  End If
End If
End Sub

Function WSockCommand(sCommand As String) As Boolean
Select Case sCommand
Case "GetUVNC"
  If WSockSendeDatei(App.Path & "\WinVNC.exe") = True Then
    WSockCommand = True
  End If
Case "HELP"
  MsgBox WSock.RemoteHost & " auf IP:'" & WSock.RemoteHostIP & "' benötigt Hilfe!!!"
  txtStatus = WSock.RemoteHost & " auf IP:'" & WSock.RemoteHostIP & "' benötigt Hilfe!!!"
Case "GetFile"
  With cdlgPfad
    .Filter = "Alle Dateien|*.*"
    .ShowOpen
    If .FileName <> "" Then
      If WSockSendeDatei(.FileName) = True Then
      End If
    End If
  End With
End Select
End Function
