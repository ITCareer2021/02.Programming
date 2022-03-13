using System;
using System.Linq;

namespace Преобразуване_на_масив_в_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[nums.Length - 1];

            int a = nums.Length;

            while (a != 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    sum[i] = nums[i] + nums[i + 1];
                }

                a--;
                nums = sum;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
