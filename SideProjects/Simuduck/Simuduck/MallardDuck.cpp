#include <iostream>
#include "MallardDuck.h"
#include "FlyWithWings.h"
#include "QuackSimple.h"

MallardDuck::MallardDuck()
{
	m_flybehavior = new FlyWithWings();
	m_quackbehavior = new QuackSimple();
}

//void MallardDuck::swim()	//Swim function has been overridden
//{
//	std::cout << "I am a Mallard Swimmer " << std::endl;
//}

void MallardDuck::display()
{
	std::cout << "I am Mr. Mallard " << std::endl;
}