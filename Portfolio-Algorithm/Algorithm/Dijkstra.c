#include <stdio.h>
#include <stdlib.h>
//도시 개수
#define CITYCOUNT 12
//무한대
#define INF 1000

//간선을 표시하기 위한 구조체
typedef struct edge{
	//출발 정점
	int start;
	//도착 정점
	int finish;
	//가중치
	int weight;
}edge;

//도시의 인접 행렬, 행에서 열로 가는 방향의 가중치
int W[CITYCOUNT+1][CITYCOUNT+1]={
//   X 서울 인천 강릉 청주 천안 동해 대전 울진 대구 광주 울산 부산
	{0, 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0  }, // X
	{0, 0,   3,	  5,   8,   INF, INF, INF, INF, INF, INF, INF, INF}, //서울
	{0, 7,   0,   INF, INF, 1,   INF, INF, INF, INF, INF, INF, INF}, //인천
	{0, 3,   INF, 0,   INF, INF, 3,   INF, INF, INF, INF, INF, INF}, //강릉
	{0, 13,  INF, INF, 0,   3,   1,   INF, 2,   INF, INF, INF, INF}, //청주
	{0, INF, 3,   INF, 4,   0,   INF, 4,   INF, INF, INF, INF, INF}, //천안
	{0, INF, INF, 5,   2,   INF, 0,   INF, 5,   INF, INF, INF, INF}, //동해
	{0, INF, INF, INF, INF, 5,   INF, 0,   5,   3,   3,   INF, INF}, //대전
	{0, INF, INF, INF, 2,   INF, 3,   5,   0,   3,   INF, 3,   INF}, //울진
	{0, INF, INF, INF, 6,   INF, INF, 6,   INF, 0,   INF, 2,   1  }, //대구
	{0, INF, INF, INF, INF, INF, INF, 3,   INF, 6,   0,   INF, 5  }, //광주
	{0, INF, INF, INF, INF, INF, INF, INF, 1,   INF, INF, 0,   2  }, //울산
	{0, INF, INF, INF, INF, INF, INF, INF, INF, INF, 4,   3,   0  }  //부산
};
//해가 되는 간선의 집합
edge F[CITYCOUNT+1]={0,};

//도시 이름 표현을 위한 2차원 배열
char cityName[CITYCOUNT+1][10]={
	"Test", "Seoul", "Incheon",
	"Gangneung", "Cheonju", "Cheonan",
	"Donghae", "Daejeon", "Uljin",
	"Daegu", "Gwangju", "Ulsan", "Busan"
};

//다익스트라 알고리즘
void dijkstra(const int W[][13], edge F[]){

	int i, j, vnear;
	int touch[CITYCOUNT+1];
	int length[CITYCOUNT+1];

	//touch, length 초기값 설정
	for(i=2;i<=CITYCOUNT;++i){
		touch[i]=1;
		length[i]=W[1][i];
	}

	for(j=0;j<CITYCOUNT-1;++j){
		int min = INF;
		//가중치가 최소값인 간선과 연결된 정점들 계산
		for(i=2;i<=CITYCOUNT;++i)
			if(length[i]>=0 && length[i]<min){
				min = length[i];
				vnear = i;
			}
		//간선의 정보 저장
		F[j+1].start=touch[vnear];
		F[j+1].finish=vnear;
		F[j+1].weight=W[F[j+1].start][F[j+1].finish];
		//touch, length 정보 업데이트
		for(i=2;i<=CITYCOUNT;++i)
			if(length[vnear]+W[vnear][i]<length[i]){
				length[i]=length[vnear]+W[vnear][i];
				touch[i]=vnear;
			}
		//계산한 정점 표시
		length[vnear]=-1;
	}
}

