package com.example.eom.termproject_client;

import android.os.Handler;
import android.os.Message;

import org.apache.http.HttpResponse;
import org.apache.http.NameValuePair;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.message.BasicNameValuePair;
import org.apache.http.util.EntityUtils;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Eom on 2015-06-13.
 */
public class ServerPostComm extends Thread {
    private int command;
    private String url, id, values;
    private Handler handle;

    public ServerPostComm(String url, int command, String id, String values,
                          Handler handle) {
        this.url = url;
        this.command = command;
        this.id = id;
        this.values = values;
        this.handle = handle;
    }

    public void run() {
        // 메시지 객체 생성
        Message message = handle.obtainMessage();

        try {
            // HttpClient 객체 생성
            HttpClient httpclient = new DefaultHttpClient();

            // HttpPost 객체 생성 및 파라메터 설정
            HttpPost httppost = new HttpPost(url + "?command=" + command + "&id=" + id);
            List<NameValuePair> paramList = new ArrayList<NameValuePair>();
            paramList.add(new BasicNameValuePair("params", values));
            httppost.setEntity(new UrlEncodedFormEntity(paramList, "UTF-8"));
            httppost.addHeader("text", "plain");

            // HTTP 호출 실행
            HttpResponse response = httpclient.execute(httppost);

            // 호출결과를 문자열로 변환
            String str = EntityUtils.toString(response.getEntity(), "UTF-8");

            // 호출 성공 후 핸들러 호출
            message.what = 0; // 성공
            message.arg1 = command;
            message.arg2 = 0; // POST 호출
            message.obj = str;
            handle.sendMessage(message);
        } catch (Exception e) {
            // 호출 실패 후 핸들러 호출
            message.what = 1; // 실패
            message.arg1 = command;
            message.arg2 = 0; // POST 호출
            handle.sendMessage(message);
        }
    }
}
