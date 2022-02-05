using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = 0;
            double s = 1;
            double d = 0;

            p = 2 * (a + b);
            s = a * b;
            d = Math.Sqrt(a * a + b * b);

            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(Math.Round(d, 13));
        }
    }
}
