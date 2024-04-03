using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class PlaceOrder
    {

        public void PlaceUserOrder()
        {
            Console.WriteLine("Placing Order...");

            //Get Product Details
            Product product = new Product();
            product.GetProductDetails();

            //Make Payment
            Payment payment = new Payment();
            payment.MakePayment();

            //Send Invoice
            Invoice invoice = new Invoice();
            invoice.SendInvoice();

            Console.WriteLine("Order placed successfully....");
        }

    }
}
