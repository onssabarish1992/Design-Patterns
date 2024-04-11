using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class TeaBuilder : BeverageBuilder
    {
        public override void AddMilk()
        {
            Console.WriteLine("2 litre");
            GetBeverage().Milk = 2;
        }

        public override void AddSugar()
        {
            Console.WriteLine("3 teaspoons");
            GetBeverage().sugarteaSpoons = 3;
        }

        public override void AddWater()
        {
            Console.WriteLine("2 Glass");
            GetBeverage().Water = 2;
        }

        public override void SetBeverageType()
        {
            Console.WriteLine("Tea");
            GetBeverage().BeverageType = "Tea";
        }
    }
}
