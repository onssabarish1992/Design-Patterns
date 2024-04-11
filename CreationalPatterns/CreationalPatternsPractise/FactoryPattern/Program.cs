
using FactoryPattern;

Console.WriteLine("Factory Pattern");

Console.WriteLine("Which match do you want to watch? 1. Football 2. Cricket");

int matchType = Convert.ToInt32(Console.ReadLine());


IMatch match = null;

if(matchType == 1)
{
    match= new FootBallMatch();
}
else
{
    match = new CricketMatch();
}

match.MatchType();
match.MatchDuration();

Console.ReadKey();


