// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Chain of Responsbibility");

ATM atm = new ATM();
Console.WriteLine("Requested Amount 4600");
atm.Withdraw(4600);


Console.ReadKey();
