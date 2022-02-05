using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //TODO
            Console.WriteLine($"min = {numbers.Min()}");
            Console.WriteLine($"max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Avarage = {numbers.Average()}");
        }
    }
}
