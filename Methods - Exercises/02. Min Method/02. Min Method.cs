using System;
namespace _02.Min_Method
{
    class Program
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondnum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            GetMin(firstNum, secondnum, thirdNum);
        }
        public static void GetMin(int firstNum, int secondNum, int thirdNum)
        {
            Console.WriteLine(Math.Min(firstNum, Math.Min(secondNum, thirdNum)));
        }
    }
}
