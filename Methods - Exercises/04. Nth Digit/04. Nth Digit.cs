using System;
namespace _04.Nth_Digit
{
    class Program
    {
        public static void Main()
        {
            {
                var number = long.Parse(Console.ReadLine());
                var index = int.Parse(Console.ReadLine());
                long numNoLastDigit = 1;
                int counter = 1;
                FindNthDigit(number, index, numNoLastDigit, counter);
            }
        }
        private static void FindNthDigit(long number, int index, long numNoLastDigit, int counter)
        {
            while (number >= 0)
            {
                numNoLastDigit = number;
                number = number % 10;
                long digit = number;
                if (counter == index)
                {
                    Console.WriteLine(digit);
                    break;
                }
                else
                {
                    number = numNoLastDigit / 10;
                    counter++;
                }
            }
        }
    }
 }
