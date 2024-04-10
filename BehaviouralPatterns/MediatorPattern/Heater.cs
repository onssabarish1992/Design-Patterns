using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Heater: Component
    {
        public Heater(IHomeController argController): base(argController)
        {

        }
        public void TurnOn()
        {
            Console.WriteLine("Heater turned on.");
        }
    }
}
