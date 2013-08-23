#pragma once
#include "pizza.h"

class CAClamPizza :
	public Pizza
{
public:
	CAClamPizza(std::string dg,
				std::string sc,
				std::string nm);
	~CAClamPizza(void);
};
