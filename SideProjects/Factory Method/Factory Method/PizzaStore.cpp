#include "PizzaStore.h"
#include "Pizza.h"

PizzaStore::PizzaStore(void)
{
}

PizzaStore::~PizzaStore(void)
{
}

Pizza * PizzaStore::orderPizza(std::string type)
{
	Pizza *pizza = NULL;

	pizza = createPizza(type);

	pizza->prepare();
	pizza->bake();
	pizza->cut();
	pizza->pack();

	return pizza;
}