#include <string>
#include "Whip.h"
#include "Beverage.h"

Whip::Whip(Beverage * bev) : Condiment (bev) { }

Whip::~Whip(void)
{
}

double Whip::cost()
{
	return beverage->cost() + 0.15;
}

std::string Whip::get_desc()
{
	return beverage->get_desc() + ", Whip";
}