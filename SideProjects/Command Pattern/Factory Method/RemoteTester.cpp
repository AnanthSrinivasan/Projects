#include <string>
#include "LightOffCommand.h"
#include "LightOnCommand.h"
#include "Light.h"
#include "RemoteControl.h"
//---
using namespace std;

int main()
{
	RemoteControl *rc = new RemoteControl();
	Light * light = new Light();
	LightOffCommand * lightOffcmd = new LightOffCommand(light);
	LightOnCommand * lightOncmd = new LightOnCommand(light);

	rc->setCommand(lightOffcmd);
	rc->buttonPressed();

	rc->setCommand(lightOncmd);
	rc->buttonPressed();

	system("PAUSE");
	return 0;
}
