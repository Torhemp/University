# 구축 및 개발 환경
- 클라이언트 : Samsung Galaxy Note2
- 서버 : 자바 이클립스 EE Luna Service Release 2(4.4.2)
- 개발 환경 : Android Studio 1.1.0
- 서버 DB : SQLite 3.8.8.2

# 프로젝트 기능 및 주요 처리 자료
  1) 클라이언트
  
    - 주요 처리 자료 : 사진 정보(촬영자, 사진 이미지, 카피문구, 위도, 경도, 주소, 일시)
    - 사진촬영 기능 : 사진촬영, 촬영된 사진 보기, 촬영된 사진 위에 카피문구 넣기,
      촬영자 + 사진 + 카피문구 + GPS 좌표 + 일시를 서버로 전송
    - 사진보기 기능 : 서버에 있는 사진 목록(촬영자 + 카피문구 + 일시) 보기, 사진 선택 시 촬영된
      사진 보기(사진 위에 촬영자, 일시, 주소 표시), 사진 아래에 카피문구, 사진 촬영 위치 표시
    - 사진삭제 기능 : 자신이 촬영한 사진을 서버에서 삭제
    - 즐겨찾기 기능 : 앱 내부 데이터베이스에 사진 정보 저장, 즐겨찾기에 저장된 사진 목록 출력,
      항목 선택 시 선택된 사진 정보 보기

  2) 서버
  
    - 주요 처리 자료 : 사진 정보(촬영자, 사진 이미지, 카피문구, 위도, 경도, 주소, 일시)
    - 저장 기능 : 사진 정보를 데이터베이스에 보관
    - 정보 처리 기능 : 클라이언트에서 요청한 정보를 받아서 요청한 정보에 맞게 클라이언트에게 전송

# 프로젝트 세부 구현 및 흐름
  1) 클라이언트
  
    - 앱을 실행하면 최초 4개의 버튼이 있는 화면 출력, 4개의 버튼은 사진촬영, 사진보기, 사진삭제,
      설정으로 지정하고 전송명령을 설정(POST 전송 -> 명령, id, values 존재)
    - 먼저 설정버튼을 누르면 촬영자를 입력할 수 있는 화면이 출력되고 촬영자를 입력하고 확인을
      누르면 촬영자가 앱 내부의 변수에 저장되고 기존의 화면으로 돌아옴
    - 다음에 사진촬영 버튼을 누르면 촬영 및 전송 버튼이 있는 화면이 출력되고 촬영버튼을 누르면
      내장된 카메라 앱이 실행되며 촬영 및 저장까지 완료되면 버튼 위에 큰 화면에 촬영된 사진이 출력
    - 촬영된 상태에서 전송 버튼을 누르게 되면 사진정보가 서버로 전송(POST요청, 명령==1, id==촬영자, values==나머지 정보)
    - 서버에서 처리에 따른 메시지를 받아 토스트 메시지로 출력
    - 사진보기 버튼을 누르면 서버에 현재 저장된 모든 사진 정보의 촬영자, 카피문구, 일시를 서버에서 
      받아와 리스트로 출력(POST요청, 명령==2, id==null, values==null)
    - 출력된 리스트 중 임의의 항목을 선택하면 선택된 항목의 사진정보를 서버에서 받아와 사진을
      출력하고 사진 위에 주소(좌상), 촬영자(좌하), 일시(우하)를 출력
      (POST요청, 명령==3, id==촬영자, values==카피문구, 일시)
    - 카피문구는 사진 바로 아래에 출력하고 지도는 가장 아래 부분에 구글 맵스로 출력
    - 여기서 사진 이미지를 누르면 앱 내부 데이터베이스에 사진정보를 저장하고 결과를 토스트
      메시지 출력
    - 사진삭제 버튼을 누르게 되면 사진보기처럼 서버에서 사진정보를 받아와 리스트로 출력
      (POST요청, 명령==2, id==촬영자, values==카피문구, 일시)
    - 출력된 리스트 중 임의의 항목을 선택하면 선택된 항목의 사진정보를 서버에서 삭제
      (POST요청, 명령==4, id==촬영자, values==카피문구, 일시)
    - 서버로 values 전송 시 구분자는 ‘:’로 지정

  2) 서버
  
    - 서버에서는 총 4가지 명령을 수행하며 DB는 서버에 있는 SQLite를 사용
    
     (1) 저장 명령(명령==1)
       - 클라이언트에서 1번 명령이 오게 되면 id는 촬영자, values는 구분자 ‘:’를 제거하고 각 항목에 
         맞게 DB에 저장
       - 저장이 성공되었다면 성공 메시지를 클라이언트에게 전송, 실패했다면 에러 내용을 전송
       
     (2) 목록 명령(명령==2)
       - 클라이언트에서 2번 명령이 오게 되면 데이터베이스 내 모든 사진 정보 중 촬영자, 카피문구,
         일시를 클라이언트에 전송
         
     (3) 목록 명령(명령==3)
       - 클라이언트에서 3번 명령이 오게 되면 데이터베이스 내 사진 정보 중 촬영자는 id와 일치하고
         values 값이 카피문구, 일시와 일치하는 항목을 검색하여 클라이언트에게 전송
         
     (4) 목록 명령(명령==4)
       - 클라이언트에서 3번 명령이 오게 되면 데이터베이스 내 사진 정보 중 촬영자는 id와 일치하고
         values 값이 카피문구, 일시와 일치하는 항목을 DB에서 삭, 삭제 결과를 클라이언트에게 전송
         
