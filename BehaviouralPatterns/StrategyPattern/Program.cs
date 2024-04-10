using StrategyPattern;

Console.WriteLine("Strategy Pattern");

TravelContext travelcontext = new TravelContext();

Console.WriteLine("Please enter the travel type");
int travelType = Convert.ToInt32(Console.ReadLine());

if(travelType == (int)TravelType.Bus)
{
    travelcontext.SetTravelStrategy(new BusTravelStrategy());
    travelcontext.GoToApirpot();
}
else if(travelType == (int)TravelType.Train)
{
    travelcontext.SetTravelStrategy(new TrainTravelStrategy());
    travelcontext.GoToApirpot();
}
else
{
    travelcontext.SetTravelStrategy(new TaxiTravelStrategy());
    travelcontext.GoToApirpot();
}

Console.ReadKey();

//Create Enum for travel Type
public enum TravelType
{
    Bus = 1,  // 1 for 
    Train = 2, // 3 for Train
    Taxi = 3  // 4 for Taxi
};




