/* ���� �ӵ� �� ���α׷� */
//�����, ����, �ð�, �����Ҵ��� ���� ��� ����
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <malloc.h>
//�ִ밳�� 10��, �� ���� ��ȯ �Լ� SWAP
#define MAX_SIZE 100000
#define SWAP(x, y, t) ((t)=(x), (x)=(y), (y)=(t))
//������Ŀ� �ʿ��� �ڸ���(DIGIT) �� n����(BUCKET)
#define BUCKET 10
#define DIGIT 6

/* �������Ľ� �ʿ��� ����Ʈ��(�迭) ����� ���� �ڷ��� */
typedef struct{
	//����Ʈ�� ����� ��
	int heap[MAX_SIZE];
	//����Ʈ���� ũ��
	int heap_size;
}HeapType;
/* ������Ľ� �ʿ��� ť ��� ����� ���� �ڷ��� */
typedef struct QueueNode{
	//ť ����� ��
	int item;
	//���� ť�� ����Ű�� ������
	struct QueueNode *link;
}QueueNode;
/* ������Ľ� �ʿ��� ť ����/�Ĵ� ������ ����� ���� �ڷ��� */
typedef struct{
	QueueNode *front, *rear;
}QueueType;

//���� �߻� �� �����ϴ� ����
int list[MAX_SIZE];
//���� ������ ���� ����
int temp[MAX_SIZE];
//�պ� ���Ľ� �ʿ��� ����
int sorted[MAX_SIZE];
//�ڷ��� ������ �����ϴ� ����
int n;

/* ���� ���� �Լ� */
//������ �迭�� �ڷ��� ������ ���ڷ� ����
void selection_sort(int list[], int n)
{
	//�ݺ��� �ʿ��� ����, �ּҰ� �ε���, �ӽ� ���� ���� ����
	int i, j, least, temp;
	//0��°~������ ���� ���� �ݺ�
	for(i=0;i<n-1;i++){
		//�ּҰ��� �ݺ��� �����ϴ� i��° ������ ����
		least=i;
		//�ּҰ��� j��° ������ ũ�� �ּҰ��� j��° ������ ����
		for(j=i+1;j<n;j++)
			if(list[j]<list[least])
				least=j;
		//i��° ���� �ּҰ� �ε����� �ִ� ���� ���� �ٲ�
		SWAP(list[i], list[least], temp);
	}
}
/* ���� ���� �Լ� */
//������ �迭�� �ڷ��� ������ ���ڷ� ����
void insertion_sort(int list[], int n)
{
	//�ݺ��� �ʿ��� ����, �񱳰� ����
	int i, j, key;
	//�ι�°~��������° ������ �ݺ�
	for(i=1;i<n;i++){
		//�񱳰��� i��° �� ����
		key=list[i];
		//j��°���� i-1��°���� j��° ���� �񱳰� ���� ũ�ٸ� j+1��° ���� j��° �� ���� �ݺ�
		for(j=i-1;j>=0 && list[j]>key;j--)
			list[j+1]=list[j];
		//j+1��° ���� �񱳰� ����
		list[j+1]=key;
	}
}
/* ���� ���� �Լ� */
//������ �迭�� �ڷ��� ������ ���ڷ� ����
void bubble_sort(int list[], int n)
{
	//�ݺ��� �ʿ��� ����, �ӽ� ���� ���� ����
	int i, j, temp;
	//n-1��° ���� 1��° ���� �ݺ�
	for(i=n-1;i>0;i--){
		//0��° ���� i-1��° ���� �ݺ�
		for(j=0;j<i;j++)
			//j��° ���� j+1��° ������ ũ�ٸ� �� �� ��ȯ
			if(list[j]>list[j+1])
				SWAP(list[j], list[j+1], temp);
	}
}
/* �� ������ ���� ���� ���� �Լ� */
//������ �迭, ù��° �ε���, ������ �ε���, ���� ������ ���̸� ���ڷ� ����
void inc_insertion_sort(int list[], int first, int last, int gap)
{
	//�ݺ��� �ʿ��� ����, �񱳰� ����
	int i, j, key;
	//gap���� �������� ���������� �ݺ�
	for(i=first+gap;i<=last;i=i+gap){
		//�� ���� i��° �� ����
		key=list[i];
		//gap���� �������� j�� ù��° ������ ũ�� �񱳰��� j��° ������ ���� ���� j+gap��° ���� j��° ������ ���� �ݺ�
		for(j=i-gap;j>=first && key<list[j];j=j-gap)
			list[j+gap]=list[j];
		//j+gap��° ���� �񱳰����� �ٲ�
		list[j+gap]=key;
	}
}

