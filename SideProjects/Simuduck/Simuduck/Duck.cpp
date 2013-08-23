#include <iostream>
#include "Duck.h"

Duck::Duck()
{

}

void Duck::perform_quack() const
{
	m_quackbehavior->quack();
}

void Duck::perform_fly() const
{
	m_flybehavior->fly();
}

void Duck::swim() const
{
	std::cout << "I know to swim as all others do" << std::endl;
}

void Duck::set_fly_behavior(FlyBehavior *fb) 
{
	m_flybehavior = fb;
}

void Duck::set_quack_behavior(QuackBehavior *qb) 
{
	m_quackbehavior = qb;
}