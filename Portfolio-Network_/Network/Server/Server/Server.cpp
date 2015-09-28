#include <stdio.h>
#include <WinSock2.h>
#include <stdlib.h>

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

typedef struct clientInfo{
	SOCKET clientSock;
	SOCKADDR_IN clientAddr;
	char userId[21];
	int index;
	bool useFlag;
	bool readyFlag;
}clientInfo;

clientInfo ci[3];
bool maxFlag=FALSE;
CRITICAL_SECTION cs;
int ccnt=0;
int cindex=0;
clientInfo p1, p2;
HANDLE checkReadyThread=NULL;
bool sel_Img[9]={false,};
bool p1_sel[9]={false,};
bool p2_sel[9]={false,};
bool orderFlag=true;
bool endFlag=false;

//게임의 승패를 결정짓는 확인 함수
int checkPlay(){
	if(orderFlag){
		if((p1_sel[0] && p1_sel[1] && p1_sel[2]) || (p1_sel[3] && p1_sel[4] && p1_sel[5]) ||
			(p1_sel[6] && p1_sel[7] && p1_sel[8]))
			return 1;
		else if((p1_sel[0] && p1_sel[3] && p1_sel[6]) || (p1_sel[1] && p1_sel[4] && p1_sel[7]) ||
			(p1_sel[2] && p1_sel[5] && p1_sel[8]))
			return 1;
		else if((p1_sel[0] && p1_sel[4] && p1_sel[8]) || (p1_sel[2] && p1_sel[4] && p1_sel[6]))
			return 1;
	}
	else{
		if((p2_sel[0] && p2_sel[1] && p2_sel[2]) || (p2_sel[3] && p2_sel[4] && p2_sel[5]) ||
			(p2_sel[6] && p2_sel[7] && p2_sel[8]))
			return 2;
		else if((p2_sel[0] && p2_sel[3] && p2_sel[6]) || (p2_sel[1] && p2_sel[4] && p2_sel[7]) ||
			(p2_sel[2] && p2_sel[5] && p2_sel[8]))
			return 2;
		else if((p2_sel[0] && p2_sel[4] && p2_sel[8]) || (p2_sel[2] && p2_sel[4] && p2_sel[6]))
			return 2;
	}
	if(sel_Img[0] && sel_Img[1] && sel_Img[2] && sel_Img[3] && sel_Img[4] &&
		 sel_Img[5] && sel_Img[6] && sel_Img[7] && sel_Img[8])
		 return 3;
	else
		return 0;
}

//준비 확인 스레드
DWORD WINAPI checkReady(LPVOID arg){
	int retval;
	byte sendCode = OP_SYSTEM_START;
	bool esc=false;
	int p1_index;
	while(1){
		for(int i=0;i<3;i++){
			if(ci[i].readyFlag){
				p1=ci[i];
				p1_index=i;
				esc=true;
				break;
			}	
		}
		if(esc)
			break;
	}
	esc=false;
	while(1){
		for(int i=0;i<3;i++){
			if(ci[i].readyFlag && i!=p1_index){
				p2=ci[i];
				esc=true;
				break;
			}	
		}
		if(esc){
			break;
		}
	}
	EnterCriticalSection(&cs);
	retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
	if(retval==SOCKET_ERROR){
		printf("Send Error_Player1_Code!\n");
		return -1;
	}
	retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
	if(retval==SOCKET_ERROR){
		printf("Send Error_Player2_Code!\n");
		return -1;
	}
	retval = send(p1.clientSock, p2.userId, 20, 0);
	if(retval==SOCKET_ERROR){
		printf("Send Error_Player1_Name!\n");
		return -1;
	}
	retval = send(p2.clientSock, p1.userId, 20, 0);
	if(retval==SOCKET_ERROR){
		printf("Send Error_Player2_Name!\n");
		return -1;
	}
	printf("게임 시작\n");
	LeaveCriticalSection(&cs);
	ExitThread(0);
	return 0;
}

