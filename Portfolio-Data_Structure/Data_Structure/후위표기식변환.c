#include <stdio.h>//�����������
#include <malloc.h>

#define MAX_SIZE 100//��� ���� 
typedef char element;// ����� ���� ������ ���� ���� 
typedef struct{
    int stack[MAX_SIZE];//�迭���� 
    int top;//������ top�� ����Ű�� ���� 
} ArrStackType;//����� ���� ����ü �迭���� ���� 

typedef struct LinkedStackNode{
    element item;//������ 
    struct LinkedStackNode *link;//���� ��带 ����Ű�� ������ 
} LinkedStackNode;//����� ���� ����ü ���Ḯ��Ʈ ���� ���� 

typedef struct {
    struct LinkedStackNode *top;//������ top�� ����Ű�� ������ 
} LinkedStackType;//����� ���� ����ü ���Ḯ��Ʈ ��� ���� 

void arr_init(ArrStackType *s)//�迭���� �ʱ�ȭ 
{
    s->top = -1;
}

int arr_is_empty(ArrStackType *s)//�迭���� ������� Ȯ�� 
{
    return (s->top == -1);
}

int arr_is_full(ArrStackType *s)//�迭���� ��ȭ���� Ȯ�� 
{
    return (s->top==(MAX_SIZE-1));
}

void arr_push(ArrStackType *s, int item)//�迭���� ����
{
    if(arr_is_full(s)){
         fprintf(stderr, "���� ��ȭ ����\n");
         return;
    }//�迭���� ��ȭ�ÿ� ���� ��� 
    else s->stack[++(s->top)]=item;//�迭���ÿ� ������ �Է��� top���� 
}

element arr_pop(ArrStackType *s)//�迭���� ���� 
{
    if(arr_is_empty(s)){
         fprintf(stderr, "���� ���� ����\n");
         exit(1);
    }//�迭���� ����ÿ� ���� ���
    else return s->stack[(s->top)--];//�迭���� top������ ������ top���� 
}

element arr_peek(ArrStackType *s)//�迭���� �ڷ� ��ȯ 
{
    if(arr_is_empty(s)){
         fprintf(stderr, "���� ���� ����\n");
         exit(1);
    }//�迭���� ����ÿ� ���� ���
    else return s->stack[s->top];//�迭������ top�� �ش�Ǵ� ������ ���� 
}

void linked_init(LinkedStackType *s)//���Ḯ��Ʈ���� �ʱ�ȭ 
{
    s->top = NULL;
}

int linked_is_empty(LinkedStackType *s)//���Ḯ��Ʈ���� ������� Ȯ�� 
{
    return (s->top == NULL);
}

void linked_push(LinkedStackType *s, element item)//���Ḯ��Ʈ���� ���� 
{
    LinkedStackNode *temp=(LinkedStackNode *)malloc(sizeof(LinkedStackNode));
    //��� �����Ҵ� 
    if(temp==NULL){
         fprintf(stderr, "�޸� �Ҵ翡��\n");
         return;
    }//�����Ҵ��� �ȵɽÿ� ���� ��� 
    else{
         temp->item=item;
         temp->link=s->top;
         s->top=temp;
    }//���Ḯ��Ʈ���ÿ� ��� �߰� �� ������ �Է�, top�����Ͱ� ����Ű�� ��� ���� 
}

element linked_pop(LinkedStackType *s)//���Ḯ��Ʈ���� ���� 
{
    if(linked_is_empty(s)){
         fprintf(stderr, "���� ���� ����\n");
         exit(1);
    }//���Ḯ��Ʈ���� ���� �� ���� ��� 
    else{
         LinkedStackNode *temp=s->top;
         element item=temp->item;
         s->top=s->top->link;
         free(temp);
         return item;
    }//���Ḯ��Ʈ������ top�� �ִ� ������ ���� �� top�� ���� ���� �� �����Ҵ����� 
}

element linked_peek(LinkedStackType *s)//���Ḯ��Ʈ���� �ڷ� ��ȯ 
{
    if(linked_is_empty(s)){
         fprintf(stderr, "���� ���� ����\n");
         exit(1);
    }//���Ḯ��Ʈ���� ���� �� ���� ��� 
    else 
         return s->top->item;//top�� ������ ���� 
}

