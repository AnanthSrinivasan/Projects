#include "Expresso.h"
#include <iostream>

Expresso::Expresso(void)
{
	description = "Expresso";
}

Expresso::~Expresso(void)
{
}

double Expresso::cost()
{
	return 3.00;
}
