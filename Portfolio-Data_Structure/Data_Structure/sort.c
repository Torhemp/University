/* 정렬 속도 비교 프로그램 */
//입출력, 문자, 시간, 동적할당을 위한 헤더 파일
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <malloc.h>
//최대개수 10만, 두 변수 교환 함수 SWAP
#define MAX_SIZE 100000
#define SWAP(x, y, t) ((t)=(x), (x)=(y), (y)=(t))
//기수정렬에 필요한 자리수(DIGIT) 및 n진수(BUCKET)
#define BUCKET 10
#define DIGIT 6

/* 히프정렬시 필요한 히프트리(배열) 사용자 정의 자료형 */
typedef struct{
	//히프트리 노드의 값
	int heap[MAX_SIZE];
	//히프트리의 크기
	int heap_size;
}HeapType;
/* 기수정렬시 필요한 큐 노드 사용자 정의 자료형 */
typedef struct QueueNode{
	//큐 노드의 값
	int item;
	//다음 큐를 가리키는 포인터
	struct QueueNode *link;
}QueueNode;
/* 기수정렬시 필요한 큐 선단/후단 포인터 사용자 정의 자료형 */
typedef struct{
	QueueNode *front, *rear;
}QueueType;

//난수 발생 후 저장하는 공간
int list[MAX_SIZE];
//난수 정렬을 위한 공간
int temp[MAX_SIZE];
//합병 정렬시 필요한 공간
int sorted[MAX_SIZE];
//자료의 개수를 결정하는 변수
int n;

/* 선택 정렬 함수 */
//정렬할 배열과 자료의 개수를 인자로 받음
void selection_sort(int list[], int n)
{
	//반복에 필요한 변수, 최소값 인덱스, 임시 저장 변수 선언
	int i, j, least, temp;
	//0번째~마지막 전값 까지 반복
	for(i=0;i<n-1;i++){
		//최소값을 반복을 시작하는 i번째 값으로 지정
		least=i;
		//최소값이 j번째 값보다 크면 최소값을 j번째 값으로 지정
		for(j=i+1;j<n;j++)
			if(list[j]<list[least])
				least=j;
		//i번째 값과 최소값 인덱스에 있는 값을 서로 바꿈
		SWAP(list[i], list[least], temp);
	}
}
/* 삽입 정렬 함수 */
//정렬할 배열과 자료의 개수를 인자로 받음
void insertion_sort(int list[], int n)
{
	//반복에 필요한 변수, 비교값 선언
	int i, j, key;
	//두번째~마지막번째 값까지 반복
	for(i=1;i<n;i++){
		//비교값에 i번째 값 대입
		key=list[i];
		//j번째에서 i-1번째까지 j번째 값이 비교값 보다 크다면 j+1번째 값에 j번째 값 대입 반복
		for(j=i-1;j>=0 && list[j]>key;j--)
			list[j+1]=list[j];
		//j+1번째 값에 비교값 대입
		list[j+1]=key;
	}
}
/* 버블 정렬 함수 */
//정렬할 배열과 자료의 개수를 인자로 받음
void bubble_sort(int list[], int n)
{
	//반복에 필요한 변수, 임시 저장 변수 선언
	int i, j, temp;
	//n-1번째 부터 1번째 까지 반복
	for(i=n-1;i>0;i--){
		//0번째 부터 i-1번째 까지 반복
		for(j=0;j<i;j++)
			//j번째 값이 j+1번째 값보다 크다면 두 값 교환
			if(list[j]>list[j+1])
				SWAP(list[j], list[j+1], temp);
	}
}
/* 쉘 정렬을 위한 삽입 정렬 함수 */
//정렬할 배열, 첫번째 인덱스, 마지막 인덱스, 변수 간격의 차이를 인자로 받음
void inc_insertion_sort(int list[], int first, int last, int gap)
{
	//반복에 필요한 변수, 비교값 선언
	int i, j, key;
	//gap차이 간격으로 마지막까지 반복
	for(i=first+gap;i<=last;i=i+gap){
		//비교 값에 i번째 값 대입
		key=list[i];
		//gap차이 간격으로 j가 첫번째 값보다 크고 비교값이 j번째 값보다 작은 동안 j+gap번째 값을 j번째 값으로 변경 반복
		for(j=i-gap;j>=first && key<list[j];j=j-gap)
			list[j+gap]=list[j];
		//j+gap번째 값을 비교값으로 바꿈
		list[j+gap]=key;
	}
}

