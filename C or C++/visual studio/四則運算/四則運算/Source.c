#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int �[ = 0, �� = 0, �� = 0, �� = 0, �`�M = 0;
	int number1 = 0, number2 = 0;
	printf("Enter First Number\n");
	scanf_s("%d", &number1);
	printf("Enter Second Number\n");
	scanf_s("%d", &number2);
	�[ = number1 + number2;
	�� = number1 - number2;
	�� = number1 * number2;
	�� = number1 / number2;
	printf("The result is %d %d %d %d\n",�[,��,��,��);
	system("PAUSE");
	return 0;
}