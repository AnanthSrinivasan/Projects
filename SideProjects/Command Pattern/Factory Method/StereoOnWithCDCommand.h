#pragma once
#include "command.h"
#include "Stereo.h"

class StereoOnWithCDCommand :
	public command
{
public:
	Stereo * m_stereo;
	StereoOnWithCDCommand(Stereo * stereo);
	~StereoOnWithCDCommand(void);

	void execute();
};
