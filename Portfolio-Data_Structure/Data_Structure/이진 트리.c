#include <stdio.h>
#include <malloc.h>

//트리에서 노드에 해당되는 사용자 정의 구조체 선언 
typedef struct TreeNode{
    //노드에 있는 값에 해당되는 변수 
    int data;
    //트리의 왼쪽, 오른쪽 서브트리를 가리키는 포인터 
    struct TreeNode *left, *right;
} TreeNode;

//자료형 변환을 쉽게 하기 위한 노드의 사용자 정의 변수 선언
typedef TreeNode * element;

//큐 사용을 위한 사용자 정의 구조체 선언 
typedef struct QueueNode{
    //큐에 있는 값에 해당되는 변수
    element item;
    //다을 큐를 가리키는 포인터 
    struct QueueNode *link;
}QueueNode;

//큐의 전단, 후단을 가리키는 포인터 구조체 선언 
typedef struct{
    QueueNode *front, *rear;
}QueueType;

//큐 에러 출력 함수 
//메세지를 인자로 받음 
void error(char *message)
{
    //에러가 났을 시에 메세지 출력
    fprintf(stderr, "%s\n", message);
    system("pause");
    //프로그램 종료 
    exit(1);
}

//큐의 초기화 함수
//큐의 전단, 후단 구조체를 인자로 받음
void queue_init(QueueType *q) 
{
    //전단, 후단 모두 값이 없어짐으로서 큐를 초기화 시킴
    q->front=q->rear=NULL;
}

//큐의 공백 상태 확인 함수
int is_empty(QueueType *q)
{
    //전단이 비어있으면 1을 그렇지 않으면 0을 반환
    return (q->front==NULL); 
}

//큐 삽입 함수
//큐의 전단, 후단 구조체와 큐 값을 인자로 받음
void enqueue(QueueType *q, element item) 
{
    //삽입할 큐 동적할당
    QueueNode *temp=(QueueNode *)malloc(sizeof(QueueNode)); 
    //큐가 동적할당이 되지 않았다면
    if(temp==NULL) 
         //오류 메세지 출력 
         error("메모리를 할당할 수 없습니다. \n");
    else//할당이 되었다면 
    {
         //삽입할 큐에 값 복사 
         temp->item=item;
         //큐 삽입은 뒤에서 부터 되기 때문에 삽입된 큐의 다음 큐는 없으므로 링크는 비어있음 
         temp->link=NULL;
         //공백 큐라면 
         if(is_empty(q))
         {
              //전단은 삽입되는 큐를 가리킴 
              q->front=temp;
              //후단은 삽입되는 큐를 가리킴 
              q->rear=temp;
         }
         //공백 큐가 아니라면
         else
         {
              //있던 마지막 큐가 삽입될 큐를 가리킴 
              q->rear->link=temp;
              //후단은 삽입되는 큐를 가리킴 
              q->rear=temp;
         }
    }
}

//큐 삭제 함수
//큐의 전단, 후단 구조체를 인자로 받음 
element dequeue(QueueType *q)
{
    //큐의 삭제는 전단에서 이루어지므로 전단을 대입
    QueueNode *temp=q->front; 
    //삭제할 큐의 값 저장할 변수 
    element item;
    //공백 큐이면 
    if(is_empty(q))
         //오류 메세지 출력 
         error("큐가 비어 있습니다. \n");
    //공백 큐가 아니라면 
    else
    {
         //삭제할 큐의 값을 item에 저장
         item=temp->item;
         //전단 큐가 가리키는 다음 큐를 전단 큐로 변경 
         q->front=q->front->link;
         //전단 큐가 비어있으면 
         if(q->front==NULL)
              //후단 큐도 비워버린다.(공백 큐) 
              q->rear=NULL;
         //삭제된 큐 동적할당 해제 
         free(temp);
         //삭제된 큐의 값 반환 
         return item;
    }
}

//큐 삭제 없이 값을 꺼내는 함수
//큐의 전단, 후단 구조체를 인자로 받음
element queue_peek(QueueType *q)
{
    //큐가 비어있다면 
    if(is_empty(q))
         //오류 메세지 출력 
         error("큐가 비어 있습니다. \n");
    //비어있지 않다면
    else 
         //전단의 큐 값을 반환
         return q->front->item; 
} 

