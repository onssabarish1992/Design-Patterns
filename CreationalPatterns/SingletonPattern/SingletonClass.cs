using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternNotThreadSafe
{
    sealed internal class SingletonClass
    {
        private static int Counter = 0;

        private static SingletonClass? Instance = null;

        public static SingletonClass GetInstance()
        {
            if (Instance == null)
                Instance = new SingletonClass();
            
            return Instance;
        }

        private SingletonClass()
        {
            Counter++;
            Console.WriteLine("Counter Value is: " + Counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
