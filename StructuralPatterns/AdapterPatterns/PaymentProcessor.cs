using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatterns
{
    //Third party class for payment
    internal class PaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"You have paid {amount}.");
        }
    }
}
