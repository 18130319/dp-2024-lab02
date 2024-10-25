namespace StrategyLab2
{
    public class Logger
    {
        public readonly IStrategy _strategy;

        public Logger(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Log(string message)
        {
            _strategy.Log(message);
        }
    }
}