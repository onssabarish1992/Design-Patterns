

using MediatorPattern;


Console.WriteLine("Mediator Pattern");

var homeController = new HomeController();

var window = new Window(homeController);
var heater = new Heater(homeController);

window.Open();

Console.ReadKey();



