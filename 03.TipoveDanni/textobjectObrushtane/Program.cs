using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = Console.ReadLine();
            object b = Console.ReadLine();
            object c1 = Console.ReadLine();
            object sw = 0;

            sw = a;
            a = c1;
            c1 = sw;

            Console.WriteLine("{0}{1}{2}", a, b, c);

        }
    }
}
