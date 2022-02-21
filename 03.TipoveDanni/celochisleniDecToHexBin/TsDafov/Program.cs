using System;

namespace _5._Десетично_към_шестнадесетично_и_двоично
{
    class Program
    {
        static void Main(string[] args)
        {
            int vhod = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(vhod, 16);
            hex = hex.ToUpper();

            string bin = Convert.ToString(vhod, 2);

            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
