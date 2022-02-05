using System;

namespace zadachi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            string bin = Convert.ToString(n, 2);

            

            hex = hex.ToUpper();

            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
