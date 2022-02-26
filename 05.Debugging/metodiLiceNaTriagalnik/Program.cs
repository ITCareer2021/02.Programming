using System;

namespace method6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(Triangle(a, h));
        }
        static double Triangle(double a, double h)
        {
            return (a * h) / 2;
        }
    }
}
