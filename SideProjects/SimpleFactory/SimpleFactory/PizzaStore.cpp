#include "PizzaStore.h"
#include "SimplePizzaFactory.h"

PizzaStore::PizzaStore(SimplePizzaFactory *spf) : m_spf(spf)
{

}

PizzaStore::~PizzaStore(void)
{
}

Pizza * PizzaStore::orderPizza(std::string type) 
{
	Pizza *pizza;

	pizza = m_spf->createPizza(type);
		
	pizza->prepare();
	pizza->bake();
	pizza->cut();
	pizza->box();

	return pizza;
}

