//Client to implement the interface

using AdapterPatterns;

var paymentProcessor = new PaymentProcessor();
var paymentProvider = new PaymentProviderAdapter(paymentProcessor);

paymentProvider.MakePayment("C# object design pattern", 100);

Console.ReadKey();
