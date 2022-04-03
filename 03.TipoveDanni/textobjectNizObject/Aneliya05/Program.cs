using System;

namespace New_Tipove_Danni
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object ab = a + " " + b;
            string c = (string) ab;
            Console.WriteLine(c);    
        }
    }
}
