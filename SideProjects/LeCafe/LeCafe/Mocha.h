#pragma once
#include "condiment.h"
#include "Beverage.h"

class Mocha :
	public Condiment
{

//private:
//	Beverage * beverage;

public:
	Mocha(Beverage * bev);
	~Mocha(void);
	double cost();
	std::string get_desc();
};