//통신 스레드
DWORD WINAPI ClientProc(LPVOID arg){
	SOCKET sock;
	int retval, addrLen, index=(int)arg, playNum=0, z=0;
	byte sendCode = 0, opCode = 0, num = 0;
	SOCKADDR_IN sockAddr;
	char chat[BUFSIZE+1];
	DWORD ThreadId;

	sock = ci[index].clientSock;
	//소켓 정보 저장
	addrLen = sizeof(sockAddr);
	getpeername(sock, (SOCKADDR *)&sockAddr, &addrLen);

	while(1){
		ZeroMemory(&sendCode, sizeof(byte));
		ZeroMemory(&opCode, sizeof(byte));
		ZeroMemory(chat, sizeof(chat));
		//명령어(opcode) 받아오기
		retval = recv(sock, (char *)&opCode, sizeof(byte), 0);
		if(retval==SOCKET_ERROR){
			break;
		}
		else if(retval==0) break;
		//명령어 종류에 따른 기능 실행
		switch(opCode){
		//로그인
		case OP_LOGIN:
			printf("Login On \n");
			//ID받기
			retval = recv(sock, ci[index].userId, 20, 0);
			if(retval==SOCKET_ERROR){
				printf("Receive Error2!\n");
				return -1;
			}
			else if(retval==0) return 0;
			//시스템 출력문 생성
			ci[index].userId[retval]=NULL;
			printf("%s 접속\n", ci[index].userId);
			//시스템 출력 명령어 전송
			sendCode=100;
			for(int re=0;re<3;re++){
				if(ci[re].userId[0]!=NULL){
					retval = send(ci[re].clientSock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error1!\n");
						return -1;
					}
					//출력문 전송
					retval = send(ci[re].clientSock, ci[index].userId, 20, 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error2!\n");
						return -1;
					}
				}
			}
			printf("Login 완료 \n");
			break;
		//채팅
		case OP_CHAT:
			printf("chat on \n");
			EnterCriticalSection(&cs);
			//출력문 받기
			retval = recv(sock, chat, BUFSIZE, 0);
			if(retval==SOCKET_ERROR){
				printf("Receive Error3!\n");
				return -1;
			}
			else if(retval==0) return 0;
			chat[retval] = NULL;
			printf("%s : %s \n", ci[index].userId, chat);
			//유저가 있는 경우
			if(ci[index].userId[0]!=NULL){
				for(int i=0;i<3;i++){
					if(ci[i].userId[0]!=NULL){
						ZeroMemory(&sendCode, sizeof(byte));
						sendCode=OP_SYSTEM_USER;
						retval = send(ci[i].clientSock, (char *)&sendCode, sizeof(byte), 0);
						if(retval==SOCKET_ERROR){
							printf("Send Error3!\n");
							return -1;
						}
						retval = send(ci[i].clientSock, ci[index].userId, 20, 0);
						if(retval==SOCKET_ERROR){
							printf("Send Error4!\n");
							return -1;
						}
						retval = send(ci[i].clientSock, chat, BUFSIZE, 0);
						if(retval==SOCKET_ERROR){
							printf("Send Error5!\n");
							return -1;
						}
					}
				}
				printf("전송 성공 \n");
			}
			//로그인을 안했을 시
			else{
				sendCode=OP_SYSTEM_ERROR;
				retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error6!\n");
					return -1;
				}
				retval = send(sock, "아직 접속하지 않았습니다.", BUFSIZE, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error7!\n");
					return -1;
				}
				printf("접속 요구 완료 \n");
			}
			LeaveCriticalSection(&cs);
			break;
		//준비코드 들어오면 준비 플래그 온
		case OP_READY:
			printf("Ready On \n");
			EnterCriticalSection(&cs);
			if(checkReadyThread==NULL){
				checkReadyThread = CreateThread(NULL, 0, checkReady, NULL, 0, &ThreadId);
				if(checkReadyThread==NULL) printf("Thread Error!\n");
			}
			sendCode=OP_SYSTEM_READY;
			retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
			if(retval==SOCKET_ERROR){
				printf("Send Error8!\n");
				return -1;
			}
			printf("준비 플래그 완료 \n");
			ci[index].readyFlag=TRUE;
			LeaveCriticalSection(&cs);
			break;
		//이미지 선택 시 플레이어에 따른 모양 변경 및 승패 확인
		case OP_SELECT:
			char checkId[21];
			ZeroMemory(checkId, sizeof(checkId));
			EnterCriticalSection(&cs);
			retval = recv(sock, checkId, 20, 0);
			if(retval==SOCKET_ERROR){
				printf("Receive Error_SELECT_NUM1!\n");
				return -1;
			}
			checkId[retval]=NULL;
			retval = recv(sock, (char *)&num, sizeof(byte), 0);
			if(retval==SOCKET_ERROR){
				printf("Receive Error_SELECT_NUM2!\n");
				return -1;
			}
			if(orderFlag){
				if(sel_Img[num-1]){
					sendCode=OP_SYSTEM_ERROR;
					retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
					retval = send(sock, "이미 선택된 항목입니다.", BUFSIZE, 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
				}
				else if(strcmp(checkId, p1.userId)==0){
					sendCode = OP_SHOW_IMAGE;
					bool a = true;
					retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p1.clientSock, (char *)&a, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p2.clientSock, (char *)&a, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p1.clientSock, (char *)&num, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p2.clientSock, (char *)&num, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					sel_Img[num-1] = true;
					p1_sel[num-1] = true;
					playNum = checkPlay();
					orderFlag=false;
					printf("%s : %d번 선택 \n", checkId, (int)num);
				}
				else{
					sendCode=OP_SYSTEM_ERROR;
					retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
					retval = send(sock, "자신의 순서가 아닙니다.", BUFSIZE, 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
				}
			}
			else{
				if(sel_Img[num-1]){
					sendCode=OP_SYSTEM_ERROR;
					retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
					retval = send(sock, "이미 선택된 항목입니다.", BUFSIZE, 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
				}
				else if(strcmp(checkId, p2.userId)==0){
					sendCode = OP_SHOW_IMAGE;
					bool a = false;
					retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p1.clientSock, (char *)&a, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p2.clientSock, (char *)&a, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p1.clientSock, (char *)&num, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					retval = send(p2.clientSock, (char *)&num, sizeof(bool), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_105!\n");
						return -1;
					}
					sel_Img[num-1] = true;
					p2_sel[num-1] = true;
					playNum = checkPlay();
					orderFlag=true;
					printf("%s : %d번 선택 \n", checkId, (int)num);
				}
				else{
					sendCode=OP_SYSTEM_ERROR;
					retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
					retval = send(sock, "자신의 순서가 아닙니다.", BUFSIZE, 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_102!\n");
						return -1;
					}
				}
			}
			switch (playNum)
			{
			case 1:
				sendCode=OP_PLAY_RESULT;
				retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_1\n");
					return -1;
				}
				retval = send(p1.clientSock, "w", 1, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_2\n");
					return -1;
				}
				retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_3\n");
					return -1;
				}
				retval = send(p2.clientSock, "l", 1, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_4\n");
					return -1;
				}
				printf("p1 승리 \n");
				endFlag = true;
				break;
			case 2:
				sendCode=OP_PLAY_RESULT;
				retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_5\n");
					return -1;
				}
				retval = send(p1.clientSock, "l", 1, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_6\n");
					return -1;
				}
				retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_7\n");
					return -1;
				}
				retval = send(p2.clientSock, "w", 1, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_8\n");
					return -1;
				}
				printf("p2 승리 \n");
				endFlag = true;
				break;
			case 3:
				sendCode=OP_PLAY_RESULT;
				retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_9\n");
					return -1;
				}
				retval = send(p1.clientSock, "d", 1, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_10\n");
					return -1;
				}
				retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_11\n");
					return -1;
				}
				retval = send(p2.clientSock, "d", 1, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_106!_12\n");
					return -1;
				}
				printf("무승부 \n");
				endFlag = true;
				break;
			default:
				break;
			}
			if(endFlag){
				printf("초기화 시작 \n");
				for(int i=0;i<9;i++){
					sel_Img[i]=false;
					p1_sel[i]=false;
					p2_sel[i]=false;
				}
				sendCode = OP_PLAY_INIT;
				retval = send(p1.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_end1\n");
					return -1;
				}
				retval = send(p2.clientSock, (char *)&sendCode, sizeof(byte), 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_end2\n");
					return -1;
				}
				playNum=0;
				endFlag=false;
			}
			LeaveCriticalSection(&cs);
			break;
		case OP_INIT:
			EnterCriticalSection(&cs);
			ci[index].readyFlag=false;
			checkReadyThread=NULL;
			LeaveCriticalSection(&cs);
			break;
		case OP_ORDER:
			EnterCriticalSection(&cs);
			sendCode = OP_SYSTEM_ORDER;
			printf("순서 보내기\n");
			retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
			if(retval==SOCKET_ERROR){
				printf("Send Error_end1\n");
				return -1;
			}
			if(orderFlag){
				retval = send(sock, p1.userId, 20, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_end1\n");
					return -1;
				}
			}
			else{
				retval = send(sock, p2.userId, 20, 0);
				if(retval==SOCKET_ERROR){
					printf("Send Error_end1\n");
					return -1;
				}
			}
			LeaveCriticalSection(&cs);
			break;
		case OP_LIST:
			printf("리스트 출력\n");
			z=0;
			EnterCriticalSection(&cs);
			sendCode = 109;
			retval = send(sock, (char *)&sendCode, sizeof(byte), 0);
			if(retval==SOCKET_ERROR){
				printf("Send Error_List1\n");
				return -1;
			}
			retval = send(sock, (char *)&ccnt, sizeof(int), 0);
			if(retval==SOCKET_ERROR){
				printf("Send Error_List1\n");
				return -1;
			}
			while(z<3){
				if(ci[z].userId[0]==NULL);
				else{
					retval = send(sock, ci[z].userId, 20, 0);
					if(retval==SOCKET_ERROR){
						printf("Send Error_List1\n");
						return -1;
					}
				}
				z++;
			}
			LeaveCriticalSection(&cs);
			break;
		default:
			printf("Not exist opCode!\n");
			break;
		}
	}
	printf("%s 나감\n", ci[index].userId);
	closesocket(sock);
	EnterCriticalSection(&cs);
	ci[index].useFlag=FALSE;
	ci[index].userId[0]=NULL;
	ccnt--;
	if(ccnt<3)
		maxFlag=FALSE;
	LeaveCriticalSection(&cs);
	return 0;
}

