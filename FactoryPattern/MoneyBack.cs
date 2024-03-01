using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public int GetCardLimit()
        {
            return 50000;
        }

        public string GetCardType()
        {
            return "Money Back";
        }
    }
}
