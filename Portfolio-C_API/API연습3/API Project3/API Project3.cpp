#include <windows.h>
#include <math.h>

//창의 최대 크기
#define MAX_SIZE 600
//창과 시계 사이의 간격
#define INTERVAL 50
//시계 중심의 원 크기
#define BUTTON 25
//시계 숫자의 위치를 잡는 길이
#define STR_LEN 235.0
//초침 길이
#define SEC_LEN 200.0
//분침 길이
#define MIN_LEN 160.0
//시침 길이
#define HOUR_LEN 100.0
//원주율(파이)
#define PI 3.141592
//초
#define SECOND 60
//분
#define MINUTE 60

//창 만드는 코드
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
HINSTANCE g_hInst;
LPSTR lpszClass="API Project3";

int APIENTRY WinMain(HINSTANCE hInstance,HINSTANCE hPrevInstance
		  ,LPSTR lpszCmdParam,int nCmdShow)
{
	HWND hWnd;
	MSG Message;
	WNDCLASS WndClass;
	g_hInst=hInstance;
	
	WndClass.cbClsExtra=0;
	WndClass.cbWndExtra=0;
	WndClass.hbrBackground=(HBRUSH)GetStockObject(WHITE_BRUSH);
	WndClass.hCursor=LoadCursor(NULL,IDC_ARROW);
	WndClass.hIcon=LoadIcon(NULL,IDI_APPLICATION);
	WndClass.hInstance=hInstance;
	WndClass.lpfnWndProc=(WNDPROC)WndProc;
	WndClass.lpszClassName=lpszClass;
	WndClass.lpszMenuName=NULL;
	WndClass.style=CS_HREDRAW | CS_VREDRAW;
	RegisterClass(&WndClass);

	hWnd=CreateWindow(lpszClass,lpszClass,WS_OVERLAPPEDWINDOW,
		  CW_USEDEFAULT,CW_USEDEFAULT,MAX_SIZE,MAX_SIZE,
		  NULL,(HMENU)NULL,hInstance,NULL);
	ShowWindow(hWnd,nCmdShow);
	
	while(GetMessage(&Message,0,0,0)) {
		TranslateMessage(&Message);
		DispatchMessage(&Message);
	}
	return Message.wParam;
}

