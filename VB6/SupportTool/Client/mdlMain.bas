Attribute VB_Name = "mdlMain"
'============================================================================================================
'Supporttool-Client
'um Supportanfragen/Verwartungen einfacher behandeln zu können
'
'Aufgaben
'
'-Erstellung und Aufbau VPN-Verbindung
'-Starten von Ultra-VNC Server
'-Statusmeldung an Supporttool-Server
'
'Copyright
'Stefan Dehner
'Stevo Software
'eMail: Stevo-Software@gmx.at
'============================================================================================================
Private Declare Function IsDestinationReachable Lib "Sensapi.dll" Alias "IsDestinationReachableA" (ByVal lpszDestination As String, lpQOCInfo As QOCINFO) As Long

Private Type QOCINFO
  dwSize As Long
  dwFlags As Long
  dwInSpeed As Long
  dwOutSpeed As Long
End Type

Public Const IP As String = "192.168.1.101"
Public Const Port As String = "7585"
Public Const BlockSize = 4048

Public nFileComplete As Boolean

Sub Main()
'Prüfen ob Installation korrekt beendet wurde
If Not GetSetting("SupTool", "Install", "Install") = "" Then
  frmMain.Show
Else
  If Install = True Then frmMain.Show
End If
End Sub

'============================================================================================================
'Installation des Supporttool-Client umfasst folgende aufgaben
'1. Eintragen der VPN-Verbindungsparameter unter:
'   C:\Dokumente und Einstellungen\All Users\Anwendungsdaten\Microsoft\Network\Connections\Pbk\rasphone.pbk
'2. VPN-Verbindung herstellen
'3. Zum Server verbinden
'4. Verzeichnis C:\FW Erstellen
'5. Installation VNC-Server - Verbindung mit Servertool für Download erforderlich
'6. Eintrag in die Registrierung unter:
'   HKEY_CURRENT_USER\Software\VB and VBA Programm Settings\SupTool\Install\Install (REG_SZ)
'============================================================================================================

Private Function Install() As Boolean
Dim sPing As Single
'1. Eintragen der VPN-Verbindungsparameter
If ErstellVPN = True Then
  '2. VPN-Verbindung herstellen
  If VerbindeVPN = True Then
    'Ping absetzen um die VPN-Verbindung zu kontrollieren
    Do Until sPing <> -1
      sPing = Ping(IP)
    Loop
    '3. Zum Server verbinden
    frmWSock.Show
    If frmWSock.WSockVerbinde() = True Then
      '4. Verzeichnis C:\FW Erstellen
      MkDir "C:\FW"
      '5. Installation VNC-Server - Verbindung mit Servertool für Download erforderlich
      If frmWSock.WSockSende("/cmd GetUVNC") = True Then
        Do Until nFileComplete = True
          'Schleife solange die Datei kopiert wird
        Loop
        nFileComplete = False
        FileCopy App.Path & "\WinVNC.exe", "C:\FW\WinVNC.exe"
        FileCopy App.Path & "\" & App.EXEName, "C:\FW\" & App.EXEName
        Shell "C:\FW\WinVnc.exe", vbNormalNoFocus
        If frmWSock.WSockSende("/cmd HELP") = True Then
          SaveSetting "SupTool", "Install", "Install", 1
          Install = True
        End If
      End If
    End If
  End If
End If
End Function

'============================================================================================================
'Öffnen der rasphone.pbk und Anfügen der VPN-Verbindung
'============================================================================================================

Private Function ErstellVPN() As Boolean
Dim F As Integer
Dim sText As String
Dim sFile As String

sFile = "C:\Dokumente und Einstellungen\All Users\Anwendungsdaten\Microsoft\Network\Connections\Pbk\rasphone.pbk"

