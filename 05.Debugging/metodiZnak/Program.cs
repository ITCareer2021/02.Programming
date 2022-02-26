using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Znak(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
            else
            if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else 
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
        static void Main(string[] args)
        {
            Znak(int.Parse(Console.ReadLine()));
        }
    }
}
