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
            if (szam % 2 == 0)
            {
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
            else if (szam < 0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám nulla");
            }
            Console.WriteLine("Adjon meg egy hónapszámot (1-12): ");
            int honap = int.Parse(Console.ReadLine());
            if (1 <= honap && honap <= 2)
            {
                Console.WriteLine("Tél");
            }
            else if (3 <= honap && honap <= 5)
            {
                Console.WriteLine("Tavasz");
            }
            else if (6 <= honap && honap <= 8)
            {
                Console.WriteLine("Nyár");
            }
            else if (9 <= honap && honap <= 11)
            {
                Console.WriteLine("Ősz");
            }
            else
            {
                Console.WriteLine("Tél");
            }
            Console.WriteLine("Adja meg életkorát: ");
            int kor = int.Parse(Console.ReadLine());
            if (kor>=18)
            {
                Console.WriteLine("Szavazhat");
            }
            else
            {
                Console.WriteLine("Nem szavazhat");
            }
            Console.WriteLine("Adjon meg egy jegyet: ");
            int jegy = int.Parse(Console.ReadLine());
            if (1<=jegy && jegy<=2)
            {
                Console.WriteLine("Elégtelen");
            }
            else if(jegy == 3)
            {
                Console.WriteLine("Elégséges");
            }
            else if (jegy == 4) {
                Console.WriteLine("Jó");
            }
            else
            {
                Console.WriteLine("Jeles");
            }
            Random rnd = new Random();
            int rand = rnd.Next(1, 5);  
            Console.WriteLine("Kitaláltam egy számot 1 és 5 között. Próbáld meg kitalálni: ");
            Console.WriteLine("Itt van amúgy: " + rand);
            int tipp = 0;
            while (tipp != rand)
            {
                tipp = int .Parse(Console.ReadLine());
                if (tipp < rand)
                {
                    Console.WriteLine("A szám nagyobb. Új tipp?");
                }
                else if (tipp > rand)
                {
                    Console.WriteLine("A szám kisebb. Új tipp?");
                }
                else
                {
                    Console.WriteLine("Eltaláltad!");
                }

            }
        }
        }
}
