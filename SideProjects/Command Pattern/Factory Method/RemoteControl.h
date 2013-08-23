#pragma once
#include "command.h"

class RemoteControl
{
public:
	RemoteControl(void);
	~RemoteControl(void);

	command * slot;

	void setCommand(command * cmd);
	void buttonPressed();
};
