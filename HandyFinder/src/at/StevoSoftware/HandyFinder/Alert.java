package at.StevoSoftware.HandyFinder;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.speech.tts.TextToSpeech.OnInitListener;

public class Alert extends Activity implements OnInitListener
{
	
	public static final String sMessage_EXTRA = "at.StevoSoftware.HandyFinder.sMessage";
	public static final String sButtonOK_EXTRA = "at.StevoSoftware.HandyFinder.sButtonOK";
	public static final String sButtonCancel_EXTRA = "at.StevoSoftware.HandyFinder.sButtonCancel";
	
	public static final int nShowDialog = 1;
		
	private String sMessage;
	private String sButtonOK;
	private String sButtonCancel;
	
	protected void onCreate(Bundle savedInstanceState) 
	{
        super.onCreate(savedInstanceState);
        
        sMessage = getIntent().getExtras().getString(sMessage_EXTRA);
        sButtonOK = getIntent().getExtras().getString(sButtonOK_EXTRA);
        sButtonCancel = getIntent().getExtras().getString(sButtonCancel_EXTRA);
        
        showDialog(nShowDialog);
	}

	public void onInit(int status) {
		// TODO Auto-generated method stub
		
	}
	
	@Override
    protected Dialog onCreateDialog(int id)
	{
		switch (id)
		{
			case nShowDialog:				
				return new AlertDialog.Builder(this)
				   .setMessage(sMessage)
				   .setPositiveButton(sButtonOK, new DialogInterface.OnClickListener() 
				   {
					   public void onClick(DialogInterface dialog, int whichButton) 
					   {
						   // Begin creating the reply with the SmsMessagingDemo activity
						   //Intent i = new Intent();
						   //i.setClass(SmsReceivedDialog.this, SmsMessagingDemo.class);
						   //i.putExtra(SmsMessagingDemo.SMS_RECIPIENT_EXTRA, mFromAddress);
						   //startActivity(i);
		
						   dialog.dismiss();
						   finish();
					   }
				   }) 
				   .setNegativeButton(sButtonCancel, new DialogInterface.OnClickListener() 
				   {
					   public void onClick(DialogInterface dialog, int whichButton) 
					   {
						   dialog.dismiss();
						   finish();
					   }
				   })
		           .create();
			
		}
		return null;
	}
}
