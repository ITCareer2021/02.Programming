using System;
using System.Linq; 

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            /*pokazvame elementite v obraten red
             * for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[arr.Length-i-1]); 
            }*/
            Array.Reverse(arr, 0, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
