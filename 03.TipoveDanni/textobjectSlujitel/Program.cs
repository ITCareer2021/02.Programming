using System;

namespace Slujitel
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var pol = Console.ReadLine();
            long id = long.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("First Name: {0}",first);
            Console.WriteLine("Last Name: {0}", last);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0} ", pol);
            Console.WriteLine("Personal ID: {0} ", id);
            Console.WriteLine("Unique Employee number: {0}",number);

        }
    }
}
