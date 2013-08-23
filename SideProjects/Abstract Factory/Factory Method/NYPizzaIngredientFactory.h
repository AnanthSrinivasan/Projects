#pragma once
#include "pizzaingredientfactory.h"
#include "Dough.h"
#include "Sauce.h"

class NYPizzaIngredientFactory :
	public PizzaIngredientFactory
{
public:
	NYPizzaIngredientFactory(void);
	~NYPizzaIngredientFactory(void);

	Dough * createDough();
	Sauce * createSauce();
};
