﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class BoldExpression : IExpression
    {
        public string Interpret(string context)
        {
            return context.Replace("*", "<b>");
        }
    }
}
