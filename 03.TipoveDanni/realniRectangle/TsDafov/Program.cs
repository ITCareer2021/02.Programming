using System;

namespace _4._Правоъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double obikolka = 2 * (a + b);
            double lice = a * b;
            double diagonal = Math.Sqrt(a * a + b * b);


            Console.WriteLine(obikolka);
            Console.WriteLine(lice);
            Console.WriteLine(Math.Round(diagonal, 13));
        }
    }
}
