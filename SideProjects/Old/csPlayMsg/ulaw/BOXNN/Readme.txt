Name: PlayMsg 

Description:

This sample shows how a simple messaging system
(i.e. Mailbox) can be setup. This mechanism is the 
foundation for a voicemail system.  


Steps Required:
The Record control must be set to record files into a 
directory (or directories) that the PlayMsgs control can 
access.  As well the extension on the file recorded must 
be .vnm or vom.
The PlayMsgs contol must be set to look for the files in 
the appropriate directory


Implementation:
The LineGroup control answers the call, and the "GetInput" 
GetDigits control prompts for 1 to record a message, 2 to 
listen to message, or 8 to exit.
If 1 is pressed, the call goes to the Record control, where 
it records a message named boxnn\msg*.vnm.  This will go to the 
boxnn directory of the project voice directory.  The file 
name will be msg + 8 random characters with a vnm extension.
If 2 is pressed, the call goes to the PlayMsgs control, 
where it looks to the \boxnn\ directory for files with the 
extension .vnm or .vom.


Notes:
.vnm stands for VBVoice New Message.
.vom stands for VBVoice Old Message.

When the delete option is chosen in the PlayMsgs control, the 
message file is not actually deleted.  Instead the extension 
is changed to .vdm (VBVoice Deleted Message).  This allows 
for messages to be recovered when accidentally deleted.  An 
off-line system (not provided) must be used to kill the 
files marked .vdm.

When setting up a system control reference 
(%controlname.propertyname%) can be used to allow the same 
Record and PlayMsgs controls to access different mailboxes - 
simply use the control reference to point to different 
directories.  See the voicemail sample for more details on 
this.  If a control reference is not used in the PlayMsgs, 
messages cannot be forwarded to other boxes.

Also note the usage of the File Data field in the Record 
control.  The information specified in this field is embedded 
into the recorded file.  This data is then extracted to the 
PlayMsgs MsgData property.




