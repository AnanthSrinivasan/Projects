#include <iostream>
#include "Pizza.h"

using namespace std;

Pizza::Pizza(void)
{
}

Pizza::~Pizza(void)
{
}

void Pizza::prepare()
{
	cout << "Preparing Pizza" << endl;
}

void Pizza::bake()
{
	cout << "Bake at 200 deg C" << endl;
}

void Pizza::cut()
{
	cout << "Cut in Pie's" << endl;
}

void Pizza::box()
{
	cout << "Box the Pizza's" << endl;
}

