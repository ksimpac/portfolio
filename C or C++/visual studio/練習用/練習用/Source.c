#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[])
{
	char a[10][10] = { 0 };

	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			printf("a[%d][%d] = %p\n", i, j, &a[i][j]);
		}
	}
	
	system("PAUSE");
	return 0;
}