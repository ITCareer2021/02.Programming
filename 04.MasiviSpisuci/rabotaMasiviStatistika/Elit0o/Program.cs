using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            Console.WriteLine($"min = {num.Min()}");
            Console.WriteLine($"max = {num.Max()}");
            Console.WriteLine($"Sum = {num.Sum()}");
            Console.WriteLine($"Avarage = {num.Average()}");
        }
    }
}
