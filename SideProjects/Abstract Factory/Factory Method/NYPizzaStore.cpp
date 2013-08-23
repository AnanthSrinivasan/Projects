#include "NYPizzaStore.h"
#include "CheesePizza.h"
#include "ClamPizza.h"
#include "PizzaIngredientFactory.h"
#include "NYPizzaIngredientFactory.h"
#include "Pizza.h"

NYPizzaStore::NYPizzaStore(void)
{
}

NYPizzaStore::~NYPizzaStore(void)
{
}

Pizza * NYPizzaStore::createPizza(std::string type)
{
	Pizza * pizza = NULL;
	PizzaIngredientFactory * pif = new NYPizzaIngredientFactory();

	if(type.compare("cheese") == 0)
	{
		pizza = new CheesePizza(pif);
		pizza->setName("NY Cheese Pizza");
	}
	else if(type.compare("clam") == 0)
	{
		pizza = new ClamPizza(pif);
		pizza->setName("NY Clam Pizza");
	}

	return pizza;
}