#include "Character.h"

Character::Character(void)
{
}

Character::~Character(void)
{
}

void Character::fight() const
{
	m_weapon->useWeapon();
}

void Character::set_weapon(WeaponBehavior *wp)
{
	m_weapon = wp;
}