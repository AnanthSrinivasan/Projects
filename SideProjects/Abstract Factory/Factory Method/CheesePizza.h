#pragma once
#include "Pizza.h"
#include "PizzaIngredientFactory.h"

class CheesePizza :
	public Pizza
{
private:
	PizzaIngredientFactory * m_pif;

public:
	CheesePizza(PizzaIngredientFactory * pif);
	~CheesePizza(void);

	void prepare();
};
