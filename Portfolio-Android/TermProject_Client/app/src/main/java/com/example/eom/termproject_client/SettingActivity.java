package com.example.eom.termproject_client;

import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;


public class SettingActivity extends ActionBarActivity {

    Button btnCheck, btnCancel;
    EditText editPhotographer;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_setting);
        btnCheck = (Button)findViewById(R.id.buttonCheck);
        btnCancel = (Button)findViewById(R.id.buttonCancel);
        editPhotographer = (EditText)findViewById(R.id.editText);
    }

    public void btnSClick(View v){
        Intent outIntent = new Intent(getApplicationContext(), MainActivity.class);
        switch(v.getId()){
            case R.id.buttonCheck:
                outIntent.putExtra("text", editPhotographer.getText().toString());
                setResult(RESULT_OK, outIntent);
                finish();
                break;
            case R.id.buttonCancel:
                setResult(RESULT_CANCELED, outIntent);
                finish();
                break;
            default:
                break;
        }
    }
}
