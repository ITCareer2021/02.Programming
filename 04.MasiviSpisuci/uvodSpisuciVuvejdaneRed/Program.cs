using System;
using System.Linq;
using System.Collections.Generic;

namespace spisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for(int i = 0; i<nums.Count; i++)
            {
                Console.WriteLine("nums[" + i + "] = " + nums[i]);
            }
        }
    }
}
