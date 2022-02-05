using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            string bin = Convert.ToString(n, 2);

            /*Upper-vame hex value 
             * Izvikvame motoda ToUpper na obekta hex*/
            hex = hex.ToUpper();

            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
