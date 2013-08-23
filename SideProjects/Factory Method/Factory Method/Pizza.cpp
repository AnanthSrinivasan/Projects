#include "Pizza.h"
#include <iostream>
#include <string>

using namespace std;

Pizza::Pizza(std::string dg, std::string sc, std::string nm) : 
								m_dough(dg),
								m_sauce(sc),
								m_name(nm)
{
}

Pizza::~Pizza(void)
{
}

void Pizza::prepare()
{
	cout << "Preparing Pizza..." << endl;
	cout << "Tossing Dough..." << m_dough << endl;
	cout << "Adding Sauce..." << m_sauce << endl;
}

void Pizza::bake()
{
	cout << "Baking the Pizza..." << endl;
}

void Pizza::cut()
{
	cout << "Cutting Pizza in Pie..." << endl;
}

void Pizza::pack()
{
	cout << "Packing the Pizza..." << endl;
}

std::string Pizza::getName()
{
	return m_name;
}
