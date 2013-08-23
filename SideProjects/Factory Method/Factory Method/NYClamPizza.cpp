#include "NYClamPizza.h"
#include "Pizza.h"
#include <iostream>

NYClamPizza::NYClamPizza(std::string dg, 
							 std::string sc, 
							 std::string nm) : Pizza(dg, sc, nm)
{
	cout << "NY Clam Pizza " << endl;
}

NYClamPizza::~NYClamPizza(void)
{
}
