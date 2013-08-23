#pragma once
#include "WeaponBehavior.h"

class Character
{
protected:
	WeaponBehavior* m_weapon;

public:
	Character(void);
	~Character(void);
	void fight() const;
	void set_weapon(WeaponBehavior *wp);
};
