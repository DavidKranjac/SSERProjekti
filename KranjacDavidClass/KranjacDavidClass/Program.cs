using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KranjacDavidClass.Klasa;

namespace KranjacDavidClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avion = new Vozilo();

            avion.setBrojKotaca(6);
            avion.setLeti(true);
            avion.setPliva(false);
            avion.setVozi(true);
            avion.setVrsta("Cessna");
            avion.setOznaka("1312");

            Console.WriteLine("Vrsta: " + avion.getVrsta() + "\nOznaka: " + avion.getOznaka() +
                "\nLeti: " + avion.getLeti() + "\nPliva: " + avion.getPliva() + "\nVozi: " +
                avion.getVozi() + "\nBroj kotača: " + avion.getBrojKotaca() + "\n");

            Vozilo kamion = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine(kamion.ToString());

            Console.ReadKey();
        }
    }
}