//트리노드 삽입 함수 
//트리 노드의 더블포인터, 삽입할 값을 인자로 받음 
void tree_insert_node(TreeNode **root, int key)
{
    //p는 부모노드를 가리키는 포인터, t는 탐색에 이용할 노드 포인터 
    TreeNode *p, *t;
    //n은 삽입할 노드 포인터 
    TreeNode *n;
    
    //루트노드부터 검색을 시작하기 위해 최초 탐색에 이용할 루트노드 지정 
    t=*root;
    //부모노드가 아직 없기 때문에 NULL을 대입 
    p=NULL;
    
    //삽입할 노드가 트리 내에 존재하는지 확인하는 검색 구문 
    //탐색할 노드가 존재하면 
    while(t!=NULL)
    {
         //탐색노드 값과 삽입할 값이 같으면 삽입함수 종료 
         if(key==t->data) return;
         //서브트리로 내려가기 전에 부모노드를 탐색노드로 교체 
         p=t;
         //삽입할 값이 부모노드값보다 작으면 왼쪽 서브트리로 이동 
         if(key<t->data) t=t->left;
         //그렇지 않으면 오른쪽 서브트리로 이동 
         else t=t->right;
    }
    
    //삽입할 노드 동적할당
    n=(TreeNode*)malloc(sizeof(TreeNode));
    //n이 가리키는 것이 없다면 동적할당이 되지 않았기 때문에 삽입함수 종료
    if(n==NULL) return;
    //삽입할 노드에 값 대입 
    n->data=key;
    //검색이 끝나고 삽입할 노드는 서브트리가 없는 노드이므로 좌, 우 포인터 모두 NULL로 지정
    n->left=n->right=NULL;
    
    //부모 노드와 삽입 노드 연결하기 
    //부모노드가 존재하면 
    if(p!=NULL)
         //삽입노드 데이터가 부모노드의 데이터보다 작으면 
         if(key<p->data)
              //부모노드 왼쪽에 연결 
              p->left=n;
         //그렇지 않으면 오른쪽에 연결 
         else p->right=n;
    //부모 노드가 존재하지 않는다는 것은 노드값이 없는 것이므로 루트 노드에 삽입
    else *root=n;
}

//트리노드 삭제 함수 
//트리 노드의 더블포인터, 삽입할 값을 인자로 받음 
void tree_delete_node(TreeNode **root, int key)
{
    //p는 부모노드를 가리키는 포인터, t는 탐색에 이용할 노드 포인터 및 삭제될 노드
    TreeNode *p, *t;
    //child는 자식 노드를 가리키는 포인터, succ는 후계자 노드 포인터, succ_p는 후계자 노드의 부모 노드 포인터 
    TreeNode *child, *succ, *succ_p;
    
    //부모노드가 아직 없기 때문에 NULL을 대입 
    p=NULL;
    //루트노드부터 검색을 시작하기 위해 최초 탐색에 이용할 루트노드 지정
    t=*root;
    
    //삭제할 노드가 트리내에 존재하는지 확인하는 검색 구문 
    while(t!=NULL && t->data!=key){
         //서브트리로 내려가기 전에 부모노드를 탐색노드로 교체
         p=t;
         //삽입할 값이 부모노드값보다 작으면 왼쪽 서브트리로 이동, 그렇지 않으면 오른쪽 서브트리로 이동 
         t=(key<t->data)?t->left:t->right;
    }
    
    //t가 값이 없는 것은 탐색이 끝났지만 삭제할 값을 못찾은 경우에 해당 
    if(t==NULL)
    {
         //값이 없다는 문장 출력 
         printf("key is not in the tree");
         //함수 종료 
         return;
    }
    
    //삭제할 노드가 단말 노드일 경우 
    if((t->left==NULL) && (t->right==NULL))
    {
         //부모노드가 존재한다면 
         if(p!=NULL)
         {
              //부모노드 왼쪽 노드가 탐색 노드면 
              if(p->left==t)
                   //노드 삭제 
                   p->left=NULL;
              //그렇지 않으면 오른쪽 노드 삭제 
              else p->right=NULL;
         }
         //부모노드가 없다면 루트노드 삭제 
         else
              *root=NULL;
    }
    
    //한쪽에 자식이 있을 경우 
    else if((t->left==NULL) || (t->right==NULL))
    {
         //삭제할 값의 왼쪽 노드가 존재하면 왼쪽노드를, 그렇지 않으면 오른쪽 노드를 대입 
         child=(t->left!=NULL)?t->left:t->right;
         //부모노드가 존재한다면 
         if(p!=NULL)
         {
              //부모노드의 왼쪽 노드가 존재하면  
              if(p->left==t)
                   //부모의 왼쪽노드의 자식노드 가져옴 
                   p->left=child;
              //그렇지 않으면 오른쪽 노드의 자식노드를 가져옴 
              else p->right=child;
         }
         //부모노드가 없다면 루트노드의 자식을 가져옴 
         else
              *root=child;
    }
    
    //양쪽 모두 자식 노드가 있을 경우      
    else
    {
         //후계자의 부모 노드에 삭제할 노드 대입 
         succ_p=t;
         //후계자 노드는 삭제 노드의 왼쪽 노드 대입 
         succ=t->left;
         //후계자 노드의 오른쪽 노드가 없을때 까지 반복 
         while(succ->right!=NULL)
         {
              //후계자 노드의 부모 노드를 후계자 노드로 변경 
              succ_p=succ;
              //후계자 노드는 후계자 노드의 오른쪽 노드로 변경 
              succ=succ->right;
         }
         
         //후계자 부모 노드의 오른쪽 노드가 후계자 노드이면 
         if(succ_p->right==succ)
              //후계자 부모 노드의 오른쪽 노드는 후계자 노드의 왼쪽 노드 대입 
              succ_p->right=succ->left;
         //그렇지 않으면      
         else
              //후계자 부모 노드의 왼쪽 노드는 후계자 노드의 왼쪽 노드 대입 
              succ_p->left=succ->left;
         //후계자 노드의 값을 삭제할 노드에 대입 
         t->data=succ->data;
         //삭제할 노드를 없애고 후계자 노드 대입 
         t=succ;
    }
    //삭제된 노드 동적할당 해제 
    free(t);
}

