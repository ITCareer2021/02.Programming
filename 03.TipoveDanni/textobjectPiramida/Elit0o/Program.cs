﻿using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());

            heigth = (length * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", heigth);
        }
    }
}
