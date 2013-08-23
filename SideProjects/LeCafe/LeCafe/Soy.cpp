#include <string>
#include "Soy.h"
#include "Beverage.h"

Soy::Soy(Beverage * bev) : Condiment (bev) { }
	
Soy::~Soy(void)
{
}

double Soy::cost()
{
	return beverage->cost() + 0.25;
}

std::string Soy::get_desc()
{
	return beverage->get_desc() + ", Soy";
}