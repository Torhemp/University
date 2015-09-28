package com.example.eom.termproject_client;

import android.content.Intent;
import android.database.Cursor;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class BookmarkActivity extends ActionBarActivity {
    private List<PicInfo> picInfoItems;
    private PicInfoAdapter picInfoAdapter;
    private ListView list;
    private DbOpenHelper mDbOpenHelper;
    private Cursor mCursor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bookmark);

        list = (ListView) findViewById(R.id.bookmarkList);
        picInfoItems = new ArrayList<PicInfo>();

        mDbOpenHelper = new DbOpenHelper(this);
        mDbOpenHelper.open();
        mCursor = mDbOpenHelper.getList();
        if(mCursor.getCount()>0) {
            do {
                picInfoItems.add(new PicInfo(mCursor.getString(0), mCursor.getString(1),
                        mCursor.getString(2)));
            } while (mCursor.moveToNext());
        }
        mDbOpenHelper.close();
        picInfoAdapter = new PicInfoAdapter(BookmarkActivity.this, R.layout.list, picInfoItems);
        list.setAdapter(picInfoAdapter);

        list.setOnItemClickListener(new AdapterView.OnItemClickListener(){
            public void onItemClick(AdapterView<?> parent, View view, int position, long id){
                ListView listView = (ListView)parent;
                PicInfo picInfo = (PicInfo)listView.getItemAtPosition(position);

                Intent intent = new Intent(getApplicationContext(), ViewActivity3.class);
                intent.putExtra("photographer", picInfo.getPhotographer());
                intent.putExtra("copystring", picInfo.getCopystring());
                intent.putExtra("date", picInfo.getDate());
                startActivity(intent);
            }
        });
    }
}
