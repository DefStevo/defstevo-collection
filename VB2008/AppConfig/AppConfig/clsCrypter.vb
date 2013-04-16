'-------------------------------------------------------------------------------------
'Autor: Stefan Dehner
'© Stevo Software 2008
'Beginn 11.06.2008
'
'Klasse zum Ver- und Entschlüssen von Strings
'-------------------------------------------------------------------------------------
'clsCrypter Version 1.0 - 11.06.2008
'
'Deklarationen:
'_Key = Private Variable welche den Key zum Ver- und Entschlüsseln beinhaltet
'
'Eigenschaften:
'Key = wird zum schreiben oder lesen der Variable _Key benötigt
'
'Funktionen:
'Crypt = Funktion zum Verschlüsseln des Strings (Key muss zuvor gesetzt werden)
'DeCrypt = Funktion zum Entschlüsseln des Strings (Key muss zuvor gesetzt werden)
'-------------------------------------------------------------------------------------
'clsCrypter Version 1.1 - 03.05.2010
'
'Deklarationen:
'_Status = Status des Crypter (0 = Nicht bereit, 1 = Bereit)
'
'Eigenschaften:
'Status = Rückgabe des Status
'-------------------------------------------------------------------------------------
'clsCrypter Version X - X
'
'ToDo:
'Einbauen einer Funktion zum Prüfen des _Key.
'-------------------------------------------------------------------------------------

Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class clsCrypter

#Region "Deklarationen"
    Private _Key As String = "#Key_clsCrypter_080611"
    Private _Status As Integer = 1
#End Region

#Region "Eigenschaften"
    Property Key() As String
        Get
            Return _Key
        End Get
        Set(ByVal value As String)
            _Key = value
            If Not _Key = "" Then
                _Status = 1
            End If
        End Set
    End Property

    ReadOnly Property Status() As String
        Get
            Select Case _Status
                Case 1
                    Return "1 - Bereit"
                Case Else
                    Return "0 - nicht Bereit"
            End Select
        End Get
    End Property

#End Region

#Region "Funktionen"
    Function Crypt(ByRef strText As String) As String
        Dim rd As New RijndaelManaged

        Dim md5 As New MD5CryptoServiceProvider
        Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(Me._Key))

        If Not _Status = 0 Then
            md5.Clear()
            rd.Key = key
            rd.GenerateIV()

            Dim iv() As Byte = rd.IV
            Dim ms As New MemoryStream

            ms.Write(iv, 0, iv.Length)

            Dim cs As New CryptoStream(ms, rd.CreateEncryptor, CryptoStreamMode.Write)
            Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)

            cs.Write(data, 0, data.Length)
            cs.FlushFinalBlock()

            Dim encdata() As Byte = ms.ToArray()
            strText = Convert.ToBase64String(encdata)
            cs.Close()
            rd.Clear()
        End If

        Return strText
    End Function

    Function DeCrypt(ByRef strText As String) As String
        Dim rd As New RijndaelManaged
        Dim rijndaelIvLength As Integer = 16
        Dim md5 As New MD5CryptoServiceProvider
        Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(Me._Key))

        If Not _Status = 0 Then
            md5.Clear()

            Dim encdata() As Byte = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream(encdata)
            Dim iv(15) As Byte

            ms.Read(iv, 0, rijndaelIvLength)
            rd.IV = iv
            rd.Key = key

            Dim cs As New CryptoStream(ms, rd.CreateDecryptor, CryptoStreamMode.Read)

            Dim data(ms.Length - rijndaelIvLength) As Byte
            Dim i As Integer = cs.Read(data, 0, data.Length)

            strText = System.Text.Encoding.UTF8.GetString(data, 0, i)
            cs.Close()
            rd.Clear()
        End If

        Return strText
    End Function
#End Region

End Class
