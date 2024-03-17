using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdapterPattern
{
    // The third-party PaymentProcessor class
    internal class PaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"You have paid {amount}.");
        }
    }
}
