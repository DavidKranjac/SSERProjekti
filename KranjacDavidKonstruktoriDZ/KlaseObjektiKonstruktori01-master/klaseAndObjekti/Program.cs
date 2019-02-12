using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Vozilo ime = new Vozilo();
            bool jos = true;
            /*Console.WriteLine("Unesite vrstu vozila:");
            ime = Console.ReadLine().ToString();*/
            do
            {
                Console.WriteLine("Kojoj vrsti pripada:");
                ime.setVrsta(Console.ReadLine().ToString());
                Console.WriteLine("Koliko kotača ima vaše vozilo(ako nema napšite 0)");
                ime.setBrojKotaca(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Može li letjeti(true/false):");
                ime.setLeti(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Može li plivati(true/false):");
                ime.setPliva(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Može li voziti(true/false):");
                ime.setVozi(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Koja je oznaka vašeg vozila:");
                ime.setOznaka(Console.ReadLine().ToString());

                Console.WriteLine(ime.ispis());

                Console.WriteLine("Želite li upisati još neko vozilo?(true/false)");
                jos = bool.Parse(Console.ReadLine());
            } while (jos == true);

            /*
            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine("Vrsta: " + ime.getVrsta() + " Oznaka: " +
                ime.getOznaka() + "\nLeti: " + ime.getLeti() + "\nPlovi: "+ ime.getPliva()
                + "\nVozi: " + ime.getVozi() + "\nBroj kotača: "+ime.getBrojKotaca() + "\n");
            
            Console.WriteLine(kamijon.ToString());
            */

            Console.ReadLine();
        }
    }

    
}
