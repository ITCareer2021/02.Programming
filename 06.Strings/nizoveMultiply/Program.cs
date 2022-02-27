using System;
using System.Linq;

namespace _5._Умножаване_на_символни_кодове
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string [] arr = Console.ReadLine().Split(' ').ToArray();
            string str1 = arr[0];
            string str2 = arr[1];
                     

            int mul = 0;
            int i2 = 0;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length && i < str2.Length; i++)
                {
                    mul = mul + (str1[i] * str2[i]);
                    i2 = i;
                }
            }
            else if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    mul = mul + (str1[i] * str2[i]);
                    i2 = i;
                }

                for (int i = i2+1; i < str1.Length; i++)
                {
                    mul += str2[i];
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    mul = mul + (str1[i] * str2[i]);
                    i2 = i;
                }

                for (int i = i2+1; i < str2.Length; i++)
                {
                    mul += str2[i];
                }
            }

            Console.WriteLine(mul);
        }
    }
}