int check_matching(char *in)//��ȣ�˻� 
{
    LinkedStackType s;
    char ch, open_ch;
    int i, n=strlen(in);//strlen(in)�� in�� ���� 
    linked_init(&s);//���Ḯ��Ʈ���� �ʱ�ȭ 
    
    for(i=0;i<n;i++){
         ch=in[i];
         switch(ch){
              case '(': case '[': case '{'://��ȣ����� ���ÿ� ���� 
                   linked_push(&s, ch);
                   break;
              case ')': case ']': case '}':
                   if(linked_is_empty(&s))
                        return 0;//��ȣ�� ���� �� �����ȣ�� ���ٸ� 0 ��ȯ 
                   else{
                        open_ch=linked_pop(&s);
                        if((open_ch=='(' && ch!=')') ||
                           (open_ch=='[' && ch!=']') ||
                           (open_ch=='{' && ch!='}')){
                                  return 0;
                        }//���ÿ� ������ ��ȣ�� �Էµ� ��ȣ�� ���������� 0 ��ȯ 
                        break;
                   }
         }
    }
    if(!linked_is_empty(&s)) return 0; //���ÿ� ��ȣ�� �ִٸ� 0 ��ȯ 
    return 1; //��� ���ǿ� �����ϸ� 1 ��ȯ 
}

int prec(char op)//������ ��ȯ 
{
    switch(op){
         case '(': case ')': return 0;//��ȣ�ÿ� 0 ��ȯ 
         case '+': case '-': return 1;//+, -�Ͻ� 1 ��ȯ 
         case '*': case '/': return 2;//*, /�Ͻ� 2 ��ȯ 
    }
    return -1;//�� �ܿ��� -1 ��ȯ 
}

void linked_infix_to_postfix(char exp[], char val[])//����ǥ����� ����ǥ������� ���� �� ���� 
{
    int i=0, j=0;
    char ch, top_op;
    int len=strlen(exp);
    LinkedStackType s;
    
    linked_init(&s);//���Ḯ��Ʈ���� �ʱ�ȭ 
    for(i=0;i<len;i++){
         ch=exp[i];
         switch(ch){
              case '+': case '-': case '*': case '/'://������ ���ڰ� �������� ��� 
                   while(!linked_is_empty(&s) && (prec(ch)<=prec(linked_peek(&s)))){
                        printf("%c", linked_peek(&s));
                        val[j]=linked_pop(&s);
                        j++;
                   }//������ ��� ���� �ʰ� �������� ������ ���ٸ� ������ ��� 
                   linked_push(&s, ch);
                   break;
              case '(': 
                   linked_push(&s, ch);//�����ȣ�� ���ÿ� ���� 
                   break;
              case ')':
                   top_op=linked_pop(&s);
                   while(top_op!='('){ 
                       printf("%c", top_op);
                       val[j]=top_op;
                       top_op=linked_pop(&s);
                       j++;
                   }//�����ȣ�ÿ� �����ȣ�� ���� �� ���� ������ ������ ��� 
                   break;
              default:
                   printf("%c", ch);//������/��ȣ�� �ƴ� �����̸� ��� 
                   val[j]=ch;
                   j++;
                   break;
         }
    }
    while(!linked_is_empty(&s)){ 
         printf("%c", linked_peek(&s));
         val[j]=linked_pop(&s);
         j++;
    }//���� �ݺ��� ���� �� ���ÿ� �����Ͱ� �����ִٸ� ��� 
    val[j]='\0';//���� �� ����ǥ��� ���ڿ��� �� ǥ�� 
    printf("\n");
}//����ǥ��� char�� ����ǥ������� ���� �� val�� ���� 

