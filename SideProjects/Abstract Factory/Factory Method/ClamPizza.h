#pragma once
#include "Pizza.h"
#include "PizzaIngredientFactory.h"

class ClamPizza :
	public Pizza
{
private:
	PizzaIngredientFactory * m_pif;

public:
	ClamPizza(PizzaIngredientFactory * pif);
	~ClamPizza(void);

	void prepare();
};
