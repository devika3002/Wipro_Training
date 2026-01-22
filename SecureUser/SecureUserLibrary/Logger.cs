using System;
using System.IO;

namespace SecureUserLibrary
{
    public static class Logger
    {
        private static readonly string logFile = "app.log";

        public static void Log(string message)
        {
            File.AppendAllText(
                logFile,
                $"{DateTime.Now}: {message}{Environment.NewLine}"
            );
        }
    }
}

