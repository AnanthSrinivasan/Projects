#include <iostream>
#include <string>
#include "CheesePizza.h"

CheesePizza::CheesePizza(PizzaIngredientFactory * pif) : m_pif(pif) 
{
	cout << "Cheese Pizza " << endl;
}

CheesePizza::~CheesePizza(void)
{
}

void CheesePizza::prepare()
{
	cout << "Preparing..." << m_name << endl;
	m_dough = m_pif->createDough();
	cout << "Tossing Dough..." << m_dough->desc << endl;
	m_sauce = m_pif->createSauce();
	cout << "Adding Sauce..." << m_sauce->desc << endl;
}

