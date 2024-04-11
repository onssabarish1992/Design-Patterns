using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FootBallMatch : IMatch
    {
        public void MatchDuration()
        {
            Console.WriteLine("9 hrs");
        }

        public void MatchType()
        {
            Console.WriteLine("Football Match");
        }
    }
}
