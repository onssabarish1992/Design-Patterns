
using MementoPattern;

Console.WriteLine("Memento Design Pattern");

ShoppingCart cart = new ShoppingCart();
CartHistory history = new CartHistory();

cart.AddItem("Laptop");
cart.AddItem("Mouse");

history.Save(cart);

cart.AddItem("USB stick");

Console.WriteLine($"Current Cart Items: {string.Join(", ", cart.Items)}");

cart.Restore(history.GetLastSavedState());

Console.WriteLine($"Restored Cart Items: {string.Join(", ", cart.Items)}");

Console.ReadKey();
