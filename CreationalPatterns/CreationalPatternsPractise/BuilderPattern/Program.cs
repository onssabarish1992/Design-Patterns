
using BuilderPattern;

Console.WriteLine("Builder Pattern");

var beverageDirector = new BeverageDirector();
beverageDirector.MakeBeverage(new CoffeeBuilder());

Console.ReadKey();
