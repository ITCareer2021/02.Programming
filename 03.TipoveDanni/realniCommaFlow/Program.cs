using System;

namespace ConsoleApp4
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
