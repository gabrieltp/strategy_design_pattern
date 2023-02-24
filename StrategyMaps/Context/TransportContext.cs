using StrategyMaps.Interfaces;

namespace StrategyMaps.Context
{
    public class TransportContext
    {
        private ITransport _transport;

        public TransportContext(ITransport transport)
        {
            _transport = transport;
        }

        public void DefineStrategy(ITransport transport)
        {
            _transport = transport ?? throw new ArgumentNullException(nameof(transport));
        }

        public void GetEstimatedTime()
        {
            _transport.GetDurationTime();
        }
    }
}
