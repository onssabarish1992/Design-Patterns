

using DecoratorPattern;

//Create a plain pizza
PlainPizza plainPizza = new PlainPizza();
Console.WriteLine(plainPizza.MakePizza());

//Chicken Pizza
PizzaDecorator chickenPizzzaDecorator = new ChickenPizzaDecorator(plainPizza);
Console.WriteLine(chickenPizzzaDecorator.MakePizza());

//Vegetable Pizza
PizzaDecorator vegetablePizzzaDecorator = new VegetablePizzaDecorator(plainPizza);
Console.WriteLine(vegetablePizzzaDecorator.MakePizza());

Console.ReadKey();






