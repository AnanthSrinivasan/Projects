#include "Pizza.h"
#include <iostream>

using namespace std;

Pizza::Pizza()
{
}

Pizza::~Pizza(void)
{
}

void Pizza::prepare()
{

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

void Pizza::setName(std::string name)
{
	m_name = name;
}

