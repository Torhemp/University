#include <stdio.h>
#include <stdlib.h>
#include <math.h>
//무한대 표현
#define MAX 1000
//도시 개수
#define CITYCOUNT 12
//비트형->정수형 변환
#define POW_2(b) (int)pow(2.0, b)
//비트의 최대값 정수형
#define MAX_BINT 4096
//도시 이름 열거형, 0은 테스트로 처리
//나머지는 각 번호에 해당하는 도시와 연결
enum city{
	Test, Seoul, Incheon,
	Gangneung, Cheonju, Cheonan,
	Donghae, Daejeon, Uljin,
	Daegu, Gwangju, Ulsan, Busan
};
//도시의 인접 행렬, 행에서 열로 가는 방향의 가중치
const int W[CITYCOUNT+1][CITYCOUNT+1]={
//   X 서울 인천 강릉 청주 천안 동해 대전 울진 대구 광주 울산 부산
	{0, 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0  }, // X
	{0, 0,   3,	  5,   8,   MAX, MAX, MAX, MAX, MAX, MAX, MAX, MAX}, //서울
	{0, 7,   0,   MAX, MAX, 1,   MAX, MAX, MAX, MAX, MAX, MAX, MAX}, //인천
	{0, 3,   MAX, 0,   MAX, MAX, 3,   MAX, MAX, MAX, MAX, MAX, MAX}, //강릉
	{0, 13,  MAX, MAX, 0,   3,   1,   MAX, 2,   MAX, MAX, MAX, MAX}, //청주
	{0, MAX, 3,   MAX, 4,   0,   MAX, 4,   MAX, MAX, MAX, MAX, MAX}, //천안
	{0, MAX, MAX, 5,   2,   MAX, 0,   MAX, 5,   MAX, MAX, MAX, MAX}, //동해
	{0, MAX, MAX, MAX, MAX, 5,   MAX, 0,   5,   3,   3,   MAX, MAX}, //대전
	{0, MAX, MAX, MAX, 2,   MAX, 3,   5,   0,   3,   MAX, 3,   MAX}, //울진
	{0, MAX, MAX, MAX, 6,   MAX, MAX, 6,   MAX, 0,   MAX, 2,   1  }, //대구
	{0, MAX, MAX, MAX, MAX, MAX, MAX, 3,   MAX, 6,   0,   MAX, 5  }, //광주
	{0, MAX, MAX, MAX, MAX, MAX, MAX, MAX, 1,   MAX, MAX, 0,   2  }, //울산
	{0, MAX, MAX, MAX, MAX, MAX, MAX, MAX, MAX, MAX, 4,   3,   0  }  //부산
};
//최적 경로 일주 인덱스 배열(열의 4096은 2^12)
int P[CITYCOUNT+1][4096]={0,};
//최단 거리 저장 배열
int D[CITYCOUNT+1][MAX_BINT];

//비트 표현을 위한 배열(A집합을 나타내는 배열)
int b[12]={0,};

//도시의 번호에 해당하는 이름 문자열(0은 테스트로 처리)
const char cityName[CITYCOUNT+1][10]={
	"Test", "Seoul", "Incheon",
	"Gangneung", "Cheonju", "Cheonan",
	"Donghae", "Daejeon", "Uljin",
	"Daegu", "Gwangju", "Ulsan", "Busan"
};

//비트 검사 함수
int checkBit(int bitS){
	int i=CITYCOUNT-1, bit=bitS, sum=0;
	//들어가있는 비트를 검사하여 부분집합의 개수 파악하여 리턴
	while(i>=0){
		b[i]=bit>>i;
		sum+=b[i];
		if(b[i]==1)
			bit-=POW_2(i);
		--i;
	}
	return sum;
}