//트리 중위 순회 
//트리 노드를 인자로 받음 
void tree_inorder(TreeNode *root)
{
    if(root){
         //루트 노드의 왼쪽 자식노드인 중위 순회 실행 
         tree_inorder(root->left);
         //현재 노드의 데이터 출력 
         printf("%d ", root->data);
         // 루트 노드의 오른쪽 자식노드인 중위 순회 실행 
         tree_inorder(root->right);
    }
} 

//전위 순회 
//트리 노드를 인자로 받음 
void tree_preorder(TreeNode *root)
{
    if(root){
         //현재 노드의 데이터 출력 
         printf("%d ", root->data);
         //루트 노드의 왼쪽 자식노드인 전위 순회 실행
         tree_preorder(root->left);
         //루트 노드의 오른쪽 자식노드인 전위 순회 실행
         tree_preorder(root->right);
    }
} 

//후위 순회 
//트리 노드를 인자로 받음 
void tree_postorder(TreeNode *root)
{
    if(root){
         //루트 노드의 왼쪽 자식노드인 후위 순회 실행
         tree_postorder(root->left);
         //루트 노드의 오른쪽 자식노드인 후위 순회 실행
         tree_postorder(root->right);
         //현재 노드의 데이터 출력
         printf("%d ", root->data);
    }
}

//트리 레벨 순회 
//트리노드를 인자로 받음 
void tree_level_order(TreeNode *ptr)
{
    //레벨 순회를 위한 큐 생성 
    QueueType q;
    
    //큐 초기화 
    queue_init(&q);
    //트리가 비어있으면 종료 
    if(!ptr) return;
    //큐에 트리노드 대입
    enqueue(&q, ptr);
    //큐가 공백일 때 까지 반복 
    while(!is_empty(&q))
    {
         //전단 큐에 있는 트리노드 삭제 및 트리노드 추출 
         ptr=dequeue(&q);
         //추출된 트리노드의 값 출력 
         printf("%d ", ptr->data);
         //노드의 왼쪽 자식노드가 있으면 
         if(ptr->left)
              //왼쪽의 자식노드 큐에 삽입 
              enqueue(&q, ptr->left);
         //노드의 오른쪽 자식노드가 있으면 
         if(ptr->right)
              //오른쪽의 자식노드 큐에 삽입 
              enqueue(&q, ptr->right);
    }
}

