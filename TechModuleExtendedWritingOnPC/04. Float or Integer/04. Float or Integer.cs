using System;
namespace _04.Float_or_Integer
{
    public class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            if (number is int)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
