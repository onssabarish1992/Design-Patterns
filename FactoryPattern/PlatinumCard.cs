using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PlatinumCard : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 600;
        }

        public int GetCardLimit()
        {
            return 80000;
        }

        public string GetCardType()
        {
            return "Platinum Card";
        }
    }
}
