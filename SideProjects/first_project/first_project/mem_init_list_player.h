//---
#ifndef mem_init_list_playerH
#define mem_init_list_playerH
//---

class player_racer
{
protected:
	int height_in_cms;
	int weight_in_kgs;
	int strength;
	char *name;
	static int count;

public:

	player_racer();
	player_racer(const player_racer &);
	const player_racer & operator=(const player_racer &);
	player_racer( int ht,
			int wt,
			int stg,
			const char *str);
	
	int no_of_players();
	virtual	void profile();			//displays player profile

};

#endif

/*
why member initialization list is preferred over assignment based version

The rules of C++ stipulate that data members of an object are initialized 
before the body of a constructor is entered.

Efficiency:

Assignment based version first uses default constructor to initialize the values and promptly 
assigns the new values on top of the default constructed ones. so the work done in default
constructor is wasted here.

ABEntry(const std::String& name, const std::string& address,
                const std::list<PhoneNumber>& phones)
{
    theName = name;                                        // these are all assignments,
    theAddress = address;                                 // no initializations
    thePhones = phones;
    numTimesConsulted = 0;
}

Where as in member initialization list approach the members are copy constructed and a single 
call to a copy constructor is more efficient and avoids two function calls.

ABEntry(const std::String& name, const std::string& address,
                const std::list<PhoneNumber>& phones):
		theName(name), theAddress(address), thePhones(phones), numTimesConsulted(0) //initializations
{
	//empty consturctor body
}

Necessity:

As per the below example, the following has to be initialized in member initialization list.

1.	references
2.	constant member
3.	sub object(whose constructors takes arguments)

class Thing
{
private:
 int & ref; // reference member
 const int MAX; // const member 
 vector arr;
public:
 Thing(int& r) : ref(r), MAX(100), arr (MAX) {}
};

Notice that the member MAX serves as arr's initializer. This is perfectly legal. 
C++ ensures that members are initialized in the order of their declaration in the class. 
If you change the member initialization list to:

Thing(int& r) : arr(MAX), MAX(100), ref(r) {}

The members will still be initialized in the following order: ref, MAX, and arr.

*/