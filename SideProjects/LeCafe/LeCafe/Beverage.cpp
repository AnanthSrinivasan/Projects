#include "Beverage.h"
#include <string>

Beverage::Beverage(void) : description ("test") { }

Beverage::~Beverage(void)
{
}

std::string Beverage::get_desc()
{
	return description;
}
