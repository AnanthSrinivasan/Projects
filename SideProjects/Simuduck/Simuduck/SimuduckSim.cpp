//---
#include <iostream>
#include "Duck.h"
#include "MallardDuck.h"
#include "ModelDuck.h"
#include "FlyRocketPowered.h"
#include "QuackSqueak.h"
//---

int main()
{
	Duck *mallard = new MallardDuck();
	mallard->perform_quack();
	mallard->perform_fly();
	mallard->swim();

	Duck *model = new ModelDuck();
	model->set_fly_behavior(new FlyRocketPowered());
	model->set_quack_behavior(new QuackSqueak());
	model->perform_fly();
	model->perform_quack();

	system("PAUSE");
	return 0;
}
