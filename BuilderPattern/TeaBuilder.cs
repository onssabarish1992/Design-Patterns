using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class TeaBuilder : BeverageBuiler
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Setting Beverage Type");
            GetBeverage().BeverageName = "Tea";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Adding Milk");
            GetBeverage().Milk = 40;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Adding Powder");
            GetBeverage().PowderQuantity = 10;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Adding Sugar");
            GetBeverage().Sugar = 10;
        }

        public override void SetWater()
        {
            Console.WriteLine("Boiling Water");
            GetBeverage().Water = 20;
        }
    }
}
