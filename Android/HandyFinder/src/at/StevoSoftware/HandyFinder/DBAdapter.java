package at.StevoSoftware.HandyFinder;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DBAdapter 
{

	//Deklarationen
	private static final String DATABASE_NAME = "data";
    private static final int DATABASE_VERSION = 1;

    private final Context oCtx;
    
    private DatabaseHelper oDbHelper;
    private SQLiteDatabase oDb;
	
    private static class DatabaseHelper extends SQLiteOpenHelper 
    {
    	
    	DatabaseHelper(Context context) 
    	{
	        super(context, DATABASE_NAME, null, DATABASE_VERSION);
	    }
	    
	    public void onCreate(SQLiteDatabase db)
	    //Create Database
	    {
	        db.execSQL(
	        		"CREATE TABLE settings (" +
	        		"name TEXT PRIMARY KEY NOT NULL, " +
	        		"value TEXT NULL);"
	        		);
	    }
	    
	    
	    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) 
	    //Update Database Version
	    {
	    	switch(oldVersion) {
	    	
	    	case 1:
	    	//DB-Version 1
	    		
	    	case 2:
	    	//DB-Version 2
		
	    	}	        
	    }
    }
    
    public DBAdapter(Context ctx) 
    {
        this.oCtx = ctx;
    }
    
    public DBAdapter open() throws SQLException
    //Open Database
    {
        oDbHelper = new DatabaseHelper(oCtx);
        oDb = oDbHelper.getWritableDatabase();
        return this;
    }
    
    public void close() 
    {
        oDbHelper.close();
    }
   
    public String GetSetting(String Name)
    {
    	Cursor oCursor = oDb.query("settings", new String[] {"value"}, "name = '" + Name + "'", null, null, null, null);
      	
    	if (oCursor != null) 
    	{
            oCursor.moveToFirst();
        }
    	
    	if (oCursor.getCount() > 0)
    	{
    		return oCursor.getString(oCursor.getColumnIndex("value"));
    	}
    	else
    	{
    		return "";	
    	}
    	
    }
    
    public long SetSetting(String Name, String Value)
    {
    	ContentValues oValues = new ContentValues();
    	oValues.put("name", Name);
  		oValues.put("value", Value);		
    	
    	Cursor oCursor = oDb.query("settings", new String[] {"value"}, "name = '" + Name + "'", null, null, null, null);
        
    	if (oCursor.getCount() != 0) {
            return oDb.update("settings", oValues, "name = '" + Name + "'", null);
        }
    	else
    	{
    		return oDb.insert("settings", null, oValues);
    	}	
    }

}
