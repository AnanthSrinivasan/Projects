#pragma once
#ifndef PizzaH
#define PizzaH

#include <iostream>
#include "Dough.h"
#include "Sauce.h"

using namespace std;

class Pizza
{

protected:
	Dough * m_dough;
	Sauce * m_sauce;
	std::string m_name;

public:
	void bake();
	void cut();
	void pack();
	void setName(std::string);

	virtual void prepare();

	std::string getName();

	Pizza();
	~Pizza(void);

};

#endif
