using System;
namespace _03.String_Repeater
{
    class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            RepeatString(text, count);
            Console.WriteLine();
        }
        public static string RepeatString(string text, int count)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{text}", count);
            }
            return repeatedString;
        }
    }
}
