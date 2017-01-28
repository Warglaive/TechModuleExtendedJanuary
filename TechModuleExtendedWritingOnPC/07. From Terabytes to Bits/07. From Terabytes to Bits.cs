using System;
namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main()
        {
            double terabyte = double.Parse(Console.ReadLine());
            var Bits = terabyte * 8796093022208;
            Console.WriteLine(Bits);
        }
    }
}