int main(void){
	int retval;
	for(int i=0;i<3;i++){
		ci[i].userId[0]=NULL;
	}
	InitializeCriticalSection(&cs);
	//WinSock Initialize
	WSADATA wsa;
	if(WSAStartup(MAKEWORD(2,2), &wsa)!=0)
		return -1;

	//listenSock Creation
	SOCKET listenSock = socket(AF_INET, SOCK_STREAM, 0);
	if(listenSock==INVALID_SOCKET){
		printf("Socket Error!\n");
		system("pause");
		return -1;
	}

	//bind
	SOCKADDR_IN serverAddr;
	ZeroMemory(&serverAddr, sizeof(serverAddr));
	serverAddr.sin_family=AF_INET;
	serverAddr.sin_port=htons(9721);
	serverAddr.sin_addr.s_addr=htonl(INADDR_ANY);
	retval=bind(listenSock, (SOCKADDR *)&serverAddr, sizeof(serverAddr));
	if(retval==SOCKET_ERROR){
		printf("Bind Error!\n");
		system("pause");
		return -1;
	}
	//listen
	retval=listen(listenSock, SOMAXCONN);
	if(retval==SOCKET_ERROR){
		printf("Listen Error!\n");
		system("pause");
		return -1;
	}

	for(int i=0;i<3;i++){
		ci[i].useFlag=FALSE;
	}
	printf("Loading Success\n");
	int addrLen;
	HANDLE hThread;
	DWORD ThreadId;

	while(1){
		//accept
		int index=cindex;
		if(ccnt<3){
			addrLen = sizeof(ci[index].clientAddr);
			ci[index].clientSock = accept(listenSock, (SOCKADDR *)&ci[index].clientAddr, &addrLen);
			if(ci[cindex].clientSock==INVALID_SOCKET){
				printf("Accept Error!\n");
				continue;
			}

			//Thread on
			hThread = CreateThread(NULL, 0, ClientProc, (LPVOID)index, 0, &ThreadId);
			if(hThread==NULL) printf("Thread Error!\n");
			else CloseHandle(hThread);
			EnterCriticalSection(&cs);
			ci[index].useFlag=TRUE;
			ccnt++;
			for(int k=0;k<3;k++){
				if(!ci[k].useFlag){
					cindex=k;
					break;
				}
			}
			LeaveCriticalSection(&cs);
		}
		if(ccnt>=3){
			maxFlag=TRUE;
			printf("최대 수용인원 달성.\n");
			while(1){
				if(!maxFlag){
					break;
				}
			}
			for(int i=0;i<=ccnt;i++){
				if(!ci[i].useFlag){
					EnterCriticalSection(&cs);
					cindex=i;
					LeaveCriticalSection(&cs);
					break;
				}
			}
		}
	}

	DeleteCriticalSection(&cs);
	closesocket(listenSock);
	WSACleanup();
	return 0;
}