using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
        public void LogError(string message)
        {
            Log("Log error: " + message);
        }

        public void LogInfo(string message)
        {
            Log("Log info: " + message);
        }

        private void Log(string message)
        {
            // the streamWriter uses file resource. The file resource is not managed b Common Language Runtime 
            // which means we need to dispose that resource once we finish using it.
            // There is an exception handel mechnism inside the using that you are not going to see its
            // implemented by the compiler. so if something goes wrong an exception throws the compiler will make sure 
            // to close the file handler by calling the Dispose method. The compiler automatically includes the Dispose method.
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
