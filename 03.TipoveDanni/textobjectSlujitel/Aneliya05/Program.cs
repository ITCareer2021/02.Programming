using System;


namespace typesOfData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = Convert.ToChar(Console.ReadLine());
            ulong id = ulong.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName} \n Last name: {lastName} \n Age: {age} \n Gender: {gender} \n Personal ID: {id} \n Unique Employee number: {employeeNumber}");
        }
    }
}
