#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) 
{
	
	char s1[100];
	char s2[50];

	scanf("%s", s1);
	scanf("%s", s2);

	char *ptr = s1;
	int i = 0,max_char = 0,times = 0;

	while (s2[max_char] != '\0')
	{
		max_char++;
	}

	while(ptr[i] != '\0')
	{
		if (strncmp(ptr, s2, max_char) == 0)
		{
			times += 1;
		}
		ptr++;
	}

	printf("%s總共出現%d次\n", s2,times);
	system("PAUSE");
	return 0;
}
