#include <string>
#include "SimplePizzaFactory.h"
#include "PizzaStore.h"
#include "Pizza.h"
//---
using namespace std;

int main()
{
	SimplePizzaFactory *omrPizzaFactory = new SimplePizzaFactory();
	PizzaStore *omrPizzaStore = new PizzaStore(omrPizzaFactory);
//	omrPizzaStore->orderPizza("cheese");
//	omrPizzaStore->orderPizza("clam");
	omrPizzaStore->orderPizza("veggie");

	system("PAUSE");
	return 0;
}
