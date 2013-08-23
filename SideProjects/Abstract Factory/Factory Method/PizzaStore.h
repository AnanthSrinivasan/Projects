#pragma once
#include <iostream>
#include "Pizza.h"

class PizzaStore
{
public:
	PizzaStore(void);
	~PizzaStore(void);

	Pizza * orderPizza(std::string type);
	virtual Pizza * createPizza(std::string type) = 0;
};
