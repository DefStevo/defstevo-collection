Type=Service
Version=1.50
StartAtBoot=False
@EndOfDesignText@
'Service module
Sub Process_Globals
	'These global variables will be declared once when the application starts.
	'These variables can be accessed from all modules.
	Dim oSMSInterceptor As SmsInterceptor
	
	Dim strFrom As String
		
End Sub
Sub Service_Create
	oSMSInterceptor.Initialize("oSMS")
	Log("svSMS Create")

End Sub

Sub Service_Start
	Log("svSMS Start")
End Sub

Sub Service_Destroy
	Log("svSMS_Stop")
End Sub

Sub oSMS_MessageReceived (From As String, Body As String)
	'Check SMS Text
	If body = Main.strSMSText Then
		strFrom = From
		ToastMessageShow("HandyFinder: NEW MESSAGE",True)
		Log("!!! New Message")
		If Main.bSMS = True Then
			ToastMessageShow("HandyFinder: SEND SMS",True)
			Log("!!! Send SMS")
		End If
		If Main.bMail = True Then
			ToastMessageShow("HandyFinder: SEND MAIL",True)
			Log("!!! Send Mail")
		End If
	Else
		ToastMessageShow("Sms from: " & From & CRLF & _
						 "Message: " & body, True)	
	End If
	
	
			
End Sub