//경로 출력 함수
//도착점부터 출발점까지 최소로 연결된 간선들을 도착점으로부터 계산 하여 구한 후 경로 출력
void printPath(int start, int finish, edge F[]){

	//인덱스 변수, 경로 정점의 인덱스, 경로의 총 가중치, 경로를 거치는 정점 집합
	int i, init=0, sum=0, vec[CITYCOUNT]={0,};
	printf("경로 : ");
	//최초 도착지의 정점 계산
	for(i=1;i<=CITYCOUNT;++i)
		if(F[i].finish==finish){
			init=i;
			break;
		}
	//경로 거치는 정점에 저장하기 위한 반복 변수
	i=CITYCOUNT-1;
	while(1){
		//간선의 도착 정점 저장 및 가중치 값 더함
		vec[i]=F[init].finish;
		sum+=F[init].weight;
		//경로 거치는 정점의 인덱스 감소
		--i;
		//출발점 도달 시 출발점 정점 저장후 반복문 종료
		if(F[init].start==start){
			vec[i]=F[init].start;
			break;
		}
		//간선의 나머지 정점(출발 정점) 찾기
		else{
			for(i=1;i<=CITYCOUNT;++i)
				if(F[i].finish==F[init].start){
					init=i;
					break;
				}
		}
	}
	//저장된 정점 출력
	for(i=0;i<CITYCOUNT;++i){
		if(vec[i]!=0)
			printf("%s ", cityName[vec[i]]);
	}
	//경로 길이 출력
	printf("\n경로 길이 : %d \n", sum);
}

//인자 변경 함수
void swap_i(int *a, int *b){
	int temp;
	temp=*a;
	*a=*b;
	*b=temp;
}

//간선에 저장된 정점 변경 함수
//출발점이 1(서울)이 아닐 시에 바꿨던 값을 다시 돌려주기 위해 사용
void changeV(int start){
	int i;
	//최초 정한 출발 인덱스와 1을 서로 바꿈
	for(i=1;i<CITYCOUNT;++i){
		if(F[i].start==start){
			F[i].start=1;
			break;
		}
		if(F[i].start==1)
			F[i].start=start;
	}
	for(i=1;i<CITYCOUNT;++i){
		if(F[i].finish==start){
			F[i].finish=1;
			break;
		}
		if(F[i].finish==1)
			F[i].finish=start;
	}
}

int main(void){
	//반복 변수, 출발지, 도착지
	int i, start, finish;
	
	printf("Dijkstra 최단 경로 찾기\n");
	printf("각 도시는 아래의 숫자와 대응됩니다. \n");
	printf("1-서울, 2-인천, 3-강릉, 4 -청주, 5 -천안, 6 -동해 \n");
	printf("7-대전, 8-울진, 9-대구, 10-광주, 11-울산, 12-부산 \n");
	//범위 내 있는 출발지 인덱스 입력
	while(1){
		printf("출발지를 입력하세요.(숫자) : ");
		scanf("%d", &start);
		if(start>CITYCOUNT || start<=0)
			printf("범위 초과, 다시 입력해 주세요(1~12)\n");
		else
			break;
	}
	//범위 내 있는 도착지 인덱스 입력
	while(1){
		printf("도착지를 입력하세요.(숫자) : ");
		scanf("%d", &finish);
		if(finish>CITYCOUNT || finish<=0)
			printf("범위 초과, 다시 입력해 주세요(1~12)\n");
		else
			break;
	}
	//출발점이 서울이 아니면 서울과 출발점의 인덱스 변경 및 인접행렬 변경
	if(start!=1){
		for(i=1;i<=CITYCOUNT;++i){
			swap_i(&W[i][1], &W[i][start]);
		}
		for(i=1;i<=CITYCOUNT;++i){
			swap_i(&W[1][i], &W[start][i]);
		}
	}
	//다익스트라 알고리즘 실행
	dijkstra(W, F);
	//출발점이 서울이 아니면 계산된 경로 내 정점의 출발점 인덱스와 서울 인덱스 값 서로 변경
	if(start!=1)
		changeV(start);
	
	//경로 출력
	printPath(start, finish, F);
	system("pause");
	return 0;
}