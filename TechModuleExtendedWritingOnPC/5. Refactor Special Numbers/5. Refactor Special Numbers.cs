using System;
namespace _5.Refactor_Special_Numbers
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                int currentNumber = 0;
                int total = 0;
                currentNumber = row;
                while (row > 0)
                {
                    total += row % 10;
                    row = row / 10;
                }
                bool sum = false;
                sum = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{currentNumber} -> {sum}");
                total = 0;
                row = currentNumber;
            }
        }
    }
}
