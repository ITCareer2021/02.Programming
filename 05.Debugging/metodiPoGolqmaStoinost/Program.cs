using System;

namespace method8
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "double")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine()); 
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
        }
        static int GetMax(int a, int b)
        {
            if (a >= b)
             return a; 
            else
                return b;
        }
        static char GetMax(char a, char b)
        {
            if (a >= b)
            return a; 
            else
                return b;
        }

        static string GetMax(string a, string b)
        {
            if (a.Length >= b.Length)
                return a;
            else
                return b;
            
        }
        static double GetMax(double a, double b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }
    }
}
