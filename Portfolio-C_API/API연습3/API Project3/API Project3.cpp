#include <windows.h>
#include <math.h>

//â�� �ִ� ũ��
#define MAX_SIZE 600
//â�� �ð� ������ ����
#define INTERVAL 50
//�ð� �߽��� �� ũ��
#define BUTTON 25
//�ð� ������ ��ġ�� ��� ����
#define STR_LEN 235.0
//��ħ ����
#define SEC_LEN 200.0
//��ħ ����
#define MIN_LEN 160.0
//��ħ ����
#define HOUR_LEN 100.0
//������(����)
#define PI 3.141592
//��
#define SECOND 60
//��
#define MINUTE 60

//â ����� �ڵ�
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

//â ������ �۵��ϴ� ����� �ڵ�
LRESULT CALLBACK WndProc(HWND hWnd,UINT iMessage,WPARAM wParam,LPARAM lParam)
{
	HDC hdc;
	PAINTSTRUCT ps;
	//��ħ, ��ħ, ��ħ ǥ���� �ʿ��� �� ����
	HPEN hand_pen[3], old_pen;
	//���� �ð��� �޾ƿ��� �ð� ����
	SYSTEMTIME st;
	//�ð迡�� �� �ð��� ��Ÿ���� ����
	LPSTR clock_num[12]={"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"};
	//���������� ���߱� ���� ���� ����ü
	static RECT rect;
	//�ð��� �߽� ��ǥ
	static POINT center_point;
	//�ð��� ���� ����� ���� ��ǥ, ��ħ, ��ħ, ��ħ ��
	static POINT clock_point[3];
	//�ð��� ���� ����(��), ��ħ, ��ħ, ��ħ ��
	static double clock_angle[3];

	//���� �ð��� �޴� �Լ�
	GetLocalTime(&st);
	//�޼����� ���� ��� ����
	switch(iMessage) {
	//���� ���� ��
	case WM_CREATE:
		//��ħ�� ���� ����� ���� ����(��)
		clock_angle[0]=st.wSecond;
		//��ħ�� ���� ����� ���� ����(��)
		clock_angle[1]=st.wMinute*SECOND+st.wSecond;
		//24�ð� �̹Ƿ� 12�ð� ���� ���ķ� ������ ��ħ�� ���� ����� ���� ����(��)
		if(st.wHour>=12) clock_angle[2]=(st.wHour-12)*SECOND*MINUTE+st.wMinute*SECOND+st.wSecond;
		else clock_angle[2]=st.wHour*SECOND*MINUTE+st.wMinute*SECOND+st.wSecond;
		//�ð��� �߽� ��ǥ ���ϱ�
		center_point.x=MAX_SIZE/2;
		center_point.y=MAX_SIZE/2;
		//Ÿ�̸� ����
		SetTimer(hWnd, 1, 1000, NULL);
		//Ÿ�̸� ���� ����
		SendMessage(hWnd, WM_TIMER, 1, 0);
		return 0;
	//Ÿ�̸� �����
	case WM_TIMER:
		//��ħ ���ϱ�
		clock_point[0].x=(int)(cos(((6.0*clock_angle[0])-90.0)*(PI/180.0))*SEC_LEN+center_point.x);
		clock_point[0].y=(int)(sin(((6.0*clock_angle[0])-90.0)*(PI/180.0))*SEC_LEN+center_point.y);
		//��ħ ���ϱ�
		clock_point[1].x=(int)(cos(((0.1*clock_angle[1])-90.0)*(PI/180.0))*MIN_LEN+center_point.x);
		clock_point[1].y=(int)(sin(((0.1*clock_angle[1])-90.0)*(PI/180.0))*MIN_LEN+center_point.y);
		//��ħ ���ϱ�
		clock_point[2].x=(int)(cos((((1.0/120.0)*clock_angle[2])-90.0)*(PI/180.0))*HOUR_LEN+center_point.x);
		clock_point[2].y=(int)(sin((((1.0/120.0)*clock_angle[2])-90.0)*(PI/180.0))*HOUR_LEN+center_point.y);
		//��ħ, ��ħ, ��ħ ������ ���� ����
		for(int i=0;i<3;++i){
			++clock_angle[i];
		}
		//��, ��, ���� �ִ�ġ�� ���� ������ 0���� �ʱ�ȭ
		if(clock_angle[0]>=60) clock_angle[0]=0;
		if(clock_angle[1]>=3600) clock_angle[1]=0;
		if(clock_angle[2]>=43200) clock_angle[2]=0;
		//�ٽ� �׸��� �ϱ�(��ȿ ���� �߻��� ���� PAINT �޼��� ȣ��)
		InvalidateRect(hWnd, NULL, FALSE);
		return 0;
	//�ٽ� �׷��� �� ��
	case WM_PAINT:
		//dc���� ����
		hdc=BeginPaint(hWnd, &ps);
		//������� ����
		SetMapMode(hdc,MM_ANISOTROPIC);
		SetWindowExtEx(hdc,MAX_SIZE,MAX_SIZE,NULL);
		GetClientRect(hWnd, &rect);
		SetViewportExtEx(hdc,rect.right,rect.bottom,NULL);
		//�ð� �׵θ�(��) �����
		Ellipse(hdc, INTERVAL, INTERVAL, MAX_SIZE-INTERVAL, MAX_SIZE-INTERVAL);
		//���� ���� ����
		if(st.wHour>=12) TextOut(hdc, 292, 120, "PM", 2);
		else TextOut(hdc, 292, 120, "AM", 2);
		//��ħ, ��ħ, ��ħ ������ ���� Ư¡ ����
		hand_pen[0]=CreatePen(PS_SOLID, 1, RGB(0, 0, 0));
		hand_pen[1]=CreatePen(PS_SOLID, 5, RGB(0, 0, 255));
		hand_pen[2]=CreatePen(PS_SOLID, 10, RGB(255, 0, 0));
		for(int i=0;i<3;++i){
			//���� Ư¡ �ڵ� Ȱ��ȭ
			old_pen=(HPEN)SelectObject(hdc, hand_pen[i]);
			//���� �׸� �� �ϳ� ����
			MoveToEx(hdc, center_point.x, center_point.y, NULL);
			//������ ���� �����Ͽ� ���� �׷� ħ ����
			LineTo(hdc, clock_point[i].x, clock_point[i].y);
			//Ȱ��ȭ �� ���� �ڵ� ����
			SelectObject(hdc, old_pen);
			DeleteObject(old_pen);
		}
		//1~12 ���� ����
		for(int i=0;i<12;++i){
			TextOut(hdc, (int)((cos(((30.0*i)-60.0)*(PI/180.0))*STR_LEN+center_point.x)-5),
				(int)((sin(((30.0*i)-60.0)*(PI/180.0))*STR_LEN+center_point.y)-5), clock_num[i] ,lstrlen(clock_num[i]));
		}
		//���� �߽� ���� �׸���
		Ellipse(hdc, center_point.x-BUTTON, center_point.y-BUTTON, center_point.x+BUTTON, center_point.y+BUTTON);
		EndPaint(hWnd, &ps);
		return 0;
	//������ â�� �ı��� ��
	case WM_DESTROY:
		//Ÿ�̸� ����
		KillTimer(hWnd, 1);
		//���� �޼��� ��ȯ
		PostQuitMessage(0);
		return 0;
	}
	//�޼��� ó�� �� ����
	return(DefWindowProc(hWnd,iMessage,wParam,lParam));
}
