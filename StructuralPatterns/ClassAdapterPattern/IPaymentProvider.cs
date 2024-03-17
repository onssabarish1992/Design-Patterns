using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdapterPattern
{
    // Our application's IPaymentProvider interface
    internal interface IPaymentProvider
    {
        void MakePayment(string details, decimal amount);
    }
}
