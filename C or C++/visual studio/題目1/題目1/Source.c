#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(void)
{
	char string[100];
	scanf_s("%s", string, 100); //�t�b�o��
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

	printf("�r�ꤤ�p�g%d�� �j�g%d�� �Ʀr%d��\n", lower, upper, number);
	system("PAUSE");
	return 0;
}