namespace StrategyLab2
{
    public class ConsoleLog : IStrategy
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}