#pragma once
#include "Beverage.h"

class Expresso :
	public Beverage
{
public:
	Expresso(void);
	~Expresso(void);

	double cost();
};
