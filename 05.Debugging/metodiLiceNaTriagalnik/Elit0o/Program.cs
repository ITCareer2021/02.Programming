using System;

namespace Пресмятане_на_лице_на_триъгълник
{
    class Program
    {
        static double Triangle(double a, double h)
        {
            return (a * h) / 2;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(Triangle(a, h));
        }
    }
}
