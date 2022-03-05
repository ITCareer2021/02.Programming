using System;
using System.Linq;

namespace _1._Статистика_на_масив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Min = {0}", arr.Min());
            Console.WriteLine("Max = {0}", arr.Max());
            Console.WriteLine("Sum = {0}", arr.Sum());
            Console.WriteLine("Average = {0}", arr.Average());
        }
    }
}
