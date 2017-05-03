namespace DelegatesPredicates.LoggerUtility
{
    public interface ILogger
    {
        void OnLog(string msg);
    }
    public class Logger
    {
        public delegate void Handler(string message);

        public event Handler LogEvent = null;
        public Logger(ILogger obj)
        {
            LogEvent += obj.OnLog;
        }
        public void Log(string msg)
        {
            LogEvent?.Invoke(msg);
        }
    }


}
