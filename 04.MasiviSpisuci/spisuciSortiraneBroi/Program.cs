using System;
using System.Collections.Generic;
using System.Linq;

namespace list_new
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
                counts[num]++;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                    Console.WriteLine($"{i} -> {counts[i]}");
            }
            ////Sus sortirane
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //nums.Sort();
            //var pos = 0;
            //while (pos < nums.Count)
            //{
            //    int num = nums[pos], count = 1;
            //    while (pos + count < nums.Count &&
            //      nums[pos + count] == num)
            //        count++;
            //    pos = pos + count;
            //    Console.WriteLine($"{num} -> {count}");
            //}


        }
    }
}
