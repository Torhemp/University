package server;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.util.Map;

import com.sun.net.httpserver.Headers;
import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;

public class RecvPicInfoHttpService implements HttpHandler {
	public void handle(HttpExchange exchange) throws IOException {
        // parameters 파라메터를 Map 자료구조에 저장 
        Map<String, Object> parameters = (Map<String, Object>) 
           exchange.getAttribute("parameters");
        String results = "null";
        
        // HTTP 요청방식에 따른 처리절차 수행 
        String request = exchange.getRequestMethod();
        if (request.equalsIgnoreCase("GET") || request.equalsIgnoreCase("POST")) {
            // 요청 파라메터 가져오기
            int command = Integer.parseInt((String) parameters.get("command"));
            String id = (String) parameters.get("id");
            String params = (String) parameters.get("params");
            String DBarg[] = params.split(":");
            
            /* GET 또는 POST 요청 처리 부분 */
            try {
				DBAccess db = new DBAccess("SQLite", "org.sqlite.JDBC", "jdbc:sqlite:/c:\\AppDB\\PicDB", "", "");
				switch(command){
				case 1:
					if(db.insert(id, DBarg[0], DBarg[1], DBarg[2], DBarg[3], DBarg[4], DBarg[5]))
						results = "정보 입력 성공";
					else
						results = "정보 입력 실패";
					break;
				case 2:
					results = db.allData();
					break;
				case 3:
					results = db.search(id, DBarg[0], DBarg[1]);
					break;
				case 4:
					if(db.delete(id, DBarg[0], DBarg[1]))
						results = "삭제 성공";
					break;
				default:
					results = "잘못된 명령 전달";
					break;
				}
            }
            catch (Exception e) {
				System.out.println("DB error : " + e.getMessage());
			}

            // results 문자열을 응답
            Headers responseHeaders = exchange.getResponseHeaders();
            responseHeaders.set("Content-Type", "text/plain");
            exchange.sendResponseHeaders(200, 0);
            OutputStream os = exchange.getResponseBody();
            os.write(results.getBytes());   
            os.close();
        }
    }
}
