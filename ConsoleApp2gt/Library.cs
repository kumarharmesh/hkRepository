using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2gt
{
    class Library
    {
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }
        public int Day()
        {
           return 1200;   
        }
        public double Root(int x)
        {
         return Math.Sqrt(x);   
        }
    }
}
