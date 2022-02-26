using System;

namespace method7
{
    class Program
    {
        static void Main(string[] args)
        {
            double ch = double.Parse(Console.ReadLine());
            int stepen = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(ch, stepen));
        }
        static double Power(double ch, int stepen)
        {
             double result = Math.Pow(ch, stepen);
            return result;
        }
    }
}
