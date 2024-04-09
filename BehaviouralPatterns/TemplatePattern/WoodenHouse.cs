using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Foundation Built with wood");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Pillars Built with wood");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Walls Built with wood");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Windows Built with wood");
        }
    }
}
