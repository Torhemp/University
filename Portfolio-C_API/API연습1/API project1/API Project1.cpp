#include <windows.h>
#include <time.h>
//공의 반지름 
#define radius 50

//윈도우 창 내에서 실제로 기능하는 부분 
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
//인스턴스 
HINSTANCE g_hInst;
//윈도 창 이름 
LPSTR lpszClass="API Project";
//공의 원점 
POINT point;
//윈도우 창의 크기를 받을 구조체 
RECT rect;

//창 만드는 코드 
int APIENTRY WinMain(HINSTANCE hInstance,HINSTANCE hPrevInstance
		  ,LPSTR lpszCmdParam,int nCmdShow)
{
    //윈도우 핸들 
	HWND hWnd;
	//윈도우 메세지 
	MSG Message;
	//윈도우 클래스 
	WNDCLASS WndClass;
	//인스턴스 대입(실체 구현) 
	g_hInst=hInstance;
	
	//윈도우 예약 영역 
	WndClass.cbClsExtra=0;
	WndClass.cbWndExtra=0;
	//윈도우 배경색상 지정 
	WndClass.hbrBackground=(HBRUSH)GetStockObject(WHITE_BRUSH);
	//윈도우 창 내의 커서, 아이콘 설정 
	WndClass.hCursor=LoadCursor(NULL,IDC_ARROW);
	WndClass.hIcon=LoadIcon(NULL,IDI_APPLICATION);
	//윈도우 인스턴스핸들 지정 
	WndClass.hInstance=hInstance;
	//윈도우 메세지 처리함수 지정 
	WndClass.lpfnWndProc=(WNDPROC)WndProc;
	//윈도우 클래스 이름 지정 
	WndClass.lpszClassName=lpszClass;
	//윈도우 메뉴 설정 
	WndClass.lpszMenuName=NULL;
	//윈도우 스타일 정의 
	WndClass.style=CS_HREDRAW | CS_VREDRAW;
	//윈도우 클래스 등록 
	RegisterClass(&WndClass);

    //윈도우 실제 생성 함수 (윈도클래스이름, 윈도타이틀바 이름, 윈도우 스타일,
    //전체 화면의 x, y좌표, 윈도우 창의 가로, 세로, 부모윈도우 지정,
    //메뉴 핸들 지정, 프로그램의 핸들 지정, 구조체 지정) 
	hWnd=CreateWindow(lpszClass,lpszClass,WS_OVERLAPPEDWINDOW,
		  CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,
		  NULL,(HMENU)NULL,hInstance,NULL);
    //윈도우 출력 
	ShowWindow(hWnd,nCmdShow);
	
	//메세지 루프, 메세지를 읽고 
	while(GetMessage(&Message,0,0,0)) {
        //키보드 입력 인식 메세지 
		TranslateMessage(&Message);
		//메세지 전달 함수 
		DispatchMessage(&Message);
	}
	//탈출코드 return 0; 과 동일 
	return Message.wParam;
}

//메세지 처리 함수 
LRESULT CALLBACK WndProc(HWND hWnd,UINT iMessage,WPARAM wParam,LPARAM lParam)
{
    //dc 영역 선언 
	HDC hdc;
	//그리기 관련 구조체 
	PAINTSTRUCT ps;
	//펜 속성 관련 인자
    HPEN circle_pen, old_pen; 
	//물체의 이동 방향 및 속도 결정 인자 
	static int valiation_x=0;
	static int valiation_y=10;

	switch(iMessage) {
    //최초 실행시 
	case WM_CREATE:
        //윈도우의 크기 대입 
		GetClientRect(hWnd, &rect);
		//공의 원점 지정 
		point.x=radius;
		point.y=radius;
		//타이머 설정 
		SetTimer(hWnd, 1, 10, NULL);
		break;
	case WM_TIMER:
        //원점 이동 
		point.x+=valiation_x;
		point.y+=valiation_y;
		//원이 아래쪽 벽에 닿았을때 방향 전환 
		if((point.y+radius)>rect.bottom){
			point.y=rect.bottom-radius;
			valiation_x=10;
			valiation_y=0;
		}
		//원이 오른쪽 벽에 닿았을때 방향 전환
		else if((point.x+radius)>rect.right){
			point.x=rect.right-radius;
			valiation_x=0;
			valiation_y=-10;
		}
		//원이 위쪽 벽에 닿았을때 방향 전환
		else if(point.y<radius){
			point.y=rect.top+radius;
			valiation_x=-10;
			valiation_y=0;
		}
		//원이 왼쪽 벽에 닿았을때 방향 전환
		else if(point.x<radius){
			point.x=rect.left+radius;
			valiation_x=0;
			valiation_y=10;
		}
		//다시 그리는 메세지 호출 
		InvalidateRect(hWnd, NULL, TRUE);
		break;
	//다시 그려야 할 때 
	case WM_PAINT:
        //그리기 영역 선언 
		hdc=BeginPaint(hWnd, &ps);
		//펜 속성 부여
		circle_pen=CreatePen(PS_SOLID, 3, RGB(0,0,0));
		//펜 속성 선택 
        old_pen=(HPEN)SelectObject(hdc, circle_pen);
		//원 그리기 
		Ellipse(hdc, point.x-radius, point.y-radius, point.x+radius, point.y+radius);
		//펜 속성 해제
        SelectObject(hdc, old_pen);
        DeleteObject(old_pen); 
		//그리기 영역 해제 
		EndPaint(hWnd, &ps);
		break;
	//창이 파괴될 경우 
	case WM_DESTROY:
        //타이머 해제 
		KillTimer(hWnd, 1);
		//종료메세지 
		PostQuitMessage(0);
		break;
	}
	//메세지 값 리턴 
	return(DefWindowProc(hWnd,iMessage,wParam,lParam));
}
