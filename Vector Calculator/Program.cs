using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(-1, 2, 3);
            Vector test2 = new Vector(1, -2, -3);
           
            
            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(" subtraction : ");
            Console.WriteLine(Vector.Subtract(test1, test2));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(Vector.Negate(test1));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(test1.GetMagnitude());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(test1.GetDirection());
            System.Threading.Thread.Sleep(1000);

           
        }
    }
}
