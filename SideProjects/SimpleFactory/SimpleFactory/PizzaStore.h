#pragma once
#include <iostream>
#include "SimplePizzaFactory.h"
#include "Pizza.h"

class PizzaStore
{
public:
	PizzaStore(SimplePizzaFactory *spf);
	~PizzaStore(void);

	Pizza * orderPizza(std::string type);
	SimplePizzaFactory * m_spf;
};
