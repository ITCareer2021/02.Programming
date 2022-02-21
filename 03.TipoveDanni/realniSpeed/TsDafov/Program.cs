using System;

namespace _5._Преобразуване_на_скорост
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceM = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            float min = float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());

            float vsSec = (((h * 60) + min) * 60) + sec;
            float vsMIN = (h * 60) + min + (sec / 60);
            //float vsH = (vsSec / 60) / 60;

            float mS = distanceM / vsSec;
            float kmH = (distanceM / 1000) / (vsMIN / 60);
            float mlH = (distanceM / 1609) / (vsMIN / 60);

            Console.WriteLine(mS);
            Console.WriteLine(kmH);
            Console.WriteLine(mlH);
        }
    }
}
