using BuilderPatternPizza;
Console.WriteLine("Builder Pattern to make Pizza");

//Veg Pizza
var vegPizzaDirector = new PizzaDirector();
vegPizzaDirector.MakePizza(new VegPizzaBuilder());

//Non Veg Pizza
var nonvegPizzaDirector = new PizzaDirector();
nonvegPizzaDirector.MakePizza(new NonVegPizzaBuilder());

Console.ReadKey();
