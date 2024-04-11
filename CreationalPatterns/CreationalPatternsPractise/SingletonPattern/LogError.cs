using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    sealed internal class LogError
    {
        private static LogError? _instance;
        private static int counter = 0;
        private static readonly object _lock = new object();
        private LogError()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static LogError GetInstance()
        {
            lock (_lock)
            {
                if(_instance == null)
                {
                    _instance = new LogError();
                }
            }

            return _instance;
        }

        public void LogApplicationError()
        {
            Console.WriteLine("Error Logged");
        }
    }
}

