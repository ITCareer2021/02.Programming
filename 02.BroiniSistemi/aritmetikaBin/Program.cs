using System;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var z=Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            if (z == "+")
            {
                Console.WriteLine(n + b);
            }
            if (z == "-")
            {
                Console.WriteLine(n - b);
            }
            if (z == "/")
            {
                Console.WriteLine(n / b);
            }
            if (z == "*")
            {
                Console.WriteLine(n * b);
            }



        }   

            

    }

}