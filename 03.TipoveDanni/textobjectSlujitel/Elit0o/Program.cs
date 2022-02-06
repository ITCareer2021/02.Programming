using System;

namespace Slujitel
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            long personalInfo = long.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0} ", gender);
            Console.WriteLine("Personal ID: {0} ", personalInfo);
            Console.WriteLine("Unique Employee number: {0}", number);
        }
    }
}
