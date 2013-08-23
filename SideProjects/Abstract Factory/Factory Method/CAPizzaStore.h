#pragma once
#include "PizzaStore.h"

class CAPizzaStore :
	public PizzaStore
{
public:
	CAPizzaStore(void);
	~CAPizzaStore(void);

	Pizza * createPizza(std::string type);

};
