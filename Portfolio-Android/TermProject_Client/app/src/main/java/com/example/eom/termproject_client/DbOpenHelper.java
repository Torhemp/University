package com.example.eom.termproject_client;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Eom on 2015-06-14.
 */
public class DbOpenHelper {
    private static final String DATABASE_NAME = "bookmarkPic.db";
    private static final String TABLE_NAME = "bookmark";
    public static final String CREATE_TABLE =
            "create table bookmark ("
                    + "photographer text primary key, "
                    + "picture blob not null, "
                    + "copystring text not null, "
                    + "lat text not null, "
                    + "lon text not null, "
                    + "address text not null, "
                    + "date text not null );";
    private static final int DATABASE_VERSION = 1;
    public static SQLiteDatabase mDB;
    private DatabaseHelper mDBHelper;
    private Context mCtx;

    private class DatabaseHelper extends SQLiteOpenHelper {
        // 생성자
        public DatabaseHelper(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
            super(context, name, factory, version);
        }
        // 최초 DB를 만들때 한번만 호출
        @Override
        public void onCreate(SQLiteDatabase db) {
            db.execSQL(CREATE_TABLE);
        }

        // 버전이 업데이트 되었을 경우 DB를 다시 생성
        @Override
        public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
            db.execSQL("DROP TABLE IF EXISTS " + TABLE_NAME);
            onCreate(db);
        }
    }

    public DbOpenHelper(Context context){
        this.mCtx = context;
    }

    public DbOpenHelper open() throws SQLException {
        mDBHelper = new DatabaseHelper(mCtx, DATABASE_NAME, null,
                DATABASE_VERSION);
        mDB = mDBHelper.getWritableDatabase();
        return this;
    }

    public void close(){
        mDB.close();
    }

    // Insert DB
    public long insert(String photographer, byte[] picture, String copystring,
                       String lat, String lon, String address, String date) {
        ContentValues values = new ContentValues();
        values.put("photographer", photographer);
        values.put("picture", picture);
        values.put("copystring", copystring);
        values.put("lat", lat);
        values.put("lon", lon);
        values.put("address", address);
        values.put("date", date);
        return mDB.insert(TABLE_NAME, null, values);
    }

    // Update DB
    public boolean update(long id , String name, String contact, String email) {
        ContentValues values = new ContentValues();
        values.put("name", name);
        values.put("contact", contact);
        values.put("email", email);
        return mDB.update(TABLE_NAME, values, "_id=" + id, null) > 0;
    }

    // Delete
    public boolean delete(String photographer, String copystring, String date){
        return mDB.delete(TABLE_NAME, "photographer like '" + photographer +
        "' and copystring like '" + copystring + "' and date like '" + date + "'", null) > 0;
    }

    // Select All
    public Cursor getAll(){
        return mDB.query(TABLE_NAME, null, null, null, null, null, null);
    }

    public Cursor getList(){
        Cursor c = mDB.rawQuery("select photographer, copystring, date from bookmark", null);
        if (c != null && c.getCount() != 0)
            c.moveToFirst();
        return c;
    }

    // 사진 정보 찾기
    public Cursor getRecord(String photographer, String copystring, String date){
        Cursor c = mDB.rawQuery("select * from bookmark where photographer = '" + photographer +
        "' and copystring = '" + copystring + "' and date = '" + date + "'", null);
        if (c != null && c.getCount() != 0)
            c.moveToFirst();
        return c;
    }

    // 이름 검색 하기 (rawQuery)
    public Cursor getMatchName(String name){
        Cursor c = mDB.rawQuery( "select * from address where name=" + "'" +
                name + "'" , null);
        return c;
    }
}
