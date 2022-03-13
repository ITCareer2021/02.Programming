using System;
using System.Linq;

namespace Обръщане_на_последователността_на_елементите
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
