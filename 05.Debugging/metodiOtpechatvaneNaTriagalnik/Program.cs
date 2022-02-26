using System;

namespace method3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintTriangle(int.Parse(Console.ReadLine()));
        }
        static void PrintTriangle(int n)
        {


            for ( int i = 1; i <= n; i++)
            {
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k+" ");
                }
                
                Console.Write("\n");
            }
            for(int i=n; i>0; i--)
            {
                for (int k = 1; k <= i-1; k++)
                {
                    Console.Write(k+" ");
                }
                Console.Write("\n");
            }
             
            }
    }
}
