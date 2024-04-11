using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class BeverageBuilder
    {
        protected Beverage? _beverage;

        public void CreateBeverage()
        {
            _beverage = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return _beverage;
        }
        public abstract void AddSugar();

        public abstract void AddMilk();

        public abstract void AddWater();

        public abstract void SetBeverageType();

    }
}
