﻿using System;
using System.IO;

namespace FixM19
{
    internal static class LoggerClass
    {
        private const string LOG_FILENAME = @"C:\NCRLogs\FixM19.LOG";

        internal static void Log(string text)
        {
                File.AppendAllText(LOG_FILENAME, $"{DateTime.Now} {text}\r\n");
        }

        internal static void Log(object obj)
        {
            Log(obj.ToString());
        }
    }
}
