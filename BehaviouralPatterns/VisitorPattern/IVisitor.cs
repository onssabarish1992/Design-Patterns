using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    //Interface Visitor
    public interface IVisitor
    {
        void Visit(Lion lion);
        void Visit(Dolphin dolphin);
        void Visit(Bird bird);
    }
}
