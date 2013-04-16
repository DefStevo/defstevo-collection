package at.StevoSoftware.HandyFinder;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.telephony.gsm.SmsMessage;

@SuppressWarnings("deprecation")
public class SMSReceiver extends BroadcastReceiver {
	
	public void onReceive(Context context, Intent intent) {
        Bundle bundle = intent.getExtras();

        Object messages[] = (Object[]) bundle.get("pdus");
        SmsMessage smsMessage[] = new SmsMessage[messages.length];
        for (int n = 0; n < messages.length; n++) {
            smsMessage[n] = SmsMessage.createFromPdu((byte[]) messages[n]);
        }
        
        Intent oIntent = new Intent();
        oIntent.setClass(context, HandyFinder.class);
        oIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        oIntent.putExtra(HandyFinder.sMessage_EXTRA, smsMessage[0].getMessageBody().toString());
        oIntent.putExtra(HandyFinder.sNumber_EXTRA, smsMessage[0].getOriginatingAddress().toString());
        context.startActivity(oIntent);        
    }
    
}
