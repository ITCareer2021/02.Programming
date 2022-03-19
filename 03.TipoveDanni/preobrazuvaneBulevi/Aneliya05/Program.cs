using System;

namespace tipoveDanni
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine(); //variant bez preobrazuvane v bulev tip
            if(n == "True")
            {
                Console.WriteLine("Yes");
            }
            else
            if (n == "False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
