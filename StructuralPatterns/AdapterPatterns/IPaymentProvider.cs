using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatterns
{
    //Application interface for making the payment
    internal interface IPaymentProvider
    {
        //This has 2 arguments in contrast to the applications make payment method
        //This is incompatible with the PaymentProcessor class
        void MakePayment(string details, decimal amount);
    }
}
