#pragma once
#include "pizza.h"

class CACheesePizza :
	public Pizza
{
public:
	CACheesePizza(std::string dg,
				std::string sc,
				std::string nm);
	~CACheesePizza(void);
};
