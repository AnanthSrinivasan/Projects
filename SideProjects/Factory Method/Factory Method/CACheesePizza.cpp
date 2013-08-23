#include "CACheesePizza.h"
#include "Pizza.h"
#include <iostream>

CACheesePizza::CACheesePizza(std::string dg, 
							 std::string sc, 
							 std::string nm) : Pizza(dg, sc, nm)
{
	cout << "CA Cheese Pizza " << endl;
}

CACheesePizza::~CACheesePizza(void)
{
}
