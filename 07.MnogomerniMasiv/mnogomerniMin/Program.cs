using System;
using System.Linq;

namespace Mnogomerni_masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowMasiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowMasiv[col];
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0,5}", matrix[row, col]);
                }
                Console.WriteLine();
            }

            for (int col = 0; col < cols; col++)
            {

                int min = 1000;
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < min)
                    {
                        min = matrix[row, col];
                    }
                }
                Console.Write("{0,5}", min);
            }
            Console.WriteLine();
        }
    }
}
