using StrategyMaps.Interfaces;

namespace StrategyMaps.ConcreteStrategies
{
    public class TransportSubway : ITransport
    {
        public void GetDurationTime()
        {
            Console.WriteLine("\nIt will take you 18 min to get to Ipanema Beach by subway");
        }
    }
}
