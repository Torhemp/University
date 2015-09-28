package com.example.eom.termproject_client;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Matrix;
import android.os.Handler;
import android.os.Message;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.util.Base64;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.MapFragment;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;


public class ViewActivity2 extends ActionBarActivity {
    ImageView imageView;
    TextView pgTextView, addrTextView, dTextView, csTextView;
    private GoogleMap map;
    private LatLng latLng;
    private byte[] temp;
    public Handler hosthandle = new Handler(){
        public void handleMessage(Message msg){
            super.handleMessage(msg);
            if(msg.what == 0){
                switch(msg.arg2) {
                    case 0:
                        if(msg.arg1==3) {
                            String[] dbArg = msg.obj.toString().split(":");
                            if(dbArg!=null){
                                Matrix m = new Matrix();
                                temp = Base64.decode(dbArg[1].getBytes(), Base64.DEFAULT);
                                Bitmap image = BitmapFactory.decodeByteArray(temp, 0, temp.length);
                                int oWidth = image.getWidth();
                                int oHeight = image.getHeight();
                                m.postScale((float)imageView.getWidth()/oWidth, (float)imageView.getHeight()/oHeight);
                                Bitmap resizeImage = Bitmap.createBitmap(image, 0, 0, oWidth, oHeight, m, true);
                                latLng = new LatLng(Double.valueOf(dbArg[3]), Double.valueOf(dbArg[4]));
                                imageView.setImageBitmap(resizeImage);
                                pgTextView.setText(dbArg[0]);
                                addrTextView.setText(dbArg[5]);
                                dTextView.setText(dbArg[6]);
                                csTextView.setText(dbArg[2]);
                                Marker current = map.addMarker(new MarkerOptions().position(latLng));
                                map.moveCamera(CameraUpdateFactory.newLatLngZoom(latLng, 15));
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
        setContentView(R.layout.activity_view2);

        imageView = (ImageView)findViewById(R.id.viewImageView);
        map = ((MapFragment) getFragmentManager().findFragmentById(R.id.maps)).getMap();
        pgTextView = (TextView)findViewById(R.id.photographerTextView);
        addrTextView = (TextView)findViewById(R.id.addressTextView);
        dTextView = (TextView)findViewById(R.id.dateTextView);
        csTextView = (TextView)findViewById(R.id.copyStringTextView);

        ServerPostComm postClient;
        String url = "http://192.168.43.31:3000/recvPicInfo";
        String id = getIntent().getStringExtra("photographer");
        String values = getIntent().getStringExtra("copystring") + ":" + getIntent().getStringExtra("date");
        postClient = new ServerPostComm(url, 3, id, values, hosthandle);
        postClient.start();
    }

    public void btnImgViewClick(View v){
        switch(v.getId()){
            case R.id.viewImageView:
                long r;
                DbOpenHelper mDbOpenHelper = new DbOpenHelper(this);
                mDbOpenHelper.open();
                try {
                    r = mDbOpenHelper.insert(pgTextView.getText().toString(), temp, csTextView.getText().toString(),
                            Double.toString(latLng.latitude), Double.toString(latLng.longitude),
                            addrTextView.getText().toString(), dTextView.getText().toString());
                    if(r==-1) {
                        Toast.makeText(ViewActivity2.this, "등록에 실패했습니다.", Toast.LENGTH_SHORT).show();
                    }
                    else{
                        Toast.makeText(ViewActivity2.this, "즐겨찾기에 추가되었습니다.", Toast.LENGTH_SHORT).show();
                    }
                }
                catch(Exception e){
                    Toast.makeText(ViewActivity2.this, e.getCause().toString(), Toast.LENGTH_SHORT).show();
                }
                finally {
                    mDbOpenHelper.close();
                }
                break;
            default:
                break;
        }
    }
}
