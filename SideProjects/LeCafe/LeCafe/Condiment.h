#pragma once
#include "Beverage.h"

class Condiment :
	public Beverage
{

protected:
	Beverage * beverage;

public:
	Condiment(Beverage * bev);
	~Condiment(void);

	virtual std::string get_desc() = 0;
};