/* 쉘 정렬 함수 */
//정렬할 배열, 자료의 개수를 인자로 받음
void shell_sort(int list[], int n)
{
	//반복 변수, 간격 차이 변수 선언
	int i, gap;
	//gap을 자료개수/2에서 시작해 2로 나누면서 0보다 클 동안 반복
	for(gap=n/2;gap>0;gap=gap/2){
		//gap이 짝수이면 1추가
		if((gap%2)==0) gap++;
		//i번째~n-1번째까지 gap차이만큼 삽입정렬 반복
		for(i=0;i<gap;i++)
			inc_insertion_sort(list, i, n-1, gap);
	}
}
/* 합병 정렬 시 필요한 머지 함수 */
//정렬할 배열, 좌측 인덱스. 중간 인덱스, 우측 인덱스를 인자로 받음
void merge(int list[], int left, int mid, int right)
{
	//비교 또는 반복 변수
	int i, j, k, l;
	//각 변수에 인자 대입
	i=left; j=mid+1; k=left;

	//좌측 인덱스가 중간 인덱스, 중간 인덱스가 우측 인덱스 보다 작은 동안 반복
	while(i<=mid && j<=right){
		//i번째 값이 j번째 해당하는 값보다 크면 새로운 배열에 i번째 값 대입 후 1증가
		if(list[i]<=list[j])
			sorted[k++]=list[i++];
		//그렇지 않다면 새로운 배열에 j번째 값 대입 후 1증가
		else
			sorted[k++]=list[j++];
	}
	//i가 mid보다 크다면 j~마지막번째 값을 새로운 배열에 대입
	if(i>mid)
		for(l=j;l<=right;l++)
			sorted[k++]=list[l];
	//그렇지 않다면 i~mid번째 값을 새로운 배열에 대입
	else
		for(l=i;l<=mid;l++)
			sorted[k++]=list[l];
	//정렬된 배열을 원래 배열에 대입
	for(l=left;l<=right;l++)
		list[l]=sorted[l];
}
/* 합병 정렬 함수 */
//정렬할 배열, 좌측 인덱스, 우측 인덱스를 인자로 받음
void merge_sort(int list[], int left, int right)
{
	//중간 인덱스 선언
	int mid;
	//좌측 인덱스가 우측 인덱스보다 작다면
	if(left<right){
		//중간 인덱스 계산
		mid=(left+right)/2;
		//좌측 인덱스부터 중간 인덱스 까지 합병정렬 실행
		merge_sort(list, left, mid);
		//중간 인덱스부터 우측 인덱스 까지 합병정렬 실행
		merge_sort(list, mid+1, right);
		//머지함수 실행
		merge(list, left, mid, right);
	}
}
/* 퀵 정렬을 위한 파티션 함수*/
//정렬할 배열, 좌측 인덱스, 우측 인덱스를 인자로 받음
int partition(int list[], int left, int right)
{
	//기준, 임시 값, 최소, 최대 변수 선언
	int pivot, temp;
	int low, high;

	//low에 좌측 인덱스 대입, high에 우측 인덱스+1 대입
	low=left;
	high=right+1;
	//기준에 배열의 좌측 인덱스의 값 대입
	pivot=list[left];
	//low가 high보다 작은 동안 까지 반복
	do{
		//low가 우측 인덱스보다 작거나 같고 low번째 값이 기준값보다 작은 동안 low 1씩 증가
		do
			low++;
		while(low<=right && list[low]<pivot);
		//high가 좌측 인덱스보다 크거나 같고 high번째 값이 기준값보다 큰 동안 high 1씩 감소
		do
			high--;
		while(high>=left && list[high]>pivot);
		//low가 high보다 작다면 low번째 값과 high번째 값을 서로 바꿈
		if(low<high) SWAP(list[low], list[high], temp);
	}while(low<high);

	//좌측 인덱스에 해당되는 값과 high번째 값을 서로 바꿈
	SWAP(list[left], list[high], temp);
	//피벗 위치 high 반환
	return high;
}
/* 퀵 정렬 함수 */
//정렬할 배열, 좌측 인덱스, 우측 인덱스를 인자로 받음
void quick_sort(int list[], int left, int right)
{
	//좌측 인덱스가 우측 인덱스보다 작다면
	if(left<right){
		//피벗 위치 반환하는 파티션 함수를 통해 피벗 위치 받음
		int q=partition(list, left, right);
		//좌측 인덱스부터 피벗 위치 전까지 퀵 정렬
		quick_sort(list, left, q-1);
		//피벗 위치+1부터 우측 인덱스까지 퀵 정렬
		quick_sort(list, q+1, right);
	}
}
/* 히프 정렬을 위한 히프 초기화 함수 */
void heap_init(HeapType *h)
{
	h->heap_size=0;
}
/* 히프 정렬을 위한 히프 삽입 함수 */
//히프 트리와 삽입할 수를 인자로 받음
void insert_max_heap(HeapType *h, int item)
{
	//비교 변수 선언
	int i;
	//i에 히프 트리 크기+1 대입
	i=++(h->heap_size);
	
	//i가 1이 아니고 item이 i/2번째 히프노드보다 클 동안 반복
	while((i!=1) && (item>h->heap[i/2])){
		//히프 노드의 값을 변경(i번째 와 i/2번째)하고 i를 2로 나눔
		h->heap[i]=h->heap[i/2];
		i/=2;
	}
	//i번째 히프 노드에 item 대입
	h->heap[i]=item;
}
/* 히프 정렬을 위한 히프 삭제 함수 */
//히프 트리를 인자로 받음
int delete_max_heap(HeapType *h)
{
	//부모, 자식 인덱스 선언
	int parent, child;
	//삭제할 노드의 자료 값 및 임시 값 변수
	int item, temp;

	//초기 item값을 첫번째 노드로 지정
	item=h->heap[1];
	//초기 temp값을 마지막 노드로 지정후 히프크기를 1 줄임
	temp=h->heap[(h->heap_size)--];
	//초기 부모 인덱스 1
	parent=1;
	//초기 자식 인덱스 2
	child=2;
	//자식 인덱스가 히프트리 범위를 벗어나지 않는동안 반복
	while(child<=h->heap_size){
		//자식 인덱스가 히프트리 범위보다 작고 자식 인덱스에 해당되는 값이 그 다음 값보다 작다면 자식 인덱스+1 함
		if((child<h->heap_size)&&(h->heap[child])<(h->heap[child+1]))
			child++;
		//temp가 자식 인덱스에 해당되느 값보다 크거나 같다면 반복문 종료
		if(temp>=h->heap[child])
			break;
		//부모 노드에 자식 노드 값 대입
		h->heap[parent]=h->heap[child];
		//부모 인덱스가 자식 인덱스로 바뀜
		parent=child;
		//자식 인덱스는 원래 자식 인덱스의 2배로 바뀜
		child*=2;
	}
	//부모 노드에 temp 대입
	h->heap[parent]=temp;
	//item 반환
	return item;
}
/* 히프 정렬 함수 */
//정렬할 배열, 자료의 개수를 인자로 받음
void heap_sort(int a[], int n)
{
	//반복 변수
	int i;
	//히프트리
	HeapType h;

	//히프트리 초기화
	heap_init(&h);
	//자료를 히프트리에 삽입
	for(i=0;i<n;i++)
		insert_max_heap(&h, a[i]);
	//히프트리에 삽입된 자료를 다시 배열에 넣음
	for(i=n-1;i>=0;i--)
		a[i]=delete_max_heap(&h);
}
/* 기수 정렬을 위한 큐 초기화 함수 */
void queue_init(QueueType *q)
{
	q->front=q->rear=NULL;
}
/* 기수 정렬을 위한 큐 공백 함수 */
int queue_is_empty(QueueType *q)
{
	return (q->front==NULL);
}
/* 기수 정렬을 위한 큐 삽입 함수 */
//큐와 넣을 값을 인자로 받음
void enqueue(QueueType *q, int item)
{
	//큐 동적할당
	QueueNode *temp=(QueueNode *)malloc(sizeof(QueueNode));
	//큐가 할당되지 않으면 종료
	if(temp==NULL)
		exit(1);
	//할당 되었으면
	else{
		//할당된 큐에 입력 값 넣음, 다음에 삽입될 큐를 위해 link를 NULL로 초기화
		temp->item=item;
		temp->link=NULL;
		//큐가 비어있는 상태이면 전단 후단 모두 삽입 큐를 가리킴
		if(queue_is_empty(q)){
			q->front=temp;
			q->rear=temp;
		}
		//그렇지 않으면 후단만 삽입 큐를 가리킴
		else{
			q->rear->link=temp;
			q->rear=temp;
		}
	}	
}
/* 기수 정렬을 위한 큐 삭제 함수 */
//큐를 인자로 받음
int dequeue(QueueType *q)
{
	//큐의 첫 노드를 가리킴
	QueueNode *temp=q->front;
	//삭제될 노드의 값을 저장하는 변수
	int item;
	//큐가 비어있다면 종료
	if(queue_is_empty(q))
		exit(1);
	//그렇지 않으면
	else{
		//삭제할 노드의 값을 item에 대입
		item=temp->item;
		//전단이 가리키는 큐를 전단 다음에 있는 큐로 바꿈
		q->front=q->front->link;
		//전단이 가리키는 큐가 비어있으면 후단이 가리키는 큐도 비어있게 함
		if(q->front==NULL)
			q->rear=NULL;
		//큐 동적할당 해제
		free(temp);
		//item 반환
		return item;
	}
}
/* 기수 정렬 함수 */
//정렬할 배열, 자료 개수를 인자로 받음
void radix_sort(int list[], int n)
{
	//반복 변수 선언
	int i, b, d, factor=1;
	//기수 정렬 시 필요한 큐를 진수의 숫자 종류 만큼 선언
	QueueType queue[BUCKET];

	//큐 초기화
	for(b=0;b<BUCKET;b++) queue_init(&queue[b]);
	//자릿수만큼 반복
	for(d=0;d<DIGIT;d++){
		//자료 개수 만큼 값의 자릿수에 해당 되는 큐에 삽입 반복
		for(i=0;i<n;i++)
			enqueue(&queue[((list[i]/factor)%10)], list[i]);
		//진수 만큼 큐 내에 값이 존재하는 동안 배열에 정렬한 값 대입
		for(b=i=0;b<BUCKET;b++)
			while(!queue_is_empty(&queue[b]))
				list[i++]=dequeue(&queue[b]);
		//자릿수를 하나씩 늘려감
		factor*=10;
	}
}
/* 정렬 출력 합수 */
//정렬된 배열, 자료 개수를 인자로 받음
void print(int list[], int n)
{
	//반복 변수
	int i;
	//자료 출력
	for(i=0;i<n;i++)
		printf("%d\n", list[i]);
}
/* 정렬 배열 초기화 함수 */
void rand_init(int list[], int temp[], int n)
{
	//반복 변수
	int i;
	//정렬할 배열 초기화
	for(i=0;i<n;i++)
		temp[i]=list[i];
}

