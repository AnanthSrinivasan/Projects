#pragma once
#include "pizza.h"

class NYCheesePizza :
	public Pizza
{
public:
	NYCheesePizza(std::string dg,
				std::string sc,
				std::string nm);
	~NYCheesePizza(void);
};
