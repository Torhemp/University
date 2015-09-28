#include <stdio.h>
#include <stdlib.h>

//���߿��Ḯ��Ʈ ����� ���� ����ü (���׽�) 
typedef struct DList {
    int coef;
    int expon;
    struct DList *head;
    struct DList *tail;
} DList;

//�ʱ�ȭ �Լ� 
void initList(DList *plist)
{
    plist->coef = 0;
    plist->expon = 0;
    plist->head=NULL;
    plist->tail=NULL;
}

//���׽� ��� ���� �Լ� 
void insert_node(DList *plist, int coef, int expon)
{
    DList *temp=(DList *)malloc(sizeof(DList));
    while(1){
         if(temp==NULL){
              printf("�޸� �Ҵ� ���� \n");
              temp=(DList *)malloc(sizeof(DList));
         }
         else
             break;
    }
         
    temp->coef=coef;
    temp->expon=expon;
    if(plist->head==NULL && plist->tail==NULL){
         plist->head=temp;
         plist->tail=temp;
         temp->head=plist;
         temp->tail=plist;
    }
    else{
         plist->head->tail=temp;
         temp->tail=plist;
         temp->head=plist->head;
         plist->head=temp;
    }
}

//���׽� ���� �Լ� 
void poly_add(DList *plist1, DList *plist2, DList *plist3)
{
    DList *a = plist1->tail;
    DList *b = plist2->tail;
    int sum;
    while(a!=plist1 && b!=plist2){
         if(a->expon == b->expon){
              sum=a->coef+b->coef;
              if(sum!=0)
                   insert_node(plist3, sum, a->expon);
              a=a->tail;
              b=b->tail;
         }
         else if(a->expon>b->expon){
              insert_node(plist3, a->coef, a->expon);
              a=a->tail;
         }
         else{
              insert_node(plist3, b->coef, b->expon);
              b=b->tail;
         }     
    }
    
    while(a!=plist1){
         insert_node(plist3, a->coef, a->expon);
         a=a->tail;
    }
    while(b!=plist2){
         insert_node(plist3, b->coef, b->expon);
         b=b->tail;
    }
}

//���׽� ���� �Լ� 
void poly_sub(DList *plist1, DList *plist2, DList *plist3)
{
    DList *a = plist1->tail;
    DList *b = plist2->tail;
    int sum;
    while(a!=plist1 && b!=plist2){
         if(a->expon == b->expon){
              sum=a->coef-b->coef;
              if(sum!=0)
                   insert_node(plist3, sum, a->expon);
              a=a->tail;
              b=b->tail;
         }
         else if(a->expon>b->expon){
              insert_node(plist3, a->coef, a->expon);
              a=a->tail;
         }
         else{
              b->coef=0-(b->coef);
              insert_node(plist3, b->coef, b->expon);
              b->coef=0-(b->coef);
              b=b->tail;
         }     
    }
    
    while(a!=plist1){
         insert_node(plist3, a->coef, a->expon);
         a=a->tail;
    }
    while(b!=plist2){
         b->coef=0-(b->coef);
         insert_node(plist3, b->coef, b->expon);
         b->coef=0-(b->coef);
         b=b->tail;
    }
}

//���׽� ��� �Լ� 
void poly_print(DList *plist)
{
     DList *p=plist->tail;
     while(p!=plist){
         printf("%dx^%d", p->coef, p->expon);
         p=p->tail;
         if(p!=plist)
              if(p->coef>0)
                    printf("+");
     }
}

//���׽� �������� ���� �Լ� 
void poly_sort(DList *plist)
{
    DList *a=plist->tail;
    DList *b=plist->tail;
    int swap;

    while(b!=plist){
         while(a!=plist){
              if(a->expon <(a->tail->expon)){
                   swap=a->expon;
                   a->expon=a->tail->expon;
                   a->tail->expon=swap;
                   swap=a->coef;
                   a->coef=a->tail->coef;
                   a->tail->coef=swap;
              }
              a=a->tail;
         }
         a=plist->tail;
         b=b->tail;
    }
}

//���׽� �ߺ� ���� ���� �Լ� 
void poly_dup(DList *plist)
{
    DList *a=plist->tail;
    
    while(a!=plist){
         a=plist->tail;
         while(a!=plist){
                   if(a->expon==a->tail->expon){
                        if(a->tail!=plist){
                             a->tail->coef=a->tail->coef+a->coef;
                             a->head->tail=a->tail;
                             a->tail->head=a->head;
                        }
                   }
                   a=a->tail;
         }
    }
}
     
int main(void)
{
    DList listhdr1, listhdr2, listhdr3, listhdr4;
    int coef, expon;
    
    initList(&listhdr1);
    initList(&listhdr2);
    initList(&listhdr3);
    initList(&listhdr4);
    
    //���׽� p(x) �Է�
    printf("���׽� p(x)�� ���, ���� ���� �Է��ϼ���. ���̸� 0 0�� �Է��ϼ���. \n");
    while(1){ 
         scanf("%d %d", &coef, &expon);
         if(coef==0){
              if(expon!=0)
                   printf("����� 0�� ���� �Է� �� �ʿ䰡 �����ϴ�! \n"); 
              else
                   break;
         }
         else
              insert_node(&listhdr1, coef, expon);
    }
    poly_sort(&listhdr1);            //p(x) �������� ���� 
    poly_dup(&listhdr1);             //p(x) �ߺ� ���� ���� 
    fflush(stdin);                   //�Է� ���� ����(�Է°� ���� ����) 
    
    //���׽� q(x) �Է� 
    printf("���׽� q(x)�� ���, ���� ���� �Է��ϼ���. ���̸� 0 0�� �Է��ϼ���. \n");
    while(1){      
         scanf("%d %d", &coef, &expon); 
         if(coef==0){
              if(expon!=0)
                   printf("����� 0�� ���� �Է� �� �ʿ䰡 �����ϴ�! \n"); 
              else
                   break;
         }
         else
              insert_node(&listhdr2, coef, expon);
    }
    poly_sort(&listhdr2);            //q(x) �������� ���� 
    poly_dup(&listhdr2);             //q(x) �ߺ� ���� ���� 
    fflush(stdin);                   //�Է� ���� ����(�Է°� ���� ����)
    
    poly_add(&listhdr1, &listhdr2, &listhdr3);
    poly_sub(&listhdr1, &listhdr2, &listhdr4);
    
    printf("**************** Input value ****************\n");
    printf("p(x)=");
    poly_print(&listhdr1);
    printf("\n");
    printf("q(x)=");
    poly_print(&listhdr2);
    printf("\n");
    printf("****************    Result   ****************\n");
    printf("p(x)+q(x)=");
    poly_print(&listhdr3);
    printf("\n");
    printf("p(x)-q(x)=");
    poly_print(&listhdr4);
    printf("\n");
    
    system("pause");
    return 0;
}
