#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
int main(int argc, char *argv[]) 
{
	
    char string[100];
	scanf("%s", string); //差在這邊 
	int lower = 0, upper = 0, number = 0,i = 0;

	int boolean_lower = 0, boolean_upper = 0, boolean_number = 0;

	while (string[i] != '\0')
	{

		boolean_lower = islower(string[i]);
		boolean_upper = isupper(string[i]);
		boolean_number = isdigit(string[i]);
		
		if (boolean_lower != 0)
		{
			lower += 1;
			string[i] = toupper(string[i]);
		}
		else if (boolean_upper != 0)
		{
			upper += 1;
			string[i] = tolower(string[i]);
		}
		else if (boolean_number != 0)
		{
			number += 1;
		}

		i++;
	}

	printf("字串中小寫%d個 大寫%d個 數字%d個\n", lower, upper, number);
	system("PAUSE");
	return 0;
}
