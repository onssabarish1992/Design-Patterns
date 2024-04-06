using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ATM
    {
        private TwoThousandHandler twoThousandHandler=new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        public ATM()
        {
            twoThousandHandler.SetNextHandler(fiveHundredHandler);
        }

        public void Withdraw(long requestedAmount)
        {
            //First check whether the amount is Divisible by 100 or not
            if (requestedAmount % 100 == 0)
            {
                twoThousandHandler.DispatchNote(requestedAmount);
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
            }
        }
    }
}
