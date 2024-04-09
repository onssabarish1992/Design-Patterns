using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Foundation Built with cement");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Pillars Built with cement");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Walls Built with cement");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Windows Built with cement");
        }
    }
}
