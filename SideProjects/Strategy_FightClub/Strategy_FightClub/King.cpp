#include "King.h"
#include "SwordBehavior.h"

King::King(void)
{
	m_weapon = new SwordBehavior();
}

King::~King(void)
{
}
