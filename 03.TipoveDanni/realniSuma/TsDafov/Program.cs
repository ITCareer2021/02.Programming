using System;

namespace _3._Точна_сума_на_реални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            while (n != 0)
            {
                decimal a = decimal.Parse(Console.ReadLine());
                sum += a;
                n--;
            }
            Console.WriteLine(sum);
        }
    }
}
