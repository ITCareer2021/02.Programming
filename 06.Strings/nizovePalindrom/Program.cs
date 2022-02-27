using System;

namespace _6._Палиндром
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();
            char[] duma2 = duma.ToCharArray();

            Array.Reverse(duma2);
            string duma3 = string.Join("", duma2);

            bool return1 = (duma == duma3);
            Console.WriteLine(return1);

        }
    }
}
