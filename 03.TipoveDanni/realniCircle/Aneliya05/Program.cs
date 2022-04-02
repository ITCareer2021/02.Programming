using System;

namespace TipoveDanni_new
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("{0:f12}", s);
        }
    }
}
