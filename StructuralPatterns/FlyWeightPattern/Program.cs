

using FlyWeightPattern;

var factory = new CharacterFactory();

var char1 = factory.GetCharacter('A', 12, "Arial");
char1.Display();

var char2 = factory.GetCharacter('B', 14, "Times New Roman");
char2.Display();

// use the flyweight instead of creating new object
var char3 = factory.GetCharacter('A', 12, "Arial");
char3.Display();

Console.ReadKey();