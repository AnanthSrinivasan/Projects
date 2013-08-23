#pragma once
#include "command.h"
#include "Light.h"

class LightOffCommand :
	public command
{
public:
	Light * m_light;
	LightOffCommand(Light * light);
	~LightOffCommand(void);

	void execute();
};
