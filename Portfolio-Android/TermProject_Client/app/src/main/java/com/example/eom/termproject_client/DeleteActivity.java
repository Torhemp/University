package com.example.eom.termproject_client;

import android.content.Intent;
import android.os.Handler;
import android.os.Message;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class DeleteActivity extends ActionBarActivity {
    private List<PicInfo> picInfoItems;
    private PicInfoAdapter picInfoAdapter;
    private ListView list;
    String url, id, values;
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
                        else if(msg.arg1==4){
                            String result = msg.obj.toString();
                            if(result!=null){
                                Toast.makeText(DeleteActivity.this, result, Toast.LENGTH_SHORT).show();
                            }
                            else{
                                Toast.makeText(DeleteActivity.this, "에러 발생", Toast.LENGTH_SHORT).show();
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
        setContentView(R.layout.activity_delete);

        list = (ListView) findViewById(R.id.deleteList);
        picInfoItems = new ArrayList<PicInfo>();
        picInfoAdapter = new PicInfoAdapter(DeleteActivity.this, R.layout.list, picInfoItems);
        list.setAdapter(picInfoAdapter);

        ServerPostComm postClient;
        url = "http://192.168.43.31:3000/recvPicInfo";
        id = "null";
        values = "null";
        postClient = new ServerPostComm(url, 2, id, values, hosthandle);
        postClient.start();
        list.setOnItemClickListener(new AdapterView.OnItemClickListener(){
            public void onItemClick(AdapterView<?> parent, View view, int position, long vid){
                ServerPostComm deleteClient;
                ListView listView = (ListView)parent;
                PicInfo picInfo = (PicInfo)listView.getItemAtPosition(position);

                id = picInfo.getPhotographer();
                values = picInfo.getCopystring() + ":" + picInfo.getDate();

                deleteClient = new ServerPostComm(url, 4, id, values, hosthandle);
                deleteClient.start();
            }
        });
    }

}