//D에 들어갈 값들 중 최소값 출력 함수
int minD(int temp[], int cnt, int* index){
	int i, min=temp[0];
	*index=0;
	//기존에 구한 값들 중 최소값 선택 후 리턴
	for(i=1;i<=cnt;++i)
		if(min>temp[i]){
			min=temp[i];
			*index=i;
		}

	return min;
}

//TSP 본체
int travel(int start, const int W[][13], int P[][4096], int b[], int D[][MAX_BINT]){
	//반복 변수
	int i, j, k;
	//D가 되는 개수 변수, 주소 변수
	int cnt=0, index=0;
	//부분집합을 표현하는 비트
	int bitS=0;
	//임시 D값 저장 배열, 임시 최단 거리 주소 저장 배열
	int temp[12]={MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX},
		indexP[12]={0,};
	//출발점 제외한 나머지 거리에서 도착점까지 최단 경로 저장
	for(i=1;i<=CITYCOUNT;++i)
		if(i!=start)
			D[i][0]=W[i][start];
	//부분집합 1~10개의 경우 계산
	for(k=1;k<=CITYCOUNT-2;++k){
		//개수에 맞는 최초부분집합 계산
		bitS=0;
		for(j=0;j<=k;++j){
			b[j]=1;
			bitS |= (int)pow(2.0, j);
		}
		b[start-1]=0;
		bitS ^= (int)pow(2.0, start-1);
		while(1){
			for(j=1;j<=CITYCOUNT;++j){
				//부분집합 A, 출발점에 포함되면 넘어감
				if((bitS & (1<<(j-1)))>0)
					continue;
				//A인 경우에 D행렬, P행렬의 일부 계산
				for(i=1, cnt=0;cnt<k;++i){
					if((bitS & (1<<(i-1)))>0){
						temp[cnt]=W[j][i]+D[i][bitS^(1<<i)];
						indexP[cnt]=i;
						++cnt;
					}
				}
				D[j][bitS]=minD(temp, cnt, &index);
				P[j][bitS]=indexP[index];
			}
			//비트수 검사하여 개수 맞으면 계속 진행, 범위 초과시 종료
			while(1){
				++bitS;
				//범위 초과시 반복 종료
				if(bitS>4095)
					break;
				//개수 일치 시 반복 종료
				else if(checkBit(bitS)==k)
					break;
			}
			//범위 초과 시 구문 종료
			if(bitS>4095)
				break;
		}
	}
	//출발 제외한 나머지 경로 거칠 때 경우 계산
	bitS=4095;
	bitS^=(int)pow(2.0, start-1);
	for(i=1, cnt=0;cnt<CITYCOUNT-1;++i){
		if((bitS & (1<<(i-1)))>0){
			temp[cnt]=W[start][i]+D[i][bitS^(1<<j)];
			indexP[cnt]=i;
			++cnt;
		}
	}
	D[start][bitS]=minD(temp,cnt,&index);
	P[start][bitS]=indexP[index];
	return D[start][bitS];
}

//경로 출력 함수
void printPath(int start, const int P[][4096]){
	int A=4095-POW_2(start-1), next=P[start][A];
	for(int i=0;i<12;i++){
		printf(" %s ", cityName[next]);
		if(i+1==start)
			A-=POW_2(P[start][A]-1);
		else
			A-=POW_2(P[next][A]-1);
		next=P[next][A];
		printf("->");
	}
}

int main(void){
	int start, minLength;

	printf("TSP 최단 경로 찾기 \n");
	printf("출발지를 입력해 주세요. \n");
	printf("서울=1, 인천=2,  강릉=3,  청주=4, \n");
	printf("천안=5, 동해=6,  대전=7,  울진=8, \n");
	printf("대구=9, 광주=10, 울산=11, 부산=12, \n");
	printf("출발지 : ");
	scanf("%d", &start);

	minLength=travel(start, W, P, b, D);
	printf("최단 거리 : %d \n", minLength);
	printf("최단 경로 \n");
	printPath(start, P);
	printf("\n");

	system("pause");
	return 0;
}