#pragma once
#include "condiment.h"
#include "Beverage.h"

class Soy :
	public Condiment
{

//private:
//	Beverage * beverage;

public:
	Soy(Beverage * bev);
	~Soy(void);
	double cost();
	std::string get_desc();
};
