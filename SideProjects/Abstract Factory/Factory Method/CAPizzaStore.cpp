#include "CAPizzaStore.h"
#include "CheesePizza.h"
#include "ClamPizza.h"
#include "PizzaIngredientFactory.h"
#include "CAPizzaIngredientFactory.h"
#include "Pizza.h"

CAPizzaStore::CAPizzaStore(void)
{
}

CAPizzaStore::~CAPizzaStore(void)
{
}

Pizza * CAPizzaStore::createPizza(std::string type)
{
	Pizza * pizza = NULL;
	PizzaIngredientFactory * pif = new CAPizzaIngredientFactory();

	if(type.compare("cheese") == 0)
	{
		pizza = new CheesePizza(pif);
		pizza->setName("CA Cheese Pizza");
	}
	else if(type.compare("clam") == 0)
	{
		pizza = new ClamPizza(pif);
		pizza->setName("CA Clam Pizza");
	}

	return pizza;
}