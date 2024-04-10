using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Veterinaran : IVisitor
    {
        public void Visit(Lion lion)
        {
            Console.WriteLine("Checks lions health");
        }

        public void Visit(Dolphin dolphin)
        {
            Console.WriteLine("Checks dolphin health");
        }

        public void Visit(Bird bird)
        {
            Console.WriteLine("Checks bird health");
        }
    }
}
