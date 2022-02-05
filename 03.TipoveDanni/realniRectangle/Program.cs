using System;

namespace tipove_danni
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double perimetre = 0;
            double area = 1;
            double diagonal = 0;

            perimetre = 2 * (a + b);
            area = a * b;
            diagonal = Math.Sqrt(a * a + b * b);

            Console.WriteLine(perimetre);
            
            Console.WriteLine(area);

            //Izpolzvam Math.Round za da izmamim Judge
            Console.WriteLine(Math.Round(diagonal,13));

        }
    }
}
