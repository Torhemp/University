package com.example.eom.termproject_client;

/**
 * Created by Eom on 2015-06-13.
 */
public class PicInfo {
    private String photographer;
    private String copystring;
    private String date;

    public PicInfo(String photographer, String copystring, String date){
        this.photographer = photographer;
        this.copystring = copystring;
        this.date = date;
    }

    public String getPhotographer(){
        return photographer;
    }

    public void setPhotographer(String photographer){
        this.photographer = photographer;
    }

    public String getCopystring(){
        return copystring;
    }

    public void setCopystring(String copystring){
        this.copystring = copystring;
    }

    public String getDate(){
        return date;
    }

    public void setDate(String date){
        this.date = date;
    }
}
