#include <windows.h>
#include <time.h>
//���� ������ 
#define radius 50

//������ â ������ ������ ����ϴ� �κ� 
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
//�ν��Ͻ� 
HINSTANCE g_hInst;
//���� â �̸� 
LPSTR lpszClass="API Project";
//���� ���� 
POINT point;
//������ â�� ũ�⸦ ���� ����ü 
RECT rect;

//â ����� �ڵ� 
int APIENTRY WinMain(HINSTANCE hInstance,HINSTANCE hPrevInstance
		  ,LPSTR lpszCmdParam,int nCmdShow)
{
    //������ �ڵ� 
	HWND hWnd;
	//������ �޼��� 
	MSG Message;
	//������ Ŭ���� 
	WNDCLASS WndClass;
	//�ν��Ͻ� ����(��ü ����) 
	g_hInst=hInstance;
	
	//������ ���� ���� 
	WndClass.cbClsExtra=0;
	WndClass.cbWndExtra=0;
	//������ ������ ���� 
	WndClass.hbrBackground=(HBRUSH)GetStockObject(WHITE_BRUSH);
	//������ â ���� Ŀ��, ������ ���� 
	WndClass.hCursor=LoadCursor(NULL,IDC_ARROW);
	WndClass.hIcon=LoadIcon(NULL,IDI_APPLICATION);
	//������ �ν��Ͻ��ڵ� ���� 
	WndClass.hInstance=hInstance;
	//������ �޼��� ó���Լ� ���� 
	WndClass.lpfnWndProc=(WNDPROC)WndProc;
	//������ Ŭ���� �̸� ���� 
	WndClass.lpszClassName=lpszClass;
	//������ �޴� ���� 
	WndClass.lpszMenuName=NULL;
	//������ ��Ÿ�� ���� 
	WndClass.style=CS_HREDRAW | CS_VREDRAW;
	//������ Ŭ���� ��� 
	RegisterClass(&WndClass);

    //������ ���� ���� �Լ� (����Ŭ�����̸�, ����Ÿ��Ʋ�� �̸�, ������ ��Ÿ��,
    //��ü ȭ���� x, y��ǥ, ������ â�� ����, ����, �θ������� ����,
    //�޴� �ڵ� ����, ���α׷��� �ڵ� ����, ����ü ����) 
	hWnd=CreateWindow(lpszClass,lpszClass,WS_OVERLAPPEDWINDOW,
		  CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,
		  NULL,(HMENU)NULL,hInstance,NULL);
    //������ ��� 
	ShowWindow(hWnd,nCmdShow);
	
	//�޼��� ����, �޼����� �а� 
	while(GetMessage(&Message,0,0,0)) {
        //Ű���� �Է� �ν� �޼��� 
		TranslateMessage(&Message);
		//�޼��� ���� �Լ� 
		DispatchMessage(&Message);
	}
	//Ż���ڵ� return 0; �� ���� 
	return Message.wParam;
}

//�޼��� ó�� �Լ� 
LRESULT CALLBACK WndProc(HWND hWnd,UINT iMessage,WPARAM wParam,LPARAM lParam)
{
    //dc ���� ���� 
	HDC hdc;
	//�׸��� ���� ����ü 
	PAINTSTRUCT ps;
	//�� �Ӽ� ���� ����
    HPEN circle_pen, old_pen; 
	//��ü�� �̵� ���� �� �ӵ� ���� ���� 
	static int valiation_x=0;
	static int valiation_y=10;

	switch(iMessage) {
    //���� ����� 
	case WM_CREATE:
        //�������� ũ�� ���� 
		GetClientRect(hWnd, &rect);
		//���� ���� ���� 
		point.x=radius;
		point.y=radius;
		//Ÿ�̸� ���� 
		SetTimer(hWnd, 1, 10, NULL);
		break;
	case WM_TIMER:
        //���� �̵� 
		point.x+=valiation_x;
		point.y+=valiation_y;
		//���� �Ʒ��� ���� ������� ���� ��ȯ 
		if((point.y+radius)>rect.bottom){
			point.y=rect.bottom-radius;
			valiation_x=10;
			valiation_y=0;
		}
		//���� ������ ���� ������� ���� ��ȯ
		else if((point.x+radius)>rect.right){
			point.x=rect.right-radius;
			valiation_x=0;
			valiation_y=-10;
		}
		//���� ���� ���� ������� ���� ��ȯ
		else if(point.y<radius){
			point.y=rect.top+radius;
			valiation_x=-10;
			valiation_y=0;
		}
		//���� ���� ���� ������� ���� ��ȯ
		else if(point.x<radius){
			point.x=rect.left+radius;
			valiation_x=0;
			valiation_y=10;
		}
		//�ٽ� �׸��� �޼��� ȣ�� 
		InvalidateRect(hWnd, NULL, TRUE);
		break;
	//�ٽ� �׷��� �� �� 
	case WM_PAINT:
        //�׸��� ���� ���� 
		hdc=BeginPaint(hWnd, &ps);
		//�� �Ӽ� �ο�
		circle_pen=CreatePen(PS_SOLID, 3, RGB(0,0,0));
		//�� �Ӽ� ���� 
        old_pen=(HPEN)SelectObject(hdc, circle_pen);
		//�� �׸��� 
		Ellipse(hdc, point.x-radius, point.y-radius, point.x+radius, point.y+radius);
		//�� �Ӽ� ����
        SelectObject(hdc, old_pen);
        DeleteObject(old_pen); 
		//�׸��� ���� ���� 
		EndPaint(hWnd, &ps);
		break;
	//â�� �ı��� ��� 
	case WM_DESTROY:
        //Ÿ�̸� ���� 
		KillTimer(hWnd, 1);
		//����޼��� 
		PostQuitMessage(0);
		break;
	}
	//�޼��� �� ���� 
	return(DefWindowProc(hWnd,iMessage,wParam,lParam));
}
