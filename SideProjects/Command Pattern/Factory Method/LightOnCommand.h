#pragma once
#include "command.h"
#include "Light.h"

class LightOnCommand :
	public command
{
public:
	Light * m_light;
	LightOnCommand(Light * light);
	~LightOnCommand(void);

	void execute();
};
