using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class OfflineSource : ISource
    {
        public void GetSourceName()
        {
            Console.WriteLine("Offline Source");
        }
    }
}
