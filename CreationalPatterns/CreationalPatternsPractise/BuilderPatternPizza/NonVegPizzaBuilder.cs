using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternPizza
{
    public class NonVegPizzaBuilder : PizzaBuilder
    {
        public override void SetCrust()
        {
            Console.WriteLine("Setting crust for Pizza");
            GetPizza().Crust = "Thick";
        }

        public override void setPizzaType()
        {
            Console.WriteLine("NonVeg Pizza");
            GetPizza().PizzaType = "NonVeg";
        }

        public override void SetToppingsCount()
        {
            Console.WriteLine("NonVeg Toppings Count");
            GetPizza().ToppingsCount = 3;
        }
    }
}
