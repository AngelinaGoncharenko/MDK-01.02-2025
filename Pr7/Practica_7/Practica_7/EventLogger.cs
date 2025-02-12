using System;
using System.IO;

namespace Practica_7
{
    public class EventLogger
    {
        private readonly string logFilePath = "events.log";

        public void Log(string message)
        {
            // Точка останова 5: В методе Log класса EventLogger
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        public void CalculationPerformedLog(string details)
        {
            Log($"Операция: {details}");
        }

        public static void LogToConsole(string details)
        {
            Console.WriteLine($"Console Log: {details}");
        }
    }
}
