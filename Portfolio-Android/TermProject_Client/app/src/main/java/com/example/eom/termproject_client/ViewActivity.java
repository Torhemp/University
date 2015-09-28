package com.example.eom.termproject_client;

import android.content.Intent;
import android.os.Handler;
import android.os.Message;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;


public class ViewActivity extends ActionBarActivity {
    private List<PicInfo> picInfoItems;
    private PicInfoAdapter picInfoAdapter;
    private ListView list;
    public Handler hosthandle = new Handler(){
        public void handleMessage(Message msg){
            super.handleMessage(msg);
            if(msg.what == 0){
                switch(msg.arg2) {
                    case 0:
                        if(msg.arg1==2) {
                            String[] dbArg = msg.obj.toString().split("=");
                            if(dbArg!=null){
                                for(int i=0;i<dbArg.length;i++){
                                    String[] info = dbArg[i].split(":");
                                    if(!info[0].equals("")) {
                                        picInfoItems.add(new PicInfo(info[0], info[1], info[2]));
                                    }
                                }
                                picInfoAdapter.notifyDataSetChanged();
                            }
                            else {
                            }
                        }
                        else {
                        }
                        break;
                    default:
                        break;
                }
            }
            else{
                System.out.println("HTTP 통신 오류!");
            }
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view);

        list = (ListView) findViewById(R.id.myList);
        picInfoItems = new ArrayList<PicInfo>();
        picInfoAdapter = new PicInfoAdapter(ViewActivity.this, R.layout.list, picInfoItems);
        list.setAdapter(picInfoAdapter);

        ServerPostComm postClient;
        String url = "http://192.168.43.31:3000/recvPicInfo";
        String id = "null";
        String values = "null";
        postClient = new ServerPostComm(url, 2, id, values, hosthandle);
        postClient.start();
        list.setOnItemClickListener(new AdapterView.OnItemClickListener(){
            public void onItemClick(AdapterView<?> parent, View view, int position, long id){
                ListView listView = (ListView)parent;
                PicInfo picInfo = (PicInfo)listView.getItemAtPosition(position);

                Intent intent = new Intent(getApplicationContext(), ViewActivity2.class);
                intent.putExtra("photographer", picInfo.getPhotographer());
                intent.putExtra("copystring", picInfo.getCopystring());
                intent.putExtra("date", picInfo.getDate());
                startActivity(intent);
            }
        });
    }

    public void btnBMClick(View v){
        switch(v.getId()){
            case R.id.bookmarkButton:
                Intent intentBM = new Intent(getApplicationContext(), BookmarkActivity.class);
                startActivity(intentBM);
                break;
            default:
                break;
        }
    }
}
