#include <iostream>
#include <string>
#include "ClamPizza.h"

ClamPizza::ClamPizza(PizzaIngredientFactory * pif) : m_pif(pif)
{
	cout << "Clam Pizza " << endl;
}

ClamPizza::~ClamPizza(void)
{
}

void ClamPizza::prepare()
{
	cout << "Preparing..." << m_name << endl;
	m_dough = m_pif->createDough();
	cout << "Tossing Dough..." << m_dough->desc << endl;
	m_sauce = m_pif->createSauce();
	cout << "Adding Sauce..." << m_sauce->desc << endl;
}