int main(void)
{
	//반복 변수, 자료 개수 결정 변수
	int i, r;
	//시간 측정을 위한 변수
	clock_t start, finish;
	double duration;
	//자료의 최대 범위 지정
	n=MAX_SIZE;

	//난수 생성
	srand((unsigned)time(NULL));

	for(i=0;i<n;i++)
		//난수의 범위를 1~10만으로 하기 위해 rand함수들을 적당히 더해 대입
		list[i]=(rand()+rand()+rand()+rand()%1699)+1;
	printf("난수 생성 완료 \n");
	
	//11이 입력되기 전까지는 무한 반복
	while(1){
		//자료 개수 입력 받기
		printf("몇 개의 값을 정렬하시겠습니까?(1~10만개, 만개단위 가능, 종료는 11) : ");
		scanf("%d", &r);
		//11이면 반복문 종료
		if(r==11)
			break;
		//1~10의 입력값이면 입력값을 바탕으로 자료 개수 지정
		else if(r>=1 && r<=10){
			n=r*MAX_SIZE/10;
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//선택 정렬 실행 및 시간 측정
			printf("선택 정렬(%d만개)\n", r);
			start=clock();
			selection_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("선택 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//삽입 정렬 실행 및 시간 측정
			printf("삽입 정렬(%d만개)\n", r);
			start=clock();
			insertion_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("삽입 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//버블 정렬 실행 및 시간 측정
			printf("버블 정렬(%d만개)\n", r);
			start=clock();
			bubble_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("버블 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//쉘 정렬 실행 및 시간 측정
			printf("쉘 정렬(%d만개)\n", r);
			start=clock();
			shell_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("쉘 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//합병 정렬 실행 및 시간 측정
			printf("합병 정렬(%d만개)\n", r);
			start=clock();
			merge_sort(temp, 0, n-1);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("합병 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//퀵 정렬 실행 및 시간 측정
			printf("퀵 정렬(%d만개)\n", r);
			start=clock();
			quick_sort(temp, 0, n-1);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("퀵 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//힙 정렬 실행 및 시간 측정
			printf("힙 정렬(%d만개)\n", r);
			start=clock();
			heap_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("힙 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//정렬할 배열에 난수 값 대입
			rand_init(list, temp, n);
			//기수 정렬 실행 및 시간 측정
			printf("기수 정렬(%d만개)\n", r);
			start=clock();
			radix_sort(temp, n);
			finish=clock();
			duration=(double)(finish-start);
			//print(temp, n);
			printf("기수 정렬시 걸린 시간은 %g초입니다.\n", duration);
			system("pause");
			//다음 입력값을 위한 input 초기화
			fflush(stdin);
		}
		//그 외의 값 입력시에 경고문 및 반복
		else{
			printf("입력 범위가 벗어났습니다. 다시 입력해주세요.\n");
			////다음 입력값을 위한 input 초기화
			fflush(stdin);
			system("pause");
			system("cls");
		}
	}
	return 0;
}