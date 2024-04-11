using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CoffeeBuilder : BeverageBuilder
    {
        public override void AddMilk()
        {
            Console.WriteLine("1 litre");
            GetBeverage().Milk = 1;
        }

        public override void AddSugar()
        {
            Console.WriteLine("2 teaspoons");
            GetBeverage().sugarteaSpoons = 2;
        }

        public override void AddWater()
        {
            Console.WriteLine("1 Glass");
            GetBeverage().Water = 1;
        }

        public override void SetBeverageType()
        {
            Console.WriteLine("Coffee");
            GetBeverage().BeverageType = "Coffee";
        }
    }
}
