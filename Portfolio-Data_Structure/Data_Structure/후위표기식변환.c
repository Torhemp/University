#include <stdio.h>//헤더파일지정
#include <malloc.h>

#define MAX_SIZE 100//상수 설정 
typedef char element;// 사용자 정의 문자형 변수 설정 
typedef struct{
    int stack[MAX_SIZE];//배열스택 
    int top;//스택의 top을 가리키는 변수 
} ArrStackType;//사용자 정의 구조체 배열스택 설정 

typedef struct LinkedStackNode{
    element item;//데이터 
    struct LinkedStackNode *link;//다음 노드를 가리키는 포인터 
} LinkedStackNode;//사용자 정의 구조체 연결리스트 스택 설정 

typedef struct {
    struct LinkedStackNode *top;//스택의 top을 가리키는 포인터 
} LinkedStackType;//사용자 정의 구조체 연결리스트 헤드 설정 

void arr_init(ArrStackType *s)//배열스택 초기화 
{
    s->top = -1;
}

int arr_is_empty(ArrStackType *s)//배열스택 공백상태 확인 
{
    return (s->top == -1);
}

int arr_is_full(ArrStackType *s)//배열스택 포화상태 확인 
{
    return (s->top==(MAX_SIZE-1));
}

void arr_push(ArrStackType *s, int item)//배열스택 삽입
{
    if(arr_is_full(s)){
         fprintf(stderr, "스택 포화 에러\n");
         return;
    }//배열스택 포화시에 에러 출력 
    else s->stack[++(s->top)]=item;//배열스택에 데이터 입력후 top증가 
}

element arr_pop(ArrStackType *s)//배열스택 삭제 
{
    if(arr_is_empty(s)){
         fprintf(stderr, "스택 공백 에러\n");
         exit(1);
    }//배열스택 공백시에 에러 출력
    else return s->stack[(s->top)--];//배열스택 top데이터 리턴후 top감소 
}

element arr_peek(ArrStackType *s)//배열스택 자료 반환 
{
    if(arr_is_empty(s)){
         fprintf(stderr, "스택 공백 에러\n");
         exit(1);
    }//배열스택 공백시에 에러 출력
    else return s->stack[s->top];//배열스택의 top에 해당되는 데이터 리턴 
}

void linked_init(LinkedStackType *s)//연결리스트스택 초기화 
{
    s->top = NULL;
}

int linked_is_empty(LinkedStackType *s)//연결리스트스택 공백상태 확인 
{
    return (s->top == NULL);
}

void linked_push(LinkedStackType *s, element item)//연결리스트스택 삽입 
{
    LinkedStackNode *temp=(LinkedStackNode *)malloc(sizeof(LinkedStackNode));
    //노드 동적할당 
    if(temp==NULL){
         fprintf(stderr, "메모리 할당에러\n");
         return;
    }//동적할당이 안될시에 에러 출력 
    else{
         temp->item=item;
         temp->link=s->top;
         s->top=temp;
    }//연결리스트스택에 노드 추가 후 데이터 입력, top포인터가 가리키는 대상 변경 
}

element linked_pop(LinkedStackType *s)//연결리스트스택 제거 
{
    if(linked_is_empty(s)){
         fprintf(stderr, "스택 공백 에러\n");
         exit(1);
    }//연결리스트스택 공백 시 에러 출력 
    else{
         LinkedStackNode *temp=s->top;
         element item=temp->item;
         s->top=s->top->link;
         free(temp);
         return item;
    }//연결리스트스택의 top에 있는 데이터 리턴 후 top의 스택 삭제 및 동적할당해제 
}

element linked_peek(LinkedStackType *s)//연결리스트스택 자료 반환 
{
    if(linked_is_empty(s)){
         fprintf(stderr, "스택 공백 에러\n");
         exit(1);
    }//연결리스트스택 공백 시 에러 출력 
    else 
         return s->top->item;//top의 데이터 리턴 
}

int check_matching(char *in)//괄호검사 
{
    LinkedStackType s;
    char ch, open_ch;
    int i, n=strlen(in);//strlen(in)은 in의 길이 
    linked_init(&s);//연결리스트스택 초기화 
    
    for(i=0;i<n;i++){
         ch=in[i];
         switch(ch){
              case '(': case '[': case '{'://괄호개행시 스택에 보관 
                   linked_push(&s, ch);
                   break;
              case ')': case ']': case '}':
                   if(linked_is_empty(&s))
                        return 0;//괄호를 닫을 때 개행괄호가 없다면 0 반환 
                   else{
                        open_ch=linked_pop(&s);
                        if((open_ch=='(' && ch!=')') ||
                           (open_ch=='[' && ch!=']') ||
                           (open_ch=='{' && ch!='}')){
                                  return 0;
                        }//스택에 보관된 괄호가 입력된 괄호와 맞지않으면 0 반환 
                        break;
                   }
         }
    }
    if(!linked_is_empty(&s)) return 0; //스택에 괄호가 있다면 0 반환 
    return 1; //모든 조건에 부합하면 1 반환 
}

