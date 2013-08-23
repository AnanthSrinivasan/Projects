//---
#ifndef first_fileH
#define first_fileH
//---

class first_sample
{
private:
	int m_a;
	int m_b;

public:

	first_sample();
	first_sample(int x, int y);
	void set_values(int x, int y);
	void display();
};

#endif

/*

Each object (instance) have their own set of data members, whereas all the objects in a class use 
the same member functions. Member functions are placed in memory only once when they are defined 
in the class declaration. Data members are placed in memory when each object is defined. 

(Robert Lafore C++, Figure 6.8)

*/