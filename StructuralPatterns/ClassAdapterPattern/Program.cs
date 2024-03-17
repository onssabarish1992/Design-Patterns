using ClassAdapterPattern;

var paymentProvider = new PaymentProviderAdapter();

paymentProvider.MakePayment("Class Adapter Pattern", 200);

Console.ReadKey();
