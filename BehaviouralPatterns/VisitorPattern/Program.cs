
using VisitorPattern;

Console.WriteLine("Visitor Patterns");

IAnimal lion = new Lion();
IAnimal dolphin = new Dolphin();
IAnimal bird = new Bird();

IVisitor vet = new Veterinaran();
IVisitor visitor = new Visitor();

Console.WriteLine("Veterinarian visits:");
lion.Accept(vet);
dolphin.Accept(vet);
bird.Accept(vet);

Console.WriteLine("\nZoo visitor visits:");
lion.Accept(visitor);
dolphin.Accept(visitor);
bird.Accept(visitor);


Console.ReadKey();
