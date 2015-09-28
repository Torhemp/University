#include <stdio.h>
#include <Windows.h>
#include "data.h"
#define SIZE 100000
#define SECTION 100000

int sortData[SIZE];

void Swap(int* a, int* b){
	int temp;
	temp=*a;
	*a=*b;
	*b=temp;
}

int Partition(int data[], int low, int high){
	int i, j=low;
	int pivot=data[low];

	for(i=low+1;i<=high;++i){
		if(data[i]<pivot){
			++j;
			Swap(&data[i], &data[j]);
		}
	}
	Swap(&data[j], &data[low]);
	return j;
}

void QuickSort(int data[], int low, int high){
	int pivot;
	if(high>low){
		pivot=Partition(data, low, high);
		QuickSort(data, low, pivot-1);
		QuickSort(data, pivot+1, high);
	}
}
int main(void){
	int i, j;
	DWORD dwTickCount;

	for(i=0;i<10;++i){
		for(j=0;j<SIZE;++j){
			sortData[j]=data[j+i*SECTION];
		}
		dwTickCount = GetTickCount();
		QuickSort(sortData, 0, SIZE-1);
		printf("%d번째 표본\n", i+1);
		printf("Code took: %dms\n", GetTickCount() - dwTickCount);
	}
	system("pause");
	return 0;
}