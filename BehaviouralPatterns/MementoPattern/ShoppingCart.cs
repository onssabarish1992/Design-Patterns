using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //Represents current cart and its item
    public class ShoppingCart
    {
        public List<string> Items { get; private set; } = new List<string>();

        public void AddItem(string item)
        {
            Items.Add(item);
        }

        public CartMemento Save()
        {
            return new CartMemento(Items);
        }

        public void Restore(CartMemento memento)
        {
            Items = new List<string>(memento.Items);
        }
    }
}
