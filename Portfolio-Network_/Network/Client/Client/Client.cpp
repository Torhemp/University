#include <WinSock2.h>
#include <stdio.h>
#include <stdlib.h>
#include "resource.h"

#define BUFSIZE 512
#define OP_LOGIN 10
#define OP_CHAT 11
#define OP_READY 12
#define OP_SELECT 13
#define OP_INIT 14
#define OP_ORDER 15
#define OP_LIST 16
#define OP_SYSTEM_LOGIN 100
#define OP_SYSTEM_USER 101
#define OP_SYSTEM_ERROR 102
#define OP_SYSTEM_READY 103
#define OP_SYSTEM_START 104
#define OP_SHOW_IMAGE 105
#define OP_PLAY_RESULT 106
#define OP_PLAY_INIT 107
#define OP_SYSTEM_ORDER 108
#define OP_CLIENT_LIST 109

//ID�ڽ�, �α��ι�ư, ä��â, �����Է�â, ���۹�ư �ڵ�
HWND hEditId, hButtonLogin, hEditChat, hEditInput, hButtonSend;
//�̹����ڽ�, �����ư, ���۹�ư �ڵ�, �÷��̾�1, �÷��̾�2
HWND hImg[9], hButtonReady, hButtonStart, hP1, hP2, hButtonList;
//ä�ÿ� ����, �Ϲ� ����
char chat[BUFSIZE+1], buf[BUFSIZE+1];
//���� ID, Ÿ ���� ID
char userId[21], aUserId[21];
//����
SOCKET sock;
//�Ӱ迵��
CRITICAL_SECTION cs;
//���� ��
int nLength;
//�̹��� ����� ����
HBITMAP hBit[3];
//���� ���� �÷���
bool startFlag=false;
//���õ� ��ü Ȯ�� ����
bool sel_Img[9]={false,};

