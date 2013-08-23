//---
#ifndef DuckH
#define DuckH
//---

#include "FlyBehavior.h"
#include "QuackBehavior.h"

class Duck
{
protected:							//We separate the behaviors that vary in an application
	FlyBehavior *m_flybehavior;		//Here we bring the composition instead of inheriting 
	QuackBehavior *m_quackbehavior;	//the behaviors directly

public:
	Duck();
	void perform_quack() const;
	void perform_fly() const;
	void swim() const;
	virtual void display() = 0;
	void set_fly_behavior(FlyBehavior *fb);		//This is where we achieve programming to an
	void set_quack_behavior(QuackBehavior *qb);	//interface and not an implementation

};

#endif
