#include <string>
#include "NYPizzaStore.h"
#include "CAPizzaStore.h"
#include "Pizza.h"
//---
using namespace std;

int main()
{
	NYPizzaStore *nyPizzaStore = new NYPizzaStore();
	CAPizzaStore *caPizzaStore = new CAPizzaStore();

	Pizza *pizza = nyPizzaStore->orderPizza("cheese");
	cout << "First Order : " << pizza->getName() << " Ready..." << endl;

	cout << endl;

	pizza = caPizzaStore->orderPizza("clam");
	cout << "Second Order : " << pizza->getName() << " Ready..." << endl;

	system("PAUSE");
	return 0;
}
