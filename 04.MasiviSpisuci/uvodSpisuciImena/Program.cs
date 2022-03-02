using System;
using System.Linq;
using System.Collections.Generic;

namespace spisutsi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(String.Join("; ", names)); 
        }
    }
}
