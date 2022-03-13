using System;

namespace Изчертаване_на_запълнен_квадрат
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopAndBottomRow(n);
            MiddleRow(n);
            TopAndBottomRow(n);
        }
        static void TopAndBottomRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void MiddleRow(int n)
        {
            for (int k = 0; k <= n - 3; k++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                { Console.Write("\\/"); }
                Console.WriteLine('-');
            }
        }
    }
}
