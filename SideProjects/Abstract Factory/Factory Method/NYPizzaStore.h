#pragma once
#include "pizzastore.h"

class NYPizzaStore :
	public PizzaStore
{
public:
	NYPizzaStore(void);
	~NYPizzaStore(void);

	Pizza * createPizza(std::string type); 
};
