#include <iostream>
#include "NYPizzaIngredientFactory.h"
#include "ThinCrustDough.h"
#include "PlumTomatoSauce.h"

using namespace std;

NYPizzaIngredientFactory::NYPizzaIngredientFactory(void)
{
	cout << "Pizza made of New York Ingredients" << endl;
}

NYPizzaIngredientFactory::~NYPizzaIngredientFactory(void)
{
}

Dough * NYPizzaIngredientFactory::createDough()
{
	return new ThinCrustDough();
}

Sauce * NYPizzaIngredientFactory::createSauce()
{
	return new PlumTomatoSauce();
}
