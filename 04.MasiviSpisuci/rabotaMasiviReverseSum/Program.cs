using System;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        //ne e vqrno, ako nqkoi umen ima idei...neka pomogne :D
		//problema v tozi primer e posokata v koqto zavurtame elementite na masiva - trqbva v protivopoljna posoka (ian)
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());
            //natrupvame sumite sled vurtene 
            int[] sums = new int[arr.Length];
            for (int i = 1; i <= r; i++)
            {
                //broqch na zavurtaniqta
                for (int c = 0; c < arr.Length; c++)
                {
                    //izpolzvame za adresirane na elementite na arr pri zavurtaniq
                    int position = c;
                    position = position + i;
                    if (position >= arr.Length)
                    {
                        position = position-arr.Length;
                    }
                    //Console.Write("<" + c + " " + position + ">");
                    sums[c] = sums[c] + arr[position];
                }
                //Console.WriteLine();
            }
            for (int i = 1; i < sums.Length; i++)
            {
                Console.Write(sums[i]+" ");
            }
            Console.WriteLine(sums[0]);
        }
    }
}
