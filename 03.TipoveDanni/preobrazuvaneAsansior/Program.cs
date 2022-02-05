using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double a = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(a);
        }
    }
}
