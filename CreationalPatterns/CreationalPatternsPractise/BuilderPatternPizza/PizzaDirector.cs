using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternPizza
{
    public class PizzaDirector
    {
        public Pizza MakePizza(PizzaBuilder argBuilder)
        {
            argBuilder.CreatePizza();
            argBuilder.setPizzaType();
            argBuilder.SetCrust();
            argBuilder.SetToppingsCount();

            return argBuilder.GetPizza();
        }
    }
}
