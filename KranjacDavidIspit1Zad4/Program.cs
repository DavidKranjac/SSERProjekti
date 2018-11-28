using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranjacDavidIspit1Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            char b;
            int z = 0, v = 0;
            int[] n1 = new int[50];
            int[] n2 = new int[50];
            Console.WriteLine("Unesite brojeve 1. niza, za prelazak u drugi niz napisite 2.(mora biti tocka poslije 2); a za kraj drugog niza napisite 3.(takoder tocka nakon 3)");
            do
            {
                a = Console.ReadLine();
                if (a == "2.") break;
                b = Convert.ToChar(a);
                n1[z] = Convert.ToInt32(b + "");
                z++;
            }
            while (a != "2.");
            do
            {
                a = Console.ReadLine();
                if (a == "3.") break;
                b = Convert.ToChar(a);
                n2[v] = Convert.ToInt32(b + "");
                v++;
            }
            while (a != "3.");
            foreach(int i in n1)
                foreach(int j in n2)
                {
                    if (n1[i] == n2[j])
                    {
                        Console.WriteLine(n1);
                    }
                }
            Console.ReadKey();
        }
    }
}
