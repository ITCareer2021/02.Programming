using System;

namespace _1._Лице_на_кръг__с_точност_12_знака_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F12}", Math.PI * r *r);
        }
    }
}
