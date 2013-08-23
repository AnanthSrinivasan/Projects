#include "SimplePizzaFactory.h"
#include "CheesePizza.h"
#include "ClamPizza.h"

SimplePizzaFactory::SimplePizzaFactory(void)
{
}

SimplePizzaFactory::~SimplePizzaFactory(void)
{
}

Pizza * SimplePizzaFactory::createPizza(std::string type)
{
	Pizza *pizza = NULL;

	if(type.compare("cheese") == 0)
		pizza = new CheesePizza();
	else if(type.compare("clam") == 0)
		pizza = new ClamPizza();

	return pizza;
}


