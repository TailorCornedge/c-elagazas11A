using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0) {
                Console.WriteLine("Ez a szám páros");
            }
            else
            {
                Console.WriteLine("Ez a szám páratan.");
            }
            if (szam > 0)
            {
                Console.WriteLine("A szám pozitív");
            }
            else if (szam < 0) {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám nulla");
            }
            Console.WriteLine("Adjon meg egy hónapszámot (1-12): ");
            int honap = int.Parse(Console.ReadLine());
            if (0<=honap<=1)
            {

            }
        }
    }
}
