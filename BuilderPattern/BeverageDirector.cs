using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class BeverageDirector
    {
        public Beverage MakeBeverage(BeverageBuiler beverageBuiler)
        {
            beverageBuiler.CreateBeverage();
            beverageBuiler.SetBeverageType();
            beverageBuiler.SetWater();
            beverageBuiler.SetMilk();
            beverageBuiler.SetSugar();
            beverageBuiler.SetPowderQuantity();

            return beverageBuiler.GetBeverage();
        }
    }
}
