﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class FiveHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 500 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 500;

            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
                }
            }
        }
    }
}
