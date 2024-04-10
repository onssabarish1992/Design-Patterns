using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class TravelContext
    {
        private ITravelStrategy _travelStrategy;

        public void SetTravelStrategy(ITravelStrategy argStrategy)
        {
            _travelStrategy = argStrategy;
        }

        public void GoToApirpot()
        {
            _travelStrategy.GoToAirport();
        }
    }
}
