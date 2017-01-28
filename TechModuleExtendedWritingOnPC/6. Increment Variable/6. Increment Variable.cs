using System;
namespace _6.Increment_Variable
{
    class Program
    {
        public static void Main()
        {
            byte num = 0;
            var n = int.Parse(Console.ReadLine());
            double result = num + n;
            double overflow = 0f;
            if (result > byte.MaxValue)
            {
                overflow = Math.Ceiling((result - byte.MaxValue) / byte.MaxValue); // if judge = 60/100 convert Math.Ceili to Math.Round and Test;
                result = result - byte.MaxValue * overflow - overflow;
                Console.WriteLine(result);
                Console.WriteLine("Overflowed {0} times", overflow);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}