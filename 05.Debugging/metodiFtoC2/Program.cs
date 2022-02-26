using System;

namespace method5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var gradus = Temp(n);
            Console.WriteLine("{0:F2}", gradus);
        }
        static double Temp(double n)
        {
            return (n - 32) * 5 / 9;
        }
    }
}