/* �� ���� �Լ� */
//������ �迭, �ڷ��� ������ ���ڷ� ����
void shell_sort(int list[], int n)
{
	//�ݺ� ����, ���� ���� ���� ����
	int i, gap;
	//gap�� �ڷᰳ��/2���� ������ 2�� �����鼭 0���� Ŭ ���� �ݺ�
	for(gap=n/2;gap>0;gap=gap/2){
		//gap�� ¦���̸� 1�߰�
		if((gap%2)==0) gap++;
		//i��°~n-1��°���� gap���̸�ŭ �������� �ݺ�
		for(i=0;i<gap;i++)
			inc_insertion_sort(list, i, n-1, gap);
	}
}
/* �պ� ���� �� �ʿ��� ���� �Լ� */
//������ �迭, ���� �ε���. �߰� �ε���, ���� �ε����� ���ڷ� ����
void merge(int list[], int left, int mid, int right)
{
	//�� �Ǵ� �ݺ� ����
	int i, j, k, l;
	//�� ������ ���� ����
	i=left; j=mid+1; k=left;

	//���� �ε����� �߰� �ε���, �߰� �ε����� ���� �ε��� ���� ���� ���� �ݺ�
	while(i<=mid && j<=right){
		//i��° ���� j��° �ش��ϴ� ������ ũ�� ���ο� �迭�� i��° �� ���� �� 1����
		if(list[i]<=list[j])
			sorted[k++]=list[i++];
		//�׷��� �ʴٸ� ���ο� �迭�� j��° �� ���� �� 1����
		else
			sorted[k++]=list[j++];
	}
	//i�� mid���� ũ�ٸ� j~��������° ���� ���ο� �迭�� ����
	if(i>mid)
		for(l=j;l<=right;l++)
			sorted[k++]=list[l];
	//�׷��� �ʴٸ� i~mid��° ���� ���ο� �迭�� ����
	else
		for(l=i;l<=mid;l++)
			sorted[k++]=list[l];
	//���ĵ� �迭�� ���� �迭�� ����
	for(l=left;l<=right;l++)
		list[l]=sorted[l];
}
/* �պ� ���� �Լ� */
//������ �迭, ���� �ε���, ���� �ε����� ���ڷ� ����
void merge_sort(int list[], int left, int right)
{
	//�߰� �ε��� ����
	int mid;
	//���� �ε����� ���� �ε������� �۴ٸ�
	if(left<right){
		//�߰� �ε��� ���
		mid=(left+right)/2;
		//���� �ε������� �߰� �ε��� ���� �պ����� ����
		merge_sort(list, left, mid);
		//�߰� �ε������� ���� �ε��� ���� �պ����� ����
		merge_sort(list, mid+1, right);
		//�����Լ� ����
		merge(list, left, mid, right);
	}
}
/* �� ������ ���� ��Ƽ�� �Լ�*/
//������ �迭, ���� �ε���, ���� �ε����� ���ڷ� ����
int partition(int list[], int left, int right)
{
	//����, �ӽ� ��, �ּ�, �ִ� ���� ����
	int pivot, temp;
	int low, high;

	//low�� ���� �ε��� ����, high�� ���� �ε���+1 ����
	low=left;
	high=right+1;
	//���ؿ� �迭�� ���� �ε����� �� ����
	pivot=list[left];
	//low�� high���� ���� ���� ���� �ݺ�
	do{
		//low�� ���� �ε������� �۰ų� ���� low��° ���� ���ذ����� ���� ���� low 1�� ����
		do
			low++;
		while(low<=right && list[low]<pivot);
		//high�� ���� �ε������� ũ�ų� ���� high��° ���� ���ذ����� ū ���� high 1�� ����
		do
			high--;
		while(high>=left && list[high]>pivot);
		//low�� high���� �۴ٸ� low��° ���� high��° ���� ���� �ٲ�
		if(low<high) SWAP(list[low], list[high], temp);
	}while(low<high);

	//���� �ε����� �ش�Ǵ� ���� high��° ���� ���� �ٲ�
	SWAP(list[left], list[high], temp);
	//�ǹ� ��ġ high ��ȯ
	return high;
}
/* �� ���� �Լ� */
//������ �迭, ���� �ε���, ���� �ε����� ���ڷ� ����
void quick_sort(int list[], int left, int right)
{
	//���� �ε����� ���� �ε������� �۴ٸ�
	if(left<right){
		//�ǹ� ��ġ ��ȯ�ϴ� ��Ƽ�� �Լ��� ���� �ǹ� ��ġ ����
		int q=partition(list, left, right);
		//���� �ε������� �ǹ� ��ġ ������ �� ����
		quick_sort(list, left, q-1);
		//�ǹ� ��ġ+1���� ���� �ε������� �� ����
		quick_sort(list, q+1, right);
	}
}
/* ���� ������ ���� ���� �ʱ�ȭ �Լ� */
void heap_init(HeapType *h)
{
	h->heap_size=0;
}
/* ���� ������ ���� ���� ���� �Լ� */
//���� Ʈ���� ������ ���� ���ڷ� ����
void insert_max_heap(HeapType *h, int item)
{
	//�� ���� ����
	int i;
	//i�� ���� Ʈ�� ũ��+1 ����
	i=++(h->heap_size);
	
	//i�� 1�� �ƴϰ� item�� i/2��° ������庸�� Ŭ ���� �ݺ�
	while((i!=1) && (item>h->heap[i/2])){
		//���� ����� ���� ����(i��° �� i/2��°)�ϰ� i�� 2�� ����
		h->heap[i]=h->heap[i/2];
		i/=2;
	}
	//i��° ���� ��忡 item ����
	h->heap[i]=item;
}
/* ���� ������ ���� ���� ���� �Լ� */
//���� Ʈ���� ���ڷ� ����
int delete_max_heap(HeapType *h)
{
	//�θ�, �ڽ� �ε��� ����
	int parent, child;
	//������ ����� �ڷ� �� �� �ӽ� �� ����
	int item, temp;

	//�ʱ� item���� ù��° ���� ����
	item=h->heap[1];
	//�ʱ� temp���� ������ ���� ������ ����ũ�⸦ 1 ����
	temp=h->heap[(h->heap_size)--];
	//�ʱ� �θ� �ε��� 1
	parent=1;
	//�ʱ� �ڽ� �ε��� 2
	child=2;
	//�ڽ� �ε����� ����Ʈ�� ������ ����� �ʴµ��� �ݺ�
	while(child<=h->heap_size){
		//�ڽ� �ε����� ����Ʈ�� �������� �۰� �ڽ� �ε����� �ش�Ǵ� ���� �� ���� ������ �۴ٸ� �ڽ� �ε���+1 ��
		if((child<h->heap_size)&&(h->heap[child])<(h->heap[child+1]))
			child++;
		//temp�� �ڽ� �ε����� �ش�Ǵ� ������ ũ�ų� ���ٸ� �ݺ��� ����
		if(temp>=h->heap[child])
			break;
		//�θ� ��忡 �ڽ� ��� �� ����
		h->heap[parent]=h->heap[child];
		//�θ� �ε����� �ڽ� �ε����� �ٲ�
		parent=child;
		//�ڽ� �ε����� ���� �ڽ� �ε����� 2��� �ٲ�
		child*=2;
	}
	//�θ� ��忡 temp ����
	h->heap[parent]=temp;
	//item ��ȯ
	return item;
}
/* ���� ���� �Լ� */
//������ �迭, �ڷ��� ������ ���ڷ� ����
void heap_sort(int a[], int n)
{
	//�ݺ� ����
	int i;
	//����Ʈ��
	HeapType h;

	//����Ʈ�� �ʱ�ȭ
	heap_init(&h);
	//�ڷḦ ����Ʈ���� ����
	for(i=0;i<n;i++)
		insert_max_heap(&h, a[i]);
	//����Ʈ���� ���Ե� �ڷḦ �ٽ� �迭�� ����
	for(i=n-1;i>=0;i--)
		a[i]=delete_max_heap(&h);
}
/* ��� ������ ���� ť �ʱ�ȭ �Լ� */
void queue_init(QueueType *q)
{
	q->front=q->rear=NULL;
}
/* ��� ������ ���� ť ���� �Լ� */
int queue_is_empty(QueueType *q)
{
	return (q->front==NULL);
}
/* ��� ������ ���� ť ���� �Լ� */
//ť�� ���� ���� ���ڷ� ����
void enqueue(QueueType *q, int item)
{
	//ť �����Ҵ�
	QueueNode *temp=(QueueNode *)malloc(sizeof(QueueNode));
	//ť�� �Ҵ���� ������ ����
	if(temp==NULL)
		exit(1);
	//�Ҵ� �Ǿ�����
	else{
		//�Ҵ�� ť�� �Է� �� ����, ������ ���Ե� ť�� ���� link�� NULL�� �ʱ�ȭ
		temp->item=item;
		temp->link=NULL;
		//ť�� ����ִ� �����̸� ���� �Ĵ� ��� ���� ť�� ����Ŵ
		if(queue_is_empty(q)){
			q->front=temp;
			q->rear=temp;
		}
		//�׷��� ������ �Ĵܸ� ���� ť�� ����Ŵ
		else{
			q->rear->link=temp;
			q->rear=temp;
		}
	}	
}
/* ��� ������ ���� ť ���� �Լ� */
//ť�� ���ڷ� ����
int dequeue(QueueType *q)
{
	//ť�� ù ��带 ����Ŵ
	QueueNode *temp=q->front;
	//������ ����� ���� �����ϴ� ����
	int item;
	//ť�� ����ִٸ� ����
	if(queue_is_empty(q))
		exit(1);
	//�׷��� ������
	else{
		//������ ����� ���� item�� ����
		item=temp->item;
		//������ ����Ű�� ť�� ���� ������ �ִ� ť�� �ٲ�
		q->front=q->front->link;
		//������ ����Ű�� ť�� ��������� �Ĵ��� ����Ű�� ť�� ����ְ� ��
		if(q->front==NULL)
			q->rear=NULL;
		//ť �����Ҵ� ����
		free(temp);
		//item ��ȯ
		return item;
	}
}
/* ��� ���� �Լ� */
//������ �迭, �ڷ� ������ ���ڷ� ����
void radix_sort(int list[], int n)
{
	//�ݺ� ���� ����
	int i, b, d, factor=1;
	//��� ���� �� �ʿ��� ť�� ������ ���� ���� ��ŭ ����
	QueueType queue[BUCKET];

	//ť �ʱ�ȭ
	for(b=0;b<BUCKET;b++) queue_init(&queue[b]);
	//�ڸ�����ŭ �ݺ�
	for(d=0;d<DIGIT;d++){
		//�ڷ� ���� ��ŭ ���� �ڸ����� �ش� �Ǵ� ť�� ���� �ݺ�
		for(i=0;i<n;i++)
			enqueue(&queue[((list[i]/factor)%10)], list[i]);
		//���� ��ŭ ť ���� ���� �����ϴ� ���� �迭�� ������ �� ����
		for(b=i=0;b<BUCKET;b++)
			while(!queue_is_empty(&queue[b]))
				list[i++]=dequeue(&queue[b]);
		//�ڸ����� �ϳ��� �÷���
		factor*=10;
	}
}
/* ���� ��� �ռ� */
//���ĵ� �迭, �ڷ� ������ ���ڷ� ����
void print(int list[], int n)
{
	//�ݺ� ����
	int i;
	//�ڷ� ���
	for(i=0;i<n;i++)
		printf("%d\n", list[i]);
}
/* ���� �迭 �ʱ�ȭ �Լ� */
void rand_init(int list[], int temp[], int n)
{
	//�ݺ� ����
	int i;
	//������ �迭 �ʱ�ȭ
	for(i=0;i<n;i++)
		temp[i]=list[i];
}

