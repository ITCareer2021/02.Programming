using System;
using System.Collections.Generic;
using System.Linq;

namespace list_new
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(',').ToList();
            foreach(var name in names)
            {
                Console.WriteLine(String.Join(" ", name.Split(' ').Reverse()));
            }
            
        }
    }
}
