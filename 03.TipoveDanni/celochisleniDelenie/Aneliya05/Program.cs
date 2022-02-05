using System;

namespace zadachi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            int totalRemainder = 0;

            while (c < n)
            {
                //Console.WriteLine(".");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                //kum obshtiq ostatuk natrupvame ostatuka na porednata dvoika
                totalRemainder = totalRemainder + (a % b);

                c++;
            }
            Console.WriteLine(totalRemainder);
        }
    }
}