sText = "[Support]"
sText = sText & "Encoding=1" & vbCrLf
sText = sText & "Type=2" & vbCrLf
sText = sText & "AutoLogon=0" & vbCrLf
sText = sText & "UseRasCredentials=1" & vbCrLf
sText = sText & "DialParamsUID=172502000" & vbCrLf
sText = sText & "Guid=EB58EC7CFDFE6D47978F7F6F520797C6" & vbCrLf
sText = sText & "BaseProtocol=1" & vbCrLf
sText = sText & "VpnStrategy=2" & vbCrLf
sText = sText & "ExcludedProtocols=0" & vbCrLf
sText = sText & "LcpExtensions=1" & vbCrLf
sText = sText & "DataEncryption=256" & vbCrLf
sText = sText & "SwCompression=1" & vbCrLf
sText = sText & "NegotiateMultilinkAlways=0" & vbCrLf
sText = sText & "SkipNwcWarning=0" & vbCrLf
sText = sText & "SkipDownLevelDialog=0" & vbCrLf
sText = sText & "SkipDoubleDialDialog=0" & vbCrLf
sText = sText & "DialMode=1" & vbCrLf
sText = sText & "DialPercent=75" & vbCrLf
sText = sText & "DialSeconds=120" & vbCrLf
sText = sText & "HangUpPercent=10" & vbCrLf
sText = sText & "HangUpSeconds=120" & vbCrLf
sText = sText & "OverridePref=15" & vbCrLf
sText = sText & "RedialAttempts=3" & vbCrLf
sText = sText & "RedialSeconds=60" & vbCrLf
sText = sText & "IdleDisconnectSeconds=0" & vbCrLf
sText = sText & "RedialOnLinkFailure=0" & vbCrLf
sText = sText & "CallbackMode=0" & vbCrLf
sText = sText & "CustomDialDll=" & vbCrLf
sText = sText & "CustomDialFunc=" & vbCrLf
sText = sText & "CustomRasDialDll=" & vbCrLf
sText = sText & "AuthenticateServer=0" & vbCrLf
sText = sText & "ShareMsFilePrint=1" & vbCrLf
sText = sText & "BindMsNetClient=1" & vbCrLf
sText = sText & "SharedPhoneNumbers=0" & vbCrLf
sText = sText & "GlobalDeviceSettings=0" & vbCrLf
sText = sText & "PrerequisiteEntry=" & vbCrLf
sText = sText & "PrerequisitePbk=" & vbCrLf
sText = sText & "PreferredPort=VPN2-0" & vbCrLf
sText = sText & "PreferredDevice=WAN-Miniport (L2TP)" & vbCrLf
sText = sText & "PreferredBps=0" & vbCrLf
sText = sText & "PreferredHwFlow=1" & vbCrLf
sText = sText & "PreferredProtocol=1" & vbCrLf
sText = sText & "PreferredCompression=1" & vbCrLf
sText = sText & "PreferredSpeaker=1" & vbCrLf
sText = sText & "PreferredMdmProtocol=0" & vbCrLf
sText = sText & "PreviewUserPw=1" & vbCrLf
sText = sText & "PreviewDomain=0" & vbCrLf
sText = sText & "PreviewPhoneNumber=0" & vbCrLf
sText = sText & "ShowDialingProgress=1" & vbCrLf
sText = sText & "ShowMonitorIconInTaskBar=1" & vbCrLf
sText = sText & "CustomAuthKey=-1" & vbCrLf
sText = sText & "AuthRestrictions=608" & vbCrLf
sText = sText & "TypicalAuth=2" & vbCrLf
sText = sText & "IpPrioritizeRemote=1" & vbCrLf
sText = sText & "IpHeaderCompression=0" & vbCrLf
sText = sText & "IpAddress=0.0.0.0" & vbCrLf
sText = sText & "IpDnsAddress=0.0.0.0" & vbCrLf
sText = sText & "IpDns2Address=0.0.0.0" & vbCrLf
sText = sText & "IpWinsAddress=0.0.0.0" & vbCrLf
sText = sText & "IpWins2Address=0.0.0.0" & vbCrLf
sText = sText & "IpAssign=1" & vbCrLf
sText = sText & "IpNameAssign=1" & vbCrLf
sText = sText & "IpFrameSize=1006" & vbCrLf
sText = sText & "IpDnsFlags=0" & vbCrLf
sText = sText & "IpNBTFlags=1" & vbCrLf
sText = sText & "TcpWindowSize=0" & vbCrLf
sText = sText & "UseFlags=0" & vbCrLf
sText = sText & "IpSecFlags=0" & vbCrLf
sText = sText & "IpDnsSuffix=" & vbCrLf
sText = sText & "NETCOMPONENTS=" & vbCrLf
sText = sText & "ms_server=1" & vbCrLf
sText = sText & "ms_msclient=1" & vbCrLf
sText = sText & "MEDIA=rastapi" & vbCrLf
sText = sText & "Port=VPN2-0" & vbCrLf
sText = sText & "Device=WAN-Miniport (L2TP)" & vbCrLf
sText = sText & "DEVICE=vpn" & vbCrLf
sText = sText & "PhoneNumber=dehner.myftp.org" & vbCrLf
sText = sText & "AreaCode=" & vbCrLf
sText = sText & "CountryCode=43" & vbCrLf
sText = sText & "CountryID=43" & vbCrLf
sText = sText & "UseDialingRules=0" & vbCrLf
sText = sText & "Comment=" & vbCrLf
sText = sText & "LastSelectedPhone=0" & vbCrLf
sText = sText & "PromoteAlternates=0" & vbCrLf
sText = sText & "TryNextAlternateOnFail=1"

F = FreeFile
Open sFile For Append As #F
Print #F, sText
Close #F

ErstellVPN = True
End Function

'============================================================================================================
'VPN-Verbindung über RASDIAL herstellen
'============================================================================================================

Function VerbindeVPN() As Boolean
Shell "rasdial Support ""Support [$upp0rt]"" ", vbHide
VerbindeVPN = True
End Function

'============================================================================================================
'Ping auf Server absetzten um VPN-Verbindung zu kontrollieren
'============================================================================================================

Private Function Ping(ByVal sHost As String) As Single
  Dim QI As QOCINFO
  Dim vTime As Single
  
  QI.dwSize = Len(QI)
  vTime = Timer
  If IsDestinationReachable(sHost, QI) = 1 Then
    Ping = Timer - vTime
  Else
    Ping = -1
  End If
End Function

'============================================================================================================
'Hilfe anfordern
'- VPN Verbindung herstellen
'- Ping ob Verbindung erfolgreich
'- Verbinden mit Server
'- Command für Hilfe senden
'============================================================================================================

Private Function Hilfe() As Boolean
If VerbindeVPN = True Then
  'Ping absetzen um die VPN-Verbindung zu kontrollieren
  Do Until sPing <> -1
    sPing = Ping(IP)
  Loop
  '3. Zum Server verbinden
  frmWSock.Show
  Shell "C:\FW\WinVnc.exe", vbNormalNoFocus
  If frmWSock.WSockVerbinde() = True Then If frmWSock.WSockSende("/cmd HELP") = True Then Hilfe = True
End If
End Function

