#include <stdio.h>
#include <stdlib.h>
//���� ����
#define CITYCOUNT 12
//���Ѵ�
#define INF 1000

//������ ǥ���ϱ� ���� ����ü
typedef struct edge{
	//��� ����
	int start;
	//���� ����
	int finish;
	//����ġ
	int weight;
}edge;

//������ ���� ���, �࿡�� ���� ���� ������ ����ġ
int W[CITYCOUNT+1][CITYCOUNT+1]={
//   X ���� ��õ ���� û�� õ�� ���� ���� ���� �뱸 ���� ��� �λ�
	{0, 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0  }, // X
	{0, 0,   3,	  5,   8,   INF, INF, INF, INF, INF, INF, INF, INF}, //����
	{0, 7,   0,   INF, INF, 1,   INF, INF, INF, INF, INF, INF, INF}, //��õ
	{0, 3,   INF, 0,   INF, INF, 3,   INF, INF, INF, INF, INF, INF}, //����
	{0, 13,  INF, INF, 0,   3,   1,   INF, 2,   INF, INF, INF, INF}, //û��
	{0, INF, 3,   INF, 4,   0,   INF, 4,   INF, INF, INF, INF, INF}, //õ��
	{0, INF, INF, 5,   2,   INF, 0,   INF, 5,   INF, INF, INF, INF}, //����
	{0, INF, INF, INF, INF, 5,   INF, 0,   5,   3,   3,   INF, INF}, //����
	{0, INF, INF, INF, 2,   INF, 3,   5,   0,   3,   INF, 3,   INF}, //����
	{0, INF, INF, INF, 6,   INF, INF, 6,   INF, 0,   INF, 2,   1  }, //�뱸
	{0, INF, INF, INF, INF, INF, INF, 3,   INF, 6,   0,   INF, 5  }, //����
	{0, INF, INF, INF, INF, INF, INF, INF, 1,   INF, INF, 0,   2  }, //���
	{0, INF, INF, INF, INF, INF, INF, INF, INF, INF, 4,   3,   0  }  //�λ�
};
//�ذ� �Ǵ� ������ ����
edge F[CITYCOUNT+1]={0,};

//���� �̸� ǥ���� ���� 2���� �迭
char cityName[CITYCOUNT+1][10]={
	"Test", "Seoul", "Incheon",
	"Gangneung", "Cheonju", "Cheonan",
	"Donghae", "Daejeon", "Uljin",
	"Daegu", "Gwangju", "Ulsan", "Busan"
};

//���ͽ�Ʈ�� �˰���
void dijkstra(const int W[][13], edge F[]){

	int i, j, vnear;
	int touch[CITYCOUNT+1];
	int length[CITYCOUNT+1];

	//touch, length �ʱⰪ ����
	for(i=2;i<=CITYCOUNT;++i){
		touch[i]=1;
		length[i]=W[1][i];
	}

	for(j=0;j<CITYCOUNT-1;++j){
		int min = INF;
		//����ġ�� �ּҰ��� ������ ����� ������ ���
		for(i=2;i<=CITYCOUNT;++i)
			if(length[i]>=0 && length[i]<min){
				min = length[i];
				vnear = i;
			}
		//������ ���� ����
		F[j+1].start=touch[vnear];
		F[j+1].finish=vnear;
		F[j+1].weight=W[F[j+1].start][F[j+1].finish];
		//touch, length ���� ������Ʈ
		for(i=2;i<=CITYCOUNT;++i)
			if(length[vnear]+W[vnear][i]<length[i]){
				length[i]=length[vnear]+W[vnear][i];
				touch[i]=vnear;
			}
		//����� ���� ǥ��
		length[vnear]=-1;
	}
}

//��� ��� �Լ�
//���������� ��������� �ּҷ� ����� �������� ���������κ��� ��� �Ͽ� ���� �� ��� ���
void printPath(int start, int finish, edge F[]){

	//�ε��� ����, ��� ������ �ε���, ����� �� ����ġ, ��θ� ��ġ�� ���� ����
	int i, init=0, sum=0, vec[CITYCOUNT]={0,};
	printf("��� : ");
	//���� �������� ���� ���
	for(i=1;i<=CITYCOUNT;++i)
		if(F[i].finish==finish){
			init=i;
			break;
		}
	//��� ��ġ�� ������ �����ϱ� ���� �ݺ� ����
	i=CITYCOUNT-1;
	while(1){
		//������ ���� ���� ���� �� ����ġ �� ����
		vec[i]=F[init].finish;
		sum+=F[init].weight;
		//��� ��ġ�� ������ �ε��� ����
		--i;
		//����� ���� �� ����� ���� ������ �ݺ��� ����
		if(F[init].start==start){
			vec[i]=F[init].start;
			break;
		}
		//������ ������ ����(��� ����) ã��
		else{
			for(i=1;i<=CITYCOUNT;++i)
				if(F[i].finish==F[init].start){
					init=i;
					break;
				}
		}
	}
	//����� ���� ���
	for(i=0;i<CITYCOUNT;++i){
		if(vec[i]!=0)
			printf("%s ", cityName[vec[i]]);
	}
	//��� ���� ���
	printf("\n��� ���� : %d \n", sum);
}

//���� ���� �Լ�
void swap_i(int *a, int *b){
	int temp;
	temp=*a;
	*a=*b;
	*b=temp;
}

//������ ����� ���� ���� �Լ�
//������� 1(����)�� �ƴ� �ÿ� �ٲ�� ���� �ٽ� �����ֱ� ���� ���
void changeV(int start){
	int i;
	//���� ���� ��� �ε����� 1�� ���� �ٲ�
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
	//�ݺ� ����, �����, ������
	int i, start, finish;
	
	printf("Dijkstra �ִ� ��� ã��\n");
	printf("�� ���ô� �Ʒ��� ���ڿ� �����˴ϴ�. \n");
	printf("1-����, 2-��õ, 3-����, 4 -û��, 5 -õ��, 6 -���� \n");
	printf("7-����, 8-����, 9-�뱸, 10-����, 11-���, 12-�λ� \n");
	//���� �� �ִ� ����� �ε��� �Է�
	while(1){
		printf("������� �Է��ϼ���.(����) : ");
		scanf("%d", &start);
		if(start>CITYCOUNT || start<=0)
			printf("���� �ʰ�, �ٽ� �Է��� �ּ���(1~12)\n");
		else
			break;
	}
	//���� �� �ִ� ������ �ε��� �Է�
	while(1){
		printf("�������� �Է��ϼ���.(����) : ");
		scanf("%d", &finish);
		if(finish>CITYCOUNT || finish<=0)
			printf("���� �ʰ�, �ٽ� �Է��� �ּ���(1~12)\n");
		else
			break;
	}
	//������� ������ �ƴϸ� ����� ������� �ε��� ���� �� ������� ����
	if(start!=1){
		for(i=1;i<=CITYCOUNT;++i){
			swap_i(&W[i][1], &W[i][start]);
		}
		for(i=1;i<=CITYCOUNT;++i){
			swap_i(&W[1][i], &W[start][i]);
		}
	}
	//���ͽ�Ʈ�� �˰��� ����
	dijkstra(W, F);
	//������� ������ �ƴϸ� ���� ��� �� ������ ����� �ε����� ���� �ε��� �� ���� ����
	if(start!=1)
		changeV(start);
	
	//��� ���
	printPath(start, finish, F);
	system("pause");
	return 0;
}