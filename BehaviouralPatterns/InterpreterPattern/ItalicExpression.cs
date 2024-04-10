using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class ItalicExpression : IExpression
    {
        public string Interpret(string context)
        {
            return context.Replace("_", "<i>");
        }
    }
}
