using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        //umnojenieto raboti kato subirane no carry moje da e > 1
        // v2 = vinagi e edno i sushto ednocifren mnojitel
        // !! primera golemi chisla v uslovieto e oburkan copy/paste vzet ot gorniq primer

        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();
            //int[] num2 = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();
            int v2 = int.Parse(Console.ReadLine());
            Array.Reverse(num1);
            //   Array.Reverse(num2);

            string result = "";
            int carry = 0;
            int whoIsBiger = num1.Length;
            //if (num2.Length > whoIsBiger)
            //    whoIsBiger = num2.Length;
            for (int i = 0; i < whoIsBiger; i++)
            {
                //int v1, v2;
                int v1;
                if (i < num1.Length)
                    v1 = num1[i];
                else
                    v1 = 1;     // zapulvame lipsvashtite razredi s 1 a ne s 0




                //if (i < num2.Length)
                //    v2 = num2[i];
                //else
                //    v2 = 0;
                result = ((v1 * v2 + carry) % 10).ToString() + result;
                carry = (v1 * v2 + carry) / 10;
            }

            if (carry > 0) // ako ima carry moje i  da e > 1
                result = carry + result;


            string resu = result.TrimStart('0');
            if (resu.Length == 0)
                resu = "0";
            Console.WriteLine(resu); // maha vodeshti 0 ako ima NO pri umnojenie po 0, 0 e validen rezultat slagame edna 0
        }
    }
}
