

using FactoryPattern;

CreditCard card = null;

Console.WriteLine("Please enter card type");

string cardType = Console.ReadLine();

if (cardType.ToUpper() == "PLATINUM")
{
    card = new PlatinumCard();
}
else if(cardType.ToUpper() == "MONEYBACK")
{
    card = new MoneyBack();
}


Console.WriteLine("Here are the card details");
Console.WriteLine(card.GetCardType());
Console.WriteLine(card.GetCardLimit());
Console.WriteLine(card.GetAnnualCharge());

Console.ReadKey();