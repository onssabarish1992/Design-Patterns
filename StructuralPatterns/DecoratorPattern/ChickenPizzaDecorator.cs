using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }

        public string AddChicken()
        {
            return ", added chicken";
        }
    }
}
