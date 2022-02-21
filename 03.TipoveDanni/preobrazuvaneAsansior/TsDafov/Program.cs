using System;

namespace _1._Асансьор
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int result = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(result);
        }
    }
}
