using System;
using System.Collections.Generic;
using System.Linq;

namespace list_new
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach(var number in numbers)
            {
                if(number%2==0)
                {
                    Console.Write(number + " ");
                }
            }
            
        }
    }
}
