using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class HomeController : IHomeController
    {
        public void Notify(Component sender, string eventInfo)
        {
            if(sender is Window && eventInfo == "opened")
            {
                Console.WriteLine("Turning of Heater");
                Console.WriteLine("Turning of Lights");
            }
        }
    }
}
