using StrategyMaps.Interfaces;

namespace StrategyMaps.ConcreteStrategies
{
    public class TransportBike : ITransport
    {
        public void GetDurationTime()
        {
            Console.WriteLine("\nIt will take you 30 min to get to Ipanema Beach by bike");
        }
    }
}
