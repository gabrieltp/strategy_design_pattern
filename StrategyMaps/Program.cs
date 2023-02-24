using Microsoft.Extensions.Configuration;
using StrategyMaps.ConcreteStrategies;
using StrategyMaps.Context;

Console.WriteLine("## Strategy Design Pattern ##\n");

TransportContext ctx = new TransportContext(new TransportSubway());

Console.WriteLine("Select the type of transport to go to Ipanema Beach from Flamengo");
Console.WriteLine("1-Subway(Default) 2-Bike 3-Taxi 4-Walking");
var transport = Convert.ToInt32(Console.ReadLine());

if (transport == 2)
{
    ctx.DefineStrategy(new TransportBike());
}
else if (transport == 3)
{
    ctx.DefineStrategy(new TransportTaxi());
}
else if (transport == 4)
{
    ctx.DefineStrategy(new TransportWalking());
}

ctx.GetEstimatedTime();

Console.Read();
