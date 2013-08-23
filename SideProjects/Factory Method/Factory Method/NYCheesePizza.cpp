#include "NYCheesePizza.h"
#include "Pizza.h"
#include <iostream>

NYCheesePizza::NYCheesePizza(std::string dg, 
							 std::string sc, 
							 std::string nm) : Pizza(dg, sc, nm)
{
	cout << "NY Cheese Pizza " << endl;
}

NYCheesePizza::~NYCheesePizza(void)
{
}