//��ȭ���� ���ν��� �� ���� ���� ���ν���
BOOL CALLBACK DlgProc(HWND hDlg, UINT uMsg, WPARAM wParam, LPARAM lParam){
	//��ȯ��
	int retval;
	byte opCode = 0;
	//?, X, O �̹��� ����
	hBit[0] = (HBITMAP)LoadImage(NULL, "Q.bmp", IMAGE_BITMAP, 50, 50, LR_LOADFROMFILE);
	hBit[1] = (HBITMAP)LoadImage(NULL, "O.bmp", IMAGE_BITMAP, 50, 50, LR_LOADFROMFILE);
	hBit[2] = (HBITMAP)LoadImage(NULL, "X.bmp", IMAGE_BITMAP, 50, 50, LR_LOADFROMFILE);

	switch(uMsg){
	case WM_INITDIALOG:
		//�ڵ鷯 �ʱ�ȭ
		hEditId = GetDlgItem(hDlg, IDC_EDIT_ID);
		hButtonLogin = GetDlgItem(hDlg, IDC_BUTTON_LOGIN);
		hEditChat = GetDlgItem(hDlg, IDC_EDIT_CHAT);
		hEditInput = GetDlgItem(hDlg, IDC_EDIT_INPUT);
		hButtonSend = GetDlgItem(hDlg, IDC_BUTTON_SEND);
		hImg[0] = GetDlgItem(hDlg, IDC_PLT);
		hImg[1] = GetDlgItem(hDlg, IDC_PCT);
		hImg[2] = GetDlgItem(hDlg, IDC_PRT);
		hImg[3] = GetDlgItem(hDlg, IDC_PLM);
		hImg[4] = GetDlgItem(hDlg, IDC_PCM);
		hImg[5] = GetDlgItem(hDlg, IDC_PRM);
		hImg[6] = GetDlgItem(hDlg, IDC_PLB);
		hImg[7] = GetDlgItem(hDlg, IDC_PCB);
		hImg[8] = GetDlgItem(hDlg, IDC_PRB);
		hButtonReady = GetDlgItem(hDlg, IDC_BUTTONREADY);
		hButtonStart = GetDlgItem(hDlg, IDC_BUTTONSTART);
		hP1 = GetDlgItem(hDlg, IDC_STATIC_P1);
		hP2 = GetDlgItem(hDlg, IDC_STATIC_P2);
		hButtonList = GetDlgItem(hDlg, IDC_BUTTONLIST);
		userId[0]=NULL;
		//ID ���� ����
		SendMessage(hEditId, EM_SETLIMITTEXT, 20, 0);
		return TRUE;
	case WM_COMMAND:
		ZeroMemory(&opCode, sizeof(byte));
		ZeroMemory(chat, sizeof(chat));
		switch(LOWORD(wParam)){
		case IDC_BUTTON_LOGIN:
			EnableWindow(hButtonLogin, FALSE);
			GetDlgItemText(hDlg, IDC_EDIT_ID, userId, 20);
			if(strlen(userId) == 0){
				EnableWindow(hButtonLogin, TRUE);
			}
			else{
				EnterCriticalSection(&cs);
				opCode = OP_LOGIN;
				retval = send(sock, (char *)&opCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
					return FALSE;
				}
				retval = send(sock, userId, 20, 0);
				if(retval==SOCKET_ERROR){
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
					return FALSE;
				}
				EnableWindow(hEditId, FALSE);
				LeaveCriticalSection(&cs);
			}
			return TRUE;
		case IDC_BUTTON_SEND:
			EnableWindow(hButtonSend, FALSE);
			GetDlgItemText(hDlg, IDC_EDIT_INPUT, chat, BUFSIZE);
			if(strlen(userId) == 0 || userId[0]==NULL);
			else{
				EnterCriticalSection(&cs);
				opCode = OP_CHAT;
				retval = send(sock, (char *)&opCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
					return FALSE;
				}
				retval = send(sock, chat, BUFSIZE, 0);
				if(retval==SOCKET_ERROR){
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
					return FALSE;
				}
				LeaveCriticalSection(&cs);
			}
			EnableWindow(hButtonSend, TRUE);
			return TRUE;
		case IDC_BUTTONREADY:
			if(userId[0]==NULL);
			else{
				EnableWindow(hButtonReady, FALSE);
				EnterCriticalSection(&cs);
				opCode = OP_READY;
				retval = send(sock, (char *)&opCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
					return FALSE;
				}
				LeaveCriticalSection(&cs);
			}
			return TRUE;
		case IDC_BUTTONLIST:
			if(userId[0]==NULL);
			else{
				EnterCriticalSection(&cs);
				opCode = OP_LIST;
				retval = send(sock, (char *)&opCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
					return FALSE;
				}
				LeaveCriticalSection(&cs);
			}
			return TRUE;
		case IDC_PLT:
			if(startFlag){
				if(sel_Img[0]==false){
					opCode = OP_SELECT;
					byte num=1;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PCT:
			if(startFlag){
				if(sel_Img[1]==false){
					opCode = OP_SELECT;
					byte num=2;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PRT:
			if(startFlag){
				if(sel_Img[2]==false){
					opCode = OP_SELECT;
					byte num=3;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PLM:
			if(startFlag){
				if(sel_Img[3]==false){
					opCode = OP_SELECT;
					byte num=4;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PCM:
			if(startFlag){
				if(sel_Img[4]==false){
					opCode = OP_SELECT;
					byte num=5;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PRM:
			if(startFlag){
				if(sel_Img[5]==false){
					opCode = OP_SELECT;
					byte num=6;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PLB:
			if(startFlag){
				if(sel_Img[6]==false){
					opCode = OP_SELECT;
					byte num=7;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PCB:
			if(startFlag){
				if(sel_Img[7]==false){
					opCode = OP_SELECT;
					byte num=8;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDC_PRB:
			if(startFlag){
				if(sel_Img[8]==false){
					opCode = OP_SELECT;
					byte num=9;
					retval = send(sock, (char *)&opCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, userId, 20, 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
					retval = send(sock, (char *)&num, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						nLength = GetWindowTextLength(hEditChat);
						SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
						SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
						return FALSE;
					}
				}
				else{
					nLength = GetWindowTextLength(hEditChat);
					SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] �̹� ���õ� �׸��Դϴ�.");
					SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				}
			}
			else{
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ������ �غ���� �ʾҽ��ϴ�.");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			return TRUE;
		case IDCANCEL:
			EndDialog(hDlg, 0);
			return TRUE;
		}
		return FALSE;
	}
	return FALSE;
}

//���ú� ���� ������
DWORD WINAPI RecvMain(LPVOID arg){
	int retval, cnt=0;
	char result=0;
	byte opCode=0;
	char orderId[20];
	byte sendCode=0;

	WSADATA wsa;
	if(WSAStartup(MAKEWORD(2,2), &wsa)!=0) ExitThread(-1);

	sock = socket(AF_INET, SOCK_STREAM, 0);
	if(sock==INVALID_SOCKET) ExitThread(-1);

	SOCKADDR_IN serverAddr;
	ZeroMemory(&serverAddr, sizeof(serverAddr));
	serverAddr.sin_family=AF_INET;
	serverAddr.sin_port=htons(9721);
	serverAddr.sin_addr.s_addr=inet_addr("127.0.0.1");
	retval = connect(sock, (SOCKADDR *)&serverAddr, sizeof(serverAddr));
	if(retval==SOCKET_ERROR){
		closesocket(sock);
		ExitThread(-1);
	}

	while(1){
		ZeroMemory(&opCode, sizeof(byte));
		ZeroMemory(aUserId, sizeof(aUserId));
		ZeroMemory(chat, sizeof(chat));
		ZeroMemory(buf, sizeof(buf));
		retval = recv(sock, (char *)&opCode, sizeof(byte), 0);
		if(retval==SOCKET_ERROR) continue;
		else if(retval==0) break;
		switch(opCode){
		//�α���
		case OP_SYSTEM_LOGIN:
			char connectId[20];
			EnterCriticalSection(&cs);
			retval = recv(sock, connectId, 20, 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[SYSTEM] ");
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)connectId);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"���� �����Ͽ����ϴ�.");
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			LeaveCriticalSection(&cs);
			break;
		//ä�� ����
		case OP_SYSTEM_USER:
			EnterCriticalSection(&cs);
			retval = recv(sock, aUserId, 20, 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)aUserId);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)": ");
			retval = recv(sock, chat, BUFSIZE, 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)chat);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			SetWindowText(hEditInput, "");
			LeaveCriticalSection(&cs);
			break;
		//���� ó��
		case OP_SYSTEM_ERROR:
			EnterCriticalSection(&cs);
			retval = recv(sock, buf, BUFSIZE, 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[ERROR] ");
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)buf);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			LeaveCriticalSection(&cs);
			break;
		//�غ� �ڵ�
		case OP_SYSTEM_READY:
			EnterCriticalSection(&cs);
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[SYSTEM] �غ�Ϸ�!");
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			for(int k=0;k<9;k++){
				SendMessage(hImg[k], STM_SETIMAGE, IMAGE_BITMAP, (LPARAM)hBit[0]);
			}
			SetWindowText(hP1, userId);
			LeaveCriticalSection(&cs);
			break;
		//���� ���� �ڵ�
		case OP_SYSTEM_START:
			EnterCriticalSection(&cs);
			sendCode = OP_ORDER;
			retval = recv(sock, aUserId, 20, 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			SetWindowText(hP2, aUserId);
			startFlag=true;
			retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
			if(retval==SOCKET_ERROR) break;
			LeaveCriticalSection(&cs);
			break;
		//�̹��� ���� �� ��� �ڵ�
		case OP_SHOW_IMAGE:
			EnterCriticalSection(&cs);
			bool oxFlag;
			byte num;
			retval = recv(sock, (char *)&oxFlag, sizeof(bool), 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			retval = recv(sock, (char *)&num, sizeof(byte), 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			if(oxFlag){
				SendMessage(hImg[num-1], STM_SETIMAGE, IMAGE_BITMAP, (LPARAM)hBit[1]);
			}
			else{
				SendMessage(hImg[num-1], STM_SETIMAGE, IMAGE_BITMAP, (LPARAM)hBit[2]);
			}
			sel_Img[num-1]=true;
			LeaveCriticalSection(&cs);
			break;
		//��� ���
		case OP_PLAY_RESULT:
			EnterCriticalSection(&cs);
			retval = recv(sock, (char *)&result, sizeof(char), 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			switch(result){
			case 'w':
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[RESULT] Win!");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				break;
			case 'l':
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[RESULT] Lose...");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				break;
			case 'd':
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[RESULT] Draw");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				break;
			default:
				break;
			}
			LeaveCriticalSection(&cs);
			break;
		//���ӿ� ���� �� �ʱ�ȭ
		case OP_PLAY_INIT:
			EnterCriticalSection(&cs);
			Sleep(2000);
			for(int i=0;i<9;i++){
				sel_Img[i]=false;
				SendMessage(hImg[i], STM_SETIMAGE, IMAGE_BITMAP, (LPARAM)hBit[0]);
			}
			SetWindowText(hP1, "Player1");
			SetWindowText(hP2, "Player2");
			startFlag=false;
			opCode = OP_INIT;
			retval = send(sock, (char *)&opCode, sizeof(byte), 0);
			if(retval==SOCKET_ERROR){
				nLength = GetWindowTextLength(hEditChat);
				SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[CSYSTEM] ���� ����");
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
				return -1;
			}
			EnableWindow(hButtonReady, true);
			LeaveCriticalSection(&cs);
			break;
		//���� ���
		case OP_SYSTEM_ORDER:
			EnterCriticalSection(&cs);
			ZeroMemory(orderId, sizeof(orderId));
			retval = recv(sock, orderId, 20, 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[SYSTEM] ");
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)orderId);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"�Ժ��� �����մϴ�.");
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			LeaveCriticalSection(&cs);
			break;
		//������ ��Ȳ Ȯ��
		case OP_CLIENT_LIST:
			EnterCriticalSection(&cs);
			retval = recv(sock, (char *)&cnt, sizeof(int), 0);
			if(retval==SOCKET_ERROR) break;
			else if(retval==0){
				closesocket(sock);
				ExitThread(-1);
			}
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[SYSTEM] ���� ������ \r\n");
			for(int z=0;z<cnt;z++){
				char tempId[20];
				retval = recv(sock, tempId, 20, 0);
				if(retval==SOCKET_ERROR) break;
				else if(retval==0){
					closesocket(sock);
					ExitThread(-1);
				}
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)tempId);
				SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"\r\n");
			}
			LeaveCriticalSection(&cs);
			break;
		//������ �ڵ�
		default:
			nLength = GetWindowTextLength(hEditChat);
			SendMessage(hEditChat, EM_SETSEL, nLength, nLength);
			SendMessage(hEditChat, EM_REPLACESEL, (WPARAM)TRUE, (LPARAM)"[SYSTEM] �߸��� ����� �Խ��ϴ�.\r\n");
			break;
		}
	}
	closesocket(sock);
	return 0;
}

int APIENTRY WinMain(HINSTANCE hInst, HINSTANCE,
					 LPSTR lpCmdLine, int nCmdShow)
{
	//�Ӱ迵�� ���� �̺�Ʈ
	InitializeCriticalSection(&cs);

	//�޼��� �޴� ������
	DWORD ThreadId;
	HANDLE hThread;
	hThread = CreateThread(NULL, 0, RecvMain, NULL, 0, &ThreadId);
	if(hThread==NULL) return -1;

	//��ȭ���� ����
	DialogBox(hInst, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);

	//���� ����
	DeleteCriticalSection(&cs);
	TerminateThread(hThread, 0);
	CloseHandle(hThread);
	closesocket(sock);
	WSACleanup();

	return 0;
}
