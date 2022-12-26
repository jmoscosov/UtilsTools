using System;
using System.IO;

namespace JMLogger
{
    internal static class Logger
    {
        private const string LOG_FILENAME = @"C:\NCRLogs\JMLogger.LOG";

        internal static void Log(string text)
        {
            if (File.Exists(LOG_FILENAME))
                File.AppendAllText(LOG_FILENAME, $"{DateTime.Now} {text}\r\n");
        }

        internal static void Log(object obj)
        {
            Log(obj.ToString());
        }
    }
}
