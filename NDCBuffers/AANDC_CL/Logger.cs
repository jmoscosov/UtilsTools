using System;
using System.IO;

namespace AANDC_CL
{
    public static class Logger
    {
        private const string LOG_FILENAME = @"C:\NCRLogs\SetDefaultPrinterCounters.LOG";

        public static void Log(string text)
        {
            //if (File.Exists(LOG_FILENAME))
                File.AppendAllText(LOG_FILENAME, $"{DateTime.Now} {text}\r\n");
        }
        public static void Log(string LOG_FILE,string text)
        {
            if (File.Exists(LOG_FILE))
                File.AppendAllText(LOG_FILE, $"{DateTime.Now} {text}\r\n");
        }
        internal static void Log(object obj)
        {
            Log(obj.ToString());
        }
    }
}
