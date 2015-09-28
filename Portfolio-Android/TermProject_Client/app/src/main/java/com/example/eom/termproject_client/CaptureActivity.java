package com.example.eom.termproject_client;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.Matrix;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Handler;
import android.os.Message;
import android.provider.MediaStore;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.util.Base64;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class CaptureActivity extends ActionBarActivity {
    private final int PICK_FROM_CAMERA = 1;
    private int oWidth, oHeight;
    Button bCapture, bSend;
    ImageView picView;
    TextView copyString;
    String year, month, date, time;
    GpsInfo gpsInfo;
    long now;
    Date dateNow;
    public Handler hosthandle = new Handler(){
        public void handleMessage(Message msg){
            super.handleMessage(msg);
            if(msg.what == 0){
                switch(msg.arg2) {
                    case 0:
                        if(msg.arg1==1) {
                            String dbArg = msg.obj.toString();
                            Toast.makeText(CaptureActivity.this, dbArg, Toast.LENGTH_SHORT).show();
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
        setContentView(R.layout.activity_capture);

        bCapture = (Button)findViewById(R.id.buttonCapture);
        bSend = (Button)findViewById(R.id.buttonSend);
        picView = (ImageView)findViewById(R.id.pictureView);
        copyString = (TextView)findViewById(R.id.textView);
    }

    public void btnClick(View v) {
        switch(v.getId()){
            case R.id.buttonCapture:
                Intent camIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
                startActivityForResult(camIntent, PICK_FROM_CAMERA);
                break;
            case R.id.buttonSend:
                if(picView != null){
                    //비트맵 -> 바이트 배열 -> 문자열 변환
                    Bitmap imageBitmap = ((BitmapDrawable)picView.getDrawable()).getBitmap();
                    ByteArrayOutputStream stream = new ByteArrayOutputStream();
                    imageBitmap.compress(Bitmap.CompressFormat.JPEG, 100, stream);
                    byte[] imageByteArray = stream.toByteArray();

                    //현재 시간을 저장함
                    now = System.currentTimeMillis();
                    dateNow = new Date(now);
                    //date -> string 변환
                    SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy년 MM월 dd일 HH시 mm분", java.util.Locale.getDefault());
                    Double lat = gpsInfo.getLat();
                    Double lon = gpsInfo.getLon();

                    //서버로 전송
                    ServerPostComm postClient;
                    String url = "http://192.168.43.31:3000/recvPicInfo";
                    String id = getIntent().getStringExtra("photographer");
                    String values = Base64.encodeToString(imageByteArray, Base64.DEFAULT) + ":" +
                            copyString.getText().toString() + ":" +
                            Double.toString(lat) + ":" +
                            Double.toString(lon) + ":" +
                            gpsInfo.findAddress(lat, lon) + ":" +
                            dateFormat.format(dateNow);
                    postClient = new ServerPostComm(url, 1, id, values, hosthandle);
                    postClient.start();
                }
                break;
            default:
                break;
        }
    }

    protected void onActivityResult(int reqCode, int resultCode, Intent data){
        if(resultCode == RESULT_OK){
            //카메라 촬영 경우에
            if(reqCode == PICK_FROM_CAMERA){
                //파일의 경로를 불러와 원본이미지를 이미지뷰에 맞게 리사이즈한 후 출력
                if(data != null){
                    Uri cUri = data.getData();
                    Bitmap mImage;
                    try{
                        if(picView.getDrawable() != null) {
                            picView.setImageBitmap(null);
                        }
                        Matrix m = new Matrix();
                        mImage = MediaStore.Images.Media.getBitmap(getContentResolver(), cUri);
                        oWidth = mImage.getWidth();
                        oHeight = mImage.getHeight();
                        float scaleWidth = ((float)picView.getHeight())/oHeight;
                        float scaleHeight = ((float)picView.getWidth())/oWidth;
                        m.postRotate(90);
                        m.postScale(scaleWidth, scaleHeight);
                        //picView.setScaleX(scaleWidth);
                        //picView.setScaleY(scaleHeight);
                        Bitmap resizeImage = Bitmap.createBitmap(mImage, 0, 0, mImage.getWidth(), mImage.getHeight(),
                                m, true);
                        picView.setImageBitmap(resizeImage);
                        picView.setScaleType(ImageView.ScaleType.FIT_XY);
                        copyString.setVisibility(View.VISIBLE);
                        //GPS값 받아오기
                        gpsInfo = new GpsInfo(CaptureActivity.this);
                        //메모리 줄이기
                        mImage = null;
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                }
            }
        }
    }
}
