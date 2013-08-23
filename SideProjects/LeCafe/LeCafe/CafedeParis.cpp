//---
#include <iostream>
#include <string>
#include "Beverage.h"
#include "HouseBlend.h"
#include "FrenchVennila.h"
#include "Mocha.h"
#include "Whip.h"
#include "Soy.h"
//---
using namespace std;

int main()
{
	Beverage *bev1 = new FrenchVennila();
	bev1 = new Mocha(bev1);
	bev1 = new Whip(bev1);
	
	Beverage *bev2 = new HouseBlend();
	bev2 = new Soy(bev2);
	bev2 = new Mocha(bev2);
	bev2 = new Whip(bev2);
	
	cout << bev2->get_desc() << " $" << bev2->cost() << endl;
	cout << bev1->get_desc() << " $" << bev1->cost() << endl;
	system("PAUSE");
	return 0;
}
