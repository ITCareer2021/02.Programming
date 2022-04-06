using System;
using System.Linq;

namespace masivi_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double min = numbers[0];
            double max = numbers[0];
            double sum = 0;
            double average = 0;
            
            for(int i = 0; i < numbers.Length; i++)
            {
                if(min>numbers[i])
                {
                    min = numbers[i];
                }
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                sum += numbers[i];
                average = sum / (numbers.Length);
            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = {0}", average);

        }
    }
}
