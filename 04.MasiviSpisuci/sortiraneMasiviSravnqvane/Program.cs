using System;
using System.Linq;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int f = i + 1; f < arr.Length; f++)
                {
                    if (arr[f] < arr[k])
                        k = f;
                }
                int swapVar = arr[i];
                arr[i] = arr[k];
                arr[k] = swapVar;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
