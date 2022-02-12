using System;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Judge ми дава някаква грешка 90/100
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                br++;
            }
            if (br == 1)
            {
                Console.WriteLine(arr[0]);
            }
            if (br % 2 == 0) //chetno
            {
                Console.WriteLine("{ "+ arr[br / 2 - 1] + ", " + arr[br / 2]+" }");
            }
            if (br % 2 != 0) //nechetno
            {
                Console.WriteLine("{ "+arr[br / 2 - 1] + ", " + arr[br / 2] + ", " + arr[br / 2 + 1]+" }");
            }
        }
    }
}
