using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            //var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); не е за judge
            //var first = numbers.Take(1).ToList(); не е за judge
            //var last = numbers.Skip(numbers.Count-1).Take(1).ToList(); не е за judge

            //Console.WriteLine($"First = {first[0]}"); не е за judge
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
            //Console.WriteLine($"Last = {last[0]}"); не е за judge
        }
    }
}
