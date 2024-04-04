


using BridgePattern;

Console.WriteLine("Select Message Type: 1 for short message 2 for long message");

int optionSelected = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the message you want to send.");

string message = Console.ReadLine();

if(optionSelected == 1)
{
    AbstractMessage shortMessage = new ShortMessage(new SMSMessageSender());
    shortMessage.SendMessage(message);
}
else
{
    AbstractMessage LongMessage = new ShortMessage(new EmailMessageSender());
    LongMessage.SendMessage(message);
}

Console.ReadKey();