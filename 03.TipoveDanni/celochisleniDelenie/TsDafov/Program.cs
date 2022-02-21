using System;

namespace _6._Делене_на_цели_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int ostatuci = 0;

            while (n != 0)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                a = a % b;
                ostatuci += a;
                n--;
            }
            Console.WriteLine(ostatuci);
        }
    }
}
