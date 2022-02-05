using System;

namespace _3._Булева_променлива
{
    class Program
    {
        static void Main(string[] args)
        {
            string inStr = Console.ReadLine();
            bool variable = Convert.ToBoolean(inStr);

            if (variable == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
