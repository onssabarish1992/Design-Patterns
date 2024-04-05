

using ProxyDesignPattern;

IImage image = new ProxyImage("Food Image");


Console.WriteLine("First call, loading necessary");
image.DisplayImage();

Console.WriteLine("Second call, loading unnecessary");
image.DisplayImage();

Console.ReadKey();