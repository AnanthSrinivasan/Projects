#include <iostream>
#include "CAPizzaIngredientFactory.h"
#include "ThickCrustDough.h"
#include "MarinaraSauce.h"

using namespace std;

CAPizzaIngredientFactory::CAPizzaIngredientFactory(void)
{
	cout << "Pizza made of CA Ingredients" << endl;
}

CAPizzaIngredientFactory::~CAPizzaIngredientFactory(void)
{
}

Dough * CAPizzaIngredientFactory::createDough()
{
	return new ThickCrustDough();
}

Sauce * CAPizzaIngredientFactory::createSauce()
{
	return new MarinaraSauce();
}
