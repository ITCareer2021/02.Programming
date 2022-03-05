using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            char[] word1 = words[0].ToCharArray();
            char[] word2 = words[1].ToCharArray();

            var w1 = word1.ToList();
            var w2 = word2.ToList();

            var w1nd = w1.Distinct().ToList();
            var w2nd = w2.Distinct().ToList();

            if (w1nd.Count == w2nd.Count)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }
    }
}