using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CricketMatch : IMatch
    {
        public void MatchDuration()
        {
            Console.WriteLine("7 hrs");
        }

        public void MatchType()
        {
            Console.WriteLine("Cricket Match");
        }
    }
}
