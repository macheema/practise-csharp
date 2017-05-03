using System.IO;

namespace DelegatesPredicates.LoggerUtility
{
    public class FileLogger : ILogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;

        // Constructor
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.OpenOrCreate);
            streamWriter = new StreamWriter(fileStream);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }

        public void OnLog(string msg)
        {
            streamWriter.WriteLine(msg);
            streamWriter.Flush();
        }
    }
}
