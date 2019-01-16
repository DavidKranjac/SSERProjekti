using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranjacDavidSystemIOOtpustanjeUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("\n-- Zapisujemo u datoteku...");
            using (StreamWriter sw = new StreamWriter(@"D:\NOOP\datoteka.txt"))
            {
                sw.WriteLine("Ime: {0}", ime);
                sw.WriteLine("Prezime: {0}", prezime);
            }
            Console.WriteLine("\n-- Pročitano iz datoteke:");
            using (StreamReader sr = new StreamReader(@"D:\NOOP\datoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
