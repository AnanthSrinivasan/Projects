#pragma once
#include "pizza.h"

class NYClamPizza :
	public Pizza
{
public:
	NYClamPizza(std::string dg,
				std::string sc,
				std::string nm);
	~NYClamPizza(void);
};