int main(void)
{
	//�ݺ� ����, �ڷ� ���� ���� ����
	int i, r;
	//�ð� ������ ���� ����
	clock_t start, finish;
	double duration;
	//�ڷ��� �ִ� ���� ����
	n=MAX_SIZE;

	//���� ����
	srand((unsigned)time(NULL));

	for(i=0;i<n;i++)
		//������ ������ 1~10������ �ϱ� ���� rand�Լ����� ������ ���� ����
		list[i]=(rand()+rand()+rand()+rand()%1699)+1;
	printf("���� ���� �Ϸ� \n");
	
	//11�� �ԷµǱ� �������� ���� �ݺ�
	while(1){
		//�ڷ� ���� �Է� �ޱ�
		printf("�� ���� ���� �����Ͻðڽ��ϱ�?(1~10����, �������� ����, ����� 11) : ");
		scanf("%d", &r);
		//11�̸� �ݺ��� ����
		if(r==11)
			break;
		//1~10�� �Է°��̸� �Է°��� �������� �ڷ� ���� ����
		else if(r>=1 && r<=10){
			n=r*MAX_SIZE/10;
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//���� ���� ���� �� �ð� ����
			printf("���� ����(%d����)\n", r);
			start=clock();
			selection_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("���� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//���� ���� ���� �� �ð� ����
			printf("���� ����(%d����)\n", r);
			start=clock();
			insertion_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("���� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//���� ���� ���� �� �ð� ����
			printf("���� ����(%d����)\n", r);
			start=clock();
			bubble_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("���� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//�� ���� ���� �� �ð� ����
			printf("�� ����(%d����)\n", r);
			start=clock();
			shell_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("�� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//�պ� ���� ���� �� �ð� ����
			printf("�պ� ����(%d����)\n", r);
			start=clock();
			merge_sort(temp, 0, n-1);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("�պ� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//�� ���� ���� �� �ð� ����
			printf("�� ����(%d����)\n", r);
			start=clock();
			quick_sort(temp, 0, n-1);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("�� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//�� ���� ���� �� �ð� ����
			printf("�� ����(%d����)\n", r);
			start=clock();
			heap_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("�� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//������ �迭�� ���� �� ����
			rand_init(list, temp, n);
			//��� ���� ���� �� �ð� ����
			printf("��� ����(%d����)\n", r);
			start=clock();
			radix_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("��� ���Ľ� �ɸ� �ð��� %g���Դϴ�.\n", duration);
			system("pause");
			//���� �Է°��� ���� input �ʱ�ȭ
			fflush(stdin);
		}
		//�� ���� �� �Է½ÿ� ��� �� �ݺ�
		else{
			printf("�Է� ������ ������ϴ�. �ٽ� �Է����ּ���.\n");
			////���� �Է°��� ���� input �ʱ�ȭ
			fflush(stdin);
			system("pause");
			system("cls");
		}
	}
	return 0;
}