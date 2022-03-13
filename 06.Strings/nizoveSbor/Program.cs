using System;
using System.Linq;

namespace stringove
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string result = "";
            int carry = 0;


            int shorter = num1.Length;
            if (num2.Length < shorter)
                shorter = num2.Length;

            int longer = num1.Length;
            if (num2.Length > longer)
                shorter = num2.Length;

            for (int i = 1; i <= shorter; i++)
            {
                int s1 = num1.Length - i;
                int s2 = num2.Length - i;
                int v1 = int.Parse(num1[s1].ToString());
                int v2 = int.Parse(num2[s2].ToString());
                //Console.WriteLine("v1 = {0}, v2 = {1}, carry = {2}", v1, v2, carry);
                result = ((v1 + v2 + carry) % 10).ToString() + result;
                carry = (v1 + v2 + carry) / 10;
                //Console.WriteLine("New carry = {0}", carry);
                //Console.WriteLine(result);
            }
            string longerString = "";
            if (num1.Length < num2.Length)
                longerString = num2;
            else
                longerString = num1;

            for (int i = shorter + 1; i <= longer; i++)
            {
                int s1 = longerString.Length - i;
                int v1 = int.Parse(longerString[s1].ToString());
                result = ((v1 + carry) % 10).ToString() + result;
                carry = (v1 + carry) / 10;
                //Console.WriteLine(result);
            }
            if (carry > 0)
                result = "1" + result;

            Console.WriteLine(result);

        }
    }
}











