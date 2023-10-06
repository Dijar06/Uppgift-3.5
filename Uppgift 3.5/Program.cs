using System;

namespace Uppgift3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett räknesätt, skriv siffran");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            double siffra = double.Parse(Console.ReadLine());

            double addition = tal1 + tal2;
            double subtraktion = tal1 - tal2;
            double multiplikation = tal1 * tal2;
            double division = tal1 / tal2;

            switch (siffra)
            {
                case 1:
                    Console.WriteLine("Du valde addition, svaret blir " + addition);
                    break;
                case 2:
                    Console.WriteLine("Du valde subtraktion, svaret blir " + subtraktion);
                    break;
                case 3:
                    Console.WriteLine("Du valde multiplikation, svaret blir " + multiplikation);
                    break;
                case 4:
                    Console.WriteLine("Du valde division, svaret blir " + division);
                    break;
                default:
                    Console.WriteLine("Siffra valdes ej, starta om programmet");
                    break;
            }

        }
    }
}