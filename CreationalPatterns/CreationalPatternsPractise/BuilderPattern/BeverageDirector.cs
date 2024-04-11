using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BeverageDirector
    {
        public Beverage MakeBeverage(BeverageBuilder argBeverageBuilder)
        {
            argBeverageBuilder.CreateBeverage();
            argBeverageBuilder.SetBeverageType();
            argBeverageBuilder.AddWater();
            argBeverageBuilder.AddMilk();
            argBeverageBuilder.AddSugar();

            return argBeverageBuilder.GetBeverage();
        }

    }
}
