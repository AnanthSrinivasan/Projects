
extern int iext;

int fun1()
{
	return ++iext;
}

//int add(const int &x, const int &y);

int add(int x, int y)
{
	//what happens here is,
	//x will be copied to the value that is passed as x = ValPassed
	return x+y;
}

//when we do this in copying objects and if there is a copy constructor without reference
//this will end in calling the copy constructor again and again for copying resulting in a loop.

int add(const int &x, const int &y)
{	
	return x+y;
}

