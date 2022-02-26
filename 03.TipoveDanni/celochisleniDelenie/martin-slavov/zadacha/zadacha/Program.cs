using System;

namespace zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalRemainder = 0;

            for (int c =0; c < n;c++)
            {
                
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                totalRemainder = totalRemainder + (a % b);

            }
            Console.WriteLine(totalRemainder);
        }
    }
}
