package StevoSoftware.at.SMS;

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
			processBA = new BA(this.getApplicationContext(), null, null, "StevoSoftware.at.SMS", "main");
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
		activityBA = new BA(this, layout, processBA, "StevoSoftware.at.SMS", "main");
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
public static String _strsms = "";
public static String _strappversion = "";
public static int _iappsavepoint = 0;
public anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper _cbmail = null;
public anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper _cbsms = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtsmstext = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtsmsto = null;
public anywheresoftware.b4a.objects.EditTextWrapper _txtmailto = null;
public anywheresoftware.b4a.objects.CompoundButtonWrapper.ToggleButtonWrapper _btnswitch = null;
public svsms _svsms = null;
public cdsql _cdsql = null;
public static String  _activity_create(boolean _firsttime) throws Exception{
		Debug.PushSubsStack("Activity_Create (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("FirstTime", _firsttime);
 BA.debugLineNum = 24;BA.debugLine="Sub Activity_Create(FirstTime As Boolean)";
Debug.ShouldStop(8388608);
 BA.debugLineNum = 25;BA.debugLine="Log(\"Activity Start\")";
Debug.ShouldStop(16777216);
anywheresoftware.b4a.keywords.Common.Log("Activity Start");
 BA.debugLineNum = 27;BA.debugLine="Activity.LoadLayout(\"loMain\")";
Debug.ShouldStop(67108864);
mostCurrent._activity.LoadLayout("loMain",mostCurrent.activityBA);
 BA.debugLineNum = 29;BA.debugLine="End Sub";
Debug.ShouldStop(268435456);
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
 BA.debugLineNum = 40;BA.debugLine="Sub Activity_Pause (UserClosed As Boolean)";
Debug.ShouldStop(128);
 BA.debugLineNum = 41;BA.debugLine="Log(\"Write Settings\")";
Debug.ShouldStop(256);
anywheresoftware.b4a.keywords.Common.Log("Write Settings");
 BA.debugLineNum = 42;BA.debugLine="Write_Settings_To_DB";
Debug.ShouldStop(512);
_write_settings_to_db();
 BA.debugLineNum = 43;BA.debugLine="End Sub";
Debug.ShouldStop(1024);
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
 BA.debugLineNum = 31;BA.debugLine="Sub Activity_Resume";
Debug.ShouldStop(1073741824);
 BA.debugLineNum = 32;BA.debugLine="Log(\"Initialize DB\")";
Debug.ShouldStop(-2147483648);
anywheresoftware.b4a.keywords.Common.Log("Initialize DB");
 BA.debugLineNum = 33;BA.debugLine="cdSQL.Init_DB";
Debug.ShouldStop(1);
mostCurrent._cdsql._init_db(mostCurrent.activityBA);
 BA.debugLineNum = 35;BA.debugLine="Log(\"Read Settings\")";
Debug.ShouldStop(4);
anywheresoftware.b4a.keywords.Common.Log("Read Settings");
 BA.debugLineNum = 36;BA.debugLine="Read_Settings_From_DB";
Debug.ShouldStop(8);
_read_settings_from_db();
 BA.debugLineNum = 37;BA.debugLine="Write_Settings_To_DB";
Debug.ShouldStop(16);
_write_settings_to_db();
 BA.debugLineNum = 38;BA.debugLine="End Sub";
Debug.ShouldStop(32);
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
 BA.debugLineNum = 45;BA.debugLine="Sub btnSwitch_Click";
Debug.ShouldStop(4096);
 BA.debugLineNum = 46;BA.debugLine="Log(\"Switch\")";
Debug.ShouldStop(8192);
anywheresoftware.b4a.keywords.Common.Log("Switch");
 BA.debugLineNum = 47;BA.debugLine="If btnSwitch.Checked = False Then";
Debug.ShouldStop(16384);
if (mostCurrent._btnswitch.getChecked()==anywheresoftware.b4a.keywords.Common.False) { 
 BA.debugLineNum = 48;BA.debugLine="StopService(svSMS)";
Debug.ShouldStop(32768);
anywheresoftware.b4a.keywords.Common.StopService(mostCurrent.activityBA,(Object)(mostCurrent._svsms.getObject()));
 }else {
 BA.debugLineNum = 50;BA.debugLine="StartService(svSMS)";
Debug.ShouldStop(131072);
anywheresoftware.b4a.keywords.Common.StartService(mostCurrent.activityBA,(Object)(mostCurrent._svsms.getObject()));
 };
 BA.debugLineNum = 52;BA.debugLine="End Sub";
Debug.ShouldStop(524288);
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
Debug.StartDebugging(mostCurrent.activityBA, 9256, new int[] {3, 1, 3} );}

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
 BA.debugLineNum = 13;BA.debugLine="Sub Globals";
 BA.debugLineNum = 18;BA.debugLine="Dim cbMail, cbSMS As CheckBox";
mostCurrent._cbmail = new anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper();
mostCurrent._cbsms = new anywheresoftware.b4a.objects.CompoundButtonWrapper.CheckBoxWrapper();
 BA.debugLineNum = 19;BA.debugLine="Dim txtSMSText, txtSMSTo, txtMailTo As EditText";
mostCurrent._txtsmstext = new anywheresoftware.b4a.objects.EditTextWrapper();
mostCurrent._txtsmsto = new anywheresoftware.b4a.objects.EditTextWrapper();
mostCurrent._txtmailto = new anywheresoftware.b4a.objects.EditTextWrapper();
 BA.debugLineNum = 20;BA.debugLine="Dim btnSwitch As ToggleButton";
mostCurrent._btnswitch = new anywheresoftware.b4a.objects.CompoundButtonWrapper.ToggleButtonWrapper();
 BA.debugLineNum = 22;BA.debugLine="End Sub";
return "";
}
public static String  _process_globals() throws Exception{
 BA.debugLineNum = 2;BA.debugLine="Sub Process_Globals";
 BA.debugLineNum = 5;BA.debugLine="Dim strSMS, strAppVersion As String";
_strsms = "";
_strappversion = "";
 BA.debugLineNum = 6;BA.debugLine="strAppVersion = \"1.0\"";
_strappversion = "1.0";
 BA.debugLineNum = 8;BA.debugLine="Dim iAppSavepoint As Int";
_iappsavepoint = 0;
 BA.debugLineNum = 9;BA.debugLine="iAppSavepoint = 1";
_iappsavepoint = (int)(1);
 BA.debugLineNum = 11;BA.debugLine="End Sub";
return "";
}
public static String  _read_settings_from_db() throws Exception{
		Debug.PushSubsStack("Read_Settings_From_DB (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
anywheresoftware.b4a.sql.SQL.CursorWrapper _csql = null;
int _i = 0;
 BA.debugLineNum = 54;BA.debugLine="Sub Read_Settings_From_DB";
Debug.ShouldStop(2097152);
 BA.debugLineNum = 55;BA.debugLine="Dim cSQL As Cursor";
Debug.ShouldStop(4194304);
_csql = new anywheresoftware.b4a.sql.SQL.CursorWrapper();Debug.locals.put("cSQL", _csql);
 BA.debugLineNum = 56;BA.debugLine="cSql = cdSQl.oSQL.ExecQuery(\"Select Id, Name, Value from tblSettings order by Id\")";
Debug.ShouldStop(8388608);
_csql.setObject((android.database.Cursor)(mostCurrent._cdsql._osql.ExecQuery("Select Id, Name, Value from tblSettings order by Id")));
 BA.debugLineNum = 58;BA.debugLine="For i = 0 To cSQl.RowCount - 1";
Debug.ShouldStop(33554432);
{
final double step37 = 1;
final double limit37 = (int)(_csql.getRowCount()-1);
for (_i = (int)(0); (step37 > 0 && _i <= limit37) || (step37 < 0 && _i >= limit37); _i += step37) {
Debug.locals.put("i", _i);
 BA.debugLineNum = 59;BA.debugLine="cSQL.Position = i";
Debug.ShouldStop(67108864);
_csql.setPosition(_i);
 BA.debugLineNum = 60;BA.debugLine="Log(\"...cSQL: Position\" & i)";
Debug.ShouldStop(134217728);
anywheresoftware.b4a.keywords.Common.Log("...cSQL: Position"+BA.NumberToString(_i));
 BA.debugLineNum = 62;BA.debugLine="Select Case cSql.GetInt(\"Id\")";
Debug.ShouldStop(536870912);
switch (BA.switchObjectToInt(_csql.GetInt("Id"),(int)(0),(int)(1),(int)(2),(int)(3),(int)(4))) {
case 0:
 BA.debugLineNum = 64;BA.debugLine="txtSmsText.Text = cSQL.GetString(\"Value\")";
Debug.ShouldStop(-2147483648);
mostCurrent._txtsmstext.setText((Object)(_csql.GetString("Value")));
 break;
case 1:
 BA.debugLineNum = 66;BA.debugLine="txtSmsTo.Text = cSQL.GetString(\"Value\")";
Debug.ShouldStop(2);
mostCurrent._txtsmsto.setText((Object)(_csql.GetString("Value")));
 break;
case 2:
 BA.debugLineNum = 68;BA.debugLine="txtMailTo.Text = cSQL.GetString(\"Value\")";
Debug.ShouldStop(8);
mostCurrent._txtmailto.setText((Object)(_csql.GetString("Value")));
 break;
case 3:
 BA.debugLineNum = 70;BA.debugLine="If cSQL.GetString(\"Value\") = \"True\" Then";
Debug.ShouldStop(32);
if ((_csql.GetString("Value")).equals("True")) { 
 BA.debugLineNum = 71;BA.debugLine="cbSMS.Checked = True";
Debug.ShouldStop(64);
mostCurrent._cbsms.setChecked(anywheresoftware.b4a.keywords.Common.True);
 }else {
 BA.debugLineNum = 73;BA.debugLine="cbSMS.Checked = False";
Debug.ShouldStop(256);
mostCurrent._cbsms.setChecked(anywheresoftware.b4a.keywords.Common.False);
 };
 break;
case 4:
 BA.debugLineNum = 76;BA.debugLine="If cSQL.GetString(\"Value\") = \"True\" Then";
Debug.ShouldStop(2048);
if ((_csql.GetString("Value")).equals("True")) { 
 BA.debugLineNum = 77;BA.debugLine="cbMail.Checked = True";
Debug.ShouldStop(4096);
mostCurrent._cbmail.setChecked(anywheresoftware.b4a.keywords.Common.True);
 }else {
 BA.debugLineNum = 79;BA.debugLine="cbMail.Checked = False";
Debug.ShouldStop(16384);
mostCurrent._cbmail.setChecked(anywheresoftware.b4a.keywords.Common.False);
 };
 break;
}
;
 }
}Debug.locals.put("i", _i);
;
 BA.debugLineNum = 84;BA.debugLine="End Sub";
Debug.ShouldStop(524288);
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
 BA.debugLineNum = 86;BA.debugLine="Sub Write_Settings_To_DB";
Debug.ShouldStop(2097152);
 BA.debugLineNum = 87;BA.debugLine="cdSQl.Execute_Non_Query(\"xUpdate tblSettings set Value = '\" & txtSmsText.Text & \"' where Id = 0\")";
Debug.ShouldStop(4194304);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"xUpdate tblSettings set Value = '"+mostCurrent._txtsmstext.getText()+"' where Id = 0");
 BA.debugLineNum = 88;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & txtSmsTo.Text & \"' where Id = 1\")";
Debug.ShouldStop(8388608);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+mostCurrent._txtsmsto.getText()+"' where Id = 1");
 BA.debugLineNum = 89;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & txtMailTo.Text & \"' where Id = 2\")";
