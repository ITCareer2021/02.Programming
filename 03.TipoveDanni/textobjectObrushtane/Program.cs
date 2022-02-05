using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object both = $"{hello} {world}";

            string end = (string)both;
            Console.WriteLine(end);
        }
    }
}