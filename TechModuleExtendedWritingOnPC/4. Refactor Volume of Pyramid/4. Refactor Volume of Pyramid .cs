using System;
namespace _4.Refactor_Volume_of_Pyramid
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var weight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var high = double.Parse(Console.ReadLine());
            high = (lenght * weight * high) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", high);
        }
    }
}