Debug.ShouldStop(16777216);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+mostCurrent._txtmailto.getText()+"' where Id = 2");
 BA.debugLineNum = 90;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & cbSMS.Checked & \"' where Id = 3\")";
Debug.ShouldStop(33554432);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+String.valueOf(mostCurrent._cbsms.getChecked())+"' where Id = 3");
 BA.debugLineNum = 91;BA.debugLine="cdSQl.Execute_Non_Query(\"Update tblSettings set Value = '\" & cbMail.Checked & \"' where Id = 4\")";
Debug.ShouldStop(67108864);
mostCurrent._cdsql._execute_non_query(mostCurrent.activityBA,"Update tblSettings set Value = '"+String.valueOf(mostCurrent._cbmail.getChecked())+"' where Id = 4");
 BA.debugLineNum = 92;BA.debugLine="End Sub";
Debug.ShouldStop(134217728);
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
		return new Object[] {"Activity",_activity,"strSMS",_strsms,"strAppVersion",_strappversion,"iAppSavepoint",_iappsavepoint,"cbMail",_cbmail,"cbSMS",_cbsms,"txtSMSText",_txtsmstext,"txtSMSTo",_txtsmsto,"txtMailTo",_txtmailto,"btnSwitch",_btnswitch,"svSMS",Debug.moduleToString(StevoSoftware.at.SMS.svsms.class),"cdSQL",Debug.moduleToString(StevoSoftware.at.SMS.cdsql.class)};
}
}
