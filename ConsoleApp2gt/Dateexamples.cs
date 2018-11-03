using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2gt
{
    class Dateexamples
    {
        public static string Datetime()
        {
            DateTime d1= DateTime.Now;
            DateTime d2 = DateTime.Now.AddDays(4);

            var x = (d2-d1).Days;
            return "";
        }
        static void Main(string[] args)
        {
            Dateexamples.Datetime();
        }
    }
}