int print_stack(char val[])//���� ���� ǥ�� 
{
    ArrStackType s;
    int i=0, j, temp1, temp2, len=strlen(val), op[MAX_SIZE];
    
    arr_init(&s);//�迭���� �ʱ�ȭ
    printf("���� ���� \n ->"); 
    while(1){
         if(val[i]!='+' && val[i]!='-' && val[i]!='*' && val[i]!='/'){
              arr_push(&s, val[i]-'0');
              op[s.top]=arr_peek(&s);
              printf("["); j=0;
              while(1){
                   printf("%d", op[j]);
                   if(j==s.top)
                        break;
                   else{
                        printf(" ");
                        j++;
                   }
              }
              printf("]");  
         }//������ ���� �����ڰ� �ƴϸ� ���ÿ� �ִ� �ڷ� ���
         else{
              printf("%c\n ->", val[i]);
              temp2=arr_pop(&s);
              temp1=arr_pop(&s);
              switch(val[i]){
                   case '+':
                        arr_push(&s, temp1+temp2);
                        break;
                   case '-':
                        arr_push(&s, temp1-temp2);
                        break;
                   case '*':
                        arr_push(&s, temp1*temp2);
                        break;
                   case '/':
                        arr_push(&s, temp1/temp2);
                        break;
              }
              op[s.top]=arr_peek(&s);
              printf("["); j=0;
              while(1){
                   printf("%d", op[j]);
                   if(j==s.top)
                        break;
                   else{
                        printf(" ");
                        j++;
                   }
              }
              printf("]");
         }//������ ���� �������̸� ������ ��� �� ���ÿ� �ִ� ���� ���� ���� �� ���ÿ� ����
         i++;
         if(i<len)
              printf("\n ->");
         else
              break;
    }
    return arr_pop(&s);//���� ��� ��ȯ
}

int limit_input(char *in)//�Է��� ���� ���� ����
{
    char ch1, ch2, i;
    int len=strlen(in);
    int con1, con2, result;
    for(i=0;i<len-1;i++){
         ch1=in[i];
         ch2=in[i+1];
         con1=prec(in[i]);
         con2=prec(in[i+1]);
         if(((ch1>='1' && ch1<='9') || con1>=0) && 
            ((ch2>='1' && ch2<='9') || con2>=0)){
             if(((ch1>='1' && ch1<='9') && ((ch2>='1' && ch2<='9') || ch2=='('))
                || (con1>=1 && con2>=1) || (ch1==')' && ch2=='(') || 
                (ch1=='(' && ch2==')') || (ch1==')' && (ch2>='1' && ch2<='9'))){
                   result=0;
                   break;
             }
             else 
                   result=1;
         }
         else{
              result=0;
              break;
         }
    }
    return result;
}//�Է��� ������ ǥ����� ��߳��ų� ���ǿ� ���� �ʴ� ��� 0�� ��ȯ, ������ ���ٸ� 1�� ��ȯ

int main(void)
{
    char ch[MAX_SIZE], val[MAX_SIZE];
    char result;
    printf("���� ǥ��� ��ȯ �� ��� ���α׷� \n");
    
    do{
         printf("������ �Է��ϼ���!(�������� q �Է�) : \n");
         scanf("%s", ch);//���� �Է�
         if(ch[0]=='q'){//q �Է½� ����
              printf("���α׷��� �����մϴ�...\n");
              break;
         }
         else if(ch[0]=='c'){
              system("cls");
              printf("ȭ�� ���� ���� �Ϸ� \n");
	          printf("���� ǥ��� ��ȯ �� ��� ���α׷� \n");
         }
         else{
              if(limit_input(ch)!=1)//���� ǥ����� ��߳� �� �����޼��� ���
                   printf("�߸��� �Է��Դϴ�! \n");
              else{ 
                   if(check_matching(ch)!=1)//��ȣ�˻�� ������ �ִٸ� �����޼��� ���
                        printf("���� : ��ȣ�� �߸� ���Ǿ����ϴ�! \n");
                   else{
                        printf("�Է��� �� : %s \n", ch);
                        printf("���� ǥ��� ��ȯ -> "); 
                        linked_infix_to_postfix(ch, val);
                        result=print_stack(val);
                        printf("\n");
                        printf("��� �� : %d \n", result);
                   }//������ ���ٸ� �Է��� ��, ����ǥ������� ��ȯ�� ��, ���� ����, ��� �� ���
              }
         }
    }while(1);

    system("pause");
    return 0;
}
