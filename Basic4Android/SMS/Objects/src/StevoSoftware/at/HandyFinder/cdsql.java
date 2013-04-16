package StevoSoftware.at.HandyFinder;

import anywheresoftware.b4a.BA;
import anywheresoftware.b4a.BALayout;
import anywheresoftware.b4a.debug.*;

public class cdsql {
private static cdsql mostCurrent = new cdsql();
public static Object getObject() {
    throw new RuntimeException("Code module does not support this method.");
}
 public anywheresoftware.b4a.keywords.Common __c = null;
public static anywheresoftware.b4a.sql.SQL _osql = null;
public static anywheresoftware.b4a.sql.SQL.CursorWrapper _csql = null;
public static boolean _bdbexist = false;
public static int _ipos = 0;
public main _main = null;
public svsms _svsms = null;
public static String  _create_tables(anywheresoftware.b4a.BA _ba) throws Exception{
		Debug.PushSubsStack("Create_Tables (cdsql) ","cdsql",2,_ba,mostCurrent);
try {
Debug.locals.put("ba", _ba);
 BA.debugLineNum = 41;BA.debugLine="Sub Create_Tables";
Debug.ShouldStop(256);
 BA.debugLineNum = 42;BA.debugLine="Log(\"Creating Table 'tblVersion'\")";
Debug.ShouldStop(512);
anywheresoftware.b4a.keywords.Common.Log("Creating Table 'tblVersion'");
 BA.debugLineNum = 43;BA.debugLine="oSQL.ExecNonQuery(\"Create Table tblVersion (Version TEXT, Savepoint INT)\")";
Debug.ShouldStop(1024);
_osql.ExecNonQuery("Create Table tblVersion (Version TEXT, Savepoint INT)");
 BA.debugLineNum = 45;BA.debugLine="Log(\"...tblVersion: Inserting Values\")";
Debug.ShouldStop(4096);
anywheresoftware.b4a.keywords.Common.Log("...tblVersion: Inserting Values");
 BA.debugLineNum = 46;BA.debugLine="oSQL.ExecNonQuery(\"Insert into tblVersion (Version, Savepoint) Values('\" & Main.strAppVersion & \"',\" & Main.iAppSavepoint & \")\")";
Debug.ShouldStop(8192);
_osql.ExecNonQuery("Insert into tblVersion (Version, Savepoint) Values('"+mostCurrent._main._strappversion+"',"+BA.NumberToString(mostCurrent._main._iappsavepoint)+")");
 BA.debugLineNum = 48;BA.debugLine="Log(\"Creating Table 'tblSettings'\")";
Debug.ShouldStop(32768);
anywheresoftware.b4a.keywords.Common.Log("Creating Table 'tblSettings'");
 BA.debugLineNum = 49;BA.debugLine="oSQl.ExecNonQuery(\"Create Table tblSettings (Id INT, Name TEXT, Value TEXT)\")";
Debug.ShouldStop(65536);
_osql.ExecNonQuery("Create Table tblSettings (Id INT, Name TEXT, Value TEXT)");
 BA.debugLineNum = 51;BA.debugLine="Log(\"...tblSettings: Inserting Values\")";
Debug.ShouldStop(262144);
anywheresoftware.b4a.keywords.Common.Log("...tblSettings: Inserting Values");
 BA.debugLineNum = 52;BA.debugLine="oSQL.ExecNonQuery(\"Insert into tblSettings(Id, Name, Value) Values(0,'SMSText','???WHERE???')\")";
Debug.ShouldStop(524288);
_osql.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(0,'SMSText','???WHERE???')");
 BA.debugLineNum = 53;BA.debugLine="oSQL.ExecNonQuery(\"Insert into tblSettings(Id, Name, Value) Values(1,'MailTo','sdehner@gmx.at')\")";
Debug.ShouldStop(1048576);
_osql.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(1,'MailTo','sdehner@gmx.at')");
 BA.debugLineNum = 54;BA.debugLine="oSQL.ExecNonQuery(\"Insert into tblSettings(Id, Name, Value) Values(2,'SMSEnbaled','True')\")";
Debug.ShouldStop(2097152);
_osql.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(2,'SMSEnbaled','True')");
 BA.debugLineNum = 55;BA.debugLine="oSQL.ExecNonQuery(\"Insert into tblSettings(Id, Name, Value) Values(3,'MailEnbaled','True')\")";
Debug.ShouldStop(4194304);
_osql.ExecNonQuery("Insert into tblSettings(Id, Name, Value) Values(3,'MailEnbaled','True')");
 BA.debugLineNum = 57;BA.debugLine="bDBExist = True";
Debug.ShouldStop(16777216);
_bdbexist = anywheresoftware.b4a.keywords.Common.True;
 BA.debugLineNum = 58;BA.debugLine="End Sub";
Debug.ShouldStop(33554432);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static boolean  _execute_non_query(anywheresoftware.b4a.BA _ba,String _query) throws Exception{
		Debug.PushSubsStack("Execute_Non_Query (cdsql) ","cdsql",2,_ba,mostCurrent);
try {
Debug.locals.put("ba", _ba);
Debug.locals.put("Query", _query);
 BA.debugLineNum = 67;BA.debugLine="Sub Execute_Non_Query(Query As String) As Boolean";
Debug.ShouldStop(4);
 BA.debugLineNum = 68;BA.debugLine="Try";
Debug.ShouldStop(8);
try { BA.debugLineNum = 69;BA.debugLine="oSQL.ExecNonQuery(Query)";
Debug.ShouldStop(16);
_osql.ExecNonQuery(_query);
 } 
       catch (Exception e) {
			(_ba.processBA == null ? _ba : _ba.processBA).setLastException(e); };
 BA.debugLineNum = 73;BA.debugLine="Return True";
Debug.ShouldStop(256);
if (true) return anywheresoftware.b4a.keywords.Common.True;
 BA.debugLineNum = 74;BA.debugLine="End Sub";
Debug.ShouldStop(512);
return false;
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _init_db(anywheresoftware.b4a.BA _ba) throws Exception{
		Debug.PushSubsStack("Init_DB (cdsql) ","cdsql",2,_ba,mostCurrent);
try {
String _strversion = "";
int _isavepoint = 0;
Debug.locals.put("ba", _ba);
 BA.debugLineNum = 14;BA.debugLine="Sub Init_DB";
Debug.ShouldStop(8192);
 BA.debugLineNum = 15;BA.debugLine="bDBExist = File.Exists(File.DirDefaultExternal,\"\\SMS.db\")";
Debug.ShouldStop(16384);
_bdbexist = anywheresoftware.b4a.keywords.Common.File.Exists(anywheresoftware.b4a.keywords.Common.File.getDirDefaultExternal(),"\\SMS.db");
 BA.debugLineNum = 17;BA.debugLine="oSQL.Initialize(File.DirDefaultExternal, \"SMS.db\", True)";
Debug.ShouldStop(65536);
_osql.Initialize(anywheresoftware.b4a.keywords.Common.File.getDirDefaultExternal(),"SMS.db",anywheresoftware.b4a.keywords.Common.True);
 BA.debugLineNum = 19;BA.debugLine="If bDBExist = False Then";
Debug.ShouldStop(262144);
if (_bdbexist==anywheresoftware.b4a.keywords.Common.False) { 
 BA.debugLineNum = 20;BA.debugLine="Log(\"Create DB\")";
Debug.ShouldStop(524288);
anywheresoftware.b4a.keywords.Common.Log("Create DB");
 BA.debugLineNum = 21;BA.debugLine="Create_Tables";
Debug.ShouldStop(1048576);
_create_tables(_ba);
 }else {
 BA.debugLineNum = 23;BA.debugLine="Log(\"Checking DB Version\")";
Debug.ShouldStop(4194304);
anywheresoftware.b4a.keywords.Common.Log("Checking DB Version");
 BA.debugLineNum = 24;BA.debugLine="Dim strVersion As String";
Debug.ShouldStop(8388608);
_strversion = "";Debug.locals.put("strVersion", _strversion);
 BA.debugLineNum = 25;BA.debugLine="Dim iSavepoint As Int";
Debug.ShouldStop(16777216);
_isavepoint = 0;Debug.locals.put("iSavepoint", _isavepoint);
 BA.debugLineNum = 27;BA.debugLine="strVersion = oSQL.ExecQuerySingleResult(\"Select Version from tblVersion\")";
Debug.ShouldStop(67108864);
_strversion = _osql.ExecQuerySingleResult("Select Version from tblVersion");Debug.locals.put("strVersion", _strversion);
 BA.debugLineNum = 28;BA.debugLine="iSavepoint = oSQL.ExecQuerySingleResult(\"Select Savepoint from tblVersion\")";
Debug.ShouldStop(134217728);
_isavepoint = (int)(Double.parseDouble(_osql.ExecQuerySingleResult("Select Savepoint from tblVersion")));Debug.locals.put("iSavepoint", _isavepoint);
 BA.debugLineNum = 30;BA.debugLine="Log(\"...Version \" & strVersion & \", Savepoint \" & iSavepoint)";
Debug.ShouldStop(536870912);
anywheresoftware.b4a.keywords.Common.Log("...Version "+_strversion+", Savepoint "+BA.NumberToString(_isavepoint));
 BA.debugLineNum = 32;BA.debugLine="If strVersion <> Main.strAppVersion OR iSavepoint <> Main.iAppSavepoint Then";
Debug.ShouldStop(-2147483648);
if ((_strversion).equals(mostCurrent._main._strappversion) == false || _isavepoint!=mostCurrent._main._iappsavepoint) { 
 BA.debugLineNum = 33;BA.debugLine="Log(\"......Update DB\")";
Debug.ShouldStop(1);
anywheresoftware.b4a.keywords.Common.Log("......Update DB");
 BA.debugLineNum = 34;BA.debugLine="Update_DB(strVersion, iSavepoint)";
Debug.ShouldStop(2);
_update_db(_ba,_strversion,_isavepoint);
 }else {
 BA.debugLineNum = 36;BA.debugLine="Log(\"......Version OK\")";
Debug.ShouldStop(8);
anywheresoftware.b4a.keywords.Common.Log("......Version OK");
 };
 };
 BA.debugLineNum = 39;BA.debugLine="End Sub";
Debug.ShouldStop(64);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _process_globals() throws Exception{
 BA.debugLineNum = 3;BA.debugLine="Sub Process_Globals";
 BA.debugLineNum = 7;BA.debugLine="Dim oSQL As SQL";
_osql = new anywheresoftware.b4a.sql.SQL();
 BA.debugLineNum = 8;BA.debugLine="Dim cSQL As Cursor";
_csql = new anywheresoftware.b4a.sql.SQL.CursorWrapper();
 BA.debugLineNum = 9;BA.debugLine="Dim bDBExist As Boolean";
_bdbexist = false;
 BA.debugLineNum = 10;BA.debugLine="Dim iPos As Int";
_ipos = 0;
 BA.debugLineNum = 11;BA.debugLine="End Sub";
return "";
}
public static String  _update_db(anywheresoftware.b4a.BA _ba,String _version,int _savepoint) throws Exception{
		Debug.PushSubsStack("Update_DB (cdsql) ","cdsql",2,_ba,mostCurrent);
try {
Debug.locals.put("ba", _ba);
Debug.locals.put("Version", _version);
Debug.locals.put("Savepoint", _savepoint);
 BA.debugLineNum = 60;BA.debugLine="Sub Update_DB(Version As String, Savepoint As Int)";
Debug.ShouldStop(134217728);
 BA.debugLineNum = 61;BA.debugLine="Select Case Version & \"_\" & Savepoint";
Debug.ShouldStop(268435456);
switch (BA.switchObjectToInt(_version+"_"+BA.NumberToString(_savepoint),"1.0_1")) {
case 0:
 break;
}
;
 BA.debugLineNum = 65;BA.debugLine="End Sub";
Debug.ShouldStop(1);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
  public Object[] GetGlobals() {
		return new Object[] {"oSQL",_osql,"cSQL",_csql,"bDBExist",_bdbexist,"iPos",_ipos,"Main",Debug.moduleToString(StevoSoftware.at.HandyFinder.main.class),"svSMS",Debug.moduleToString(StevoSoftware.at.HandyFinder.svsms.class)};
}
}
