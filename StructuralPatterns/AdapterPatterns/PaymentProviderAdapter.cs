using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatterns
{
    //Adapter class that implements the systems payment provider interface
    internal class PaymentProviderAdapter : IPaymentProvider
    {
        private readonly PaymentProcessor _processor;
        public PaymentProviderAdapter(PaymentProcessor paymentProcessor)
        {
            _processor = paymentProcessor;
        }
        public void MakePayment(string details, decimal amount)
        {
            Console.WriteLine($"Making a payment for: {details}");
            _processor.ProcessPayment(amount);
        }
    }
}
