#include <windows.h>
#include <time.h>
#define radius 50
#define SPEED 7

LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
HINSTANCE g_hInst;
LPSTR lpszClass="API Project";
POINT point;
RECT rect;

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
		  CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,
		  NULL,(HMENU)NULL,hInstance,NULL);
	ShowWindow(hWnd,nCmdShow);
	
	while(GetMessage(&Message,0,0,0)) {
		TranslateMessage(&Message);
		DispatchMessage(&Message);
	}
	return Message.wParam;
}

LRESULT CALLBACK WndProc(HWND hWnd,UINT iMessage,WPARAM wParam,LPARAM lParam)
{
	HDC hdc;
	PAINTSTRUCT ps;
	HPEN circle_pen, old_pen;
	static int valiation_x=SPEED;
	static int valiation_y=SPEED;

	switch(iMessage) {
	case WM_CREATE:
		GetClientRect(hWnd, &rect);
		//난수를 통한 공의 위치 임의 생성 
		srand((unsigned)time(NULL));
		point.x=(rand()%(rect.right-radius*2))+radius;
		point.y=(rand()%(rect.bottom-radius*2))+radius;
		SetTimer(hWnd, 1, 5, NULL);
		break;
	case WM_TIMER:
		point.x+=valiation_x;
		point.y+=valiation_y;
		//왼쪽 또는 오른쪽 벽에 닿았을 경우 x방향 반대로 
		if((point.x+radius)>=rect.right || point.x<=radius)
			valiation_x*=(-1);
		//위쪽 또는 아래쪽 벽에 닿았을 경우 y방향 반대로 
		if((point.y+radius)>=rect.bottom || point.y<=radius)
			valiation_y*=(-1);
		InvalidateRect(hWnd, NULL, TRUE);
		break;
	case WM_PAINT:
		hdc=BeginPaint(hWnd, &ps);
		circle_pen=CreatePen(PS_SOLID, 3, RGB(50,150,150));
        old_pen=(HPEN)SelectObject(hdc, circle_pen);
		Ellipse(hdc, point.x-radius, point.y-radius, point.x+radius, point.y+radius);
		SelectObject(hdc, old_pen);
        DeleteObject(old_pen); 
		EndPaint(hWnd, &ps);
		break;
	case WM_DESTROY:
		KillTimer(hWnd, 1);
		PostQuitMessage(0);
		break;
	}
	return(DefWindowProc(hWnd,iMessage,wParam,lParam));
}
