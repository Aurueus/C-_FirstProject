using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public interface ILogger
    {
        void Log(string message);
        void LogWithTime(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}