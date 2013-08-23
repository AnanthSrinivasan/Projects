#pragma once
#include "Beverage.h"

class FrenchVennila :
	public Beverage
{
public:
	FrenchVennila(void);
	~FrenchVennila(void);

	double cost();
};
