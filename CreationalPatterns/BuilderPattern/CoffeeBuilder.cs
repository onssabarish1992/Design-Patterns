using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class CoffeeBuilder : BeverageBuiler
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Setting Beverage Type");
            GetBeverage().BeverageName = "Coffee";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Adding Milk");
            GetBeverage().Milk = 50;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Adding Powder");
            GetBeverage().PowderQuantity = 20;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Adding Sugar");
            GetBeverage().Sugar = 5;
        }

        public override void SetWater()
        {
            Console.WriteLine("Boiling Water");
            GetBeverage().Water = 19;
        }
    }
}
