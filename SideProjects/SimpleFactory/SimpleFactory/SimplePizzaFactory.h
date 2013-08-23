#pragma once
#include <iostream>
#include "Pizza.h"

class SimplePizzaFactory
{
public:
	SimplePizzaFactory(void);
	~SimplePizzaFactory(void);

	Pizza * createPizza(std::string type);
};
