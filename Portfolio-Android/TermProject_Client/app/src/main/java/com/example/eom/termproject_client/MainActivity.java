package com.example.eom.termproject_client;

import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends ActionBarActivity {
    Button btnPCapture, btnPViewer, btnPDelete, btnSetting;
    String photographer;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnPCapture = (Button)findViewById(R.id.bPCapture);
        btnPViewer = (Button)findViewById(R.id.bPViewer);
        btnPDelete = (Button)findViewById(R.id.bPDelete);
        btnSetting = (Button)findViewById(R.id.bSetting);
    }

    public void btnPClick(View v){
        switch(v.getId()) {
            case R.id.bPCapture:
                Intent intentP = new Intent(getApplicationContext(), CaptureActivity.class);
                intentP.putExtra("photographer", photographer);
                startActivity(intentP);
                break;
            case R.id.bPViewer:
                Intent intentV = new Intent(getApplicationContext(), ViewActivity.class);
                startActivity(intentV);
                break;
            case R.id.bPDelete:
                Intent intentD = new Intent(getApplicationContext(), DeleteActivity.class);
                startActivity(intentD);
                break;
            case R.id.bSetting:
                Intent intentS = new Intent(getApplicationContext(), SettingActivity.class);
                startActivityForResult(intentS, 0);
                break;
            default:
                break;
        }
    }

    protected void onActivityResult(int reqCode, int resultCode, Intent data){
        if(resultCode == RESULT_OK){
            photographer = data.getStringExtra("text");
        }
        else if(resultCode == RESULT_CANCELED){

        }
    }
}
