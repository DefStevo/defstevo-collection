Type=StaticCode
Version=1.50
@EndOfDesignText@
'Code module
'Subs in this code module will be accessible from all modules.
Sub Process_Globals
	'These global variables will be declared once when the application starts.
	'These variables can be accessed from all modules.
	
	Dim oSQL As SQL
	Dim cSQL As Cursor
	Dim bDBExist As Boolean
	Dim iPos As Int
End Sub


Sub Init_DB
	bDBExist = File.Exists(File.DirDefaultExternal,"\SMS.db")
	
	oSQL.Initialize(File.DirDefaultExternal, "SMS.db", True)
	
	If bDBExist = False Then
		Log("Create DB")
		Create_Tables
	Else
		Log("Checking DB Version")
		Dim strVersion As String
		Dim iSavepoint As Int
		
		strVersion = oSQL.ExecQuerySingleResult("Select Version from tblVersion")
		iSavepoint = oSQL.ExecQuerySingleResult("Select Savepoint from tblVersion")
		
		Log("...Version " & strVersion & ", Savepoint " & iSavepoint)
				
		If strVersion <> Main.strAppVersion OR iSavepoint <> Main.iAppSavepoint Then
			Log("......Update DB")
			Update_DB(strVersion, iSavepoint)
		Else
			Log("......Version OK")
		End If
	End If
End Sub

Sub Create_Tables
	Log("Creating Table 'tblVersion'")
	oSQL.ExecNonQuery("Create Table tblVersion (Version TEXT, Savepoint INT)")
	
	Log("...tblVersion: Inserting Values")
	oSQL.ExecNonQuery("Insert into tblVersion (Version, Savepoint) Values('" & Main.strAppVersion & "'," & Main.iAppSavepoint & ")")
					  
	Log("Creating Table 'tblSettings'")
	oSQl.ExecNonQuery("Create Table tblSettings (Id INT, Name TEXT, Value TEXT)")
	
	Log("...tblSettings: Inserting Values")
	oSQL.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(0,'SMSText','???WHERE???')")
	oSQL.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(1,'MailTo','sdehner@gmx.at')")
	oSQL.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(2,'SMSEnbaled','True')")
	oSQL.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(3,'MailEnbaled','True')")
					  
	bDBExist = True
End Sub

Sub Update_DB(Version As String, Savepoint As Int)
	Select Case Version & "_" & Savepoint
		Case "1.0_1"
				
	End Select
End Sub

Sub Execute_Non_Query(Query As String) As Boolean
	Try
		oSQL.ExecNonQuery(Query)
	Catch
		'Log(ex)
	End Try
	Return True
End Sub

