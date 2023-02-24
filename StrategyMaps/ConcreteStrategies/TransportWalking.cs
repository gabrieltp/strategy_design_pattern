using StrategyMaps.Interfaces;

namespace StrategyMaps.ConcreteStrategies
{
    public class TransportWalking : ITransport
    {
        public void GetDurationTime()
        {
            Console.WriteLine("\nIt will take you 1h 40 min to get to Ipanema Beach walking");
        }
    }
}