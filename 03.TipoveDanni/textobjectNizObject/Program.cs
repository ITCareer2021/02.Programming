using System;

namespace _3._Низове_и_обекти
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
