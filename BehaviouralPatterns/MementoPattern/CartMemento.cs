using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //Captures current state of the cart
    public class CartMemento
    {
        public List<string> Items { get; private set; }

        public CartMemento(List<string> items)
        {
            this.Items = new List<string>(items);
        }
    }
}
