using System;
using System.Linq;
using System.Collections.Generic;

namespace Миньорска_задача
{
    class Program
    {
        static void Main(string[] args) //pochti raboti 75%
        {
            var oresQuantity = new Dictionary<string, int>();
            
            bool stop = false;

            do
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] != "stop")
                {
                    int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();



                   if (!oresQuantity.ContainsKey(input[0]))
                   {
                      oresQuantity[input[0]] = input2[0];
                   }
                   else
                   {
                      oresQuantity[input[0]] = oresQuantity[input[0]] + input2[0];
                   }

                    
                }
                else
                {
                    stop = true;
                } 
            }
            while (!stop);
            foreach (var resource in oresQuantity)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}
