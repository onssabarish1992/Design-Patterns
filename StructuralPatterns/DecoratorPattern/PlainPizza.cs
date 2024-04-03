using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class PlainPizza : Pizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
