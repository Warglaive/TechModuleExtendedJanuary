using System;
namespace _4.Transport
{
    public class Transport
    {
        static void Main()
        {
            double nPersons = double.Parse(Console.ReadLine());
            double vehicleOne = 4;
            double vehicleTwo = 8;
            double vehicleThree = 12;
            double vehiclesSeats = vehicleOne + vehicleTwo + vehicleThree;
            double courses = nPersons/vehiclesSeats;
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
