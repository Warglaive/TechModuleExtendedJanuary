using System;
namespace _03.Exchange_Variable_Values
{
    public class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int newB = 0;
            newB = b;
            b = a;
            a = newB;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
