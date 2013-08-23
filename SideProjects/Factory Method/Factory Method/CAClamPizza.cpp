#include "CAClamPizza.h"
#include "Pizza.h"
#include <iostream>

CAClamPizza::CAClamPizza(std::string dg, 
							 std::string sc, 
							 std::string nm) : Pizza(dg, sc, nm)
{
	cout << "CA Clam Pizza " << endl;
}

CAClamPizza::~CAClamPizza(void)
{
}
