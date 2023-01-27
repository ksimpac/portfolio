#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

struct book
{
	char *bookname;
	char *author;
	char *ISBN;
	int price;
};

int main(int argc, char *argv[]) 
{
	
	struct book a[10];
	
	FILE *fPtr = fopen("data.dat","rb");
	
	int i = 0;
	
	for(i = 0;i < 10;i++)
	{
		fread(&a[i],sizeof(struct book),1,fPtr);
	}
	
	printf("%s",a[0].bookname);
	
	
	system("PAUSE");
	return 0;
}
