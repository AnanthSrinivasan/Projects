#include <iostream>
#include <string>
#include "mem_init_list_player.h"

int player_racer::count = 0;	//static variable which is common for all objects

player_racer::player_racer()	//default constructor
{
	count++;
}

player_racer::player_racer(int ht, int wt, int stg, const char* s = "")	
:	height_in_cms(ht),
	weight_in_kgs(wt),
	strength(stg)
{
	count++;
	name = new char[strlen(s) + 1];
	strcpy_s(name, strlen(s) + 1, s);
} 

player_racer::player_racer(const player_racer & other)	//Copy Constructor
{
	count++;
	height_in_cms = other.height_in_cms;
	weight_in_kgs = other.weight_in_kgs;
	strength = other.strength;
	name = new char[strlen(other.name) + 1];
	strcpy_s(name, strlen(other.name) + 1, other.name);
}

const player_racer & player_racer::operator =(const player_racer & other) //Assignment Operator
{
	count++;
	height_in_cms = other.height_in_cms;
	weight_in_kgs = other.weight_in_kgs;
	strength = other.strength;
	name = new char[strlen(other.name) + 1];
	strcpy_s(name, strlen(other.name) + 1, other.name);
	return *this;
}

void player_racer::profile()	//Member function to display player profile
{
	std::cout << "Name : " << name << std::endl;
	std::cout << "Height : " << height_in_cms << std::endl;
	std::cout << "Weight : " << weight_in_kgs << std::endl;
	std::cout << "Strength : " << strength << std::endl;
}

int player_racer::no_of_players()
{
	return count;
}


/*

Class's Static Data Member:

Here count is the static variable, 

Unlike other data members which are declared and defined inside the class, 
the static members are declared within the class and defined outside the class.
Putting the definition of static data member outside of class is to emphasize that 
the memory space for such data is allocated only once, before the program start 
to execute and that one static item is accessed by an entire class 
(for all the instances of that player_racer class).

The normal static variable is different from class's static data member 

Normal static variable (consider the following example)

float average(float val)
{
	static float total = 0.0;
	total += val;
	return total;
}

main()
{
	float x;
	x = average(50);
}

Here total is the static variable which is initialized only once for the whole program
static variables exists for the life time of the program and the visibility is within 
the function containing it like local automatic variables.

Hence the normal static variables are used to retain information between calls to function and
class's static data member is used to share information among the instances of the class.

*/
