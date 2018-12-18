using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranjacDavidSystemIODZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();

            if(Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke:");
                foreach(string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }

                string putanjaPodditektorija = putanja + "\\TEST";

                if(!Directory.Exists(putanjaPodditektorija))
                {
                    Directory.CreateDirectory(putanjaPodditektorija)
                }

                Console.WriteLine("Poddirektorij");
                foreach(string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }
                else
                {
                    Console.WriteLine("Putanja ne postoji na računalu!");
                }
                Console.ReadKey();
            }
        }
    }
}
