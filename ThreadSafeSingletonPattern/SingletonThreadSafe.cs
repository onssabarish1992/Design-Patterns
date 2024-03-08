using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonPattern
{
    sealed internal class SingletonThreadSafe
    {
        private static int counter = 0;

        private static SingletonThreadSafe? instance;

        //Create a readonly variable for locking
        private static readonly object _lock=new object();

        private SingletonThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value is: "+ counter);
        }

        public static SingletonThreadSafe GetInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new SingletonThreadSafe();
                }
            }
            

            return instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
