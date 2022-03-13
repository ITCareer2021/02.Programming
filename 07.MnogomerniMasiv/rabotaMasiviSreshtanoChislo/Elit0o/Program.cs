using System;
using System.Linq;

namespace Най_често_срещано_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = 0;
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int br = 0;
                for (int n = 0; n < arr.Length; n++)
                {
                    if (arr[i] == arr[n])
                    {
                        br++;
                    }
                }

                if (br > max)
                {
                    num = arr[i];
                    max = br;
                }
            }
            Console.WriteLine(num);
        }
    }
}
