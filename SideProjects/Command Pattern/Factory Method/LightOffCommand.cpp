#include "LightOffCommand.h"
#include "Light.h"

LightOffCommand::LightOffCommand(Light * light)
{
	m_light = light;
}

LightOffCommand::~LightOffCommand(void)
{
}

void LightOffCommand::execute()
{
	m_light->lightOff();
}
