#pragma once
#include "Beverage.h"

class HouseBlend :
	public Beverage
{
public:
	HouseBlend(void);
	~HouseBlend(void);

	double cost();
};
