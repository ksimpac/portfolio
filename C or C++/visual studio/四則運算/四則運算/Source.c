#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int 加 = 0, 減 = 0, 乘 = 0, 除 = 0, 總和 = 0;
	int number1 = 0, number2 = 0;
	printf("Enter First Number\n");
	scanf_s("%d", &number1);
	printf("Enter Second Number\n");
	scanf_s("%d", &number2);
	加 = number1 + number2;
	減 = number1 - number2;
	乘 = number1 * number2;
	除 = number1 / number2;
	printf("The result is %d %d %d %d\n",加,減,乘,除);
	system("PAUSE");
	return 0;
}