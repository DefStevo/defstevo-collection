package StevoSoftware.at.HandyFinder;

import anywheresoftware.b4a.B4AMenuItem;
import android.app.Activity;
import android.os.Bundle;
import anywheresoftware.b4a.BA;
import anywheresoftware.b4a.BALayout;
import anywheresoftware.b4a.B4AActivity;
import anywheresoftware.b4a.ObjectWrapper;
import anywheresoftware.b4a.objects.ActivityWrapper;
import java.lang.reflect.InvocationTargetException;
import anywheresoftware.b4a.B4AUncaughtException;
import anywheresoftware.b4a.debug.*;
import java.lang.ref.WeakReference;

public class main extends Activity implements B4AActivity{
	static main mostCurrent;
	static boolean afterFirstLayout;
	static boolean isFirst = true;
    private static boolean processGlobalsRun = false;
	BALayout layout;
	public static BA processBA;
	BA activityBA;
    ActivityWrapper _activity;
    java.util.ArrayList<B4AMenuItem> menuItems;
	private static final boolean fullScreen = false;
	private static final boolean includeTitle = true;
    public static WeakReference<Activity> previousOne;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		if (isFirst) {
			processBA = new BA(this.getApplicationContext(), null, null, "StevoSoftware.at.HandyFinder", "main");
			processBA.loadHtSubs(this.getClass());
	        float deviceScale = getApplicationContext().getResources().getDisplayMetrics().density;
	        BALayout.setDeviceScale(deviceScale);
		}
		else if (previousOne != null) {
			Activity p = previousOne.get();
			if (p != null && p != this) {
                anywheresoftware.b4a.keywords.Common.Log("Killing previous instance (main).");
				p.finish();
			}
		}
		if (!includeTitle) {
        	this.getWindow().requestFeature(android.view.Window.FEATURE_NO_TITLE);
        }
        if (fullScreen) {
        	getWindow().setFlags(android.view.WindowManager.LayoutParams.FLAG_FULLSCREEN,   
        			android.view.WindowManager.LayoutParams.FLAG_FULLSCREEN);
        }
		mostCurrent = this;
        processBA.activityBA = null;
		layout = new BALayout(this);
		setContentView(layout);
		afterFirstLayout = false;
		BA.handler.postDelayed(new WaitForLayout(), 5);

	}
	private static class WaitForLayout implements Runnable {
		public void run() {
			if (afterFirstLayout)
				return;
			if (mostCurrent.layout.getWidth() == 0) {
				BA.handler.postDelayed(this, 5);
				return;
			}
			mostCurrent.layout.getLayoutParams().height = mostCurrent.layout.getHeight();
			mostCurrent.layout.getLayoutParams().width = mostCurrent.layout.getWidth();
			afterFirstLayout = true;
			mostCurrent.afterFirstLayout();
		}
	}
	private void afterFirstLayout() {
		activityBA = new BA(this, layout, processBA, "StevoSoftware.at.HandyFinder", "main");
        processBA.activityBA = new java.lang.ref.WeakReference<BA>(activityBA);
        _activity = new ActivityWrapper(activityBA, "activity");
        anywheresoftware.b4a.Msgbox.isDismissing = false;
        initializeProcessGlobals();		
        initializeGlobals();
        anywheresoftware.b4a.objects.ViewWrapper.lastId = 0;
        anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Create, isFirst = " + isFirst + " **");
        processBA.raiseEvent2(null, true, "activity_create", false, isFirst);
		isFirst = false;
		if (mostCurrent == null || mostCurrent != this)
			return;
        processBA.setActivityPaused(false);
        anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Resume **");
        processBA.raiseEvent(null, "activity_resume");

	}
	public void addMenuItem(B4AMenuItem item) {
		if (menuItems == null)
			menuItems = new java.util.ArrayList<B4AMenuItem>();
		menuItems.add(item);
	}
	@Override
	public boolean onCreateOptionsMenu(android.view.Menu menu) {
		super.onCreateOptionsMenu(menu);
		if (menuItems == null)
			return false;
		for (B4AMenuItem bmi : menuItems) {
			android.view.MenuItem mi = menu.add(bmi.title);
			if (bmi.drawable != null)
				mi.setIcon(bmi.drawable);
			mi.setOnMenuItemClickListener(new B4AMenuItemsClickListener(bmi.eventName.toLowerCase(BA.cul)));
		}
		return true;
	}
	private class B4AMenuItemsClickListener implements android.view.MenuItem.OnMenuItemClickListener {
		private final String eventName;
		public B4AMenuItemsClickListener(String eventName) {
			this.eventName = eventName;
		}
		public boolean onMenuItemClick(android.view.MenuItem item) {
			processBA.raiseEvent(item.getTitle(), eventName + "_click");
			return true;
		}
	}
    public static Class<?> getObject() {
		return main.class;
	}
    private Boolean onKeySubExist = null;
	@Override
	public boolean onKeyDown(int keyCode, android.view.KeyEvent event) {
		if (onKeySubExist == null)
			onKeySubExist = processBA.subExists("activity_keypress");
		if (onKeySubExist) {
			Boolean res =  (Boolean)processBA.raiseEvent2(_activity, false, "activity_keypress", false, keyCode);
			if (res == null || res == true)
				return true;
		}
		return super.onKeyDown(keyCode, event);
	}
    @Override 
	public void onPause() {
		super.onPause();
        if (_activity == null) //workaround for emulator bug (Issue 2423)
            return;
		anywheresoftware.b4a.Msgbox.dismiss(true);
        anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Pause, UserClosed = " + activityBA.activity.isFinishing() + " **");
        processBA.raiseEvent2(_activity, true, "activity_pause", false, activityBA.activity.isFinishing());		
        processBA.setActivityPaused(true);
        mostCurrent = null;
        if (!activityBA.activity.isFinishing())
			previousOne = new WeakReference<Activity>(this);
	}

	@Override
	public void onDestroy() {
        super.onDestroy();
		previousOne = null;
	}
    @Override 
	public void onResume() {
		super.onResume();
        mostCurrent = this;
        anywheresoftware.b4a.Msgbox.isDismissing = false;
        if (activityBA != null) { //will be null during activity create (which waits for AfterLayout).
        	ResumeMessage rm = new ResumeMessage(mostCurrent);
        	BA.handler.post(rm);
        }
	}
    private static class ResumeMessage implements Runnable {
    	private final WeakReference<Activity> activity;
    	public ResumeMessage(Activity activity) {
    		this.activity = new WeakReference<Activity>(activity);
    	}
		public void run() {
			if (mostCurrent == null || mostCurrent != activity.get())
				return;
			processBA.setActivityPaused(false);
            anywheresoftware.b4a.keywords.Common.Log("** Activity (main) Resume **");
		    processBA.raiseEvent(mostCurrent._activity, "activity_resume", (Object[])null);
		}
    }
	@Override
	protected void onActivityResult(int requestCode, int resultCode,
	      android.content.Intent data) {
		processBA.onActivityResult(requestCode, resultCode, data);
	}
	private static void initializeGlobals() {
		processBA.raiseEvent2(null, true, "globals", false, (Object[])null);
	}

