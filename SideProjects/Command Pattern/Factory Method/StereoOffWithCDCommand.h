#pragma once
#include "command.h"
#include "Stereo.h"

class StereoOffWithCDCommand :
	public command
{
public:
	Stereo * m_stereo;
	StereoOffWithCDCommand(Stereo * stereo);
	~StereoOffWithCDCommand(void);

	void execute();
};
