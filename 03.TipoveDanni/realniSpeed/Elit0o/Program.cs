using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float totalHours = hours + minutes / 60 + seconds / 3600;
            float metresInKm = distance / 1000;
            float metresInMp = distance / 1609;

            float metresPerSecond = distance / totalSeconds;
            float kilometresPerHour = metresInKm / totalHours;
            float mpPerHour = metresInMp / totalHours;

            Console.WriteLine(metresPerSecond);
            Console.WriteLine(kilometresPerHour);
            Console.WriteLine(mpPerHour);
        }
    }
}
