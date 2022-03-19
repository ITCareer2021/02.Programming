using System;

namespace tipoveDanni
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInElevator = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int pulenKurs = peopleInElevator / capacity;
            if(peopleInElevator % capacity != 0)
            {
                pulenKurs = pulenKurs + 1;
            }
            Console.WriteLine(pulenKurs);
        }
    }
}
