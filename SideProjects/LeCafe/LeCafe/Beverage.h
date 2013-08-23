#pragma once
#include <iostream>

class Beverage
{
protected:
	std::string description;

public:
	Beverage(void);
	~Beverage(void);

	virtual double cost() = 0;
	virtual std::string get_desc();
};
