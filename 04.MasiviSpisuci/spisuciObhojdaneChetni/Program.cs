using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> res = new List<int>();
            

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    res.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
