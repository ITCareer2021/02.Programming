using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var tels = new Dictionary<string, string>();
            var namesToSearch = new List<string>();

            while (!exit)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] == "END")
                {
                    exit = true;
                }
                else
                if (input[0] == "A")
                {
                    tels[input[1]] = input[2];
                }
                else //Search input[0] = "S"
                {
                    namesToSearch.Add(input[1]);

                    //foreach (var oneName in namesToSearch)
                    var oneName = input[1];
                    {
                        if (tels.ContainsKey(oneName))
                        {
                            tels.TryGetValue(oneName, out var value);
                            Console.WriteLine("{0} -> {1}", oneName, value);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", oneName);
                        }
                    }
                }
            }
        }
    }
}




