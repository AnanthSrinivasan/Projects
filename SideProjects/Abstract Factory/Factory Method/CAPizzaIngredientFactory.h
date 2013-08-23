#pragma once
#include "pizzaingredientfactory.h"
#include "Dough.h"
#include "Sauce.h"

class CAPizzaIngredientFactory :
	public PizzaIngredientFactory
{
public:
	CAPizzaIngredientFactory(void);
	~CAPizzaIngredientFactory(void);

	Dough * createDough();
	Sauce * createSauce();

};
