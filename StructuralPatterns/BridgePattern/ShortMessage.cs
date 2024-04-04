using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ShortMessage : AbstractMessage
    {

        public ShortMessage(IMessageSender argMessageSender)
        {
            this.messageSender = argMessageSender;
        }

        public override void SendMessage(string Message)
        {
            if(Message.Length <= 10)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send message since max limit is 10 characters");
            }
        }
    }
}
