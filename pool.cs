using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class pool
    {
        static void Main(string[] args)
        {
            WaitCallback cb = Run;
            ThreadPool.QueueUserWorkItem(cb, 12);
            Console.WriteLine(DateTime.Now.ToString());
        }
        public static void Run(object state)
        {
            int table = (int)state;
            for(int i=1;i<=10;i++)
                Console.WriteLine($"{table}X{i}={table*i}");
        }
    }
}
