using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            TopRow();
            MiddleRow();
            BottomRow();

        }
        static void TopRow()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void MiddleRow()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void BottomRow()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 BG");
            //в judge не искат последния ред да пише SoftUni, а BG
        }
        
    }
}
