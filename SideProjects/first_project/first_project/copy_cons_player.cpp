#include <iostream>
#include <string>
#include "copy_cons_player.h"

player::player(){}	//default constructor

player::player(const char* s = "")	
{
	height_in_cms = 0;
	weight_in_kgs = 0;
	strength = 0;
	name = new char[strlen(s) + 1];
	strcpy_s(name, strlen(s) + 1, s);
} 

player::player(const player & other)	//Copy Constructor
{
	height_in_cms = other.height_in_cms;
	weight_in_kgs = other.weight_in_kgs;
	strength = other.strength;
	name = new char[strlen(other.name) + 1];
	strcpy_s(name, strlen(other.name) + 1, other.name);
}

const player & player::operator =(const player & other) //Assignment Operator
{
	height_in_cms = other.height_in_cms;
	weight_in_kgs = other.weight_in_kgs;
	strength = other.strength;
	name = new char[strlen(other.name) + 1];
	strcpy_s(name, strlen(other.name) + 1, other.name);
	return *this;
}

void player::profile()	//Member function to display player profile
{
	std::cout << "Name : " << name << std::endl;
	std::cout << "Height : " << height_in_cms << std::endl;
	std::cout << "Weight : " << weight_in_kgs << std::endl;
	std::cout << "Strength : " << strength << std::endl;
}

/*

we will discuss two things about copy constructor,

1.	Parameter of a copy constructor must be a reference.
	what if the parameter is not a reference, then the object has to be passed by value which means object should
	be copied by function which is called (here it is the copy constructor itself), copy constructor again calls 
	itself to do the copy again and it continues wihout being able to get out of it and forms an infinite recursion.
	The standard doesn't allow the parameter to be declared a non reference any more.

2.	It's better have the parameter to be const.
	The parameter is passed by reference, we are not supposed to change the original object. And here we copy a 
	temporary object which cannot be bind to a non-const reference.
	From the below example code, we are not going to modify the other object but to just copy to a temporary object.
	x = other.x is nothing but this->x = other.x, hence we only modify the this object just by copying it from 
	other object	
	Ex:
	Vector(const Vector& other) // Copy constructor 
	{
		x = other.x;
		y = other.y;
	}

Assignment operator:

	It is very apt to discuss about Assignment operator as well while discussing copy constructors
	Assignment operator also has to be overloaded (operator overloading) when you have your version of 
	copy constructor. 
	For example below code invokes the assignment operator and copies one object into other.
	Ex:
	Player p4;
	p4=p3;

*/