public anywheresoftware.b4a.keywords.Common __c = null;
public static String _strsmstext = "";
public static String _strmailto = "";
public static String _strappversion = "";
public static boolean _bsms = false;
public static boolean _bmail = false;
public static int _iappsavepoint = 0;
public anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper _cbmail = null;
public anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper _cbsms = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtsmstext = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtmailto = null;
public anywheresoftware.b4a.objects.CompoundButtonWrapper.ToggleButtonWrapper _btnswitch = null;
public svsms _svsms = null;
public cdsql _cdsql = null;
public static String  _activity_create(boolean _firsttime) throws Exception{
		Debug.PushSubsStack("Activity_Create (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("FirstTime", _firsttime);
 BA.debugLineNum = 27;BA.debugLine="Sub Activity_Create(FirstTime As Boolean)";
Debug.ShouldStop(67108864);
 BA.debugLineNum = 28;BA.debugLine="Log(\"Activity Start\")";
Debug.ShouldStop(134217728);
anywheresoftware.b4a.keywords.Common.Log("Activity Start");
 BA.debugLineNum = 30;BA.debugLine="Activity.LoadLayout(\"loMain\")";
Debug.ShouldStop(536870912);
mostCurrent._activity.LoadLayout("loMain",mostCurrent.activityBA);
 BA.debugLineNum = 32;BA.debugLine="End Sub";
Debug.ShouldStop(-2147483648);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _activity_pause(boolean _userclosed) throws Exception{
		Debug.PushSubsStack("Activity_Pause (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("UserClosed", _userclosed);
 BA.debugLineNum = 43;BA.debugLine="Sub Activity_Pause (UserClosed As Boolean)";
Debug.ShouldStop(1024);
 BA.debugLineNum = 44;BA.debugLine="Log(\"Write Settings\")";
Debug.ShouldStop(2048);
anywheresoftware.b4a.keywords.Common.Log("Write Settings");
 BA.debugLineNum = 45;BA.debugLine="Write_Settings_To_DB";
Debug.ShouldStop(4096);
_write_settings_to_db();
 BA.debugLineNum = 46;BA.debugLine="End Sub";
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
public static String  _activity_resume() throws Exception{
		Debug.PushSubsStack("Activity_Resume (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
 BA.debugLineNum = 34;BA.debugLine="Sub Activity_Resume";
Debug.ShouldStop(2);
 BA.debugLineNum = 35;BA.debugLine="Log(\"Initialize DB\")";
Debug.ShouldStop(4);
anywheresoftware.b4a.keywords.Common.Log("Initialize DB");
 BA.debugLineNum = 36;BA.debugLine="cdSQL.Init_DB";
Debug.ShouldStop(8);
mostCurrent._cdsql._init_db(mostCurrent.activityBA);
 BA.debugLineNum = 38;BA.debugLine="Log(\"Read Settings\")";
Debug.ShouldStop(32);
anywheresoftware.b4a.keywords.Common.Log("Read Settings");
 BA.debugLineNum = 39;BA.debugLine="Read_Settings_From_DB";
Debug.ShouldStop(64);
_read_settings_from_db();
 BA.debugLineNum = 40;BA.debugLine="Write_Settings_To_DB";
Debug.ShouldStop(128);
_write_settings_to_db();
 BA.debugLineNum = 41;BA.debugLine="End Sub";
Debug.ShouldStop(256);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _btnswitch_click() throws Exception{
		Debug.PushSubsStack("btnSwitch_Click (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
 BA.debugLineNum = 48;BA.debugLine="Sub btnSwitch_Click";
Debug.ShouldStop(32768);
 BA.debugLineNum = 49;BA.debugLine="Log(\"Switch\")";
Debug.ShouldStop(65536);
anywheresoftware.b4a.keywords.Common.Log("Switch");
 BA.debugLineNum = 50;BA.debugLine="If btnSwitch.Checked = False Then";
Debug.ShouldStop(131072);
if (mostCurrent._btnswitch.getChecked()==anywheresoftware.b4a.keywords.Common.False) { 
 BA.debugLineNum = 51;BA.debugLine="StopService(svSMS)";
Debug.ShouldStop(262144);
anywheresoftware.b4a.keywords.Common.StopService(mostCurrent.activityBA,(Object)(mostCurrent._svsms.getObject()));
 }else {
 BA.debugLineNum = 53;BA.debugLine="StartService(svSMS)";
Debug.ShouldStop(1048576);
anywheresoftware.b4a.keywords.Common.StartService(mostCurrent.activityBA,(Object)(mostCurrent._svsms.getObject()));
 };
 BA.debugLineNum = 55;BA.debugLine="End Sub";
Debug.ShouldStop(4194304);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _cbmail_checkedchange(boolean _checked) throws Exception{
		Debug.PushSubsStack("cbMail_CheckedChange (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("Checked", _checked);
 BA.debugLineNum = 116;BA.debugLine="Sub cbMail_CheckedChange(Checked As Boolean)";
Debug.ShouldStop(524288);
 BA.debugLineNum = 117;BA.debugLine="bMail = cbMail.Checked";
Debug.ShouldStop(1048576);
_bmail = mostCurrent._cbmail.getChecked();
 BA.debugLineNum = 119;BA.debugLine="Write_Settings_to_DB";
Debug.ShouldStop(4194304);
_write_settings_to_db();
 BA.debugLineNum = 120;BA.debugLine="End Sub";
Debug.ShouldStop(8388608);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _cbsms_checkedchange(boolean _checked) throws Exception{
		Debug.PushSubsStack("cbSMS_CheckedChange (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("Checked", _checked);
 BA.debugLineNum = 111;BA.debugLine="Sub cbSMS_CheckedChange(Checked As Boolean)";
Debug.ShouldStop(16384);
 BA.debugLineNum = 112;BA.debugLine="bSMS = cbSms.Checked";
Debug.ShouldStop(32768);
_bsms = mostCurrent._cbsms.getChecked();
 BA.debugLineNum = 114;BA.debugLine="Write_Settings_to_DB";
Debug.ShouldStop(131072);
_write_settings_to_db();
 BA.debugLineNum = 115;BA.debugLine="End Sub";
Debug.ShouldStop(262144);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}

public static void initializeProcessGlobals() {
    if (processGlobalsRun == false) {
	    processGlobalsRun = true;
		try {
                if (mostCurrent != null) {
Debug.StartDebugging(mostCurrent.activityBA, 35595, new int[] {4, 2, 3} );}

		        main._process_globals();
svsms._process_globals();
cdsql._process_globals();
		
        } catch (Exception e) {
			throw new RuntimeException(e);
		}
    }
}

public static void killProgram() {
    
            if (main.previousOne != null) {
				Activity a = main.previousOne.get();
				if (a != null)
					a.finish();
			}

BA.applicationContext.stopService(new android.content.Intent(BA.applicationContext, svsms.class));
}
public static String  _globals() throws Exception{
 BA.debugLineNum = 16;BA.debugLine="Sub Globals";
 BA.debugLineNum = 21;BA.debugLine="Dim cbMail, cbSMS As CheckBox";
mostCurrent._cbmail = new anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper();
mostCurrent._cbsms = new anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper();
 BA.debugLineNum = 22;BA.debugLine="Dim txtSMSText, txtMailTo As EditText";
mostCurrent._txtsmstext = new anywheresoftware.b4a.objects.EditTextWrapper();
mostCurrent._txtmailto = new anywheresoftware.b4a.objects.EditTextWrapper();
 BA.debugLineNum = 23;BA.debugLine="Dim btnSwitch As ToggleButton";
mostCurrent._btnswitch = new anywheresoftware.b4a.objects.CompoundButtonWrapper.ToggleButtonWrapper();
 BA.debugLineNum = 25;BA.debugLine="End Sub";
return "";
}
public static String  _process_globals() throws Exception{
 BA.debugLineNum = 2;BA.debugLine="Sub Process_Globals";
 BA.debugLineNum = 6;BA.debugLine="Dim strSMSText, strMailTo, strAppVersion As String";
_strsmstext = "";
_strmailto = "";
_strappversion = "";
 BA.debugLineNum = 7;BA.debugLine="strAppVersion = \"1.0\"";
_strappversion = "1.0";
 BA.debugLineNum = 9;BA.debugLine="Dim bSMS, bMail As Boolean";
_bsms = false;
_bmail = false;
 BA.debugLineNum = 11;BA.debugLine="Dim iAppSavepoint As Int";
_iappsavepoint = 0;
 BA.debugLineNum = 12;BA.debugLine="iAppSavepoint = 1";
_iappsavepoint = (int)(1);
 BA.debugLineNum = 14;BA.debugLine="End Sub";
return "";
}
public static String  _read_settings_from_db() throws Exception{
		Debug.PushSubsStack("Read_Settings_From_DB (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
anywheresoftware.b4a.sql.SQL.CursorWrapper _csql = null;
int _i = 0;
 BA.debugLineNum = 57;BA.debugLine="Sub Read_Settings_From_DB";
Debug.ShouldStop(16777216);
 BA.debugLineNum = 58;BA.debugLine="Dim cSQL As Cursor";
Debug.ShouldStop(33554432);
_csql = new anywheresoftware.b4a.sql.SQL.CursorWrapper();Debug.locals.put("cSQL", _csql);
 BA.debugLineNum = 59;BA.debugLine="cSql = cdSQl.oSQL.ExecQuery(\"Select Id, Name, Value from tblSettings order by Id\")";
Debug.ShouldStop(67108864);
_csql.setObject((android.database.Cursor)(mostCurrent._cdsql._osql.ExecQuery("Select Id, Name, Value from tblSettings order by Id")));
 BA.debugLineNum = 61;BA.debugLine="For i = 0 To cSQl.RowCount - 1";
Debug.ShouldStop(268435456);
{
final double step38 = 1;
final double limit38 = (int)(_csql.getRowCount()-1);
for (_i = (int)(0); (step38 > 0 && _i <= limit38) || (step38 < 0 && _i >= limit38); _i += step38) {
Debug.locals.put("i", _i);
 BA.debugLineNum = 62;BA.debugLine="cSQL.Position = i";
Debug.ShouldStop(536870912);
_csql.setPosition(_i);
 BA.debugLineNum = 63;BA.debugLine="Log(\"...cSQL: Position\" & i)";
Debug.ShouldStop(1073741824);
anywheresoftware.b4a.keywords.Common.Log("...cSQL: Position"+BA.NumberToString(_i));
 BA.debugLineNum = 65;BA.debugLine="Select Case cSql.GetInt(\"Id\")";
Debug.ShouldStop(1);
switch (BA.switchObjectToInt(_csql.GetInt("Id"),(int)(0),(int)(1),(int)(2),(int)(3))) {
case 0:
 BA.debugLineNum = 67;BA.debugLine="txtSmsText.Text = cSQL.GetString(\"Value\")";
Debug.ShouldStop(4);
mostCurrent._txtsmstext.setText((Object)(_csql.GetString("Value")));
 BA.debugLineNum = 68;BA.debugLine="strSMSText = txtSmsText.Text";
Debug.ShouldStop(8);
_strsmstext = mostCurrent._txtsmstext.getText();
 break;
case 1:
 BA.debugLineNum = 70;BA.debugLine="txtMailTo.Text = cSQL.GetString(\"Value\")";
Debug.ShouldStop(32);
mostCurrent._txtmailto.setText((Object)(_csql.GetString("Value")));
 BA.debugLineNum = 71;BA.debugLine="strMailTo = txtMailTo.Text";
Debug.ShouldStop(64);
_strmailto = mostCurrent._txtmailto.getText();
 break;
case 2:
 BA.debugLineNum = 73;BA.debugLine="If cSQL.GetString(\"Value\") = \"True\" Then";
Debug.ShouldStop(256);
if ((_csql.GetString("Value")).equals("True")) { 
 BA.debugLineNum = 74;BA.debugLine="cbSMS.Checked = True";
Debug.ShouldStop(512);
mostCurrent._cbsms.setChecked(anywheresoftware.b4a.keywords.Common.True);
 }else {
 BA.debugLineNum = 76;BA.debugLine="cbSMS.Checked = False";
Debug.ShouldStop(2048);
mostCurrent._cbsms.setChecked(anywheresoftware.b4a.keywords.Common.False);
 };
 break;
case 3:
 BA.debugLineNum = 79;BA.debugLine="If cSQL.GetString(\"Value\") = \"True\" Then";
Debug.ShouldStop(16384);
if ((_csql.GetString("Value")).equals("True")) { 
 BA.debugLineNum = 80;BA.debugLine="cbMail.Checked = True";
Debug.ShouldStop(32768);
mostCurrent._cbmail.setChecked(anywheresoftware.b4a.keywords.Common.True);
 }else {
 BA.debugLineNum = 82;BA.debugLine="cbMail.Checked = False";
Debug.ShouldStop(131072);
mostCurrent._cbmail.setChecked(anywheresoftware.b4a.keywords.Common.False);
 };
 break;
}
;
 }
}Debug.locals.put("i", _i);
;
 BA.debugLineNum = 87;BA.debugLine="End Sub";
Debug.ShouldStop(4194304);
return "";
}
catch (Exception e) {
			Debug.ErrorCaught(e);
			throw e;
		} 
finally {
			Debug.PopSubsStack();
		}}
public static String  _txtmailto_textchanged(String _old,String _new) throws Exception{
		Debug.PushSubsStack("txtMailTo_TextChanged (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("Old", _old);
Debug.locals.put("New", _new);
 BA.debugLineNum = 104;BA.debugLine="Sub txtMailTo_TextChanged (Old As String, New As String)";
Debug.ShouldStop(128);
 BA.debugLineNum = 105;BA.debugLine="If Old <> New AND New <> \"\" Then";
Debug.ShouldStop(256);
if ((_old).equals(_new) == false && (_new).equals("") == false) { 
 BA.debugLineNum = 106;BA.debugLine="strMailTo = New";
Debug.ShouldStop(512);
_strmailto = _new;
 };
 BA.debugLineNum = 109;BA.debugLine="Write_Settings_to_DB";
Debug.ShouldStop(4096);
_write_settings_to_db();
 BA.debugLineNum = 110;BA.debugLine="End Sub";
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
public static String  _txtsmstext_textchanged(String _old,String _new) throws Exception{
		Debug.PushSubsStack("txtSMSText_TextChanged (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("Old", _old);
Debug.locals.put("New", _new);
 BA.debugLineNum = 97;BA.debugLine="Sub txtSMSText_TextChanged (Old As String, New As String)";
Debug.ShouldStop(1);
 BA.debugLineNum = 98;BA.debugLine="If Old <> New AND New <> \"\" Then";
Debug.ShouldStop(2);
if ((_old).equals(_new) == false && (_new).equals("") == false) { 
 BA.debugLineNum = 99;BA.debugLine="strSMSText = New";
Debug.ShouldStop(4);
_strsmstext = _new;
 };
 BA.debugLineNum = 102;BA.debugLine="Write_Settings_to_DB";
Debug.ShouldStop(32);
_write_settings_to_db();
 BA.debugLineNum = 103;BA.debugLine="End Sub";
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
public static String  _write_settings_to_db() throws Exception{
		Debug.PushSubsStack("Write_Settings_To_DB (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
 BA.debugLineNum = 89;BA.debugLine="Sub Write_Settings_To_DB";
Debug.ShouldStop(16777216);
 BA.debugLineNum = 90;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & txtSmsText.Text & \"' where Id = 0\")";
Debug.ShouldStop(33554432);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+mostCurrent._txtsmstext.getText()+"' where Id = 0");
 BA.debugLineNum = 91;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & txtMailTo.Text & \"' where Id = 1\")";
Debug.ShouldStop(67108864);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+mostCurrent._txtmailto.getText()+"' where Id = 1");
 BA.debugLineNum = 92;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & cbSMS.Checked & \"' where Id = 2\")";
Debug.ShouldStop(134217728);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+String.valueOf(mostCurrent._cbsms.getChecked())+"' where Id = 2");
 BA.debugLineNum = 93;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & cbMail.Checked & \"' where Id = 3\")";
Debug.ShouldStop(268435456);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+String.valueOf(mostCurrent._cbmail.getChecked())+"' where Id = 3");
 BA.debugLineNum = 94;BA.debugLine="End Sub";
Debug.ShouldStop(536870912);
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
		return new Object[] {"Activity",_activity,"strSMSText",_strsmstext,"strMailTo",_strmailto,"strAppVersion",_strappversion,"bSMS",_bsms,"bMail",_bmail,"iAppSavepoint",_iappsavepoint,"cbMail",_cbmail,"cbSMS",_cbsms,"txtSMSText",_txtsmstext,"txtMailTo",_txtmailto,"btnSwitch",_btnswitch,"svSMS",Debug.moduleToString(StevoSoftware.at.HandyFinder.svsms.class),"cdSQL",Debug.moduleToString(StevoSoftware.at.HandyFinder.cdsql.class)};
}
}
