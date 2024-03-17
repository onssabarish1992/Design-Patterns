using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdapterPattern
{
    // The adapter class that adapts the PaymentProcessor to the IPaymentProvider interface
    internal class PaymentProviderAdapter : PaymentProcessor, IPaymentProvider
    {
        public void MakePayment(string details, decimal amount)
        {
            Console.WriteLine($"Making a payment for: {details}");
            ProcessPayment(amount);
        }
    }
}
