using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class HeaderExpression : IExpression
    {
        public string Interpret(string context)
        {
            return context.Replace("#", "<h1>") + "</h1>";
        }
    }
}
