//---
#include <iostream>
#include "first_file.h"
#include "copy_cons_player.h"
#include "mem_init_list_player.h"
#include <string>
//---

using namespace std;

char * reverse_string(char * str);

int fun1();			
//int add(const int &x, const int &y);
int add(int x, int y);
int atoi_impl(const char* str);

int iext = 25;		//

int main()
{
/*	first_sample inst_a(10, 20);	//overloaded constructor invoked.
	first_sample inst_b;			//default constructor invoked.
	inst_b.set_values(100, 200);
	
	std::cout << "Lets Print First Instance : \n";
	inst_a.display();
	std::cout << "\nLets Print Second Instance : \n";
	inst_b.display();
	cout <<	std::endl;

	player p1("Ananth");
	player p2(p1);					//Invokes Copy constructor
	player p3("Maran");
	player p4 = p3;					//Invokes Copy constructor
	player p5("Bala");
	player p6;
	p6 = p5;						//Assignment operator is called

	p1.profile();
//	p2.profile();
//	p3.profile();
//	p4.profile();
//	p5.profile();
//	p6.profile();

	player_racer ferrari(181, 70, 10, "Ananth");
	player_racer one(175, 75, 10, "Ajith");

	ferrari.profile();
	one.profile();
	
	std::cout << "No. of Racers in field" << one.no_of_players() << std::endl;
*/
//	system("PAUSE");

//int input[]={1,1,1,2,2,2,2,3,3,4};
//int array_size = sizeof(input) / sizeof(int);
//printf("ARRAY SIZE = %d \n", array_size);
//
//int prev = input[0];
//int count = 1;
//int max = 0;
//int element = 0;
//
//for (int i = 1; i < 10 ; i++)
//{
//	printf ("i = %d \t", i);
//	printf ("input[%d] = %d \t", i, input[i]);
//	printf ("count = %d \n", count);
//  if (input[i] == prev)
//  {
//	  printf ("input[%d] = %d \t", i, prev);
//	  count++;
// 	  printf ("count in loop = %d \n", count);
//
//  }
//  else
//  {
//    printf("%d=%d  times\n", prev, count);
//	if(count > max)
//	{
//		max = count;
//		element = input[i - 1];		
//	}
//    prev = input[i];
//    count = 1;
//  }
//}
//// Printing the last element
//	printf("%d=%d ", prev, count);
//	printf ("max = %d \n", max);
//	printf ("element max = %d \n", element);

//	cout << "iext = " << iext << endl;
//	int f1 = 0 ;
	
	//f1 = fun1();
	//int fun2 = fun2();
//	f1 = add(24, 39); 



//	cout << "fun 1 " << f1;
	//cout << "fun 2 " << fun2;

//	string test = "i love vaishu";
//	cout << test;

//	char org_string[] = "ananth";
	char *atoi_test = "12ZX09ab";

	cout << "Input :" << atoi_test << endl;

	//std::cout << "Original String " << org_string << std::endl;

	//reverse_string(org_string);
	//std::cout << "Reversed String " << org_string << std::endl;

	int x = atoi_impl(atoi_test);
	cout << "Output :" << x << endl;


	system("PAUSE");
	return 0;
}

char * reverse_string(char *str)
{
	char temp = ' '; 

	if (*str == NULL || *str == '\0')
		return str; 

	int start, end;
	for (end = 0; str[end]; end++);

	end--;

	for (start = 0; start < strlen(str)/2; start++)
	//for (start = 0; start < end; start++, end--)
	{
		temp = str[start];
// 		str[start] = str[len];
//		str[len--] = temp;
 		str[start] = str[end];
		str[end--] = temp;
	}

	return str;
}

//	int len = strlen(str) - 1;
//	std::cout << "Length :" << len << std::endl;
