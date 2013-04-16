package StevoSoftware.at.MySecond;

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
			processBA = new BA(this.getApplicationContext(), null, null, "StevoSoftware.at.MySecond", "main");
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
		activityBA = new BA(this, layout, processBA, "StevoSoftware.at.MySecond", "main");
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
public static int _nrndnumber = 0;
public anywheresoftware.b4a.objects.EditTextWrapper _nnumber = null;
public anywheresoftware.b4a.objects.LabelWrapper _lbtext2 = null;
public static String  _activity_create(boolean _firsttime) throws Exception{
		Debug.PushSubsStack("Activity_Create (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("FirstTime", _firsttime);
 BA.debugLineNum = 16;BA.debugLine="Sub Activity_Create(FirstTime As Boolean)";
Debug.ShouldStop(32768);
 BA.debugLineNum = 17;BA.debugLine="If FirstTime Then";
Debug.ShouldStop(65536);
if (_firsttime) { 
 BA.debugLineNum = 18;BA.debugLine="Log(\"START\")";
Debug.ShouldStop(131072);
anywheresoftware.b4a.keywords.Common.Log("START");
 }else {
 BA.debugLineNum = 20;BA.debugLine="Log(\"Restart\")";
Debug.ShouldStop(524288);
anywheresoftware.b4a.keywords.Common.Log("Restart");
 };
 BA.debugLineNum = 22;BA.debugLine="Activity.LoadLayout(\"loMain\")";
Debug.ShouldStop(2097152);
mostCurrent._activity.LoadLayout("loMain",mostCurrent.activityBA);
 BA.debugLineNum = 23;BA.debugLine="nRndNumber = Rnd(1,100)";
Debug.ShouldStop(4194304);
_nrndnumber = anywheresoftware.b4a.keywords.Common.Rnd((int)(1),(int)(100));
 BA.debugLineNum = 24;BA.debugLine="Log(\"RndNumber: \" & nRndNumber)";
Debug.ShouldStop(8388608);
anywheresoftware.b4a.keywords.Common.Log("RndNumber: "+BA.NumberToString(_nrndnumber));
 BA.debugLineNum = 26;BA.debugLine="End Sub";
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
public static String  _activity_pause(boolean _userclosed) throws Exception{
		Debug.PushSubsStack("Activity_Pause (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
Debug.locals.put("UserClosed", _userclosed);
 BA.debugLineNum = 32;BA.debugLine="Sub Activity_Pause (UserClosed As Boolean)";
Debug.ShouldStop(-2147483648);
 BA.debugLineNum = 34;BA.debugLine="End Sub";
Debug.ShouldStop(2);
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
 BA.debugLineNum = 28;BA.debugLine="Sub Activity_Resume";
Debug.ShouldStop(134217728);
 BA.debugLineNum = 30;BA.debugLine="End Sub";
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
public static String  _btgo_click() throws Exception{
		Debug.PushSubsStack("btGo_Click (main) ","main",0,mostCurrent.activityBA,mostCurrent);
try {
 BA.debugLineNum = 36;BA.debugLine="Sub btGo_Click";
Debug.ShouldStop(8);
 BA.debugLineNum = 37;BA.debugLine="Log(\"Number: \" & nNumber.text)";
Debug.ShouldStop(16);
anywheresoftware.b4a.keywords.Common.Log("Number: "+mostCurrent._nnumber.getText());
 BA.debugLineNum = 39;BA.debugLine="If nNumber.Text > nRndNumber Then";
Debug.ShouldStop(64);
if ((double)(Double.parseDouble(mostCurrent._nnumber.getText()))>_nrndnumber) { 
 BA.debugLineNum = 40;BA.debugLine="ToastMessageShow(\"My number is smaller.\", False)";
Debug.ShouldStop(128);
anywheresoftware.b4a.keywords.Common.ToastMessageShow("My number is smaller.",anywheresoftware.b4a.keywords.Common.False);
 BA.debugLineNum = 41;BA.debugLine="Log(\"Toast Text: Smaller\")";
Debug.ShouldStop(256);
anywheresoftware.b4a.keywords.Common.Log("Toast Text: Smaller");
 BA.debugLineNum = 42;BA.debugLine="nNumber.SelectAll";
Debug.ShouldStop(512);
mostCurrent._nnumber.SelectAll();
 }else 
{ BA.debugLineNum = 44;BA.debugLine="Else If nNumber.Text < nRndNumber Then";
Debug.ShouldStop(2048);
if ((double)(Double.parseDouble(mostCurrent._nnumber.getText()))<_nrndnumber) { 
 BA.debugLineNum = 45;BA.debugLine="ToastMessageShow(\"My number is larger.\", False)";
Debug.ShouldStop(4096);
anywheresoftware.b4a.keywords.Common.ToastMessageShow("My number is larger.",anywheresoftware.b4a.keywords.Common.False);
 BA.debugLineNum = 46;BA.debugLine="Log(\"Toast Text: Greater\")";
Debug.ShouldStop(8192);
anywheresoftware.b4a.keywords.Common.Log("Toast Text: Greater");
 BA.debugLineNum = 47;BA.debugLine="nNumber.SelectAll";
Debug.ShouldStop(16384);
mostCurrent._nnumber.SelectAll();
 }else {
 BA.debugLineNum = 50;BA.debugLine="Log(\"Load Label loWell.bal\")";
Debug.ShouldStop(131072);
anywheresoftware.b4a.keywords.Common.Log("Load Label loWell.bal");
 BA.debugLineNum = 51;BA.debugLine="Activity.LoadLayout(\"loWell\")";
Debug.ShouldStop(262144);
mostCurrent._activity.LoadLayout("loWell",mostCurrent.activityBA);
 BA.debugLineNum = 52;BA.debugLine="Log(\"Write Text: Well Done\")";
Debug.ShouldStop(524288);
anywheresoftware.b4a.keywords.Common.Log("Write Text: Well Done");
 BA.debugLineNum = 53;BA.debugLine="lbText2.Text = \"Well Done\"";
Debug.ShouldStop(1048576);
mostCurrent._lbtext2.setText((Object)("Well Done"));
 }};
 BA.debugLineNum = 57;BA.debugLine="End Sub";
Debug.ShouldStop(16777216);
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
Debug.StartDebugging(mostCurrent.activityBA, 42807, new int[] {2} );}

		        main._process_globals();
		
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

}
public static String  _globals() throws Exception{
 BA.debugLineNum = 8;BA.debugLine="Sub Globals";
 BA.debugLineNum = 11;BA.debugLine="Dim nRndNumber As Int";
_nrndnumber = 0;
 BA.debugLineNum = 12;BA.debugLine="Dim nNumber As EditText";
mostCurrent._nnumber = new anywheresoftware.b4a.objects.EditTextWrapper();
 BA.debugLineNum = 13;BA.debugLine="Dim lbText2 As Label";
mostCurrent._lbtext2 = new anywheresoftware.b4a.objects.LabelWrapper();
 BA.debugLineNum = 14;BA.debugLine="End Sub";
return "";
}
public static String  _process_globals() throws Exception{
 BA.debugLineNum = 2;BA.debugLine="Sub Process_Globals";
 BA.debugLineNum = 6;BA.debugLine="End Sub";
return "";
}
  public Object[] GetGlobals() {
		return new Object[] {"Activity",_activity,"nRndNumber",_nrndnumber,"nNumber",_nnumber,"lbText2",_lbtext2};
}
}
