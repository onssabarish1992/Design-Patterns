using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class VegetablePizzaDecorator : PizzaDecorator
    {
        public VegetablePizzaDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetable();
        }

        public string AddVegetable()
        {
            return ", added vegetables";
        }
    }
}
