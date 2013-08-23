#pragma once
#include <iostream>

using namespace std;

class Pizza
{

private:
	std::string m_dough;
	std::string m_sauce;
	std::string m_name;

public:
	void prepare();
	void bake();
	void cut();
	void pack();
	std::string getName();

	Pizza(std::string dg, std::string sc, std::string nm);
	~Pizza(void);

};

