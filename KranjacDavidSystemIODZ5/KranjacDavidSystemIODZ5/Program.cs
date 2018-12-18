using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranjacDavidSystemIODZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(@"D:\My Documents\NOOP\datoteka.txt");
            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();
        }
    }
}
