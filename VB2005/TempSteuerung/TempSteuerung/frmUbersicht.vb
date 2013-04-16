Imports Microsoft.Win32

Public Class frmUbersicht
  Private sCPUTyp As String
  Private sCPUTakt As String

  Private Sub frmUbersicht_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    GetCPUInfos()
    txtCPUTakt.Text = sCPUTakt
    txtCPUTyp.Text = sCPUTyp
  End Sub

  Private Function GetCPUInfos()
    ' Registry-Zweig öffnen
    Dim RegKey As RegistryKey = Registry.LocalMachine.OpenSubKey( _
    "HARDWARE\DESCRIPTION\System\CentralProcessor\0")

    ' CPU-Takt auslesen
    sCPUTakt = CType(RegKey.GetValue("~MHz", 0), Integer) & " MHz"

    ' CPU-Takt formatieren
    'sCPUTakt = Format(sCPUTakt, "##0.##") & " MHz"

    ' CPU-Typ auslesen
    sCPUTyp = CType(RegKey.GetValue("ProcessorNameString", 0), String)

    ' Registry wieder schließen
    RegKey.Close()
    Return Nothing
  End Function
End Class
