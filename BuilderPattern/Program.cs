


using BuilderPattern;

Beverage beverage;
BeverageDirector beverageDirector = new BeverageDirector();

TeaBuilder teaBuilder = new TeaBuilder();
beverage = beverageDirector.MakeBeverage(teaBuilder);
Console.WriteLine(beverage.ShowBeverage());

CoffeeBuilder coffeeBuilder = new CoffeeBuilder();
beverage = beverageDirector.MakeBeverage(coffeeBuilder);
Console.WriteLine(beverage.ShowBeverage());

Console.ReadKey();