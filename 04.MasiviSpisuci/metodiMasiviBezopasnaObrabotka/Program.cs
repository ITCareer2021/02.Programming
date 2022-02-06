using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] el = Console.ReadLine().Split(' ').ToArray();
            bool exit = false;

            
            //el[2] = "Hello";
            //Console.WriteLine(el[2]);
            do
            {
                string[] cmd = Console.ReadLine().Split(' ').ToArray();
                //string smd = cmd[0];
                //smd = Console.ReadLine();
                switch (cmd[0])
                {
                    case "Distinct":
                        string[] el1 = el.Distinct().ToArray();
                        el = el1; //!?!?!? ugh
                        
                        break;
                        
                    case "Reverse":
                        Array.Reverse(el);
                        break;

                    case "Replace":                     
                        int position = int.Parse(cmd[1]);
                        if (position < 0 || position > el.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                            el[position] = cmd[2];                      
                        break;

                    case "END":
                        exit = true;
                        for (int i = 0; i < el.Length - 1; i++)
                        {
                            Console.Write(el[i] + ", ");
                        }
                        Console.WriteLine(el[el.Length - 1]);
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            while (!exit);
        }
    }
}
