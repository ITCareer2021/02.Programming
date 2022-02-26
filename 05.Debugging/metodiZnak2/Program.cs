using System;

namespace methode2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sign(int.Parse(Console.ReadLine()));
        }
        static void Sign(int n)
        {
            if(n>0)
            { Console.WriteLine("The number {0} is positive.", n); }
            if (n < 0)
            { Console.WriteLine("The number {0} is negative.", n); }
            else if(n==0)
            { Console.WriteLine("The number 0 is zero."); }
        }
    }
}
