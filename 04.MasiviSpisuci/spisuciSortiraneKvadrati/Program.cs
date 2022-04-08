using System;
using System.Collections.Generic;
using System.Linq;

namespace list_new
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for(int i = 0; i < numbers.Count; i++)
            {
                if(Math.Sqrt(numbers[i]) == (int) Math.Sqrt(numbers[i]))
                {
                    result.Add(numbers[i]);
                    result.Sort();
                    result.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
