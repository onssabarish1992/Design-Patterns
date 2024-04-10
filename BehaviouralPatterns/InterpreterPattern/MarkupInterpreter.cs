using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class MarkupInterpreter 
    {
        private List<IExpression> expressions;

        public MarkupInterpreter()
        {
            expressions = new List<IExpression>
            {
                new HeaderExpression(),
                new ItalicExpression(),
                new BoldExpression(),
            };
        }

        public string Interpret(string argContext)
        {
            foreach (var expression in expressions)
            {
                argContext = expression.Interpret(argContext);
            }

            return argContext;
        }
    }
}
