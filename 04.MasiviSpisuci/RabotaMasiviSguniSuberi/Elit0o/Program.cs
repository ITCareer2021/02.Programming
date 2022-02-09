using System;
using System.Linq;

namespace SguniSuberi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            Array.Reverse(arr, 0, arr.Length);

            int[] result = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                result[i] += arr[arr.Length - k + i] + arr[arr.Length - k - i - 1];
                result[i + k] += arr[i] + arr[arr.Length - (2 * k) - i - 1];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
