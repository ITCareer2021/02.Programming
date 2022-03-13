using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();
            int[] num2 = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();

            Array.Reverse(num1);
            Array.Reverse(num2);

            string result = "";
            int carry = 0;
            int whoIsBiger = num1.Length;
            if (num2.Length > whoIsBiger)
                whoIsBiger = num2.Length;
            for (int i=0; i < whoIsBiger; i++)
            {
                int v1, v2;
                if (i < num1.Length)
                    v1 = num1[i];
                else
                    v1 = 0;
                if (i < num2.Length)
                    v2 = num2[i];
                else
                    v2 = 0;
                result = ((v1 + v2 + carry) % 10).ToString()+ result;
                carry = (v1 + v2 + carry) / 10;
            }
            if (carry == 1)
                result = "1" + result;
     

            Console.WriteLine(result.TrimStart('0')); // maha vodeshti 0 ako ima
        }
    }
}
