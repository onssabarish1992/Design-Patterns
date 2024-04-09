using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class Vibration : IRingerState
    {
        public void HandleIncomingCall()
        {
            Console.WriteLine("Vibration Mode...");
        }
    }
}
