package server;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.commons.codec.binary.Base64;

public class DBAccess {
	private DatabaseConnectionPool dbConnectionPool;

    public DBAccess(String dbName, String driverName, String dbUrl, String dbUser, 
      String dbPwd) throws Exception {
        
        // 데이터베이스 커넥션 풀 구성       
        try {
            dbConnectionPool = new DatabaseConnectionPool(dbName, driverName, dbUrl, 
              dbUser, dbPwd);
        } catch(Exception e) {
            System.out.println("[커넥션풀 생성 오류]" + e.getMessage());
            throw e;
        }
    }
    
    /* 작성자, 시간으로 항목 찾기 */
    public String search(String photographer, String copystring, String date) throws Exception {
        // 데이터베이스 커넥션 가져오기
        Connection c = dbConnectionPool.getConnection();
        if (c == null) throw new Exception();
        
        // 질의 SQL 문장 작성
        String sql = "select photographer, picture, copystring, lat, lon, address, date from PicDB where photographer like '" 
          + photographer + "' and date like '" + date + "' and copystring like '" + copystring + "';";
            
        StringBuffer sb = new StringBuffer();
        try {
            // 질의 SQL 문장 실행
            PreparedStatement pstmt = c.prepareStatement(sql);
            ResultSet rs = pstmt.executeQuery();
        	
            // 질의결과를 문자열로 만들기
            if (rs.next()) {
            	byte[] image = rs.getBytes(2);
            	String text = new String(Base64.encodeBase64(image));
                sb.append(rs.getString(1) + ":" + text
                	 + ":" + rs.getString(3) + ":" + rs.getString(4) + ":" + rs.getString(5)
                	 + ":" + rs.getString(6) + ":" + rs.getString(7));
            }

            rs.close();
            pstmt.close();
        } catch(Exception e) {                    
            System.out.println("[검색 오류]" + e.getMessage());
            throw e;
        }           
                
        // 데이터베이스 커넥션 반납
        dbConnectionPool.freeConnection(c);

        // 결과 반환
        return sb.toString();
    } 
    
    /* 새로운 사진 정보 레코드를 PicDB 테이블에 저장 */
    public boolean insert(String photographer, String picture, String copystring,
    		String lat, String lon, String address, String date)
        throws Exception {
        // 데이터베이스 커넥션 가져오기
        Connection c = dbConnectionPool.getConnection();
        if (c == null) throw new Exception(); 

        // 삽입 SQL 문장 작성
        byte[] buf = Base64.decodeBase64(picture.getBytes());
        String sql = "insert into PicDB (photographer, picture, copystring, lat, lon, address, date)"
                     + " values ( '"  + photographer + "', ?, '"  + copystring + "', '"
                     + lat + "', '" + lon + "', '" + address + "', '" + date + "');";	
        try {
            // 삽입 SQL 문장 실행
            PreparedStatement pstmt = c.prepareStatement(sql);
            pstmt.setBytes(1, buf);
            pstmt.executeUpdate();
            pstmt.close();
            c.setAutoCommit(true);
        } catch (SQLException e) {
            System.out.println("[추가 오류]" + e.getMessage());
            return false;
        }
        
        // 데이터베이스 커넥션 반납
        dbConnectionPool.freeConnection(c);
        return true;
    }
    
    /* 데이터 삭제 */
    public boolean delete(String photographer, String copystring, String date) throws Exception {
        // 데이터베이스 커넥션 가져오기
        Connection c = dbConnectionPool.getConnection();
        if (c == null) throw new Exception(); 

        // 삭제 SQL 문장 작성
        String sql = "delete from PicDB where photographer like '" 
                + photographer + "' and date like '" + date + "' and copystring like '" + copystring + "';";;

        try {
            // 삭제 SQL 문장 실행
            Statement stmt = c.createStatement();
            stmt.executeUpdate(sql);
            stmt.close();
            c.setAutoCommit(true);
        } catch (SQLException e) {
            System.out.println("[추가 오류]" + e.getMessage());
            throw e;
        }
        
        // 데이터베이스 커넥션 반납
        dbConnectionPool.freeConnection(c);        
        return true;
    }
    
    public String allData() throws Exception{
    	Connection c = dbConnectionPool.getConnection();
        if (c == null) throw new Exception();
        
     // 질의 SQL 문장 작성
        String sql = "select photographer, copystring, date from PicDB order by date DESC, photographer ASC";
            
        StringBuffer sb = new StringBuffer();
        try {
            // 질의 SQL 문장 실행
            PreparedStatement pstmt = c.prepareStatement(sql);
            ResultSet rs = pstmt.executeQuery();
        	
            // 질의결과를 문자열로 만들기
            while (rs.next()) {
                sb.append(rs.getString(1) + ":" + rs.getString(2) + ":" + rs.getString(3) + "=");
            }

            rs.close();
            pstmt.close();
        } catch(Exception e) {                    
            System.out.println("[검색 오류]" + e.getMessage());
            throw e;
        }           
                
        // 데이터베이스 커넥션 반납
        dbConnectionPool.freeConnection(c);

        // 결과 반환
        return sb.toString();
    }
}
