using StrategyMaps.Interfaces;

namespace StrategyMaps.ConcreteStrategies
{
    public class TransportTaxi : ITransport
    {
        public void GetDurationTime()
        {
            Console.WriteLine("\nYou will take 18 min to get to Ipanema Beach by taxi");
        }
    }
}
