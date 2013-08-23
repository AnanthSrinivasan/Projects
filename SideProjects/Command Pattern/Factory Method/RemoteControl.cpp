#include "RemoteControl.h"
#include "command.h"

RemoteControl::RemoteControl(void)
{
}

RemoteControl::~RemoteControl(void)
{
}

void RemoteControl::setCommand(command * cmd)
{
	slot = cmd;
}

void RemoteControl::buttonPressed()
{
	slot->execute();
}