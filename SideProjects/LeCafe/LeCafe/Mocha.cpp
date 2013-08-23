#include <string>
#include "Mocha.h"
#include "Beverage.h"

Mocha::Mocha(Beverage * bev) : Condiment (bev) { }

Mocha::~Mocha(void)
{
	
}

double Mocha::cost()
{
	return beverage->cost() + 0.10;
}

std::string Mocha::get_desc()
{
	return beverage->get_desc() + ", Mocha";
}

