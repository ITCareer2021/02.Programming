﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace list_new
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));

        }
    }
}
