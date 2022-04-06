using System;
using System.Linq;
using System.Collections.Generic;

namespace Трите_най_големи_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sortedNums = nums.OrderByDescending(num => num).ToList();
            var largestNums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largestNums));
        }
    }
}
