
using CommandPattern;

Console.WriteLine("Command Pattern");
Television tv = new Television();

ICommand turnOn = new TurnOnCommand(tv);
ICommand turnOff = new TurnOffCommand(tv);
ICommand volumeUp = new VolumeUpCommand(tv);
ICommand volumeDown = new VolumeDownCommand(tv);

RemoteControl remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PressButton();

remote.SetCommand(volumeUp);
remote.PressButton();

remote.SetCommand(turnOff);
remote.PressButton();

Console.ReadKey();