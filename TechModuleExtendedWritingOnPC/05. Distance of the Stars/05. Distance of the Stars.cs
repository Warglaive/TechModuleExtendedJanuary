using System;
using System.Globalization;

namespace _05.Distance_of_the_Stars
{
    public class Program
    {
        static void Main()
        {
            decimal lightYearsToKillometers = 1 * 9450000000000m;
            decimal earthToNearestStar = lightYearsToKillometers * 4.22m;
            decimal galaxyCenter = lightYearsToKillometers * 26000m;
            decimal diameterMilkyWay = lightYearsToKillometers * 100000m;
            decimal edgeOfUniverse = lightYearsToKillometers * 46500000000m;
            Console.WriteLine("{0:e2}", earthToNearestStar);
            Console.WriteLine("{0:e2}", galaxyCenter);
            Console.WriteLine("{0:e2}", diameterMilkyWay);
            Console.WriteLine("{0:e2}", edgeOfUniverse);
        }
    }
}
