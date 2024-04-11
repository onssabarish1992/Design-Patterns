using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternPizza
{
    public class Pizza
    {
        public string PizzaType{ get; set; }

        public int ToppingsCount { get; set; }

        public string Crust{ get; set; }

        public void DisplayPizza()
        {
            Console.WriteLine(this.PizzaType+" "+this.ToppingsCount+" "+this.Crust);
        }
    }
}
