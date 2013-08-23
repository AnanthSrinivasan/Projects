#pragma once
#include "condiment.h"
#include "Beverage.h"

class Whip :
	public Condiment
{

//private:
//	Beverage * beverage;

public:
	Whip(Beverage * bev);
	~Whip(void);
	double cost();
	std::string get_desc();
};
