using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class SMSMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Message Sent using SMS: "+" "+ message);
        }
    }
}
