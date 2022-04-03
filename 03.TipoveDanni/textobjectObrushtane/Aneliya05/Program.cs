using System;


namespace typesOfData
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Convert.ToChar(Console.ReadLine()); //1-ви вариант за директно прочитане на char ог конзолата
            char b = Convert.ToChar(Console.ReadLine()); 
            char c = Console.ReadLine()[0]; //2-ри вариант за директно прочитане на char ог конзолата
            Console.WriteLine("{0}{1}{2}", c,b,a);
        }
    }
}
