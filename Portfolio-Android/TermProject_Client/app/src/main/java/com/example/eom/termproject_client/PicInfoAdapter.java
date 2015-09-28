package com.example.eom.termproject_client;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.List;

/**
 * Created by Eom on 2015-06-13.
 */
public class PicInfoAdapter extends ArrayAdapter<PicInfo> {
    private List<PicInfo> items;
    private LayoutInflater inflater;

    public PicInfoAdapter(Context context, int textViewResourceId, List<PicInfo> items){
        super(context, textViewResourceId, items);
        this.items = items;
        this.inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
    }

    public View getView(int position, View view, ViewGroup viewGroup){
        if(view == null){
            view = inflater.inflate(R.layout.list, null);
        }

        PicInfo item = (PicInfo) items.get(position);
        if(item!=null){
            TextView picInfoPhotographer  = (TextView) view.findViewById(R.id.textViewPhotographer);
            picInfoPhotographer.setText(item.getPhotographer());
            TextView picInfoCopystring  = (TextView) view.findViewById(R.id.textViewCopystring);
            picInfoCopystring.setText(item.getCopystring());
            TextView picInfoDate  = (TextView) view.findViewById(R.id.textViewDate);
            picInfoDate.setText(item.getDate());
        }
        return view;
    }
}
