using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Visitor : IVisitor
    {
        public void Visit(Lion lion)
        {
            Console.WriteLine("Watches Lion from distance");
        }

        public void Visit(Dolphin dolphin)
        {
            Console.WriteLine("Watches dolphin from distance");
        }

        public void Visit(Bird bird)
        {
            Console.WriteLine("Watches bird from distance");
        }
    }
}
