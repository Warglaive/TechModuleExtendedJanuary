using System;
namespace debugExample
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            GetMultipleOfEvensAndOdds(Math.Abs(n));
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int SumOdds = GetSumOfOddDigits(n);
            Console.WriteLine(sumEvens * SumOdds);
            return sumEvens * SumOdds;
        }

        public static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0) 
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit% 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
