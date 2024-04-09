using StateDesignPattern;

Console.WriteLine("State Design Pattern");

MobilePhone mobilePhone = new MobilePhone();

//Play the ringtone
mobilePhone.IncomingCall();

mobilePhone.SetState(new Silent());
mobilePhone.IncomingCall(); // Silent Mode

mobilePhone.SetState(new Vibration());
mobilePhone.IncomingCall(); // Vibration Mode


Console.ReadKey();
