Attribute VB_Name = "mdlPBHQE"
Public FehlerText As String
Public dZGröße As Double
Public dGröße As Double

Sub Main()
If Not Command$ = "" Then
  frmMenu.txtPfad = Command$
  If DateiÖffnen(Command$) = True Then
    frmMenu.Show
  Else
    MsgBox FehlerText
  End If
Else
  frmMenu.Show
End If
End Sub

Function DateiÖffnen(Pfad As String) As Boolean
Dim F As Integer
Dim dSaldo As Double
Dim strZellen() As String
'On Error GoTo Err
DateiÖffnen = True
dGröße = DateiGröße(Pfad)
F = FreeFile
dZeilen = 0
Open Pfad For Input As #F
While Not EOF(F)
  Line Input #F, sLine
  strZellen() = Split(sLine, ";", -1)
  If IsDate(strZellen(0)) Then
  dSaldo = dSaldo + strZellen(4)
  frmMenu.lst.AddItem , Format(strZellen(0), "DD.MM.YYYY") & vbTab & _
                               strZellen(1) & vbTab & _
                               strZellen(2) & vbTab & _
                               strZellen(3) & vbTab & _
                               Format(strZellen(4), "#,##0.00 €") & vbTab & _
                               strZellen(5) & vbTab & _
                               strZellen(6) & vbTab & _
                               strZellen(7) & vbTab
  frmMenu.lst.DeSelectAll
  End If
Wend
Close #F
frmMenu.txtGröße = Format(dGröße / 1024, "0.00") & " KB"
frmMenu.txtSaldo = dSaldo
frmMenu.txtDatensätze = frmMenu.lst.ListCount
On Error Resume Next
If Not frmMenu.lst.ListCount = 0 Then
  dZGröße = Format(dGröße / 1024, "0.00") / (frmMenu.lst.ListCount + 1)
Else
  dZGröße = Format(dGröße / 1024, "0.00")
End If
Exit Function
Err:
DateiÖffnen = False
FehlerText = "Öffnen Fehlgeschlagen" & vbCrLf & vbCrLf & _
             "Fehler " & Err.Number & " - " & Err.Description
End Function

Function DateiGröße(Datei As String) As Double
On Error GoTo Err
Dim objFso As FileSystemObject
Dim objFile As File
  
Set objFso = New FileSystemObject
Set objFile = objFso.GetFile(Datei)
DateiGröße = objFile.Size
Set objFile = Nothing
Set objFso = Nothing
Exit Function
Err:
FehlerText = "Dateigrößenermittlung Fehlgeschlagen" & vbCrLf & vbCrLf & _
             "Fehler " & Err.Number & " - " & Err.Description
End Function

Function DateiZeilen(Datei As String) As Double
Dim F As Integer
Dim nLines As Long
Dim sLine As String

F = FreeFile
Open Datei For Input As #F
While Not EOF(F)
  Line Input #F, sLine
  nLines = nLines + 1
Wend
Close #F
End Function

Function DateiSpeichern(Pfad As String) As Boolean
Dim strText As String
Dim F As Integer
Dim i As Integer
On Error GoTo Err
DateiSpeichern = True
strText = "BuchDate;BuchArt;BuchKtoBestand;BuchKto;BuchKtoBetrag;BuchText;BuchAdr;BuchMemo" & vbCrLf
For i = 1 To frmMenu.lst.ListCount
  strText = strText & _
            frmMenu.lst.SubItems(i, 1) & ";" & _
            frmMenu.lst.SubItems(i, 2) & ";" & _
            frmMenu.lst.SubItems(i, 3) & ";" & _
            frmMenu.lst.SubItems(i, 4) & ";" & _
            CCur(frmMenu.lst.SubItems(i, 5)) & ";" & _
            frmMenu.lst.SubItems(i, 6) & ";" & _
            frmMenu.lst.SubItems(i, 7) & ";" & _
            frmMenu.lst.SubItems(i, 8)
  If Not i = frmMenu.lst.ListCount Then
  strText = strText & vbCrLf
  End If
Next i
F = FreeFile
Open Pfad For Output As #F
  Print #F, strText
Close #F
dGröße = DateiGröße(Pfad)
frmMenu.txtGröße = Format(dGröße / 1024, "0.00") & " KB"
dZGröße = Format(dGröße / 1024, "0.00") / frmMenu.lst.ListCount
Exit Function
Err:
DateiSpeichern = False
FehlerText = "Speichern Fehlgeschlagen" & vbCrLf & vbCrLf & _
             "Fehler " & Err.Number & " - " & Err.Description
End Function

