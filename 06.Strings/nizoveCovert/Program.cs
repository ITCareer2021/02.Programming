using System;

namespace _3._Обръщане_на_низ
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();

            for (int i = duma.Length - 1; i >= 0; i--)
            {
                Console.Write(duma[i]);
            }
        }
    }
}
