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
	char *bookname_data[10] = {"房思琪的初戀樂園","無盡之境01長生","用得到的化學：建構世界的美妙分子","有個秘密，叫初戀","微光北極星","一個人到處瘋慶典：高木直子日本祭典萬萬歲","情緒勒索：那些在伴侶、親子、職場間，最讓人窒息的相處","心路，新路：我與癌症共舞的白晝與黑夜","人生準備40%就衝了！：超乎常人的目標執行力","高手的養成：股市新手必須知道的3個祕密"};
	char *author_data[10] = {"林奕含","Misa","葛雷","袁晞","煙波","高木直子","周慕姿","章經綸","謝文憲","安納金"};
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
