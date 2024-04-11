using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Beverage
    {
        public int sugarteaSpoons { get; set; }

        public int Milk { get; set; }

        public int Water { get; set; }

        public string? BeverageType { get; set; }


        public void DisplayBeverage()
        {
            Console.WriteLine(this.sugarteaSpoons+" "+this.Milk+" "+this.Water+" "+this.BeverageType);
        }
    }
}
