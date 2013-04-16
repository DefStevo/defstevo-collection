package StevoSoftware.at.HandyFinder;

import anywheresoftware.b4a.BA;
import anywheresoftware.b4a.objects.ServiceHelper;
import anywheresoftware.b4a.debug.*;

public class svsms extends android.app.Service {
	public static class svsms_BR extends android.content.BroadcastReceiver {

		@Override
		public void onReceive(android.content.Context context, android.content.Intent intent) {
			android.util.Log.w("B4A", "Service (svsms) ReceiveBroadcast");
			context.startService(new android.content.Intent(context, svsms.class));
		}

	}
    static svsms mostCurrent;
	public static BA processBA;
    private ServiceHelper _service;
    public static Class<?> getObject() {
		return svsms.class;
	}
	@Override
	public void onCreate() {
        mostCurrent = this;
        if (processBA == null) {
            main.initializeProcessGlobals();
		    processBA = new BA(this, null, null, "StevoSoftware.at.HandyFinder", "svsms");
            processBA.loadHtSubs(this.getClass());
            ServiceHelper.init();
        }
        _service = new ServiceHelper(this);
        processBA.service = this;
        processBA.setActivityPaused(false);
        anywheresoftware.b4a.keywords.Common.Log("** Service (svsms) Create **");
        processBA.raiseEvent(null, "service_create");
    }
	@Override
	public void onStart(android.content.Intent intent, int startId) {
		handleStart();
    }
    @Override
    public int onStartCommand(android.content.Intent intent, int flags, int startId) {
    	handleStart();
		return android.app.Service.START_STICKY;
    }
    private void handleStart() {
    	anywheresoftware.b4a.keywords.Common.Log("** Service (svsms) Start **");
        processBA.raiseEvent(null, "service_start");
    }
	@Override
	public android.os.IBinder onBind(android.content.Intent intent) {
		return null;
	}
	@Override
	public void onDestroy() {
        anywheresoftware.b4a.keywords.Common.Log("** Service (svsms) Destroy **");
		processBA.raiseEvent(null, "service_destroy");
        processBA.service = null;
		mostCurrent = null;
		processBA.setActivityPaused(true);
	}
public anywheresoftware.b4a.keywords.Common __c = null;
public static anywheresoftware.b4a.phone.PhoneEvents.SMSInterceptor _osmsinterceptor = null;
public static String _strfrom = "";
public main _main = null;
public cdsql _cdsql = null;
public static String  _osms_messagereceived(String _from,String _body) throws Exception{
		Debug.PushSubsStack("oSMS_MessageReceived (svsms) ","svsms",1,processBA,mostCurrent);
try {
Debug.locals.put("From", _from);
Debug.locals.put("Body", _body);
 BA.debugLineNum = 24;BA.debugLine="Sub oSMS_MessageReceived (From As String, Body As String)";
Debug.ShouldStop(8388608);
 BA.debugLineNum = 26;BA.debugLine="If body = Main.strSMSText Then";
Debug.ShouldStop(33554432);
if ((_body).equals(mostCurrent._main._strsmstext)) { 
 BA.debugLineNum = 27;BA.debugLine="strFrom = From";
Debug.ShouldStop(67108864);
_strfrom = _from;
 BA.debugLineNum = 28;BA.debugLine="ToastMessageShow(\"HandyFinder: NEW MESSAGE\",True)";
Debug.ShouldStop(134217728);
anywheresoftware.b4a.keywords.Common.ToastMessageShow("HandyFinder: NEW MESSAGE",anywheresoftware.b4a.keywords.Common.True);
 BA.debugLineNum = 29;BA.debugLine="Log(\"!!! New Message\")";
Debug.ShouldStop(268435456);
anywheresoftware.b4a.keywords.Common.Log("!!! New Message");
 BA.debugLineNum = 30;BA.debugLine="If Main.bSMS = True Then";
Debug.ShouldStop(536870912);
if (mostCurrent._main._bsms==anywheresoftware.b4a.keywords.Common.True) { 
 BA.debugLineNum = 31;BA.debugLine="ToastMessageShow(\"HandyFinder: SEND SMS\",True)";
Debug.ShouldStop(1073741824);
anywheresoftware.b4a.keywords.Common.ToastMessageShow("HandyFinder: SEND SMS",anywheresoftware.b4a.keywords.Common.True);
 BA.debugLineNum = 32;BA.debugLine="Log(\"!!! Send SMS\")";
Debug.ShouldStop(-2147483648);
anywheresoftware.b4a.keywords.Common.Log("!!! Send SMS");
 };
 BA.debugLineNum = 34;BA.debugLine="If Main.bMail = True Then";
Debug.ShouldStop(2);
if (mostCurrent._main._bmail==anywheresoftware.b4a.keywords.Common.True) { 
 BA.debugLineNum = 35;BA.debugLine="ToastMessageShow(\"HandyFinder: SEND MAIL\",True)";
Debug.ShouldStop(4);
anywheresoftware.b4a.keywords.Common.ToastMessageShow("HandyFinder: SEND MAIL",anywheresoftware.b4a.keywords.Common.True);
 BA.debugLineNum = 36;BA.debugLine="Log(\"!!! Send Mail\")";
Debug.ShouldStop(8);
anywheresoftware.b4a.keywords.Common.Log("!!! Send Mail");
 };
 }else {
 BA.debugLineNum = 39;BA.debugLine="ToastMessageShow(\"Sms from: \" & From & CRLF & _ 						 \"Message: \" & body, True)";
Debug.ShouldStop(64);
anywheresoftware.b4a.keywords.Common.ToastMessageShow("Sms from: "+_from+anywheresoftware.b4a.keywords.Common.CRLF+"Message: "+_body,anywheresoftware.b4a.keywords.Common.True);
 };
 BA.debugLineNum = 45;BA.debugLine="End Sub";
Debug.ShouldStop(4096);
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
 BA.debugLineNum = 2;BA.debugLine="Sub Process_Globals";
 BA.debugLineNum = 5;BA.debugLine="Dim oSMSInterceptor As SmsInterceptor";
_osmsinterceptor = new anywheresoftware.b4a.phone.PhoneEvents.SMSInterceptor();
 BA.debugLineNum = 7;BA.debugLine="Dim strFrom As String";
_strfrom = "";
 BA.debugLineNum = 9;BA.debugLine="End Sub";
return "";
}
public static String  _service_create() throws Exception{
		Debug.PushSubsStack("Service_Create (svsms) ","svsms",1,processBA,mostCurrent);
try {
 BA.debugLineNum = 10;BA.debugLine="Sub Service_Create";
Debug.ShouldStop(512);
 BA.debugLineNum = 11;BA.debugLine="oSMSInterceptor.Initialize(\"oSMS\")";
Debug.ShouldStop(1024);
_osmsinterceptor.Initialize("oSMS",processBA);
 BA.debugLineNum = 12;BA.debugLine="Log(\"svSMS Create\")";
Debug.ShouldStop(2048);
anywheresoftware.b4a.keywords.Common.Log("svSMS Create");
 BA.debugLineNum = 14;BA.debugLine="End Sub";
Debug.ShouldStop(8192);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _service_destroy() throws Exception{
		Debug.PushSubsStack("Service_Destroy (svsms) ","svsms",1,processBA,mostCurrent);
try {
 BA.debugLineNum = 20;BA.debugLine="Sub Service_Destroy";
Debug.ShouldStop(524288);
 BA.debugLineNum = 21;BA.debugLine="Log(\"svSMS_Stop\")";
Debug.ShouldStop(1048576);
anywheresoftware.b4a.keywords.Common.Log("svSMS_Stop");
 BA.debugLineNum = 22;BA.debugLine="End Sub";
Debug.ShouldStop(2097152);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _service_start() throws Exception{
		Debug.PushSubsStack("Service_Start (svsms) ","svsms",1,processBA,mostCurrent);
try {
 BA.debugLineNum = 16;BA.debugLine="Sub Service_Start";
Debug.ShouldStop(32768);
 BA.debugLineNum = 17;BA.debugLine="Log(\"svSMS Start\")";
Debug.ShouldStop(65536);
anywheresoftware.b4a.keywords.Common.Log("svSMS Start");
 BA.debugLineNum = 18;BA.debugLine="End Sub";
Debug.ShouldStop(131072);
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
		return new Object[] {"Service",_service,"oSMSInterceptor",_osmsinterceptor,"strFrom",_strfrom,"Main",Debug.moduleToString(StevoSoftware.at.HandyFinder.main.class),"cdSQL",Debug.moduleToString(StevoSoftware.at.HandyFinder.cdsql.class)};
}
}
