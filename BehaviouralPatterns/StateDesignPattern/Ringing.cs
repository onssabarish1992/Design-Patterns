using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class Ringing : IRingerState
    {
        public void HandleIncomingCall()
        {
            Console.WriteLine("Ringing Mode...");
        }
    }
}
