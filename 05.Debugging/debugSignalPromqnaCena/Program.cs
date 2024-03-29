﻿using System;
using System.Globalization;

namespace ConsoleApp14
{
    class Program
    {
        //Не извежда краен резултат
        static void Main(string[] args)
        {

            double t = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());
            
            int n = 0;
            int limit = 0;

            for (int i = 0; i < n - 1; i++)
            {
                double ciurrentPrice = double.Parse(Console.ReadLine());
                double priceDiff = CalculatePriceDifference(lastPrice, ciurrentPrice);
                bool isSignificantDifference = SignificantDifference(priceDiff, limit);

                string message = GetMessage(ciurrentPrice, lastPrice, priceDiff, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = ciurrentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double lastPrice, double priceDiff, bool isSignificantDifference)
        {
            string message = "";
            if (priceDiff == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else
            
                if (isSignificantDifference)
                {
                    message = string.Format("PRICE DOWN: {0} to {1} ({2:p2})", lastPrice, currentPrice, priceDiff);
                }
            

            else
            
                if (isSignificantDifference && (priceDiff > 0))
                {
                    message = string.Format("PRICE DOWN: {0} to {1} ({2:p2})", lastPrice, currentPrice, priceDiff);
                }
            

            else 
            {
                if (isSignificantDifference && (priceDiff < 0)) 
                {
                    message = string.Format("PRICE DOWN: {0} to {1} ({2:p2})", lastPrice, currentPrice, priceDiff);
                }
            } 
            return message;
        }
        private static bool SignificantDifference(double limit, double isDiff)
        {
            if (Math.Abs(limit) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double CalculatePriceDifference(double last, double price)
        {
            return (price - last) / last;
        }
    }
}