//창 내에서 작동하는 기능의 코드
LRESULT CALLBACK WndProc(HWND hWnd,UINT iMessage,WPARAM wParam,LPARAM lParam)
{
	HDC hdc;
	PAINTSTRUCT ps;
	//시침, 분침, 초침 표현에 필요한 펜 인자
	HPEN hand_pen[3], old_pen;
	//실제 시간을 받아오는 시간 인자
	SYSTEMTIME st;
	//시계에서 각 시간을 나타내는 문자
	LPSTR clock_num[12]={"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"};
	//가변비율을 맞추기 위한 범위 구조체
	static RECT rect;
	//시계의 중심 좌표
	static POINT center_point;
	//시계의 선을 만드는 점의 좌표, 초침, 분침, 시침 순
	static POINT clock_point[3];
	//시계의 선의 각도(초), 초침, 분침, 시침 순
	static double clock_angle[3];

	//실제 시간을 받는 함수
	GetLocalTime(&st);
	//메세지에 따른 기능 실행
	switch(iMessage) {
	//최초 실행 시
	case WM_CREATE:
		//초침의 각도 계산을 위한 인자(초)
		clock_angle[0]=st.wSecond;
		//분침의 각도 계산을 위한 인자(초)
		clock_angle[1]=st.wMinute*SECOND+st.wSecond;
		//24시간 이므로 12시간 이전 이후로 나누어 시침의 각도 계산을 위한 인자(초)
		if(st.wHour>=12) clock_angle[2]=(st.wHour-12)*SECOND*MINUTE+st.wMinute*SECOND+st.wSecond;
		else clock_angle[2]=st.wHour*SECOND*MINUTE+st.wMinute*SECOND+st.wSecond;
		//시계의 중심 좌표 구하기
		center_point.x=MAX_SIZE/2;
		center_point.y=MAX_SIZE/2;
		//타이머 설정
		SetTimer(hWnd, 1, 1000, NULL);
		//타이머 강제 실행
		SendMessage(hWnd, WM_TIMER, 1, 0);
		return 0;
	//타이머 실행시
	case WM_TIMER:
		//초침 구하기
		clock_point[0].x=(int)(cos(((6.0*clock_angle[0])-90.0)*(PI/180.0))*SEC_LEN+center_point.x);
		clock_point[0].y=(int)(sin(((6.0*clock_angle[0])-90.0)*(PI/180.0))*SEC_LEN+center_point.y);
		//분침 구하기
		clock_point[1].x=(int)(cos(((0.1*clock_angle[1])-90.0)*(PI/180.0))*MIN_LEN+center_point.x);
		clock_point[1].y=(int)(sin(((0.1*clock_angle[1])-90.0)*(PI/180.0))*MIN_LEN+center_point.y);
		//시침 구하기
		clock_point[2].x=(int)(cos((((1.0/120.0)*clock_angle[2])-90.0)*(PI/180.0))*HOUR_LEN+center_point.x);
		clock_point[2].y=(int)(sin((((1.0/120.0)*clock_angle[2])-90.0)*(PI/180.0))*HOUR_LEN+center_point.y);
		//시침, 분침, 초침 각도의 인자 증가
		for(int i=0;i<3;++i){
			++clock_angle[i];
		}
		//시, 분, 초의 최대치에 도달 했을때 0으로 초기화
		if(clock_angle[0]>=60) clock_angle[0]=0;
		if(clock_angle[1]>=3600) clock_angle[1]=0;
		if(clock_angle[2]>=43200) clock_angle[2]=0;
		//다시 그리게 하기(무효 영역 발생을 통한 PAINT 메세지 호출)
		InvalidateRect(hWnd, NULL, FALSE);
		return 0;
	//다시 그려야 할 때
	case WM_PAINT:
		//dc영역 생성
		hdc=BeginPaint(hWnd, &ps);
		//가변모드 설정
		SetMapMode(hdc,MM_ANISOTROPIC);
		SetWindowExtEx(hdc,MAX_SIZE,MAX_SIZE,NULL);
		GetClientRect(hWnd, &rect);
		SetViewportExtEx(hdc,rect.right,rect.bottom,NULL);
		//시계 테두리(원) 만들기
		Ellipse(hdc, INTERVAL, INTERVAL, MAX_SIZE-INTERVAL, MAX_SIZE-INTERVAL);
		//오전 오후 설정
		if(st.wHour>=12) TextOut(hdc, 292, 120, "PM", 2);
		else TextOut(hdc, 292, 120, "AM", 2);
		//초침, 분침, 시침 순으로 선의 특징 설정
		hand_pen[0]=CreatePen(PS_SOLID, 1, RGB(0, 0, 0));
		hand_pen[1]=CreatePen(PS_SOLID, 5, RGB(0, 0, 255));
		hand_pen[2]=CreatePen(PS_SOLID, 10, RGB(255, 0, 0));
		for(int i=0;i<3;++i){
			//선의 특징 핸들 활성화
			old_pen=(HPEN)SelectObject(hdc, hand_pen[i]);
			//선을 그릴 점 하나 세팅
			MoveToEx(hdc, center_point.x, center_point.y, NULL);
			//나머지 점도 세팅하여 선을 그려 침 생성
			LineTo(hdc, clock_point[i].x, clock_point[i].y);
			//활성화 된 선의 핸들 삭제
			SelectObject(hdc, old_pen);
			DeleteObject(old_pen);
		}
		//1~12 문자 생성
		for(int i=0;i<12;++i){
			TextOut(hdc, (int)((cos(((30.0*i)-60.0)*(PI/180.0))*STR_LEN+center_point.x)-5),
				(int)((sin(((30.0*i)-60.0)*(PI/180.0))*STR_LEN+center_point.y)-5), clock_num[i] ,lstrlen(clock_num[i]));
		}
		//원의 중심 단추 그리기
		Ellipse(hdc, center_point.x-BUTTON, center_point.y-BUTTON, center_point.x+BUTTON, center_point.y+BUTTON);
		EndPaint(hWnd, &ps);
		return 0;
	//윈도우 창이 파괴될 시
	case WM_DESTROY:
		//타이머 해제
		KillTimer(hWnd, 1);
		//종료 메세지 반환
		PostQuitMessage(0);
		return 0;
	}
	//메세지 처리 후 종료
	return(DefWindowProc(hWnd,iMessage,wParam,lParam));
}
