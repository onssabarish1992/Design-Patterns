using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternPizza
{
    public abstract class PizzaBuilder
    {
        protected Pizza? _pizza;

        public void CreatePizza()
        {
            _pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return new Pizza();
        }

        public abstract void setPizzaType();
        public abstract void SetToppingsCount();
        public abstract void SetCrust();

    }
}
