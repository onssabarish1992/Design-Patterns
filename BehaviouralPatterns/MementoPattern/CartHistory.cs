using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //Manages and keeps track of saved states of the cart
    public class CartHistory
    {
        private Stack<CartMemento> _history = new Stack<CartMemento>();

        public void Save(ShoppingCart cart)
        {
            _history.Push(cart.Save());
        }

        public CartMemento GetLastSavedState()
        {
            return _history.Pop();
        }
    }
}
