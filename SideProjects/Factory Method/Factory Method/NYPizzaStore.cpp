#include "NYPizzaStore.h"
#include "NYCheesePizza.h"
#include "NYClamPizza.h"

NYPizzaStore::NYPizzaStore(void)
{
}

NYPizzaStore::~NYPizzaStore(void)
{
}

Pizza * NYPizzaStore::createPizza(std::string type)
{
	Pizza * pizza = NULL;

	if(type.compare("cheese") == 0)
	{
		pizza = new NYCheesePizza("Thin Crust", 
									"Marinara Sauce", 
									"NY Style Cheese Pizza");
	}
	else if(type.compare("clam") == 0)
	{
		pizza = new NYClamPizza("Thin Crust", 
									"Marinara Sauce", 
									"NY Style Clam Pizza");
	}

	return pizza;
}