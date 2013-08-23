//---
#include <iostream>
#include "King.h"
#include "Queen.h"
#include "Bishop.h"
#include "Knight.h"
#include "SwordBehavior.h"
#include "KnifeBehavior.h"
#include "AxeBehavior.h"
#include "BABehavior.h"
//---

int main()
{
	Character *henry = new King();
	std::cout << "I am Henry The King.";
	henry->fight(); 

	Character *elizabeth = new Queen();
	std::cout << "I am Elizabeth The Queen.";
	elizabeth->fight();

	Character *chaitanya = new Bishop();
	chaitanya->fight();

	Character *alexandra = new Knight();
	alexandra->fight();

	Character *louis = new King();
	louis->set_weapon(new AxeBehavior());
	louis->fight();

	alexandra->set_weapon(new KnifeBehavior());
	alexandra->fight();

	system("PAUSE");
	return 0;
}
