using System;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void RotateRight(int[] a) //metod za zavurtane na elementite na masiv na dqsno 
        //masiva parametur se predava po referenciq! promenite koito napravim v tozi masiv parametur shte ostanat vidimi i v masiva s koito se vika metoda 
        {
            int sw = a[a.Length - 1]; //zapazvame posledniq element v sw
            for (int i = a.Length - 1; i > 0; i--) //
                a[i] = a[i - 1];
            a[0] = sw;

        }
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());

            int[] aSummed = new int[arr.Length]; //masiv za formirane na sumite s broi elementi kato arr


            for (int i = 0; i < r; i++)
            {
                RotateRight(arr); //zavurtame na dqsno

                for (int aindex = 0; aindex < arr.Length; aindex++) //natrupvame sumite elemen po element
                    aSummed[aindex] = aSummed[aindex] + arr[aindex];
            }

            Console.WriteLine(string.Join(" ", aSummed));
        }
    }
}
