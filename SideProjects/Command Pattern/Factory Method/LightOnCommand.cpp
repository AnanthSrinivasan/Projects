#include "LightOnCommand.h"

LightOnCommand::LightOnCommand(Light * light)
{
	m_light = light;
}

LightOnCommand::~LightOnCommand(void)
{
}

void LightOnCommand::execute()
{
	m_light->lightOn();
}