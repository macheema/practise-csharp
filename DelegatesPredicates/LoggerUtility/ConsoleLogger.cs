using System;

namespace DelegatesPredicates.LoggerUtility
{
    public class ConsoleLogger : ILogger
    {
        public void OnLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
