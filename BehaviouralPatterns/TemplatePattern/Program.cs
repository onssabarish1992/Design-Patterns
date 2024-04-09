
using TemplatePattern;

Console.WriteLine("Template Pattern");

//Build Concrete House
HouseTemplate housetemplate = new ConcreteHouse();
housetemplate.BuildHouse();

//Build Wooden House
HouseTemplate woodenHousetemplate = new ConcreteHouse();
woodenHousetemplate.BuildHouse();

Console.ReadKey();
