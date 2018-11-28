using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Nova = new DateTime(2018, 12, 31, 23, 59, 59);
            DateTime sad = DateTime.Now;
            int dan, sat, min, sec;
            dan = Nova.Month - sad.Month;
            dan = Nova.Day - sad.Day + dan * 30;
            sat = Nova.Hour - sad.Hour;
            min = Nova.Minute - sad.Minute;
            sec = Nova.Second - sad.Second + 1;
            Console.WriteLine("Do Nove godine ostalo je:");
            Console.WriteLine("{0} dana, {1} sati, {2} minuta, {3} sekundi", dan, sat, min, sec);
            Console.ReadKey();
        }
    }
}
