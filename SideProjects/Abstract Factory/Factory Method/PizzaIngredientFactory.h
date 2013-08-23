#pragma once
#include "Dough.h"
#include "Sauce.h"

class PizzaIngredientFactory
{
public:
	PizzaIngredientFactory(void);
	~PizzaIngredientFactory(void);

	virtual Dough * createDough() = 0;
	virtual Sauce * createSauce() = 0;
};
