#include <iostream>
#include "ModelDuck.h"
#include "FlyWithWings.h"
#include "QuackSimple.h"

ModelDuck::ModelDuck()
{
	m_flybehavior = new FlyWithWings();
	m_quackbehavior = new QuackSimple();
}

void ModelDuck::display()
{
	std::cout << "I am Mr. Model " << std::endl;
}