//트리 높이 구하는 함수
//트리노드를 인자로 받음 
int tree_height(TreeNode *root)
{   
    //트리 전체의 높이 
    int height=0;
    //루트노드의 좌, 우 서브트리의 높이 
    int l, r;
    
    //루트노드가 없으면 0 반환 
    if(root==NULL)
         return 0;
    
    //루트노드의 좌측 서브트리 높이 저장      
    l=tree_height(root->left);
    //루트노드의 우측 서브트리 높이 저장  
    r=tree_height(root->right);
    //루트노드의 좌/우 서브트리 중에서 높이가 높은 값 추출 후 루트 자신의 높이인 1을 더함 
    height=(l>r?l:r)+1;
    
    //총 높이를 반환 
    return height;
}

//트리내의 노드 개수 구하는 함수 
//트리노드를 인자로 받음 
int tree_get_node_count(TreeNode *node)
{
    //최초 개수는 0개 
    int count=0;
    //노드가 존재하면 
    if(node!=NULL)
         //자신의 노드 개수, 노드의 왼쪽 자식 트리 개수, 노드의 오른쪽 자식 트리 개수의 합을 구함
         count=1+tree_get_node_count(node->left)+tree_get_node_count(node->right);
    
    //개수 반환 
    return count;
}

int main(void)
{
    //트리를 구성할 루트노드 
    TreeNode *root=NULL;
    //트리에 넣을 값들을 받을 정수형 배열 
    int val[100];
    //반복 구문을 수행할 정수형 변수 
    int i, j;
    
    //트리에 구성할 값들을 입력 받기 
    //설명문 출력 
    printf("트리를 구성할 값을 입력하세요.\n(정수 범위: 1~100 / 최대 100개 입력 가능 / 종료는 101)\n");
    //트리에 넣을 값을 배열에 저장(최대 100번 반복)
    for(i=0;i<100;i++)
    {
         //트리에 넣을 값 입력 
         scanf("%d", &val[i]);
         //101를 입력받으면 반복 종료 
         if(val[i]==101)
              break;
         //입력 범위를 초과하면 
         else if(val[i]>101)
              //오류 메세지 출력 
              error("값을 초과하였습니다.");
    }
    
    //입력 값 출력 및 입력 값 트리에 삽입 
    printf("\n입력 값 \n");
    //입력 한 값들의 갯수만큼 반복 
    for(j=0;j<i;j++)
    {
         //입력 값 확인을 위한 출력 
         printf("%d ", val[j]);
         //입력 값 트리에 삽입 
         tree_insert_node(&root, val[j]);
    }
    //출력 구분을 위한 개행 
    printf("\n-------------------------------------------------------\n");

    //전위 순회 함수를 통해 전위 순회 출력 
    printf("전위 순회 출력 결과\n"); 
    tree_preorder(root);
    
    //중위 순회 함수를 통해 전위 순회 출력 
    printf("\n중위 순회 출력 결과\n"); 
    tree_inorder(root);
    
    //후위 순회 함수를 통해 전위 순회 출력 
    printf("\n후위 순회 출력 결과\n"); 
    tree_postorder(root);
    printf("\n");
    
    //입력 받은 값 트리에서 삭제하기 
    //설명문 출력 
    printf("\n트리에서 삭제할 값을 순서대로 입력하세요!(종료는 101) \n");
    //트리에서 삭제할 값 배열에 저장(최대 100번 반복)
    for(i=0;i<100;i++)
    {
         //삭제할 값 입력 
         scanf("%d", &val[i]);
         //101을 입력받으면 반복 종료 
         if(val[i]==101)
              break;
         //입력 범위를 초과하면 
         else if(val[i]>101)
              //오류 메세지 출력 
              error("값을 초과하였습니다.");
    }
    
    //입력 값 출력 및 입력 값 트리에서 삭제 
    printf("\n입력 값 \n");
    //입력 한 값들의 갯수만큼 반복 
    for(j=0;j<i;j++)
    {
         //삭제 값 확인을 위한 출력 
         printf("%d ", val[j]);
         //트리에서 해당되는 노드 삭제  
         tree_delete_node(&root, val[j]);
    }
    
    //출력 구분을 위한 개행 
    printf("\n-------------------------------------------------------\n");
    //트리 노드 개수 구하는 함수를 통한 개수 출력 
    printf("삭제 후 트리의 노드 개수 : %d\n", tree_get_node_count(root));
    //트리 높이 구하는 함수를 통한 높이 출력 
    printf("삭제 후 트리의 높이 : %d\n", tree_height(root));
    //레벨 순회 함수를 통한 레벨 순회 출력
    printf("삭제 후 트리의 레벨 순회 \n");
    tree_level_order(root); 
    printf("\n");
    
    system("pause");
    return 0;
}
