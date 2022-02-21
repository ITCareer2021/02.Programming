using System;

namespace _3._Шестнадесетична_променлива
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine(dec);
        }
    }
}
