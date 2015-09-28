package com.example.eom.termproject_client;

import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Matrix;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.util.Base64;
import android.view.Menu;
import android.view.MenuItem;
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


public class ViewActivity3 extends ActionBarActivity {
    ImageView imageView;
    TextView pgTextView, addrTextView, dTextView, csTextView;
    private GoogleMap map;
    private LatLng latLng;
    private byte[] temp;
    private DbOpenHelper mDbOpenHelper;
    private Cursor mCursor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view3);

        imageView = (ImageView)findViewById(R.id.viewImageView2);
        map = ((MapFragment) getFragmentManager().findFragmentById(R.id.maps2)).getMap();
        pgTextView = (TextView)findViewById(R.id.photographerTextView2);
        addrTextView = (TextView)findViewById(R.id.addressTextView2);
        dTextView = (TextView)findViewById(R.id.dateTextView2);
        csTextView = (TextView)findViewById(R.id.copyStringTextView2);


        mDbOpenHelper = new DbOpenHelper(this);
        mDbOpenHelper.open();
        mCursor = mDbOpenHelper.getRecord(getIntent().getStringExtra("photographer"),
                    getIntent().getStringExtra("copystring"),
                    getIntent().getStringExtra("date"));
        temp = mCursor.getBlob(1);
        latLng = new LatLng(Double.valueOf(mCursor.getString(3)),
                Double.valueOf(mCursor.getString(4)));
        pgTextView.setText(mCursor.getString(0));
        addrTextView.setText(mCursor.getString(5));
        dTextView.setText(mCursor.getString(6));
        csTextView.setText(mCursor.getString(2));
        Marker current = map.addMarker(new MarkerOptions().position(latLng));
        map.moveCamera(CameraUpdateFactory.newLatLngZoom(latLng, 15));
        mDbOpenHelper.close();
    }

    public void onWindowFocusChanged(boolean hasFocus) {
        super.onWindowFocusChanged(hasFocus);

        Matrix m = new Matrix();
        Bitmap image = BitmapFactory.decodeByteArray(temp, 0, temp.length);
        int oWidth = image.getWidth();
        int oHeight = image.getHeight();
        m.postScale((float)imageView.getWidth()/oWidth,
                (float)imageView.getHeight()/oHeight);
        Bitmap resizeImage = Bitmap.createBitmap(image, 0, 0, oWidth, oHeight, m, true);
        imageView.setImageBitmap(resizeImage);
    }

    public void btnImgViewClick2(View v){
        switch(v.getId()){
            case R.id.viewImageView2:
                try {
                    mDbOpenHelper = new DbOpenHelper(this);
                    mDbOpenHelper.open();
                    if(mDbOpenHelper.delete(getIntent().getStringExtra("photographer"),
                            getIntent().getStringExtra("copystring"),
                            getIntent().getStringExtra("date")))
                        Toast.makeText(ViewActivity3.this, "즐겨찾기에서 삭제되었습니다.",
                                Toast.LENGTH_SHORT).show();
                }
                catch(Exception e){
                    Toast.makeText(ViewActivity3.this, e.getCause().toString(),
                            Toast.LENGTH_SHORT).show();
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
