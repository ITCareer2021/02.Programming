using System;
using System.Linq;

namespace _1._Oт_10_ична_в_N_ична_бройна_система
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sistemaChislo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int chislo = sistemaChislo[1];
            int N = sistemaChislo[0];
            string result = "", result2;

            while (chislo > 0)
            {
                int nChislo = chislo % N;
                result2 = nChislo.ToString();
                result = $"{result2}{result}";
                chislo = chislo/N;
            }
            Console.WriteLine(result);
        }
    }
}
