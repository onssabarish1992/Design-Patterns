using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternPizza
{
    public class VegPizzaBuilder : PizzaBuilder
    {
        public override void SetCrust()
        {
            Console.WriteLine("Setting crust for Pizza");
            GetPizza().Crust = "Thin";
        }

        public override void setPizzaType()
        {
            Console.WriteLine("Veg Pizza");
            GetPizza().PizzaType = "Veg";
        }

        public override void SetToppingsCount()
        {
            Console.WriteLine("Veg Toppings Count");
            GetPizza().ToppingsCount = 2;
        }
    }
}
