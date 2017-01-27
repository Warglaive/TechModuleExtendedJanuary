using System;
namespace _1.Special_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var currentNumber = i;
                var sum = 0;
                while (currentNumber > 0) 
                {
                    sum = sum + currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
