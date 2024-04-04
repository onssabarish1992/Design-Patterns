using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class LongMessage : AbstractMessage
    {

        public LongMessage(IMessageSender argSender)
        {
            this.messageSender = argSender;
        }

        public override void SendMessage(string Message)
        {
            messageSender.SendMessage(Message);
        }
    }
}
