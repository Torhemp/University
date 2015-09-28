#include <stdio.h>
#include <stdlib.h>
#include <math.h>
//���Ѵ� ǥ��
#define MAX 1000
//���� ����
#define CITYCOUNT 12
//��Ʈ��->������ ��ȯ
#define POW_2(b) (int)pow(2.0, b)
//��Ʈ�� �ִ밪 ������
#define MAX_BINT 4096
//���� �̸� ������, 0�� �׽�Ʈ�� ó��
//�������� �� ��ȣ�� �ش��ϴ� ���ÿ� ����
enum city{
	Test, Seoul, Incheon,
	Gangneung, Cheonju, Cheonan,
	Donghae, Daejeon, Uljin,
	Daegu, Gwangju, Ulsan, Busan
};
//������ ���� ���, �࿡�� ���� ���� ������ ����ġ
const int W[CITYCOUNT+1][CITYCOUNT+1]={
//   X ���� ��õ ���� û�� õ�� ���� ���� ���� �뱸 ���� ��� �λ�
	{0, 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0  }, // X
	{0, 0,   3,	  5,   8,   MAX, MAX, MAX, MAX, MAX, MAX, MAX, MAX}, //����
	{0, 7,   0,   MAX, MAX, 1,   MAX, MAX, MAX, MAX, MAX, MAX, MAX}, //��õ
	{0, 3,   MAX, 0,   MAX, MAX, 3,   MAX, MAX, MAX, MAX, MAX, MAX}, //����
	{0, 13,  MAX, MAX, 0,   3,   1,   MAX, 2,   MAX, MAX, MAX, MAX}, //û��
	{0, MAX, 3,   MAX, 4,   0,   MAX, 4,   MAX, MAX, MAX, MAX, MAX}, //õ��
	{0, MAX, MAX, 5,   2,   MAX, 0,   MAX, 5,   MAX, MAX, MAX, MAX}, //����
	{0, MAX, MAX, MAX, MAX, 5,   MAX, 0,   5,   3,   3,   MAX, MAX}, //����
	{0, MAX, MAX, MAX, 2,   MAX, 3,   5,   0,   3,   MAX, 3,   MAX}, //����
	{0, MAX, MAX, MAX, 6,   MAX, MAX, 6,   MAX, 0,   MAX, 2,   1  }, //�뱸
	{0, MAX, MAX, MAX, MAX, MAX, MAX, 3,   MAX, 6,   0,   MAX, 5  }, //����
	{0, MAX, MAX, MAX, MAX, MAX, MAX, MAX, 1,   MAX, MAX, 0,   2  }, //���
	{0, MAX, MAX, MAX, MAX, MAX, MAX, MAX, MAX, MAX, 4,   3,   0  }  //�λ�
};
//���� ��� ���� �ε��� �迭(���� 4096�� 2^12)
int P[CITYCOUNT+1][4096]={0,};
//�ִ� �Ÿ� ���� �迭
int D[CITYCOUNT+1][MAX_BINT];

//��Ʈ ǥ���� ���� �迭(A������ ��Ÿ���� �迭)
int b[12]={0,};

//������ ��ȣ�� �ش��ϴ� �̸� ���ڿ�(0�� �׽�Ʈ�� ó��)
const char cityName[CITYCOUNT+1][10]={
	"Test", "Seoul", "Incheon",
	"Gangneung", "Cheonju", "Cheonan",
	"Donghae", "Daejeon", "Uljin",
	"Daegu", "Gwangju", "Ulsan", "Busan"
};

//��Ʈ �˻� �Լ�
int checkBit(int bitS){
	int i=CITYCOUNT-1, bit=bitS, sum=0;
	//���ִ� ��Ʈ�� �˻��Ͽ� �κ������� ���� �ľ��Ͽ� ����
	while(i>=0){
		b[i]=bit>>i;
		sum+=b[i];
		if(b[i]==1)
			bit-=POW_2(i);
		--i;
	}
	return sum;
}

//D�� �� ���� �� �ּҰ� ��� �Լ�
int minD(int temp[], int cnt, int* index){
	int i, min=temp[0];
	*index=0;
	//������ ���� ���� �� �ּҰ� ���� �� ����
	for(i=1;i<=cnt;++i)
		if(min>temp[i]){
			min=temp[i];
			*index=i;
		}

	return min;
}

//TSP ��ü
int travel(int start, const int W[][13], int P[][4096], int b[], int D[][MAX_BINT]){
	//�ݺ� ����
	int i, j, k;
	//D�� �Ǵ� ���� ����, �ּ� ����
	int cnt=0, index=0;
	//�κ������� ǥ���ϴ� ��Ʈ
	int bitS=0;
	//�ӽ� D�� ���� �迭, �ӽ� �ִ� �Ÿ� �ּ� ���� �迭
	int temp[12]={MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX,MAX},
		indexP[12]={0,};
	//����� ������ ������ �Ÿ����� ���������� �ִ� ��� ����
	for(i=1;i<=CITYCOUNT;++i)
		if(i!=start)
			D[i][0]=W[i][start];
	//�κ����� 1~10���� ��� ���
	for(k=1;k<=CITYCOUNT-2;++k){
		//������ �´� ���ʺκ����� ���
		bitS=0;
		for(j=0;j<=k;++j){
			b[j]=1;
			bitS |= (int)pow(2.0, j);
		}
		b[start-1]=0;
		bitS ^= (int)pow(2.0, start-1);
		while(1){
			for(j=1;j<=CITYCOUNT;++j){
				//�κ����� A, ������� ���ԵǸ� �Ѿ
				if((bitS & (1<<(j-1)))>0)
					continue;
				//A�� ��쿡 D���, P����� �Ϻ� ���
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
			//��Ʈ�� �˻��Ͽ� ���� ������ ��� ����, ���� �ʰ��� ����
			while(1){
				++bitS;
				//���� �ʰ��� �ݺ� ����
				if(bitS>4095)
					break;
				//���� ��ġ �� �ݺ� ����
				else if(checkBit(bitS)==k)
					break;
			}
			//���� �ʰ� �� ���� ����
			if(bitS>4095)
				break;
		}
	}
	//��� ������ ������ ��� ��ĥ �� ��� ���
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

//��� ��� �Լ�
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

	printf("TSP �ִ� ��� ã�� \n");
	printf("������� �Է��� �ּ���. \n");
	printf("����=1, ��õ=2,  ����=3,  û��=4, \n");
	printf("õ��=5, ����=6,  ����=7,  ����=8, \n");
	printf("�뱸=9, ����=10, ���=11, �λ�=12, \n");
	printf("����� : ");
	scanf("%d", &start);

	minLength=travel(start, W, P, b, D);
	printf("�ִ� �Ÿ� : %d \n", minLength);
	printf("�ִ� ��� \n");
	printPath(start, P);
	printf("\n");

	system("pause");
	return 0;
}