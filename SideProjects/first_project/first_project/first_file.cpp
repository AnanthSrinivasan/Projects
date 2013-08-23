#include <iostream>
#include "first_file.h"

first_sample::first_sample(){}	//default constructor

first_sample::first_sample(int x, int y)	//overloaded constructor
{
	m_a = x;
	m_b	= y;
}

void first_sample::set_values(int x, int y)	//this function does the same job of overloaded constructor
{											//this is not necessary and object can be created with 
	m_a = x;								//overloaded constructor itself and the members can be initialized
	m_b = y;
}

void first_sample::display()				//display function to print members that object holds
{											//each members will have its own value of x and y
	std::cout << "a :" << m_a << "\t";
	std::cout << "b :" << m_b;
}

/*
Note: 
	When there are no constructor defined, compiler provides a default constructor.
	
	When no constructor is defined, during object creation the default constructor will be called.
	and the default constructor just allocates memory to the object but doesn't initializes it.

*/