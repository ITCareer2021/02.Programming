using System;

namespace _2._Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int p = 0;
                int q = i;
                while (q > 0)
                {
                    p += q % 10;
                    q = q / 10;
                }
                bool special = (p == 5) || (p == 7) || (p == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            } 
        }
    }
}
