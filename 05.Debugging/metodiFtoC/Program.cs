using System;

namespace ConsoleApp12
{
    class Program
    {
        static double FtoC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{00:F2}",FtoC(double.Parse(Console.ReadLine())));
        }
    }
}
