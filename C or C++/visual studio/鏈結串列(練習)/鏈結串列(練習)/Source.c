#include <stdio.h>
#include <stdlib.h>

typedef struct Node
{
	int number;
	struct Node *NextPtr;
}node;

int main(void)
{
	node *head = malloc(sizeof(node));
	head = NULL;
	return 0;
}