int prec(char op)//연산자 반환 
{
    switch(op){
         case '(': case ')': return 0;//괄호시에 0 반환 
         case '+': case '-': return 1;//+, -일시 1 반환 
         case '*': case '/': return 2;//*, /일시 2 반환 
    }
    return -1;//그 외에는 -1 반환 
}

void linked_infix_to_postfix(char exp[], char val[])//중위표기식을 후위표기식으로 변경 및 복사 
{
    int i=0, j=0;
    char ch, top_op;
    int len=strlen(exp);
    LinkedStackType s;
    
    linked_init(&s);//연결리스트스택 초기화 
    for(i=0;i<len;i++){
         ch=exp[i];
         switch(ch){
              case '+': case '-': case '*': case '/'://가져온 문자가 연산자일 경우 
                   while(!linked_is_empty(&s) && (prec(ch)<=prec(linked_peek(&s)))){
                        printf("%c", linked_peek(&s));
                        val[j]=linked_pop(&s);
                        j++;
                   }//스택이 비어 있지 않고 연산자의 순위가 높다면 연산자 출력 
                   linked_push(&s, ch);
                   break;
              case '(': 
                   linked_push(&s, ch);//개행괄호시 스택에 삽입 
                   break;
              case ')':
                   top_op=linked_pop(&s);
                   while(top_op!='('){ 
                       printf("%c", top_op);
                       val[j]=top_op;
                       top_op=linked_pop(&s);
                       j++;
                   }//폐행괄호시에 개행괄호가 나올 때 까지 스택의 데이터 출력 
                   break;
              default:
                   printf("%c", ch);//연산자/괄호가 아닌 숫자이면 출력 
                   val[j]=ch;
                   j++;
                   break;
         }
    }
    while(!linked_is_empty(&s)){ 
         printf("%c", linked_peek(&s));
         val[j]=linked_pop(&s);
         j++;
    }//조건 반복문 종료 후 스택에 데이터가 남아있다면 출력 
    val[j]='\0';//복사 된 후위표기식 문자열의 끝 표시 
    printf("\n");
}//중위표기식 char를 후위표기식으로 변경 후 val에 복사 

int print_stack(char val[])//스택 상태 표시 
{
    ArrStackType s;
    int i=0, j, temp1, temp2, len=strlen(val), op[MAX_SIZE];
    
    arr_init(&s);//배열스택 초기화
    printf("스택 상태 \n ->"); 
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
         }//가져온 값이 연산자가 아니면 스택에 있는 자료 출력
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
         }//가져온 값이 연산자이면 연산자 출력 후 스택에 있는 값을 꺼내 연산 후 스택에 삽입
         i++;
         if(i<len)
              printf("\n ->");
         else
              break;
    }
    return arr_pop(&s);//연산 결과 반환
}

int limit_input(char *in)//입력한 수식 조건 제한
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
}//입력한 수식이 표기법에 어긋나거나 조건에 맞지 않는 경우 0을 반환, 문제가 없다면 1을 반환

int main(void)
{
    char ch[MAX_SIZE], val[MAX_SIZE];
    char result;
    printf("후위 표기법 변환 및 계산 프로그램 \n");
    
    do{
         printf("수식을 입력하세요!(끝낼려면 q 입력) : \n");
         scanf("%s", ch);//수식 입력
         if(ch[0]=='q'){//q 입력시 종료
              printf("프로그램을 종료합니다...\n");
              break;
         }
         else if(ch[0]=='c'){
              system("cls");
              printf("화면 내용 삭제 완료 \n");
	          printf("후위 표기법 변환 및 계산 프로그램 \n");
         }
         else{
              if(limit_input(ch)!=1)//수식 표기법에 어긋날 시 에러메세지 출력
                   printf("잘못된 입력입니다! \n");
              else{ 
                   if(check_matching(ch)!=1)//괄호검사시 문제가 있다면 에러메세지 출력
                        printf("에러 : 괄호가 잘못 사용되었습니다! \n");
                   else{
                        printf("입력한 값 : %s \n", ch);
                        printf("후위 표기식 변환 -> "); 
                        linked_infix_to_postfix(ch, val);
                        result=print_stack(val);
                        printf("\n");
                        printf("결과 값 : %d \n", result);
                   }//문제가 없다면 입력한 값, 후위표기식으로 변환된 값, 스택 구조, 결과 값 출력
              }
         }
    }while(1);

    system("pause");
    return 0;
}
