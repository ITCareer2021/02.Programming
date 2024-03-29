﻿using System;

namespace ConsoleApp12
{
    class Program
    {
        private static int GetSumOfEvenDigits(int n) 
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = sum + lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 1)
                {
                    sum = sum + lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }

        private static int GetMultipleOfEvensAndOdds(int n) 
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens*sumOdds;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(Math.Abs(n))); 
        }
    }
}
