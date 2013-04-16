Imports System.Net.Mail

Module mdlMain

    Public nError = 0
    Public sErrorTxt = ""

    Private sServer As String = ""
    Private nPort As Integer = 0
    Private sUser As String = ""
    Private sPass As String = ""
    Private sFrom As String = ""
    Private sTo As String = ""
    Private sSubject As String = ""

    Private sUrlDetail As String = ""
    Private sUsernameDetail As String = ""
    Private sPasswordDetail As String = ""

    Private sUrlGH As String = ""
    Private sUsernameGH As String = ""
    Private sPasswordGH As String = ""


    Sub Main()
        Dim sPage As String = ""
        Dim sFilename As String = ""
        Dim nRetry As Integer = 0
        Dim frm As New frmWS

        XMLReadSettings()

        If My.Application.CommandLineArgs.Count = 0 Then
            Console.WriteLine("Fehler: Keine Startargumente (Formular wird erstellt)")
        Else
            For i As Integer = 0 To My.Application.CommandLineArgs.Count - 1
                Select Case Left(My.Application.CommandLineArgs.Item(i).ToString, 3)
                    Case "/F:"
                        sFilename = My.Application.CommandLineArgs.Item(i).Split(":")(1).ToString & ":" & My.Application.CommandLineArgs.Item(i).Split(":")(2).ToString
                    Case "/P:"
                        sPage = My.Application.CommandLineArgs.Item(i).Split(":")(1).ToString
                    Case "/R:"
                        nRetry = Val(My.Application.CommandLineArgs.Item(i).Split(":")(1).ToString)
                    Case Else
                        Console.WriteLine("Fehler: Fehlerhafte Startargumente " + Left(My.Application.CommandLineArgs.Item(i).ToString, 3))
                End Select
            Next
        End If

        If sFilename = "" Or sPage = "" Then
            frm.ShowDialog()
            Exit Sub
        End If

        UploadWS(sFilename, sPage, nRetry)

        If nError = 1 Then

            SentMail()
        End If

    End Sub

    Function UploadWS(ByVal sFilename As String, ByVal sPage As String, ByVal nRetry As Integer) As String
        Dim sBoundry As String = ""
        Dim sBuffer As String = ""
        Dim sModul As String = ""

        Dim sUrl As String = ""
        Dim sUsername As String = ""
        Dim sPassword As String = ""

        Dim sBufferUpload As String = ""

        Dim sDir As String = ""
        Dim sNeuDir As String = ""
        Dim sNeuFilename As String = ""

        Dim nRetryCnt As Integer = 0

        sDir = Left(sFilename, InStrRev(sFilename, "\"))
        sNeuDir = sDir + "Save\"

        sFilename = Mid(sFilename, InStrRev(sFilename, "\") + 1, Len(sFilename) - InStrRev(sFilename, "\") + 1)
        sNeuFilename = Right(Date.Today.Year.ToString, 2) + Right("0" & Date.Now.Month.ToString, 2) + Right("0" & Date.Now.Day.ToString, 2) + "_" + sFilename

        sDir = sDir + sFilename
        sNeuDir = sNeuDir + sNeuFilename

        Select Case sPage
            Case "a_shop_currency"
                sModul = "CShopCurrency"
                sUrl = sUrlDetail
                sUsername = sUsernameDetail
                sPassword = sPasswordDetail
            Case "a_shop_item_DT"
                sPage = "a_shop_item"
                sModul = "CShopItem"
                sUrl = sUrlDetail
                sUsername = sUsernameDetail
                sPassword = sPasswordDetail
            Case "a_customer"
                sModul = "CCustomer"
                sUrl = sUrlDetail
                sUsername = sUsernameDetail
                sPassword = sPasswordDetail
            Case "a_shop_item_GH"
                sPage = "a_shop_item"
                sModul = "CShopItem"
                sUrl = sUrlGH
                sUsername = sUsernameGH
                sPassword = sPasswordGH
            Case "a_shop_pricelist"
                sModul = "CShopPricelist"
                sUrl = sUrlGH
                sUsername = sUsernameGH
                sPassword = sPasswordGH
            Case "a_shop_region"
                sModul = "CShopRegion"
                sUrl = sUrlGH
                sUsername = sUsernameGH
                sPassword = sPasswordGH
            Case Else
                Console.WriteLine("Fehler: Modul/Page nicht angegeben")
                Return "Fehler: Modul/Page nicht angegeben"
                Exit Function
        End Select

        sBoundry = "---------------------------0123456789012"

        sBuffer = ""
        sBuffer = sBuffer + HttpFormData("submit", "1", sBoundry, "", "")
        sBuffer = sBuffer + HttpFormData("username", sUsername, sBoundry, "", "")
        sBuffer = sBuffer + HttpFormData("password", sPassword, sBoundry, "", "")
        sBuffer = sBuffer + HttpFormData("page", sPage, sBoundry, "", "")
        sBuffer = sBuffer + HttpFormData("modul", sModul, sBoundry, "", "")
        sBuffer = sBuffer + HttpFormData("encoding", "utf-8", sBoundry, "", "")
        sBuffer = sBuffer + HttpFormData("filename", FileReadText(sDir, sNeuDir), sBoundry, "Content-Type: application/upload", "file.csv")

        Do While nRetryCnt <= nRetry
            sBufferUpload = HttpPost(sUrl, sBuffer, sBoundry)

            If Not InStr(1, sBufferUpload, "!-- import_submitted --") = 0 Then
                Exit Do
            End If

            nRetryCnt += 1
        Loop

        If Not InStr(1, sBufferUpload, "!-- import_submitted --") = 0 Then
            Console.WriteLine("ok " + sPage + " " + sDir)
            Return "ok " + sPage + " " + sDir
        Else
            Console.WriteLine("nicht ok " + sPage + " " + sDir + vbNewLine + sBufferUpload)
            nError = 1
            sErrorTxt = sErrorTxt + "nicht ok " + sPage + " " + sDir + vbNewLine + vbNewLine + sBufferUpload + vbNewLine + vbNewLine
            Return "nicht ok " + sPage + " " + sDir + vbNewLine + sBufferUpload
        End If

    End Function

    Function HttpFormData(ByVal sField As String, ByVal sValue As String, ByVal sBoundry As String, ByVal sHeader As String, ByVal sFilename As String) As String
        Dim sBuffer As String = ""

        sBuffer = "--" + sBoundry + vbNewLine + "Content-Disposition: form-data; name=""" + sField + """"
        If Not sFilename = "" Then
            sBuffer = sBuffer + "; filename=""" + sFilename + """" + vbNewLine
        End If
        sBuffer = sBuffer + sHeader + vbNewLine + vbNewLine + sValue + vbNewLine

        Return sBuffer
    End Function

    Function HttpPost(ByVal sUrl As String, ByVal sData As String, ByVal sBoundry As String) As String
        Dim oHttp As New MSXML2.ServerXMLHTTP

        sData = Replace(sData, Chr(150), "-")
        sData = Replace(sData, Chr(132), """")
        sData = Replace(sData, Chr(147), """")

        Try
            oHttp.setTimeouts(6 * 1000, 6 * 1000, 600 * 1000, 600 * 1000)

            oHttp.open("POST", sUrl, False)
            oHttp.setRequestHeader("Content-Type", "multipart/form-data; charset=ISO-8859-1; boundary=" + sBoundry)

            oHttp.send(sData + "--" + sBoundry + "--")

            Return oHttp.responseText

        Catch x As Exception
            Console.WriteLine(x.Message)
            nError = 1
            sErrorTxt = sErrorTxt + x.Message + vbNewLine + vbNewLine
            Return ""
        End Try

    End Function

    Function FileReadText(ByVal sDir As String, ByVal sNeuDir As String) As String

        Dim sr As System.IO.StreamReader
        Dim sContent As String
        Dim i As Integer = 1

        If System.IO.File.Exists(sDir) Then
            sr = New System.IO.StreamReader(sDir, System.Text.Encoding.Default)
            sContent = sr.ReadToEnd
            sr.Close()

            If System.IO.File.Exists(sNeuDir) Then
                Do
                    If Not System.IO.File.Exists(sNeuDir & "." & i.ToString) Then
                        sNeuDir = sNeuDir & "." & i.ToString
                        Exit Do
                    End If

                    i = i + 1
                Loop
            End If

            System.IO.File.Move(sDir, sNeuDir)

            Return sContent
        Else
            Console.WriteLine("nicht ok - " + sDir + " Datei nicht vorhanden")
            nError = 1
            sErrorTxt = sErrorTxt + "nicht ok - " + sDir + " Datei nicht vorhanden" + vbNewLine + vbNewLine
            Return ""
        End If
    End Function

    Function SentMail() As Boolean
        Dim MailMsg As New MailMessage
        Dim MailCredentials As New System.Net.NetworkCredential
        Dim MailSmtp As New SmtpClient()

        Try



            MailCredentials.UserName = sUser
            MailCredentials.Password = sPass

            MailSmtp.Host = sServer
            MailSmtp.Port = nPort
            MailSmtp.UseDefaultCredentials = False
            MailSmtp.Credentials = MailCredentials

            MailMsg.From = New MailAddress(sFrom)
            MailMsg.To.Add(sTo)
            MailMsg.Subject = sSubject
            MailMsg.Body = sErrorTxt

            MailMsg.IsBodyHtml = False

            MailSmtp.Send(MailMsg)
            Return True

        Catch x As Exception
            Console.WriteLine(x.Message)
            nError = 1
            sErrorTxt = sErrorTxt + x.Message + vbNewLine + vbNewLine
            Return False
        End Try

    End Function

    Function XMLReadSettings() As Boolean
        If System.IO.File.Exists("WebShop_Settings.xml") Then
            Dim oXMLReader As Xml.XmlReader = New Xml.XmlTextReader("Webshop_Settings.xml")
            With oXMLReader
                Do While .Read
                    Select Case .NodeType
                        Case Xml.XmlNodeType.Element
                            Select Case .Name
                                Case "MailParameter"
                                    If .AttributeCount > 0 Then
                                        While .MoveToNextAttribute
                                            Select Case .Name
                                                Case "Server"
                                                    sServer = .Value
                                                Case "Port"
                                                    nPort = Val(.Value)
                                                Case "User"
                                                    sUser = .Value
                                                Case "Pass"
                                                    sPass = .Value
                                                Case "From"
                                                    sFrom = .Value
                                                Case "To"
                                                    sTo = .Value
                                                Case "Subject"
                                                    sSubject = .Value
                                            End Select
                                        End While
                                    End If
                                Case "WebShopDetail"
                                    If .AttributeCount > 0 Then
                                        While .MoveToNextAttribute
                                            Select Case .Name
                                                Case "Server"
                                                    sUrlDetail = .Value
                                                Case "User"
                                                    sUsernameDetail = .Value
                                                Case "Pass"
                                                    sPasswordDetail = .Value
                                            End Select
                                        End While
                                    End If
                                Case "WebShopGH"
                                    If .AttributeCount > 0 Then
                                        While .MoveToNextAttribute
                                            Select Case .Name
                                                Case "Server"
                                                    sUrlGH = .Value
                                                Case "User"
                                                    sUsernameGH = .Value
                                                Case "Pass"
                                                    sPasswordGH = .Value
                                            End Select
                                        End While
                                    End If
                            End Select
                    End Select
                Loop
            End With
            Return True
        Else
            Console.WriteLine("nicht ok - Webshop_Settings.xml nicht vorhanden")
            nError = 1
            sErrorTxt = sErrorTxt + "nicht ok - Webshop_Settings.xml nicht vorhanden" + vbNewLine + vbNewLine
            Return False
        End If
    End Function
End Module
