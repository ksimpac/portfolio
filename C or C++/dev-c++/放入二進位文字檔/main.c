#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

struct book
{
	char **bookname;
	char **author;
	char **ISBN;
	int price;
};

struct book2
{
	char *bookname;
	char *author;
	char *ISBN;
	int price;
};

int main(int argc, char *argv[]) 
{
	char *bookname_data[10] = {"�Ы�X�����ʼֶ�","�L�ɤ���01����","�αo�쪺�ƾǡG�غc�@�ɪ��������l","���ӯ��K�A�s����","�L���_���P","�@�ӤH��B�Ƽy��G���쪽�l�饻����U�U��","�����ǯ��G���Ǧb��Q�B�ˤl�B¾�����A�����H�������۳B","�߸��A�s���G�ڻP���g�@�R���ձ޻P�©]","�H�ͷǳ�40%�N�ĤF�I�G�W�G�`�H���ؼа���O","���⪺�i���G�ѥ��s�⥲�����D��3�ӯ��K"};
	char *author_data[10] = {"�L���t","Misa","���p","�K��","�Ϫi","���쪽�l","�P�}��","���g��","�¤��","�w�Ǫ�"};
	char *ISBN_data[10] = {"9789869236478","9789869470612","9789864791675","9789869469883","9789869470629","9789861794891","9789864060788","9789869468749","9789869395588","9789869382038"};
	int price_data[10] = {253,198,462,142,198,221,245,237,277,395};
	
	struct book a;
	
	FILE *fPtr = fopen("data.dat","wb");
	
	int i = 0;
	
	for(i = 0;i < 10;i++)
	{
		a.bookname = &bookname_data[i];
	    a.author = &author_data[i];
	    a.ISBN = &ISBN_data[i];
	    a.price = price_data[i];
	    fwrite(&a, sizeof(struct book2), 1, fPtr);
	}
	
	system("PAUSE");
	return 0;
}
