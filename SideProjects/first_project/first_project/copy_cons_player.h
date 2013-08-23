//---
#ifndef copy_cons_playerH
#define copy_cons_playerH
//---

class player
{
private:
	int height_in_cms;
	int weight_in_kgs;
	int strength;
	char *name;

public:
	player();
	player(const char* s);
	player(const player&);	//copy constructor
	
	void profile();			//displays player profile
	const player& operator=(const player&); //assignment operator
};

#endif

/*

When you don't define a copy constructor for your class, 
compiler provides a default copy constructor similar to the default constructor we saw in the earlier section.

Before going in detail, first we will understand why copy constructors are needed.
Answer: when you want to create objects from an existing object. for ex:

Player p1(181, 70, 10, "Ananth");
Player p2(p1); Here the copy constructor is invoked to create p2 from p1.
Player p3=p2; Here also the copy constructor is invoked to create p3 from p2.

You can very well make use of the default copy constructor if your class doesn't contain any pointer variables.
We have a pointer variable in our example, actually what happens in default constructor is, it does a 
member wise copy of the object. In the process of copying if there is a pointer variable then the address of the 
pointer is copied and not what is contained inside the pointer. Now the address is shared by two objects 
(original object and the copied object).

Real catastrophe happens when the destructor is called on any of these two objects, the pointer will be freed
properly for the first object and when the destructor is called for the second object there will not be an 
actual valid pointer available for this object as it already freed for the first object (which might lead to a crash).

*/