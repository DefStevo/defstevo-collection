Type=StaticCode
Version=1.50
@EndOfDesignText@
'Code module
'Subs in this code module will be accessible from all modules.
Sub Process_Globals
	'These global variables will be declared once when the application starts.
	'These variables can be accessed from all modules.
	
	Dim oGPS As GPS

End Sub

Sub Init_GPS

	oGPS.Initialize("GPS")
	
	If oGPS.GPSEnabled = False Then
		oGPS.GPSEnabled = True
	End If		
End Sub

Sub Start_GPS
	oGPS.Start(0,0)
End Sub

Sub Stop_GPS
	oGPS.Stop
End Sub
