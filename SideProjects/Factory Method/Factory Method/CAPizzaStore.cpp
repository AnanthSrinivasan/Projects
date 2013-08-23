#include "CAPizzaStore.h"
#include "CACheesePizza.h"
#include "CAClamPizza.h"

CAPizzaStore::CAPizzaStore(void)
{
}

CAPizzaStore::~CAPizzaStore(void)
{
}

Pizza * CAPizzaStore::createPizza(std::string type)
{
	Pizza * pizza = NULL;

	if(type.compare("cheese") == 0)
	{
		pizza = new CACheesePizza("Thick Crust", 
									"Plum Tomato Sauce", 
									"CA Style Cheese Pizza");
	}
	else if(type.compare("clam") == 0)
	{
		pizza = new CAClamPizza("Thick Crust", 
									"Plum Tomato Sauce", 
									"CA Style Clam Pizza");
	}

	return pizza;
}