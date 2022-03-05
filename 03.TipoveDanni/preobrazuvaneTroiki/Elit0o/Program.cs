using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 1; i++)
            {
                for (int p = 0; p <= n - 1; p++)
                {
                    for (int c = 0; c <= n - 1; c++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)(097 + i), (char)(097 + p), (char)(097 + c));
                    }
                }
            }
        }
    }
}
